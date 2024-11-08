using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaAnaliseSugestao
    {
        public TblSerasaAnaliseSugestao()
        {
            TblSerasaSugestaos = new HashSet<TblSerasaSugestao>();
        }

        public byte InAnalise { get; set; }
        public string DsAnalise { get; set; } = null!;

        public virtual ICollection<TblSerasaSugestao> TblSerasaSugestaos { get; set; }
    }
}
