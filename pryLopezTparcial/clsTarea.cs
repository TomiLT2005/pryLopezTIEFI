using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezTparcial
{
    class clsTarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public clsTarea(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
