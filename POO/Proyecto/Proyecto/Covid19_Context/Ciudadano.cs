using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            Cita = new HashSet<Citum>();
            Enfermedads = new HashSet<Enfermedad>();
            Vacunacions = new HashSet<Vacunacion>();
        }

        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int? NumeroIdentificador { get; set; }
        public int IdentificadorEmpleado { get; set; }

        public virtual Empleado IdentificadorEmpleadoNavigation { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Enfermedad> Enfermedads { get; set; }
        public virtual ICollection<Vacunacion> Vacunacions { get; set; }
    }
}
