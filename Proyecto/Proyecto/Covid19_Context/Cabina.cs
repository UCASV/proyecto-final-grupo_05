using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Cabina
    {
        public Cabina()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
