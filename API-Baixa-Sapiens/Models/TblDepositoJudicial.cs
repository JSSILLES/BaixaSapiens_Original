using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblDepositoJudicial
    {
        public int SqDepositoJudicial { get; set; }
        public DateTime DaDepositoJudicial { get; set; }
        public decimal VlPagamento { get; set; }
        public int? NrOrdemFinanceira { get; set; }
        public decimal? SqDocumento { get; set; }
        public short? NrOrdemDocumentoEnvio { get; set; }
        public DateTime? DaConversaoRenda { get; set; }
        public decimal? VlConversaoRenda { get; set; }

        public virtual TblFinanceira? TblFinanceira { get; set; }
    }
}
