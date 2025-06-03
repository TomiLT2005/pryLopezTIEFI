namespace pryLopezTparcial
{
    partial class frmHistorial
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
            this.mrcBuscar = new System.Windows.Forms.GroupBox();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.mrcTarea = new System.Windows.Forms.GroupBox();
            this.txtBusTarea = new System.Windows.Forms.TextBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.mrcBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.mrcTarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcBuscar
            // 
            this.mrcBuscar.Controls.Add(this.dtpBuscarFecha);
            this.mrcBuscar.Location = new System.Drawing.Point(22, 21);
            this.mrcBuscar.Name = "mrcBuscar";
            this.mrcBuscar.Size = new System.Drawing.Size(236, 54);
            this.mrcBuscar.TabIndex = 4;
            this.mrcBuscar.TabStop = false;
            this.mrcBuscar.Text = "Buscar por Fecha";
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Location = new System.Drawing.Point(6, 19);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(214, 20);
            this.dtpBuscarFecha.TabIndex = 1;
            this.dtpBuscarFecha.ValueChanged += new System.EventHandler(this.dtpBuscarFecha_ValueChanged);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(22, 90);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(766, 348);
            this.dgvHistorial.TabIndex = 3;
            // 
            // mrcTarea
            // 
            this.mrcTarea.Controls.Add(this.txtBusTarea);
            this.mrcTarea.Location = new System.Drawing.Point(289, 22);
            this.mrcTarea.Name = "mrcTarea";
            this.mrcTarea.Size = new System.Drawing.Size(261, 53);
            this.mrcTarea.TabIndex = 12;
            this.mrcTarea.TabStop = false;
            this.mrcTarea.Text = "Buscar por Tarea";
            // 
            // txtBusTarea
            // 
            this.txtBusTarea.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusTarea.Location = new System.Drawing.Point(6, 22);
            this.txtBusTarea.Multiline = true;
            this.txtBusTarea.Name = "txtBusTarea";
            this.txtBusTarea.Size = new System.Drawing.Size(249, 23);
            this.txtBusTarea.TabIndex = 9;
            this.txtBusTarea.TextChanged += new System.EventHandler(this.txtBusTarea_TextChanged);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.Location = new System.Drawing.Point(585, 40);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(114, 32);
            this.btnVerTodos.TabIndex = 13;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.mrcTarea);
            this.Controls.Add(this.mrcBuscar);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            this.mrcBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.mrcTarea.ResumeLayout(false);
            this.mrcTarea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcBuscar;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.GroupBox mrcTarea;
        private System.Windows.Forms.TextBox txtBusTarea;
        private System.Windows.Forms.Button btnVerTodos;
    }
}