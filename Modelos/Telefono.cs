using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class Telefono
    {
        public Telefono()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdTelefono { get; set; }
        public int Numero { get; set; }
        public string TipoTelefono { get; set; } = null!;

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
