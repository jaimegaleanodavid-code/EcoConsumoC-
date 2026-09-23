# EcoConsumoCsharp
Proyecto Universitario para revisar el consumo energético de aparatos electrónicos, Elaborado en C# con WIndows Forms .NET Framework 
<img width="1024" height="1024" alt="logo EcoConsumo" src="https://github.com/user-attachments/assets/6fd21b54-b244-4b3f-adfa-804f485f0433" />

https://www.unan.edu.ni/

https://www.unan.edu.ni/index.php/oferta-educativa-areas-de-conocimiento

<img width="648" height="340" alt="img-1201202402" src="https://github.com/user-attachments/assets/5d26faa2-48dc-40be-be25-5fbc449721d1" />

Problemática actual:
 Esta problemática surge debido a la viralización de denuncias públicas, presentando recibos elevados en consumo esto respecto a los fuertes calores que enfrentaba el país en el mes 4 del año en curso, esto debido a que las familias empezaron a usar por mucho tiempo aparatos electrónicos para disipar el calor.
En los hogares se utilizan múltiples equipos eléctricos (aires acondicionados, refrigeradoras, entre otros electrodomésticos) sin una herramienta que permita identificar con claridad cuáles generan el mayor gasto energético o cómo optimizar su uso antes de recibir la factura del servicio.

Objetivo general:
Desarrollar una herramienta tecnológica para la gestión y control del consumo de energía que permita registrar aparatos eléctricos, estimar su consumo en kilovatios-hora (KWh) y calcular el costo aproximado de la energía utilizada.


Objetivos específicos:
• Solicitar y validar los datos necesarios para estimar el consumo de cada aparato eléctrico.
• Aplicar una función matemática para calcular el consumo estimado en kWh.
• Utilizar listas y ciclos para registrar y procesar varios aparatos.
• Identificar el aparato que presenta el mayor consumo estimado dentro del período seleccionado.
• Clasificar el consumo total en bajo, moderado o alto según los rangos definidos para el algoritmo.
• Incorporar manejo de excepciones para evitar errores ante entradas no numéricas o valores fuera de los rangos establecidos.
• Realizar una simulación sencilla de ahorro a partir de una reducción del uso del aparato de mayor consumo.

Avance de la aplicación en C# Windows Forms

Tecnología: C# / .NET Framework / Windows Forms (Visual Studio 2026) 
	Estructura del proyecto en Visual Studio:

La solución EcoConsumoAppC_ está organizada de manera modular en el Explorador de Soluciones para mantener la separación de responsabilidades y facilitar su escalabilidad:

Program.cs: Punto de entrada de la aplicación, configurado para iniciar directamente en la pantalla de autenticación (Form1).

Form1.cs / Form1.Designer.cs: Formulario principal de Inicio de Sesión (Login).

pantallaregistro.cs / pantallaregistro.Designer.cs: Formulario para la creación de nuevas cuentas de usuario.

PanelRedondeado.cs: Componente visual personalizado derivado de Panel, creado para lograr tarjetas y contenedores con esquinas redondeadas y bordes limpios en la interfaz.

App.config: Archivo de configuración global que alojará las cadenas de conexión a la base de datos SQL Server.

Dashboard.cs / Dashboard.Designer.cs: El Dashboard actúa como la vista principal (Main Hub / Panel de Control) de la arquitectura de la aplicación tras una autenticación exitosa.

	Formularios desarrollados
Hasta esta etapa del desarrollo, se han implementado y diseñado con éxito los tres formularios clave del módulo de acceso:

Formulario de Login (Form1): Diseñado con una temática ecológica visualmente atractiva (paleta en verdes y blancos). Cuenta con paneles de credenciales, campo de usuario/correo, contraseña con opción de visibilidad, casilla de "Recordar Usuario" y botón de acceso directo al registro.

Formulario de Registro de Usuario (pantallaregistro): Interfaz para el alta de nuevos usuarios que incluye campos para Nombre Completo, Nombre de Usuario, Correo Electrónico, Contraseña y Confirmación de Contraseña.

El Dashboard: actúa como la vista principal (Main Hub / Panel de Control) de la arquitectura de la aplicación tras una autenticación exitosa. Cumple la función de orquestador de navegación e interfaz de visualización de métricas de telemetría energética:

	Monitoreo en tiempo real / diferido: Presenta métricas clave de rendimiento (KPIs) sobre el consumo eléctrico (kWh), costos estimados e inventario de aparatos activos.
  
	Contenedor MDI / Navegación Modular: Funciona como interfaz centralizada donde el usuario puede alternar entre las distintas áreas operativas mediante una barra lateral (Sidebar) sin salir del contexto de la sesión.
  
