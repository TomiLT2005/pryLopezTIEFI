﻿namespace pryLopezTparcial
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.statusBarInicio = new System.Windows.Forms.StatusStrip();
            this.lblBienvenido = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaInicio = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuInicio = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregarTarea = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregarLugar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblUsuarioActivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarInicio.SuspendLayout();
            this.menuInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBarInicio
            // 
            this.statusBarInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBienvenido,
            this.lblUsuarioActivo,
            this.LblTiempo,
            this.lblFechaInicio});
            this.statusBarInicio.Location = new System.Drawing.Point(0, 532);
            this.statusBarInicio.Name = "statusBarInicio";
            this.statusBarInicio.Size = new System.Drawing.Size(845, 22);
            this.statusBarInicio.TabIndex = 0;
            this.statusBarInicio.Text = "statusStrip1";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(80, 17);
            this.lblBienvenido.Text = "Bienvenido:";
            // 
            // LblTiempo
            // 
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(603, 17);
            this.LblTiempo.Spring = true;
            this.LblTiempo.Text = "Tiempo";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(43, 17);
            this.lblFechaInicio.Text = "Fecha";
            // 
            // menuInicio
            // 
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuTareas,
            this.mnuAdmin});
            this.menuInicio.Location = new System.Drawing.Point(0, 0);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(845, 32);
            this.menuInicio.TabIndex = 1;
            this.menuInicio.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuHome.Image = global::pryLopezTparcial.Properties.Resources.imgHome;
            this.mnuHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(36, 28);
            this.mnuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuSalir
            // 
            this.mnuSalir.Image = global::pryLopezTparcial.Properties.Resources.imgSalir;
            this.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(151, 30);
            this.mnuSalir.Text = "Cerrar Sesión";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuTareas
            // 
            this.mnuTareas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregarTarea,
            this.mnuAgregarLugar,
            this.mnuRegistro,
            this.mnuHistorial});
            this.mnuTareas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTareas.Image = ((System.Drawing.Image)(resources.GetObject("mnuTareas.Image")));
            this.mnuTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuTareas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuTareas.Name = "mnuTareas";
            this.mnuTareas.Size = new System.Drawing.Size(83, 28);
            this.mnuTareas.Text = "Tareas";
            this.mnuTareas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuAgregarTarea
            // 
            this.mnuAgregarTarea.Image = global::pryLopezTparcial.Properties.Resources.imgAgregarTarea;
            this.mnuAgregarTarea.Name = "mnuAgregarTarea";
            this.mnuAgregarTarea.Size = new System.Drawing.Size(161, 22);
            this.mnuAgregarTarea.Text = "Agregar Tarea";
            this.mnuAgregarTarea.Click += new System.EventHandler(this.mnuAgregarTarea_Click);
            // 
            // mnuAgregarLugar
            // 
            this.mnuAgregarLugar.Image = global::pryLopezTparcial.Properties.Resources.imgAgregarLugar;
            this.mnuAgregarLugar.Name = "mnuAgregarLugar";
            this.mnuAgregarLugar.Size = new System.Drawing.Size(161, 22);
            this.mnuAgregarLugar.Text = "Agregar Lugar";
            this.mnuAgregarLugar.Click += new System.EventHandler(this.mnuAgregarLugar_Click);
            // 
            // mnuRegistro
            // 
            this.mnuRegistro.Image = global::pryLopezTparcial.Properties.Resources.imgRegistro;
            this.mnuRegistro.Name = "mnuRegistro";
            this.mnuRegistro.Size = new System.Drawing.Size(161, 22);
            this.mnuRegistro.Text = "Registro";
            this.mnuRegistro.Click += new System.EventHandler(this.mnuRegistro_Click);
            // 
            // mnuHistorial
            // 
            this.mnuHistorial.Image = global::pryLopezTparcial.Properties.Resources.imgHistorial;
            this.mnuHistorial.Name = "mnuHistorial";
            this.mnuHistorial.Size = new System.Drawing.Size(161, 22);
            this.mnuHistorial.Text = "Historial";
            this.mnuHistorial.Click += new System.EventHandler(this.mnuHistorial_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuAuditoria});
            this.mnuAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdmin.Image = global::pryLopezTparcial.Properties.Resources.imgAdmin;
            this.mnuAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(134, 28);
            this.mnuAdmin.Text = " Administración";
            this.mnuAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("mnuUsuarios.Image")));
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(129, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuAuditoria
            // 
            this.mnuAuditoria.Image = ((System.Drawing.Image)(resources.GetObject("mnuAuditoria.Image")));
            this.mnuAuditoria.Name = "mnuAuditoria";
            this.mnuAuditoria.Size = new System.Drawing.Size(129, 22);
            this.mnuAuditoria.Text = "Auditoria";
            this.mnuAuditoria.Click += new System.EventHandler(this.mnuAuditoria_Click);
            // 
            // timerTiempo
            // 
            this.timerTiempo.Tick += new System.EventHandler(this.timerTiempo_Tick);
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(98, 17);
            this.lblUsuarioActivo.Text = "Usuario Activo";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(845, 554);
            this.Controls.Add(this.statusBarInicio);
            this.Controls.Add(this.menuInicio);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuInicio;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicio_FormClosed);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.statusBarInicio.ResumeLayout(false);
            this.statusBarInicio.PerformLayout();
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBarInicio;
        private System.Windows.Forms.ToolStripStatusLabel lblBienvenido;
        private System.Windows.Forms.MenuStrip menuInicio;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuTareas;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAuditoria;
        private System.Windows.Forms.ToolStripStatusLabel LblTiempo;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaInicio;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarLugar;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistro;
        private System.Windows.Forms.ToolStripMenuItem mnuHistorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarTarea;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActivo;
    }
}