namespace pryLopezTparcial
{
    partial class frmGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestion));
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNomTarea = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mrcTareas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.txtNomTarea);
            this.mrcTareas.Location = new System.Drawing.Point(29, 38);
            this.mrcTareas.Margin = new System.Windows.Forms.Padding(4);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Padding = new System.Windows.Forms.Padding(4);
            this.mrcTareas.Size = new System.Drawing.Size(250, 66);
            this.mrcTareas.TabIndex = 1;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tarea";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(29, 139);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(216, 39);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtNomTarea
            // 
            this.txtNomTarea.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomTarea.Location = new System.Drawing.Point(17, 20);
            this.txtNomTarea.Name = "txtNomTarea";
            this.txtNomTarea.Size = new System.Drawing.Size(216, 25);
            this.txtNomTarea.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(319, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(250, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 25);
            this.textBox1.TabIndex = 3;
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.mrcTareas);
            this.Name = "frmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión";
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNomTarea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}