using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblLogImputacao
    {
        public int SqLogImputacao { get; set; }
        public int SqParcelamento { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public decimal SqDocumento { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public string CoUsuario { get; set; } = null!;
        public DateTime DaImputacao { get; set; }
        public string? DsObservacao { get; set; }

        public virtual TblUsuario CoUsuarioNavigation { get; set; } = null!;
        public virtual TblParcelamento SqParcelamentoNavigation { get; set; } = null!;
        public virtual TblFinanceira TblFinanceira { get; set; } = null!;
    }
}
