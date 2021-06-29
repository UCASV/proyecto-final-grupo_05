using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Tipo
    {
        public Tipo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string Tipo1 { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
