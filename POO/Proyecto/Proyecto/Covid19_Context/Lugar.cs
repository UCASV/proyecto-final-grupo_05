using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Lugar
    {
        public Lugar()
        {
            Cita = new HashSet<Citum>();
        }

        public int Id { get; set; }
        public string Lugar1 { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
    }
}
