using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaMotivoBaixa
    {
        public TblSerasaMotivoBaixa()
        {
            TblSerasaDocumentos = new HashSet<TblSerasaDocumento>();
            TblSerasaInformacionals = new HashSet<TblSerasaInformacional>();
        }

        public int SqSerasaMotivoBaixa { get; set; }
        public string CoSerasaMotivoBaixa { get; set; } = null!;
        public string DsSerasaMotivoBaixa { get; set; } = null!;

        public virtual ICollection<TblSerasaDocumento> TblSerasaDocumentos { get; set; }
        public virtual ICollection<TblSerasaInformacional> TblSerasaInformacionals { get; set; }
    }
}
