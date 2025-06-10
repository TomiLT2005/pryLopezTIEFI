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
    public partial class frmLogin: Form
    {
        clsConexion conexion = new clsConexion();


        //Variable para guardar el número de intentos
        int intentos = 3;


        public frmLogin()
        {
            InitializeComponent();
        }


        //Evento de carga del formulario
        private void frmLogin_Load(object sender, EventArgs e)
        {
            timerLogin.Enabled = true; //Inicia el timer

            txtContraseña.PasswordChar = '●';
            btnOcultar.Image = Properties.Resources.imgOjoCerrado;


            //El form captura los eventos de teclado antes que los controles
            this.KeyPreview = true;
            this.KeyPress += frmLogin_KeyPress;
            this.MouseMove += frmLogin_MouseMove; 

        }




        //Evento Controles Principales (Ingresar y Cancelar)
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else
            {
                clsUsuario usuario = new clsUsuario(0, txtUsuario.Text, txtContraseña.Text, "", "", 0);

                bool resultado = conexion.verificar_Usuario(usuario);

                if (resultado)
                {
                    frmInicio ventana = new frmInicio(usuario.Nombre, usuario.RolId);
                    this.Hide();
                    ventana.ShowDialog();
                    
                }
                else
                {
                    intentos = intentos - 1;
                    MessageBox.Show("Datos incorrectos. Intentos restantes: " + intentos);

                    if (intentos == 0)
                    {
                        MessageBox.Show("Has alcanzado el límite de intentos. Contacta con el administrador.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnIngresar.Enabled = false;
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //Controles Secundarios (Ocultar y Mostrar Contraseñas y tiempo excedido)
        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if(txtContraseña.PasswordChar == '●')
            {
                txtContraseña.PasswordChar = '\0';
                btnOcultar.Image = Properties.Resources.imgOjoAbierto;
            }
            else
            {
                txtContraseña.PasswordChar = '●';
                btnOcultar.Image = Properties.Resources.imgOjoCerrado;
            }
        }


        private void timerLogin_Tick(object sender, EventArgs e)
        {
            
            timerLogin.Enabled = false; //Detiene el timer  
            MessageBox.Show("Tiempo excedido. Cerrando la aplicación.", "Tiempo de espera", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }


        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            reiniciarTimer();
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            reiniciarTimer();
        }


        //evento para reiniciar el timer
        private void reiniciarTimer()
        {
            timerLogin.Enabled = false;
            timerLogin.Enabled = true;
        }
    }
}
