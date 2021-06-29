using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class EfectoSecundario
    {
        public EfectoSecundario()
        {
            Vacunacions = new HashSet<Vacunacion>();
        }

        public int Id { get; set; }
        public string EfectoSecundario1 { get; set; }

        public virtual ICollection<Vacunacion> Vacunacions { get; set; }
    }
}
