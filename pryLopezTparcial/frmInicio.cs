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
        private DateTime horaInicio;
        private DateTime horaFin;
        private TimeSpan tiempoActual; 


        public frmInicio(string nombre, int rol)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            rolUsuario = rol;
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now; //obtiene la hora de inicio
            timerTiempo.Enabled = true; //inicia el timer

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
                timerTiempo.Enabled = false; //detiene el timer

                Application.Exit(); // aca debo parar el contador
            }
        }


        //Ventana Usuarios
        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ventana = new frmUsuarios();
            ventana.ShowDialog();
        }

        

        //Cierre FrmInicio
        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            horaFin = DateTime.Now; //obtiene la hora de cierre
            timerTiempo.Enabled = false; //detiene el timer
        }



        //Tiempo Actual
        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            tiempoActual = DateTime.Now - horaFin;
            LblTiempo.Text = "Activo: " + tiempoActual.ToString(@"hh\:mm\:ss"); 
        }
    }
}
