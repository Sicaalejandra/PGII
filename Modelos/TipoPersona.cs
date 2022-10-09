using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class TipoPersona
    {
        public TipoPersona()
        {
            Personas = new HashSet<Persona>();
            TicketPersonas = new HashSet<TicketPersona>();
        }

        public int IdTipopersona { get; set; }
        public string TipoPersona1 { get; set; } = null!;

        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<TicketPersona> TicketPersonas { get; set; }
    }
}
