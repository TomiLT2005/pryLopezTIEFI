namespace pryLopezTparcial
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.mrcUsuarios = new System.Windows.Forms.GroupBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.mtxtTelefonoUsuario = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtConUsuario = new System.Windows.Forms.TextBox();
            this.lblContUsuario = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.epValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBusUsuario = new System.Windows.Forms.TextBox();
            this.mrcBuscar = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.mrcUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).BeginInit();
            this.mrcBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcUsuarios
            // 
            this.mrcUsuarios.Controls.Add(this.cmbRoles);
            this.mrcUsuarios.Controls.Add(this.lblRol);
            this.mrcUsuarios.Controls.Add(this.txtCorreoUsuario);
            this.mrcUsuarios.Controls.Add(this.lblCorreo);
            this.mrcUsuarios.Controls.Add(this.lbltelefono);
            this.mrcUsuarios.Controls.Add(this.mtxtTelefonoUsuario);
            this.mrcUsuarios.Controls.Add(this.btnEliminar);
            this.mrcUsuarios.Controls.Add(this.btnModificar);
            this.mrcUsuarios.Controls.Add(this.btnNuevo);
            this.mrcUsuarios.Controls.Add(this.txtConUsuario);
            this.mrcUsuarios.Controls.Add(this.lblContUsuario);
            this.mrcUsuarios.Controls.Add(this.txtNomUsuario);
            this.mrcUsuarios.Controls.Add(this.lblNomUsuario);
            this.mrcUsuarios.Location = new System.Drawing.Point(24, 28);
            this.mrcUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Name = "mrcUsuarios";
            this.mrcUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Size = new System.Drawing.Size(273, 571);
            this.mrcUsuarios.TabIndex = 0;
            this.mrcUsuarios.TabStop = false;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoUsuario.Location = new System.Drawing.Point(23, 186);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(216, 25);
            this.txtCorreoUsuario.TabIndex = 12;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(20, 163);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(42, 16);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(20, 235);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(53, 16);
            this.lbltelefono.TabIndex = 10;
            this.lbltelefono.Text = "Teléfono";
            // 
            // mtxtTelefonoUsuario
            // 
            this.mtxtTelefonoUsuario.Location = new System.Drawing.Point(23, 254);
            this.mtxtTelefonoUsuario.Mask = "(0000) 000000";
            this.mtxtTelefonoUsuario.Name = "mtxtTelefonoUsuario";
            this.mtxtTelefonoUsuario.Size = new System.Drawing.Size(216, 22);
            this.mtxtTelefonoUsuario.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::pryLopezTparcial.Properties.Resources.imgEliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(23, 511);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(216, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::pryLopezTparcial.Properties.Resources.imgModificar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(23, 466);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 39);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(23, 421);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(216, 39);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtConUsuario
            // 
            this.txtConUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConUsuario.Location = new System.Drawing.Point(23, 118);
            this.txtConUsuario.Name = "txtConUsuario";
            this.txtConUsuario.Size = new System.Drawing.Size(216, 25);
            this.txtConUsuario.TabIndex = 5;
            // 
            // lblContUsuario
            // 
            this.lblContUsuario.AutoSize = true;
            this.lblContUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContUsuario.Location = new System.Drawing.Point(20, 95);
            this.lblContUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContUsuario.Name = "lblContUsuario";
            this.lblContUsuario.Size = new System.Drawing.Size(66, 16);
            this.lblContUsuario.TabIndex = 4;
            this.lblContUsuario.Text = "Contraseña";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsuario.Location = new System.Drawing.Point(23, 49);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(216, 25);
            this.txtNomUsuario.TabIndex = 3;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(20, 26);
            this.lblNomUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(47, 16);
            this.lblNomUsuario.TabIndex = 2;
            this.lblNomUsuario.Text = "Usuario";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(320, 85);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(553, 514);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Image = global::pryLopezTparcial.Properties.Resources.imgVolver;
            this.btnVolver.Location = new System.Drawing.Point(763, 35);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(52, 35);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::pryLopezTparcial.Properties.Resources.imgCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(821, 35);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epValidacion
            // 
            this.epValidacion.ContainerControl = this;
            // 
            // txtBusUsuario
            // 
            this.txtBusUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusUsuario.Location = new System.Drawing.Point(6, 22);
            this.txtBusUsuario.Multiline = true;
            this.txtBusUsuario.Name = "txtBusUsuario";
            this.txtBusUsuario.Size = new System.Drawing.Size(249, 23);
            this.txtBusUsuario.TabIndex = 9;
            this.txtBusUsuario.TextChanged += new System.EventHandler(this.txtBusUsuario_TextChanged);
            // 
            // mrcBuscar
            // 
            this.mrcBuscar.Controls.Add(this.txtBusUsuario);
            this.mrcBuscar.Location = new System.Drawing.Point(320, 25);
            this.mrcBuscar.Name = "mrcBuscar";
            this.mrcBuscar.Size = new System.Drawing.Size(261, 53);
            this.mrcBuscar.TabIndex = 11;
            this.mrcBuscar.TabStop = false;
            this.mrcBuscar.Text = "Buscar Usuario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(20, 302);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 16);
            this.lblRol.TabIndex = 13;
            this.lblRol.Text = "Rol";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(23, 321);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(216, 24);
            this.cmbRoles.TabIndex = 14;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 627);
            this.Controls.Add(this.mrcBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.mrcUsuarios);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.mrcUsuarios.ResumeLayout(false);
            this.mrcUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).EndInit();
            this.mrcBuscar.ResumeLayout(false);
            this.mrcBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtConUsuario;
        private System.Windows.Forms.Label lblContUsuario;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epValidacion;
        private System.Windows.Forms.TextBox txtBusUsuario;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonoUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.GroupBox mrcBuscar;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRol;
    }
}