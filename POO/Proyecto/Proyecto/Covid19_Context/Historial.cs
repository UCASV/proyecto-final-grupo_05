using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Historial
    {
        public Historial()
        {
            Empleadoxhistorials = new HashSet<Empleadoxhistorial>();
        }

        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int IdCabina { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual ICollection<Empleadoxhistorial> Empleadoxhistorials { get; set; }
    }
}
