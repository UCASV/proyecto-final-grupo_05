using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Citum
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int IdentificadorCita { get; set; }
        public int IdLugar { get; set; }
        public int IdentificadorEmpleado { get; set; }
        public string IdCiudadano { get; set; }

        public virtual Ciudadano IdCiudadanoNavigation { get; set; }
        public virtual Lugar IdLugarNavigation { get; set; }
        public virtual Empleado IdentificadorEmpleadoNavigation { get; set; }
    }
}
