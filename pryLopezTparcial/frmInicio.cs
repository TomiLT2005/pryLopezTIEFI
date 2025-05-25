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
        private TimeSpan tiempoTotal;


        private int tiempoActual = 0; 

        clsConexionBD conexion = new clsConexionBD(); 


        public frmInicio(string nombre, int rol)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            rolUsuario = rol;
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now; //hora y fecha de Inicio
            timerTiempo.Enabled = true; //inicia el timer

            //Usuario activo
            lblUsuarioActivo.Text = $"Bienvenido: {nombreUsuario}";

            //Fecha de Inicio
            lblFechaInicio.Text = $"Fecha de Inicio: {horaInicio.ToString("dd/MM/yyyy")}";


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



        //Cierre FrmInicio
        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerTiempo.Enabled = false; //detiene el timer

            horaFin = DateTime.Now; //obtiene la hora de cierre 

            //Tiempo Total
            tiempoTotal = horaFin - horaInicio;
            conexion.GuardarSesion(nombreUsuario, horaInicio, horaFin, tiempoTotal);

            Application.Exit();
        }




        //Tiempo Actual - Opcional
        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            tiempoActual++;
            TimeSpan ts = TimeSpan.FromSeconds(tiempoActual);
            LblTiempo.Text = ts.ToString(@"hh\:mm\:ss"); 
        }




        //Cerrar Sesión
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quieres Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerTiempo.Enabled = false; //detiene el timer

                Application.Exit();
            }
        }



        //Ventana Usuarios
        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ventana = new frmUsuarios();
            ventana.ShowDialog();
        }


        //Ventana Auditoria
        private void mnuAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria ventana = new frmAuditoria();
            ventana.ShowDialog();
        }
    }
}
