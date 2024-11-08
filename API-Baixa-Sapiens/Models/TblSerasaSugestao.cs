using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaSugestao
    {
        public int SqSerasaSugestao { get; set; }
        public int? IdtipoDocumento { get; set; }
        public DateTime DaGeracao { get; set; }
        public int? IddocumentoSismultas { get; set; }
        public int? IddocumentoSgm { get; set; }
        public int? SqDocumento { get; set; }
        public DateTime DaLimitePagamento { get; set; }
        public decimal VlDevidoGeracao { get; set; }
        public DateTime? DaAnalise { get; set; }
        public byte InAnalise { get; set; }

        public virtual TblSerasaAnaliseSugestao InAnaliseNavigation { get; set; } = null!;
    }
}
