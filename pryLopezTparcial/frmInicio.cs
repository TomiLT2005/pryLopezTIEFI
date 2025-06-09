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
        private DateTime fechaInicio;
        private DateTime horaInicio;
        private DateTime horaFin;
        private TimeSpan tiempoTranscurrido;


        private int tiempoActual = 0; 

        clsConexion conexion = new clsConexion(); 


        public frmInicio(string nombre, int rol)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            rolUsuario = rol;
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now;       //hora
            fechaInicio = horaInicio.Date;   //fecha
           
            timerTiempo.Enabled = true; //inicia el timer

            //Usuario activo
            lblUsuarioActivo.Text = $"Bienvenido: {nombreUsuario}";

            //Fecha de Inicio
            lblFechaInicio.Text = $"Fecha de Inicio: {horaInicio.ToString("dd/MM/yyyy")}";


            //control de acceso
            if (rolUsuario == 1)
            {
                mnuRegistro.Visible = false;
            }
            else if (rolUsuario == 2)
            {
                mnuRegistro.Visible = false;
                mnuAdmin.Visible = false;
            }
            else 
            {
                mnuAgregarTarea.Visible = false;
                mnuAgregarLugar.Visible = false;
                mnuAdmin.Visible = false;
            }
        }



        //Cierre FrmInicio
        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerTiempo.Enabled = false; //detiene el timer

            horaFin = DateTime.Now; //obtiene la hora de cierre 

            //Tiempo Transcurrido
            tiempoTranscurrido = horaFin - horaInicio;

            //Obtengo Id del Usuario por Nombre
            int idUsuario = conexion.ObtenerIdUsuarioPorNombre(nombreUsuario);

            clsSesion sesion = new clsSesion(0,idUsuario,fechaInicio,horaInicio,horaFin,tiempoTranscurrido);


            conexion.GuardarSesion(sesion);

            this.Close();
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

                
                frmLogin ventanaLogin = new frmLogin();
                ventanaLogin.Show();

                this.Close();
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

        //Ventana Tareas
       

        //Ventana Lugar
        private void mnuAgregarLugar_Click(object sender, EventArgs e)
        {
            frmLugares ventana = new frmLugares();
            ventana.ShowDialog();
        }

        //Ventana Registro
        private void mnuRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro ventana = new frmRegistro();
            ventana.ShowDialog();
        }

        //Ventana Historial
        private void mnuHistorial_Click(object sender, EventArgs e)
        {
            frmHistorial ventana = new frmHistorial();
            ventana.ShowDialog();
        }

        private void mnuAgregarTarea_Click(object sender, EventArgs e)
        {
            frmTareas ventana = new frmTareas();
            ventana.ShowDialog();
        }
    }
}
