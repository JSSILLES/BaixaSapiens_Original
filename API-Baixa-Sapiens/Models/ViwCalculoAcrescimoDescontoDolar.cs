using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwCalculoAcrescimoDescontoDolar
    {
        public decimal SqDocumento { get; set; }
        public DateTime? DaLimitePagamento { get; set; }
        public DateTime? DaPagamento { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlLimitePagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlMoraMultaPagamento { get; set; }
        public DateTime DaIndice { get; set; }
        public decimal VlIndice { get; set; }
        public decimal? VlConvertido { get; set; }
        public decimal? VlMoraMultaCorreta { get; set; }
    }
}
