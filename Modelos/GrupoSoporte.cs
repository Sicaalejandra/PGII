using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class GrupoSoporte
    {
        public GrupoSoporte()
        {
            Correos = new HashSet<Correo>();
        }

        public int IdGrupo { get; set; }
        public string DescripcionGrupo { get; set; } = null!;

        public virtual ICollection<Correo> Correos { get; set; }
    }
}
