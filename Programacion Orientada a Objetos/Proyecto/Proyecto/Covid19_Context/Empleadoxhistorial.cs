using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Empleadoxhistorial
    {
        public int Id { get; set; }
        public int IdHistorial { get; set; }
        public int IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Historial IdHistorialNavigation { get; set; }
    }
}
