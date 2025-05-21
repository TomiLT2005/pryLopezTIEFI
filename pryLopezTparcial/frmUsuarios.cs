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


        //Variable para guardar el código seleccionado
        public int codigoSeleccionado = 0;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            conexion.ListarBD(dgvUsuarios);
        }


        //Agregar Usuario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string Nombre = txtNomUsuario.Text;
                string Contraseña = txtConUsuario.Text;

                clsUsuario nuevousuario = new clsUsuario(Nombre, Contraseña, 2);

                conexion.Agregar(nuevousuario);
                conexion.ListarBD(dgvUsuarios);

                LimpiarCampos();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }




        //Controles
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


        //limpiar campos
        private void LimpiarCampos() 
        {
            txtNomUsuario.Text = "";
            txtConUsuario.Text = "";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs f)
        {
            if (f.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[f.RowIndex];

                codigoSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                txtNomUsuario.Text = fila.Cells["Nombre"].Value.ToString();
                txtConUsuario.Text = fila.Cells["Contraseña"].Value.ToString();
                

                btnNuevo.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}
