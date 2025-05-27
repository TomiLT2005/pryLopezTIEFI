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
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int RolId { get; set; }


        public clsUsuario(int id,string nombre, string contraseña, string correo, string telefono, int rolId)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Correo = correo;
            this.Telefono = telefono;
            this.RolId = rolId;
        }
    }
}
