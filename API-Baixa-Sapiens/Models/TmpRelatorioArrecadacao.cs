using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TmpRelatorioArrecadacao
    {
        public decimal? VlDesconto { get; set; }
        public DateTime? DaPagamento { get; set; }
        public DateTime? DaVencimento { get; set; }
        public decimal? VlPagamento { get; set; }
        public string DsTipoDocumento { get; set; } = null!;
        public decimal? VlMoraMulta { get; set; }
        public string NoSuperintendencia { get; set; } = null!;
        public decimal? VlLimitePagamento { get; set; }
        public DateTime? DaLimitePagamento { get; set; }
        public string? NrCnpjAutuado { get; set; }
        public string? NrCpfAutuado { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public string? NrAutoInfracao { get; set; }
        public byte CoTipoArrecadacao { get; set; }
        public byte CoOrgaoAutuador { get; set; }
        public byte CoSuperintendencia { get; set; }
        public int NrSequencialDocumento { get; set; }
        public short? AaSequencialDocumento { get; set; }
        public decimal SqDocumento { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlMoraMultaCorreta { get; set; }
        public int SqTipoDocumento { get; set; }
    }
}
