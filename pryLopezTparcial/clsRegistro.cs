using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezTparcial
{
    class clsRegistro
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int TareaId { get; set; }
        public int LugarId { get; set; }
        public bool Insumos { get; set; }
        public bool Vacacion { get; set; }
        public bool Estudio { get; set; }
        public bool Salario { get; set; }
        public bool Recibo { get; set; }
        public string Comentarios { get; set; }

        public clsRegistro(int id, DateTime fechaRegistro, int tareaId, int lugarId, bool insumos, bool vacacion, bool estudio, bool salario, bool recibo, string comentarios)
        {
            this.Id = id;
            this.FechaRegistro = fechaRegistro;
            this.TareaId = tareaId;
            this.LugarId = lugarId;
            this.Insumos = insumos;
            this.Vacacion = vacacion;
            this.Estudio = estudio;
            this.Salario = salario;
            this.Recibo = recibo;
            this.Comentarios = comentarios;
        }
    }
}
