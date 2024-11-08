using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblPer
    {
        public string? NoMensagem1 { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }
        public DateTime? DaLimite { get; set; }
        public decimal SqDocumento { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
