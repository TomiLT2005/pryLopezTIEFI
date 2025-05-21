using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezTparcial
{
    class clsUsuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public int RolId { get; set; }


        public clsUsuario(string nombre, string contraseña, int rolId)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.RolId = rolId;
        }
    }
}
