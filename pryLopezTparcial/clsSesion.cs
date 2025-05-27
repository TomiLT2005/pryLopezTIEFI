﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezTparcial
{
    class clsSesion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public TimeSpan TiempoTranscurrido { get; set; }


        public clsSesion(int id, int idUsuario, DateTime fechaInicio, DateTime horaInicio, DateTime horaFin, TimeSpan tiempoTranscurrido)
        {
            this.Id = id;
            this.IdUsuario = idUsuario;
            this.FechaInicio = fechaInicio;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.TiempoTranscurrido = tiempoTranscurrido;
        }
    }
}
