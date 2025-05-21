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

        clsConexionBD conexion = new clsConexionBD();


        //Variable para guardar el Id seleccionado
        private int IdSeleccionado = 0;

        public frmUsuarios()
        {
            InitializeComponent();
        }



        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            conexion.ConectarBD();   //verificar conexión//
            conexion.ListarBD(dgvUsuarios);
        }




        //Controles Principales (Nuevo, Modificar, Eliminar)
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string Nombre = txtNomUsuario.Text;
                string Contraseña = txtConUsuario.Text;

                clsUsuario nuevousuario = new clsUsuario(0, Nombre, Contraseña, 2);

                conexion.Agregar(nuevousuario);
                conexion.ListarBD(dgvUsuarios);

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
                clsUsuario usuario = new clsUsuario(IdSeleccionado, txtNomUsuario.Text, txtConUsuario.Text, 0);

                conexion.Modificar(usuario);
                conexion.ListarBD(dgvUsuarios);

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
                conexion.Eliminar(IdSeleccionado);
                conexion.ListarBD(dgvUsuarios);

                LimpiarCampos();
            }
        }




        //Controles Secundarios (Buscar, Volver, Cancelar)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBusUsuario.Text;
            conexion.BuscarporNombre(dgvUsuarios, busqueda);

            LimpiarCampos();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            conexion.ListarBD(dgvUsuarios);
            LimpiarCampos();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtNomUsuario.Focus();
            conexion.ListarBD(dgvUsuarios);

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

            return true; //esta todo correcto//
        }


        private void LimpiarCampos() 
        {
            txtNomUsuario.Text = "";
            txtConUsuario.Text = "";
            txtBusUsuario.Text = "";
            IdSeleccionado = 0;
        }
    }
}
