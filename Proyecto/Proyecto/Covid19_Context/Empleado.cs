using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Empleado
    {
        public Empleado()
        {
            Cita = new HashSet<Citum>();
            Ciudadanos = new HashSet<Ciudadano>();
            Empleadoxhistorials = new HashSet<Empleadoxhistorial>();
        }

        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public int IdTipo { get; set; }
        public int IdCabina { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Tipo IdTipoNavigation { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
        public virtual ICollection<Empleadoxhistorial> Empleadoxhistorials { get; set; }
    }
}
