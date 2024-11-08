using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwMovimentoDivergentePeriodo
    {
        public decimal SqDocumento { get; set; }
        public int SqOrgaoAutuador { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public string? NrCnpjAutuado { get; set; }
        public string? NrAutoInfracao { get; set; }
        public string? NrCpfAutuado { get; set; }
        public int SqTipoDocumento { get; set; }
        public int NrSequencialDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public short? AaSequencialDocumento { get; set; }
        public decimal? NrAgenciaRecebedora { get; set; }
        public decimal? NrBancoRecebedor { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlMoraMulta { get; set; }
        public DateTime? DaPagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlLimitePagamento { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public byte CoOrgaoAutuador { get; set; }
        public int SqSuperintendencia { get; set; }
        public byte CoSuperintendencia { get; set; }
        public string NoSuperintendencia { get; set; } = null!;
        public int SqTipoArrecadacao { get; set; }
        public byte CoTipoArrecadacao { get; set; }
        public short CoTipoDocumento { get; set; }
        public string DsTipoDocumento { get; set; } = null!;
        public DateTime? DaVencimento { get; set; }
        public DateTime? DaTolerancia { get; set; }
        public decimal? VlMoraMultaCorreta { get; set; }
        public string? Movimentoduplicado { get; set; }
        public int SqFaseDocumento { get; set; }
    }
}
