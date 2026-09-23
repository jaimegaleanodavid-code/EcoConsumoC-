-- ============================================================================
-- PROYECTO: EcoConsumo - Base de Datos SQL Server
-- DESCRIPCIÓN: Script de creación de base de datos optimizado para C# (.NET)
--                    Corregido por: DAJG
-- ============================================================================

CREATE DATABASE EcoConsumoDB;
GO

USE EcoConsumoDB;
GO

-- ----------------------------------------------------------------------------
-- 1. TABLA: Planes

CREATE TABLE Planes (
    PlanTipoID INT IDENTITY(1,1) PRIMARY KEY,
    NombrePlan NVARCHAR(50) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL DEFAULT 0.00 CHECK (Precio >= 0),
    Descripcion NVARCHAR(255) NULL
);

-- ----------------------------------------------------------------------------
-- 2. TABLA: PerfilEnergetico

CREATE TABLE PerfilEnergetico (
    PerfilEnergeticoID INT IDENTITY(1,1) PRIMARY KEY,
    NombrePerfil NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255) NULL
);

-- ----------------------------------------------------------------------------
-- 3. TABLA: Usuario (Soporte directo para Login y Registro en C#)

CREATE TABLE Usuario (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
    Correo NVARCHAR(150) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL,
    Estado NVARCHAR(20) NOT NULL DEFAULT 'Activo' CHECK (Estado IN ('Activo', 'Inactivo', 'Suspendido')),
    PlanTipoID INT NOT NULL DEFAULT 1,
    PerfilEnergeticoID INT NULL,
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Usuario_Planes FOREIGN KEY (PlanTipoID) REFERENCES Planes(PlanTipoID),
    CONSTRAINT FK_Usuario_PerfilEnergetico FOREIGN KEY (PerfilEnergeticoID) REFERENCES PerfilEnergetico(PerfilEnergeticoID)
);

-- ----------------------------------------------------------------------------
-- 4. TABLA: CategoriaAparatos

CREATE TABLE CategoriaAparatos (
    CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
    NombreCategoria NVARCHAR(50) NOT NULL UNIQUE
);

-- ----------------------------------------------------------------------------
-- 5. TABLA: AparatosReferencias

CREATE TABLE AparatosReferencias (
    AparatoReferenciaID INT IDENTITY(1,1) PRIMARY KEY,
    NombreAparato NVARCHAR(100) NOT NULL,
    PotenciaWattsReferencia DECIMAL(8,2) NOT NULL CHECK (PotenciaWattsReferencia > 0),
    CategoriaID INT NOT NULL,
    CONSTRAINT FK_AparatosReferencias_CategoriaAparatos FOREIGN KEY (CategoriaID) REFERENCES CategoriaAparatos(CategoriaID)
);

-- ----------------------------------------------------------------------------
-- 6. TABLA: DispositivoUsuario (Inventario de equipos por usuario)

CREATE TABLE DispositivoUsuario (
    DispositivoID INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioID INT NOT NULL,
    AparatoReferenciaID INT NOT NULL,
    NombrePersonalizado NVARCHAR(100) NULL,
    HorasUsoDiario DECIMAL(5,2) NOT NULL CHECK (HorasUsoDiario >= 0 AND HorasUsoDiario <= 24),
    DiasUsoPorSemana INT NOT NULL DEFAULT 7 CHECK (DiasUsoPorSemana >= 1 AND DiasUsoPorSemana <= 7),
    Estado NVARCHAR(20) NOT NULL DEFAULT 'Activo' CHECK (Estado IN ('Activo', 'Inactivo')),
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_DispositivoUsuario_Usuario FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    CONSTRAINT FK_DispositivoUsuario_AparatosReferencias FOREIGN KEY (AparatoReferenciaID) REFERENCES AparatosReferencias(AparatoReferenciaID)
);

-- ----------------------------------------------------------------------------
-- 7. TABLA: RegistroConsumo (ALIMENTA EL DASHBOARD EN C#)

CREATE TABLE RegistroConsumo (
    RegistroID INT IDENTITY(1,1) PRIMARY KEY,
    DispositivoID INT NOT NULL,
    FechaConsumo DATETIME2 NOT NULL DEFAULT GETDATE(),
    HorasUso DECIMAL(5,2) NOT NULL CHECK (HorasUso >= 0 AND HorasUso <= 24),
    KWhConsumidos DECIMAL(10,2) NOT NULL CHECK (KWhConsumidos >= 0),
    CostoEstimado DECIMAL(10,2) NOT NULL DEFAULT 0.00 CHECK (CostoEstimado >= 0),

    CONSTRAINT FK_RegistroConsumo_DispositivoUsuario
        FOREIGN KEY (DispositivoID)
        REFERENCES DispositivoUsuario(DispositivoID)
);

-- ----------------------------------------------------------------------------
-- 8. TABLA: Retos

CREATE TABLE Retos (
    RetoID INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255) NOT NULL,
    PorcentajeAhorroObjetivo DECIMAL(5,2) NOT NULL CHECK (PorcentajeAhorroObjetivo > 0 AND PorcentajeAhorroObjetivo <= 100),
    CategoriaID INT NULL,
    CONSTRAINT FK_Retos_CategoriaAparatos FOREIGN KEY (CategoriaID) REFERENCES CategoriaAparatos(CategoriaID)
);

-- ----------------------------------------------------------------------------
-- 9. TABLA: RetosUsuario

CREATE TABLE RetosUsuario (
    RetoUsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioID INT NOT NULL,
    RetoID INT NOT NULL,
    Estado NVARCHAR(20) NOT NULL DEFAULT 'En Progreso' CHECK (Estado IN ('En Progreso', 'Completado', 'Abandonado')),
    FechaInicio DATETIME NOT NULL DEFAULT GETDATE(),
    FechaCompletado DATETIME NULL,
    AhorroEstimadoKWh DECIMAL(8,2) NOT NULL DEFAULT 0.00 CHECK (AhorroEstimadoKWh >= 0),
    CONSTRAINT FK_RetosUsuario_Usuario FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    CONSTRAINT FK_RetosUsuario_Retos FOREIGN KEY (RetoID) REFERENCES Retos(RetoID)
);
GO

-- ============================================================================
-- DATOS INICIALES DE PRUEBA (SEED DATA) 
--       Creados por: DAJG
-- ============================================================================

-- Planes
INSERT INTO Planes (NombrePlan, Precio, Descripcion) VALUES 
(N'Plan Gratuito', 0.00, N'Registrar hasta 3 dispositivos, consumo básico y recomendaciones'),
(N'EcoConsumo Premium', 199.00, N'Análisis detallado, historial ilimitado, estadísticas, retos y proyecciones');

-- Perfiles Energéticos
INSERT INTO PerfilEnergetico (NombrePerfil, Descripcion) VALUES 
(N'Consumidor Consciente', N'Tu consumo estimado está por debajo del promedio de los usuarios'),
(N'Consumidor Moderado', N'Tu consumo está dentro del rango promedio esperado'),
(N'Alto Consumo', N'Algunos de tus dispositivos presentan un consumo elevado');

-- Categorías
INSERT INTO CategoriaAparatos (NombreCategoria) VALUES 
(N'Línea Blanca'), 
(N'Climatización'), 
(N'Entretenimiento'), 
(N'Cómputo'), 
(N'Iluminación');

-- Aparatos de Referencia
INSERT INTO AparatosReferencias (NombreAparato, PotenciaWattsReferencia, CategoriaID) VALUES 
(N'Refrigerador', 150.00, 1),
(N'Aire Acondicionado', 1500.00, 2),
(N'Ventilador', 75.00, 2),
(N'Televisor', 100.00, 3),
(N'Computadora', 200.00, 4),
(N'Microondas', 1200.00, 1);

-- Retos
INSERT INTO Retos (Titulo, Descripcion, PorcentajeAhorroObjetivo, CategoriaID) VALUES 
(N'Reduce iluminación', N'Reduce tu consumo de iluminación un 10%', 10.00, 5),
(N'Optimización de Clima', N'Disminuye 1 hora diaria el uso de aire acondicionado o ventiladores', 15.00, 2);

-- Usuario de prueba (Credenciales iniciales)
INSERT INTO Usuario (NombreUsuario, Correo, PasswordHash, PlanTipoID, PerfilEnergeticoID) VALUES
(N'DavidJaime', N'david@ecoconsumo.com', N'hash_password_ejemplo', 1, 2);

-- Dispositivo de prueba asignado al usuario
INSERT INTO DispositivoUsuario (UsuarioID, AparatoReferenciaID, NombrePersonalizado, HorasUsoDiario, DiasUsoPorSemana) VALUES
(1, 1, N'Refrigeradora Principal', 24.00, 7),
(1, 2, N'Aire Sala', 6.00, 7);

-- Registros de consumo para alimentar métricas e histogramas del Dashboard
INSERT INTO RegistroConsumo (UsuarioID, DispositivoID, FechaConsumo, HorasUso, KWhConsumidos, CostoEstimado) VALUES
(1, 1, GETDATE() - 1, 24.00, 3.60, 0.54),
(1, 2, GETDATE() - 1, 6.00, 9.00, 1.35),
(1, 1, GETDATE(), 24.00, 3.60, 0.54),
(1, 2, GETDATE(), 5.00, 7.50, 1.12);
GO