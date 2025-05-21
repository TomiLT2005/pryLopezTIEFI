using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezTparcial
{
    public partial class frmInicio: Form
    {

        private string nombreUsuario;
        private int rolUsuario;
        private int tiempo = 0; //contador

        public frmInicio(string nombre, int rol)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            rolUsuario = rol;
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            //Usuario activo
            lblUsuarioActivo.Text = $"Bienvenido: {nombreUsuario}";


            //control de acceso
            if (rolUsuario == 1) 
            {
                mnuHome.Visible = true;
                mnuTareas.Visible = false;
                mnuAdmin.Visible = true;

            }
            else 
            {
                mnuHome.Visible = true;
                mnuTareas.Visible = true;
                mnuAdmin.Visible = false;
            }

        }





        //Cerrar Sesión
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quieres Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // aca debo parar el contador
            }
        }


        //Ventana Usuarios
        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ventana = new frmUsuarios();
            ventana.ShowDialog();
        }
    }
}
