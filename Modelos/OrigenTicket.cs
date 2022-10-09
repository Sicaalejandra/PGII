using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class OrigenTicket
    {
        public OrigenTicket()
        {
            TicketGenerals = new HashSet<TicketGeneral>();
        }

        public int IdTienda { get; set; }
        public string NombreTienda { get; set; } = null!;
        public int IdDireccion { get; set; }

        public virtual DireccionGeneral IdDireccionNavigation { get; set; } = null!;
        public virtual ICollection<TicketGeneral> TicketGenerals { get; set; }
    }
}
