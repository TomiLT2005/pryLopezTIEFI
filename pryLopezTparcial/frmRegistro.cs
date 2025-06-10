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
    public partial class frmRegistro: Form
    {

        clsConexion conexion = new clsConexion();


        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            conexion.CargarTareas(cmbTareas);
            conexion.CargarLugares(cmbLugares);
            dtpFechaTarea.MaxDate = DateTime.Today;
        }



        //Controles Principales (Agregar, Cancelar)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DateTime fecha = dtpFechaTarea.Value;
                int idTarea = Convert.ToInt32(cmbTareas.SelectedValue);
                int idLugar = Convert.ToInt32(cmbLugares.SelectedValue);
                bool insumos = chkInsumos.Checked;
                bool vacacion = chkVacacion.Checked;
                bool estudio = chkEstudio.Checked;
                bool salario = chkSalario.Checked;
                bool recibo = chkRecibo.Checked;
                string comentarios = txtComentarios.Text;

                clsRegistro nuevoregistro = new clsRegistro(0, fecha, idTarea, idLugar, insumos, vacacion, estudio, salario, recibo, comentarios);

                conexion.Agregar_Registro(nuevoregistro);

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }




        //Controles (Validar - Limpiar campos)
        private bool validarCampos()
        {
            epValidacion.Clear();

    
            if (cmbTareas.SelectedIndex == -1)
            {
                epValidacion.SetError(cmbTareas, "Debes elegir una Tarea");
                cmbTareas.Focus();
                return false;
            }

            if (cmbLugares.SelectedIndex == -1)
            {
                epValidacion.SetError(cmbLugares, "Debes elegir un Lugar");
                cmbLugares.Focus();
                return false;
            }

            return true; //esta todo correcto//
        }


        private void LimpiarCampos()
        {
            cmbTareas.SelectedIndex = -1;
            cmbLugares.SelectedIndex = -1;
            chkInsumos.Checked = false;
            chkVacacion.Checked = false;
            chkEstudio.Checked = false;
            chkSalario.Checked = false;
            chkRecibo.Checked = false;
            txtComentarios.Text = "";
        }

        private void mrcRegistro_Enter(object sender, EventArgs e)
        {

        }
    }
}
