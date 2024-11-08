using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblImpressao
    {
        public string CoUsuario { get; set; } = null!;
        public decimal SqDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public string? CoCarteira { get; set; }
        public string? NrNossoNumero { get; set; }
        public string? NrCodigoBarra { get; set; }
        public string? NrLinhaDigitavel { get; set; }
        public string? NrAutoInfracaoDv { get; set; }
    }
}
