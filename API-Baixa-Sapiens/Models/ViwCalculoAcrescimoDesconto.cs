using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwCalculoAcrescimoDesconto
    {
        public decimal SqDocumento { get; set; }
        public int SqTipoDocumento { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public int SqTipoArrecadacao { get; set; }
        public DateTime? DaPagamento { get; set; }
        public DateTime? DaVencimento { get; set; }
        public DateTime? DaTolerancia { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlLimitePagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlMoraMultaPagamento { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlDocumentoCorreto { get; set; }
        public decimal? VlMoraMultaCorreta { get; set; }
        public decimal? ValorDolarVencimento { get; set; }
        public decimal? ValorDolarAntesPagamento { get; set; }
        public decimal? ValorSelic { get; set; }
    }
}
