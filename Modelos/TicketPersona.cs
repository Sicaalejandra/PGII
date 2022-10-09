using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class TicketPersona
    {
        public int NoTicket { get; set; }
        public int IdTicket { get; set; }
        public int IdPersona { get; set; }
        public int IdTipopersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual TicketGeneral IdTicketNavigation { get; set; } = null!;
        public virtual TipoPersona IdTipopersonaNavigation { get; set; } = null!;
    }
}
