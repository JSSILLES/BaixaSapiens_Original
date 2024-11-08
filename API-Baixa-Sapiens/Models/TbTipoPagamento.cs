using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbTipoPagamento
    {
        public int CdTipoPagamento { get; set; }
        public string NoTipoPagamento { get; set; } = null!;
        public string DsTipoPagamento { get; set; } = null!;
        public DateTime DtIncluso { get; set; }
    }
}
