using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSuperintendencium
    {
        public TblSuperintendencium()
        {
            TblTipoDocumentos = new HashSet<TblTipoDocumento>();
            TblUsuarios = new HashSet<TblUsuario>();
        }

        public int SqSuperintendencia { get; set; }
        public byte CoSuperintendencia { get; set; }
        public string NoSuperintendencia { get; set; } = null!;

        public virtual ICollection<TblTipoDocumento> TblTipoDocumentos { get; set; }
        public virtual ICollection<TblUsuario> TblUsuarios { get; set; }
    }
}
