using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwMovimentoDivergentePeriodoDolar
    {
        public decimal? VlDesconto { get; set; }
        public DateTime? DaPagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlMoraMulta { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlLimitePagamento { get; set; }
        public DateTime? DaLimitePagamento { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public string NoSuperintendencia { get; set; } = null!;
        public byte CoSuperintendencia { get; set; }
        public string? NrCnpjAutuado { get; set; }
        public string? NrCpfAutuado { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public string? NrAutoInfracao { get; set; }
        public decimal SqDocumento { get; set; }
        public byte CoTipoArrecadacao { get; set; }
        public int SqTipoArrecadacao { get; set; }
        public byte CoOrgaoAutuador { get; set; }
        public int SqOrgaoAutuador { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public int NrSequencialDocumento { get; set; }
        public short? AaSequencialDocumento { get; set; }
        public string DsTipoDocumento { get; set; } = null!;
        public int SqSuperintendencia { get; set; }
        public int SqTipoDocumento { get; set; }
        public decimal? VlConvertido { get; set; }
        public decimal VlIndice { get; set; }
        public decimal? VlMoraMultaCorreta { get; set; }
        public string? MovimentoDuplicado { get; set; }
    }
}
