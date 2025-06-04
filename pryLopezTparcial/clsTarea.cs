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
        public int Nombre { get; set; }

        public clsTarea(int id, int nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
