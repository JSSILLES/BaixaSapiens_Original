using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblMotivoCancelamentoParcelamento
    {
        public decimal SqMotivoCancelamentoParcelamento { get; set; }
        public string? DsMotivoCancelamentoParcelamento { get; set; }
        public short InReparcelamento { get; set; }
        public int InRescisao { get; set; }
    }
}
