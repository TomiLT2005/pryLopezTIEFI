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
    public partial class Tareas: Form
    {

        clsConexion conexion = new clsConexion();


        //Variable para guardar el Id seleccionado
        private int IdSeleccionado = 0;


        public Tareas()
        {
            InitializeComponent();
        }

        private void frmTareas_Load(object sender, EventArgs e)
        {
            conexion.Listar_Tareas(dgvTareas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
