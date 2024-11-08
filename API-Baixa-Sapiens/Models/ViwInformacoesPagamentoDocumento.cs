using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwInformacoesPagamentoDocumento
    {
        public decimal SqDocumento { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public int? NrAutoInfracao { get; set; }
        public string DsTipoDocumento { get; set; } = null!;
        public int SqTipoDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public DateTime? DaVencimento { get; set; }
        public DateTime? DaPagamento { get; set; }
        public decimal VlDocumento { get; set; }
        public decimal VlDevido { get; set; }
        public decimal VlPagamento { get; set; }
        public decimal VlMoraMulta { get; set; }
        public decimal VlMoraMultaCorreta { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlDescontoCorreto { get; set; }
        public string DsTipoArrecadacao { get; set; } = null!;
    }
}
