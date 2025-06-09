namespace pryLopezTparcial
{
    partial class frmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareas));
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.mrcUsuarios = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNomTarea = new System.Windows.Forms.TextBox();
            this.lblNomTarea = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.epValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.mrcUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeColumns = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(316, 32);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(270, 277);
            this.dgvTareas.TabIndex = 16;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellClick);
            // 
            // mrcUsuarios
            // 
            this.mrcUsuarios.Controls.Add(this.btnEliminar);
            this.mrcUsuarios.Controls.Add(this.btnModificar);
            this.mrcUsuarios.Controls.Add(this.btnAgregar);
            this.mrcUsuarios.Controls.Add(this.txtNomTarea);
            this.mrcUsuarios.Controls.Add(this.lblNomTarea);
            this.mrcUsuarios.Location = new System.Drawing.Point(13, 25);
            this.mrcUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Name = "mrcUsuarios";
            this.mrcUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Size = new System.Drawing.Size(273, 284);
            this.mrcUsuarios.TabIndex = 15;
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
            // txtNomTarea
            // 
            this.txtNomTarea.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomTarea.Location = new System.Drawing.Point(23, 49);
            this.txtNomTarea.Name = "txtNomTarea";
            this.txtNomTarea.Size = new System.Drawing.Size(216, 25);
            this.txtNomTarea.TabIndex = 3;
            // 
            // lblNomTarea
            // 
            this.lblNomTarea.AutoSize = true;
            this.lblNomTarea.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTarea.Location = new System.Drawing.Point(20, 26);
            this.lblNomTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomTarea.Name = "lblNomTarea";
            this.lblNomTarea.Size = new System.Drawing.Size(50, 16);
            this.lblNomTarea.TabIndex = 2;
            this.lblNomTarea.Text = "Nombre";
            // 
            // btnVolver
            // 
            this.btnVolver.Image = global::pryLopezTparcial.Properties.Resources.imgVolver;
            this.btnVolver.Location = new System.Drawing.Point(593, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(52, 35);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // epValidacion
            // 
            this.epValidacion.ContainerControl = this;
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 327);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.mrcUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.frmTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.mrcUsuarios.ResumeLayout(false);
            this.mrcUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.GroupBox mrcUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNomTarea;
        private System.Windows.Forms.Label lblNomTarea;
        private System.Windows.Forms.ErrorProvider epValidacion;
    }
}