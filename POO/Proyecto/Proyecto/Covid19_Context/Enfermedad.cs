using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class Enfermedad
    {
        public int Id { get; set; }
        public string Enfermedad1 { get; set; }
        public string IdCiudadano { get; set; }

        public virtual Ciudadano IdCiudadanoNavigation { get; set; }
    }
}
