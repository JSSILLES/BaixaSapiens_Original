using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblLogBaixaFeriadoMunicipal
    {
        public int SqLogBaixaFeriadoMunicipal { get; set; }
        public string NrAutoInfracao { get; set; } = null!;
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public string NrNossoNumero { get; set; } = null!;
        public decimal SqDocumento { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public DateTime DaVencimento { get; set; }
        public DateTime DaPagamento { get; set; }
        public decimal VlDocumento { get; set; }
        public decimal VlPagamento { get; set; }
        public decimal NrAgenciaRecebedora { get; set; }
        public decimal NrBancoRecebedor { get; set; }
        public DateTime DaLogBaixa { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
        public virtual TblFinanceira TblFinanceira { get; set; } = null!;
    }
}
