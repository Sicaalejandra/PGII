using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class Correo
    {
        public Correo()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdCorreo { get; set; }
        public string CorreoP { get; set; } = null!;
        public int IdGrupo { get; set; }

        public virtual GrupoSoporte IdGrupoNavigation { get; set; } = null!;
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
