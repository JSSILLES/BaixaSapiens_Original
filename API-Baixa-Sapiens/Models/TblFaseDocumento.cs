using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblFaseDocumento
    {
        public TblFaseDocumento()
        {
            TblDocumentos = new HashSet<TblDocumento>();
            TblVersaoLayouts = new HashSet<TblVersaoLayout>();
        }

        public int SqFaseDocumento { get; set; }
        public string DsFaseDocumento { get; set; } = null!;
        public byte? CoFaseDocumento { get; set; }
        public string InEmissaoCobranca { get; set; } = null!;

        public virtual ICollection<TblDocumento> TblDocumentos { get; set; }
        public virtual ICollection<TblVersaoLayout> TblVersaoLayouts { get; set; }
    }
}
