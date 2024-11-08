using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaSituacaoDocumento
    {
        public TblSerasaSituacaoDocumento()
        {
            TblSerasaDocumentos = new HashSet<TblSerasaDocumento>();
        }

        public byte InSituacao { get; set; }
        public string DsSituacao { get; set; } = null!;

        public virtual ICollection<TblSerasaDocumento> TblSerasaDocumentos { get; set; }
    }
}
