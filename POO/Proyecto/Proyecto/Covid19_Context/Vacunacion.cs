using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Vacunacion
    {
        public int Id { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public int? Tiempo { get; set; }
        public int IdEfectoSecundario { get; set; }
        public string IdCiudadano { get; set; }

        public virtual Ciudadano IdCiudadanoNavigation { get; set; }
        public virtual EfectoSecundario IdEfectoSecundarioNavigation { get; set; }
    }
}
