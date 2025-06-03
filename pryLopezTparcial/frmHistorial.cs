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
    public partial class frmHistorial: Form
    {

        clsConexion conexion = new clsConexion();

        public frmHistorial()
        {
            InitializeComponent();
        }


        private void frmHistorial_Load(object sender, EventArgs e)
        {
            conexion.Listar_Registros(dgvHistorial);
            dtpBuscarFecha.MaxDate = DateTime.Today;
        }


        //Controles Principales (Buscar Fecha - Nombre - Todos)
        private void dtpBuscarFecha_ValueChanged(object sender, EventArgs e)
        {
            conexion.BuscarPorFecha_Registro(dgvHistorial, dtpBuscarFecha.Value);
        }

        private void txtBusTarea_TextChanged(object sender, EventArgs e)
        {
            conexion.BuscarporTarea(dgvHistorial, txtBusTarea.Text);
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            conexion.Listar_Registros(dgvHistorial);
        }
    }
}
