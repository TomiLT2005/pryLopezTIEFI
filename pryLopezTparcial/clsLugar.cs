using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezTparcial
{
    class clsLugar
    {
        public int Id { get; set; }
        public int Nombre { get; set; }

        public clsLugar(int id, int nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
