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
    public partial class frmTareas: Form
    {

        clsConexion conexion = new clsConexion();


        //Variable para guardar el Id seleccionado
        private int IdSeleccionado = 0;


        public frmTareas()
        {
            InitializeComponent();
        }

        private void frmTareas_Load(object sender, EventArgs e)
        {
            conexion.Listar_Tareas(dgvTareas);
        }



        //Controles Principales (Nuevo, Modificar, Eliminar)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string Nombre = txtNomTarea.Text;


                clsTarea nuevaTarea = new clsTarea(0, Nombre);

                conexion.Agregar_Tarea(nuevaTarea);
                conexion.Listar_Tareas(dgvTareas);

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
                clsTarea lugar = new clsTarea(IdSeleccionado, txtNomTarea.Text);

                conexion.Modificar_Tarea(lugar);
                conexion.Listar_Tareas(dgvTareas);

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Estás seguro de que deseas eliminar esta Tarea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                conexion.Eliminar_Tarea(IdSeleccionado);
                conexion.Listar_Tareas(dgvTareas); 


                LimpiarCampos();
            }
        }




        //Control Secundario (Volver)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            conexion.Listar_Tareas(dgvTareas);
            LimpiarCampos();
        }




        //Método para obtener valores de la fila seleccionada
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs f)
        {
            if (f.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTareas.Rows[f.RowIndex];

                IdSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                txtNomTarea.Text = fila.Cells["Nombre"].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }




        //Controles (Validar - Limpiar campos)
        private bool validarCampos()
        {
            epValidacion.Clear();

            if (string.IsNullOrWhiteSpace(txtNomTarea.Text))
            {
                epValidacion.SetError(txtNomTarea, "La Tarea debe tener un Nombre");
                txtNomTarea.Focus();
                return false;
            }

            return true; //esta todo correcto//
        }


        private void LimpiarCampos()
        {
            txtNomTarea.Text = "";
            IdSeleccionado = 0;
        }
    }
}
