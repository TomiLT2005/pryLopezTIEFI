namespace pryLopezTparcial
{
    partial class frmLugares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLugares));
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvLugares = new System.Windows.Forms.DataGridView();
            this.mrcUsuarios = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNomLugar = new System.Windows.Forms.TextBox();
            this.lblNomLugar = new System.Windows.Forms.Label();
            this.epValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).BeginInit();
            this.mrcUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Image = global::pryLopezTparcial.Properties.Resources.imgVolver;
            this.btnVolver.Location = new System.Drawing.Point(593, 34);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(52, 35);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvLugares
            // 
            this.dgvLugares.AllowUserToAddRows = false;
            this.dgvLugares.AllowUserToDeleteRows = false;
            this.dgvLugares.AllowUserToResizeColumns = false;
            this.dgvLugares.AllowUserToResizeRows = false;
            this.dgvLugares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugares.Location = new System.Drawing.Point(316, 34);
            this.dgvLugares.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLugares.Name = "dgvLugares";
            this.dgvLugares.ReadOnly = true;
            this.dgvLugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLugares.Size = new System.Drawing.Size(270, 277);
            this.dgvLugares.TabIndex = 13;
            this.dgvLugares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLugares_CellClick);
            // 
            // mrcUsuarios
            // 
            this.mrcUsuarios.Controls.Add(this.btnEliminar);
            this.mrcUsuarios.Controls.Add(this.btnModificar);
            this.mrcUsuarios.Controls.Add(this.btnAgregar);
            this.mrcUsuarios.Controls.Add(this.txtNomLugar);
            this.mrcUsuarios.Controls.Add(this.lblNomLugar);
            this.mrcUsuarios.Location = new System.Drawing.Point(13, 27);
            this.mrcUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Name = "mrcUsuarios";
            this.mrcUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Size = new System.Drawing.Size(273, 284);
            this.mrcUsuarios.TabIndex = 12;
            this.mrcUsuarios.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::pryLopezTparcial.Properties.Resources.imgEliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(23, 226);
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
            this.btnModificar.Location = new System.Drawing.Point(23, 181);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 39);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(23, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(216, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNomLugar
            // 
            this.txtNomLugar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomLugar.Location = new System.Drawing.Point(23, 49);
            this.txtNomLugar.Name = "txtNomLugar";
            this.txtNomLugar.Size = new System.Drawing.Size(216, 25);
            this.txtNomLugar.TabIndex = 3;
            // 
            // lblNomLugar
            // 
            this.lblNomLugar.AutoSize = true;
            this.lblNomLugar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLugar.Location = new System.Drawing.Point(20, 26);
            this.lblNomLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomLugar.Name = "lblNomLugar";
            this.lblNomLugar.Size = new System.Drawing.Size(50, 16);
            this.lblNomLugar.TabIndex = 2;
            this.lblNomLugar.Text = "Nombre";
            // 
            // epValidacion
            // 
            this.epValidacion.ContainerControl = this;
            // 
            // frmLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 338);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvLugares);
            this.Controls.Add(this.mrcUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLugares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lugares";
            this.Load += new System.EventHandler(this.frmLugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).EndInit();
            this.mrcUsuarios.ResumeLayout(false);
            this.mrcUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvLugares;
        private System.Windows.Forms.GroupBox mrcUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNomLugar;
        private System.Windows.Forms.Label lblNomLugar;
        private System.Windows.Forms.ErrorProvider epValidacion;
    }
}