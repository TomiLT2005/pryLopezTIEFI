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
    public partial class frmLugares: Form
    {

        clsConexion conexion = new clsConexion();


        //Variable para guardar el Id seleccionado
        private int IdSeleccionado = 0;


        public frmLugares()
        {
            InitializeComponent();
        }


        private void frmLugar_Load(object sender, EventArgs e)
        {
            conexion.Listar_Lugares(dgvLugares);
        }



        //Controles Principales (Nuevo, Modificar, Eliminar)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string Nombre = txtNomLugar.Text;
                

                clsLugar nuevoLugar = new clsLugar(0, Nombre);

                conexion.Agregar_Lugar(nuevoLugar);
                conexion.Listar_Lugares(dgvLugares);

                LimpiarCampos();

                btnAgregar.Enabled = false;
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
                clsLugar lugar = new clsLugar(IdSeleccionado, txtNomLugar.Text);

                conexion.Modificar_Lugar(lugar);
                conexion.Listar_Lugares(dgvLugares);

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Estás seguro de que deseas eliminar este Lugar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                conexion.Eliminar_Lugar(IdSeleccionado);
                conexion.Listar_Lugares(dgvLugares);

                LimpiarCampos();
            }
        }




        //Control Secundario (Volver)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            conexion.Listar_Lugares(dgvLugares);
            LimpiarCampos();
        }





        //Método para obtener valores de la fila seleccionada
        private void dgvLugares_CellClick(object sender, DataGridViewCellEventArgs f)
        {
            if (f.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLugares.Rows[f.RowIndex];

                IdSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                txtNomLugar.Text = fila.Cells["Nombre"].Value.ToString();
              
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }




        //Controles (Validar - Limpiar campos)
        private bool validarCampos()
        {
            epValidacion.Clear();

            if (string.IsNullOrWhiteSpace(txtNomLugar.Text))
            {
                epValidacion.SetError(txtNomLugar, "El Lugar debe tener un Nombre");
                txtNomLugar.Focus();
                return false;
            }

            return true; //esta todo correcto//
        }


        private void LimpiarCampos()
        {
            txtNomLugar.Text = "";
            IdSeleccionado = 0;
        }
    }
}
