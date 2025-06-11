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
    public partial class frmUsuarios : Form
    {

        clsConexion conexion = new clsConexion();


        //Variable para guardar el Id seleccionado
        private int IdSeleccionado = 0;

       
        public frmUsuarios()
        {
            InitializeComponent();
        }


        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            conexion.ConectarBD();   //verificar conexión//
            conexion.Listar_Usuarios(dgvUsuarios);
            conexion.CargarRoles(cmbRoles);
        }



        //Controles Principales (Nuevo, Modificar, Eliminar)
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string Nombre = txtNomUsuario.Text;
                string Contraseña = txtConUsuario.Text;
                string Correo = txtCorreoUsuario.Text;
                string Telefono = mtxtTelefonoUsuario.Text;
                int Rol = Convert.ToInt32(cmbRoles.SelectedValue);

                clsUsuario nuevousuario = new clsUsuario(0, Nombre, Contraseña, Correo, Telefono, Rol);

                conexion.Agregar_Usuario(nuevousuario);
                conexion.Listar_Usuarios(dgvUsuarios);

                LimpiarCampos();

                btnNuevo.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarCampos()) 
            {
                clsUsuario usuario = new clsUsuario(IdSeleccionado, txtNomUsuario.Text, txtConUsuario.Text, txtCorreoUsuario.Text, mtxtTelefonoUsuario.Text, Convert.ToInt32(cmbRoles.SelectedValue));

                conexion.Modificar_Usuario(usuario);
                conexion.Listar_Usuarios(dgvUsuarios);

                LimpiarCampos();
            }
            else 
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Estás seguro de que deseas eliminar este Usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                conexion.Eliminar_Usuario(IdSeleccionado);
                conexion.Listar_Usuarios(dgvUsuarios);

                LimpiarCampos();
            }
        }




        //Controles Secundarios (Buscar, Volver, Cancelar)
        private void txtBusUsuario_TextChanged(object sender, EventArgs e)
        {
            conexion.BuscarporNombre_Usuario(dgvUsuarios, txtBusUsuario.Text);
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            conexion.Listar_Usuarios(dgvUsuarios);
            LimpiarCampos();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtNomUsuario.Focus();
            conexion.Listar_Usuarios(dgvUsuarios);

            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }




        //Método para obtener valores de la fila seleccionada
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs f)
        {
            if (f.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[f.RowIndex];

                IdSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                txtNomUsuario.Text = fila.Cells["Nombre"].Value.ToString();
                txtConUsuario.Text = fila.Cells["Contraseña"].Value.ToString();
                txtCorreoUsuario.Text = fila.Cells["Correo"].Value.ToString();
                mtxtTelefonoUsuario.Text = fila.Cells["Telefono"].Value.ToString();
                cmbRoles.SelectedValue = fila.Cells["RolId"].Value;



                btnNuevo.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }




        //Controles (Validar - Limpiar campos)
        private bool validarCampos()
        {
            epValidacion.Clear();

            if (string.IsNullOrWhiteSpace(txtNomUsuario.Text))
            {
                epValidacion.SetError(txtNomUsuario, "Debe ingresar un nombre de usuario");
                txtNomUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConUsuario.Text))
            {
                epValidacion.SetError(txtConUsuario, "Debe ingresar una contraseña");
                txtConUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoUsuario.Text))
            {
                epValidacion.SetError(txtCorreoUsuario, "Debe ingresar un correo electrónico");
                txtCorreoUsuario.Focus();
                return false;
            }

            if (!txtCorreoUsuario.Text.Contains("@")) //verifica si contiene @
            {
                epValidacion.SetError(txtCorreoUsuario, "El correo debe contener '@'");
                txtCorreoUsuario.Focus();
                return false;
            }

            if (!mtxtTelefonoUsuario.MaskFull || mtxtTelefonoUsuario.Text.Contains("_"))
            {
                epValidacion.SetError(mtxtTelefonoUsuario, "Debe ingresar un número de teléfono válido.");
                mtxtTelefonoUsuario.Focus();
                return false;
            }

            if (cmbRoles.SelectedIndex == -1)
            {
                epValidacion.SetError(cmbRoles, "El Usuario necesita una Rol");
                cmbRoles.Focus();
                return false;
            }

            return true; //esta todo correcto//
        }


        private void LimpiarCampos() 
        {
            txtNomUsuario.Text = "";
            txtConUsuario.Text = "";
            txtCorreoUsuario.Text = "";
            mtxtTelefonoUsuario.Text = "";
            txtBusUsuario.Text = "";
            cmbRoles.SelectedIndex = -1; 
            IdSeleccionado = 0;
        }
    }
}
