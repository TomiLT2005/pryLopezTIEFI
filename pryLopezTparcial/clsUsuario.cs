using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezTparcial
{
    class clsUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public int RolId { get; set; }


        public clsUsuario(int id,string nombre, string contraseña, int rolId)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.RolId = rolId;
        }
    }
}
