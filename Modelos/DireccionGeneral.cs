using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class DireccionGeneral
    {
        public DireccionGeneral()
        {
            OrigenTickets = new HashSet<OrigenTicket>();
        }

        public int IdDireccion { get; set; }
        public int IdDepartamento { get; set; }
        public int IdMunicipio { get; set; }
        public int IdColonia { get; set; }
        public int IdCalle { get; set; }

        public virtual CalleCanton IdCalleNavigation { get; set; } = null!;
        public virtual Colonium IdColoniaNavigation { get; set; } = null!;
        public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
        public virtual Municipo IdMunicipioNavigation { get; set; } = null!;
        public virtual ICollection<OrigenTicket> OrigenTickets { get; set; }
    }
}
