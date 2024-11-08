using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblErroBancario
    {
        public decimal SqErroBancario { get; set; }
        public string NrNossoNumero { get; set; } = null!;
        public DateTime DaUltimoProcessamento { get; set; }
        public string? DsMotivoErroBancario { get; set; }
        public string NoArquivoBanco { get; set; } = null!;
        public string? CoCarteira { get; set; }
    }
}
