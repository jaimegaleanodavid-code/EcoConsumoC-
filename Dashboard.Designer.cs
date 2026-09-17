namespace EcoConsumoAppC_
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.lblNombreUsuarioHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBadgEPlan = new System.Windows.Forms.Label();
            this.btnMejorarPlan = new System.Windows.Forms.Button();
            this.picPerfilUsuario = new System.Windows.Forms.PictureBox();
            this.txtBuscarDashboard = new System.Windows.Forms.TextBox();
            this.lblLogoTexto = new System.Windows.Forms.Label();
            this.picLogoDashboard = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnMenuCerrarSesion = new System.Windows.Forms.Button();
            this.btnMenuConfiguracion = new System.Windows.Forms.Button();
            this.btnMenuPlanes = new System.Windows.Forms.Button();
            this.btnMenuRegistro = new System.Windows.Forms.Button();
            this.btnMenuAparatos = new System.Windows.Forms.Button();
            this.btnMenuInicio = new System.Windows.Forms.Button();
            this.panelContenidoPrincipal = new System.Windows.Forms.Panel();
            this.cardConsumoHoy = new PanelRedondeado();
            this.panelIndicadorHoy = new PanelRedondeado();
            this.lblTituloHoy = new System.Windows.Forms.Label();
            this.lblValorHoy = new System.Windows.Forms.Label();
            this.pnlTopbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfilUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoDashboard)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.panelContenidoPrincipal.SuspendLayout();
            this.cardConsumoHoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(37)))));
            this.pnlTopbar.Controls.Add(this.btnNotificaciones);
            this.pnlTopbar.Controls.Add(this.lblNombreUsuarioHeader);
            this.pnlTopbar.Controls.Add(this.panel1);
            this.pnlTopbar.Controls.Add(this.picPerfilUsuario);
            this.pnlTopbar.Controls.Add(this.txtBuscarDashboard);
            this.pnlTopbar.Controls.Add(this.lblLogoTexto);
            this.pnlTopbar.Controls.Add(this.picLogoDashboard);
            this.pnlTopbar.Location = new System.Drawing.Point(-5, 1);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(1196, 70);
            this.pnlTopbar.TabIndex = 0;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNotificaciones.Location = new System.Drawing.Point(1142, 12);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(35, 35);
            this.btnNotificaciones.TabIndex = 7;
            this.btnNotificaciones.Text = "🔔";
            this.btnNotificaciones.UseVisualStyleBackColor = false;
            // 
            // lblNombreUsuarioHeader
            // 
            this.lblNombreUsuarioHeader.AutoSize = true;
            this.lblNombreUsuarioHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioHeader.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuarioHeader.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblNombreUsuarioHeader.Location = new System.Drawing.Point(977, 26);
            this.lblNombreUsuarioHeader.Name = "lblNombreUsuarioHeader";
            this.lblNombreUsuarioHeader.Size = new System.Drawing.Size(94, 21);
            this.lblNombreUsuarioHeader.TabIndex = 6;
            this.lblNombreUsuarioHeader.Text = "David Jaime";
            this.lblNombreUsuarioHeader.Click += new System.EventHandler(this.lblNombreUsuarioHeader_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBadgEPlan);
            this.panel1.Controls.Add(this.btnMejorarPlan);
            this.panel1.Location = new System.Drawing.Point(632, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 47);
            this.panel1.TabIndex = 1;
            // 
            // lblBadgEPlan
            // 
            this.lblBadgEPlan.AutoSize = true;
            this.lblBadgEPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblBadgEPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadgEPlan.ForeColor = System.Drawing.Color.White;
            this.lblBadgEPlan.Location = new System.Drawing.Point(9, 16);
            this.lblBadgEPlan.Name = "lblBadgEPlan";
            this.lblBadgEPlan.Size = new System.Drawing.Size(173, 15);
            this.lblBadgEPlan.TabIndex = 3;
            this.lblBadgEPlan.Text = "PLAN GRATUITO (8/8 Aparatos)";
            this.lblBadgEPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMejorarPlan
            // 
            this.btnMejorarPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.btnMejorarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMejorarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMejorarPlan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMejorarPlan.ForeColor = System.Drawing.Color.White;
            this.btnMejorarPlan.Location = new System.Drawing.Point(189, 6);
            this.btnMejorarPlan.Name = "btnMejorarPlan";
            this.btnMejorarPlan.Size = new System.Drawing.Size(130, 34);
            this.btnMejorarPlan.TabIndex = 4;
            this.btnMejorarPlan.Text = "⚡ Mejorar Plan";
            this.btnMejorarPlan.UseVisualStyleBackColor = false;
            // 
            // picPerfilUsuario
            // 
            this.picPerfilUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picPerfilUsuario.Image")));
            this.picPerfilUsuario.Location = new System.Drawing.Point(1077, 11);
            this.picPerfilUsuario.Name = "picPerfilUsuario";
            this.picPerfilUsuario.Size = new System.Drawing.Size(40, 40);
            this.picPerfilUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfilUsuario.TabIndex = 5;
            this.picPerfilUsuario.TabStop = false;
            // 
            // txtBuscarDashboard
            // 
            this.txtBuscarDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDashboard.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarDashboard.Location = new System.Drawing.Point(225, 21);
            this.txtBuscarDashboard.Multiline = true;
            this.txtBuscarDashboard.Name = "txtBuscarDashboard";
            this.txtBuscarDashboard.Size = new System.Drawing.Size(389, 30);
            this.txtBuscarDashboard.TabIndex = 2;
            this.txtBuscarDashboard.Text = "Buscar aparato o seccion";
            // 
            // lblLogoTexto
            // 
            this.lblLogoTexto.AutoSize = true;
            this.lblLogoTexto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoTexto.ForeColor = System.Drawing.Color.White;
            this.lblLogoTexto.Location = new System.Drawing.Point(72, 20);
            this.lblLogoTexto.Name = "lblLogoTexto";
            this.lblLogoTexto.Size = new System.Drawing.Size(134, 30);
            this.lblLogoTexto.TabIndex = 1;
            this.lblLogoTexto.Text = "EcoConsumo";
            // 
            // picLogoDashboard
            // 
            this.picLogoDashboard.Image = ((System.Drawing.Image)(resources.GetObject("picLogoDashboard.Image")));
            this.picLogoDashboard.Location = new System.Drawing.Point(15, 10);
            this.picLogoDashboard.Name = "picLogoDashboard";
            this.picLogoDashboard.Size = new System.Drawing.Size(50, 50);
            this.picLogoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoDashboard.TabIndex = 0;
            this.picLogoDashboard.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(37)))));
            this.pnlSidebar.Controls.Add(this.btnMenuCerrarSesion);
            this.pnlSidebar.Controls.Add(this.btnMenuConfiguracion);
            this.pnlSidebar.Controls.Add(this.btnMenuPlanes);
            this.pnlSidebar.Controls.Add(this.btnMenuRegistro);
            this.pnlSidebar.Controls.Add(this.btnMenuAparatos);
            this.pnlSidebar.Controls.Add(this.btnMenuInicio);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 67);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 634);
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnMenuCerrarSesion
            // 
            this.btnMenuCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMenuCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenuCerrarSesion.Location = new System.Drawing.Point(10, 436);
            this.btnMenuCerrarSesion.Name = "btnMenuCerrarSesion";
            this.btnMenuCerrarSesion.Size = new System.Drawing.Size(210, 45);
            this.btnMenuCerrarSesion.TabIndex = 5;
            this.btnMenuCerrarSesion.Text = "🚪  Cerrar Sesión";
            this.btnMenuCerrarSesion.UseVisualStyleBackColor = false;
            this.btnMenuCerrarSesion.Click += new System.EventHandler(this.btnMenuCerrarSesion_Click);
            // 
            // btnMenuConfiguracion
            // 
            this.btnMenuConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMenuConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnMenuConfiguracion.Location = new System.Drawing.Point(10, 240);
            this.btnMenuConfiguracion.Name = "btnMenuConfiguracion";
            this.btnMenuConfiguracion.Size = new System.Drawing.Size(210, 45);
            this.btnMenuConfiguracion.TabIndex = 4;
            this.btnMenuConfiguracion.Text = "⚙️  Configuración";
            this.btnMenuConfiguracion.UseVisualStyleBackColor = false;
            // 
            // btnMenuPlanes
            // 
            this.btnMenuPlanes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMenuPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPlanes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPlanes.ForeColor = System.Drawing.Color.White;
            this.btnMenuPlanes.Location = new System.Drawing.Point(10, 185);
            this.btnMenuPlanes.Name = "btnMenuPlanes";
            this.btnMenuPlanes.Size = new System.Drawing.Size(210, 45);
            this.btnMenuPlanes.TabIndex = 3;
            this.btnMenuPlanes.Text = "💎  Planes y Precios";
            this.btnMenuPlanes.UseVisualStyleBackColor = false;
            // 
            // btnMenuRegistro
            // 
            this.btnMenuRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMenuRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistro.ForeColor = System.Drawing.Color.White;
            this.btnMenuRegistro.Location = new System.Drawing.Point(10, 130);
            this.btnMenuRegistro.Name = "btnMenuRegistro";
            this.btnMenuRegistro.Size = new System.Drawing.Size(210, 45);
            this.btnMenuRegistro.TabIndex = 2;
            this.btnMenuRegistro.Text = "⏱️  Registro de Uso";
            this.btnMenuRegistro.UseVisualStyleBackColor = false;
            // 
            // btnMenuAparatos
            // 
            this.btnMenuAparatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMenuAparatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAparatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAparatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAparatos.ForeColor = System.Drawing.Color.White;
            this.btnMenuAparatos.Location = new System.Drawing.Point(10, 75);
            this.btnMenuAparatos.Name = "btnMenuAparatos";
            this.btnMenuAparatos.Size = new System.Drawing.Size(210, 45);
            this.btnMenuAparatos.TabIndex = 1;
            this.btnMenuAparatos.Text = "🔌  Mis Aparatos";
            this.btnMenuAparatos.UseVisualStyleBackColor = false;
            // 
            // btnMenuInicio
            // 
            this.btnMenuInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMenuInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInicio.ForeColor = System.Drawing.Color.White;
            this.btnMenuInicio.Location = new System.Drawing.Point(10, 20);
            this.btnMenuInicio.Name = "btnMenuInicio";
            this.btnMenuInicio.Size = new System.Drawing.Size(210, 45);
            this.btnMenuInicio.TabIndex = 0;
            this.btnMenuInicio.Text = "🏠  Inicio";
            this.btnMenuInicio.UseVisualStyleBackColor = false;
            // 
            // panelContenidoPrincipal
            // 
            this.panelContenidoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContenidoPrincipal.Controls.Add(this.cardConsumoHoy);
            this.panelContenidoPrincipal.Location = new System.Drawing.Point(246, 87);
            this.panelContenidoPrincipal.Name = "panelContenidoPrincipal";
            this.panelContenidoPrincipal.Size = new System.Drawing.Size(926, 461);
            this.panelContenidoPrincipal.TabIndex = 2;
            // 
            // cardConsumoHoy
            // 
            this.cardConsumoHoy.BackColor = System.Drawing.Color.White;
            this.cardConsumoHoy.ColorBorde = System.Drawing.Color.Transparent;
            this.cardConsumoHoy.Controls.Add(this.lblValorHoy);
            this.cardConsumoHoy.Controls.Add(this.lblTituloHoy);
            this.cardConsumoHoy.Controls.Add(this.panelIndicadorHoy);
            this.cardConsumoHoy.GrosorBorde = 1;
            this.cardConsumoHoy.Location = new System.Drawing.Point(245, 85);
            this.cardConsumoHoy.Name = "cardConsumoHoy";
            this.cardConsumoHoy.RadioBorde = 20;
            this.cardConsumoHoy.Size = new System.Drawing.Size(290, 90);
            this.cardConsumoHoy.TabIndex = 0;
            // 
            // panelIndicadorHoy
            // 
            this.panelIndicadorHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelIndicadorHoy.ColorBorde = System.Drawing.Color.Transparent;
            this.panelIndicadorHoy.GrosorBorde = 1;
            this.panelIndicadorHoy.Location = new System.Drawing.Point(0, 0);
            this.panelIndicadorHoy.Name = "panelIndicadorHoy";
            this.panelIndicadorHoy.RadioBorde = 20;
            this.panelIndicadorHoy.Size = new System.Drawing.Size(6, 90);
            this.panelIndicadorHoy.TabIndex = 0;
            // 
            // lblTituloHoy
            // 
            this.lblTituloHoy.AutoSize = true;
            this.lblTituloHoy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHoy.Location = new System.Drawing.Point(15, 10);
            this.lblTituloHoy.Name = "lblTituloHoy";
            this.lblTituloHoy.Size = new System.Drawing.Size(94, 15);
            this.lblTituloHoy.TabIndex = 1;
            this.lblTituloHoy.Text = "\"Consumo Hoy\"";
            // 
            // lblValorHoy
            // 
            this.lblValorHoy.AutoSize = true;
            this.lblValorHoy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblValorHoy.Location = new System.Drawing.Point(15, 30);
            this.lblValorHoy.Name = "lblValorHoy";
            this.lblValorHoy.Size = new System.Drawing.Size(115, 30);
            this.lblValorHoy.TabIndex = 2;
            this.lblValorHoy.Text = "\"12.4 kWh\"";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelContenidoPrincipal);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopbar);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.pnlTopbar.ResumeLayout(false);
            this.pnlTopbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfilUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoDashboard)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.panelContenidoPrincipal.ResumeLayout(false);
            this.cardConsumoHoy.ResumeLayout(false);
            this.cardConsumoHoy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Label lblLogoTexto;
        private System.Windows.Forms.PictureBox picLogoDashboard;
        private System.Windows.Forms.TextBox txtBuscarDashboard;
        private System.Windows.Forms.Label lblBadgEPlan;
        private System.Windows.Forms.Button btnMejorarPlan;
        private System.Windows.Forms.Label lblNombreUsuarioHeader;
        private System.Windows.Forms.PictureBox picPerfilUsuario;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnMenuInicio;
        private System.Windows.Forms.Button btnMenuAparatos;
        private System.Windows.Forms.Button btnMenuConfiguracion;
        private System.Windows.Forms.Button btnMenuPlanes;
        private System.Windows.Forms.Button btnMenuRegistro;
        private System.Windows.Forms.Button btnMenuCerrarSesion;
        private System.Windows.Forms.Panel panelContenidoPrincipal;
        private PanelRedondeado cardConsumoHoy;
        private PanelRedondeado panelIndicadorHoy;
        private System.Windows.Forms.Label lblValorHoy;
        private System.Windows.Forms.Label lblTituloHoy;
    }
}