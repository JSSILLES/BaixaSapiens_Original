using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblImpressaoBoletoBancarioAtit
    {
        public string CoUsuario { get; set; } = null!;
        public string CoCarteira { get; set; } = null!;
        public int NrConvenioBanco { get; set; }
        public string NrNossoNumero { get; set; } = null!;
        public string NrCodigoBarra { get; set; } = null!;
        public string NrLinhaDigitavel { get; set; } = null!;
    }
}
