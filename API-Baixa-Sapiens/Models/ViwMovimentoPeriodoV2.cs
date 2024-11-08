using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwMovimentoPeriodoV2
    {
        public DateTime? DaVencimento { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlDesconto { get; set; }
        public DateTime? DaPagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlMoraMulta { get; set; }
        public string NoSuperintendencia { get; set; } = null!;
        public string? NrCnpjAutuado { get; set; }
        public string? NrCpfAutuado { get; set; }
        public string? NrAutoInfracao { get; set; }
        public byte CoTipoArrecadacao { get; set; }
        public byte CoOrgaoAutuador { get; set; }
        public byte CoSuperintendencia { get; set; }
        public int NrSequencialDocumento { get; set; }
        public short? AaSequencialDocumento { get; set; }
        public decimal SqDocumento { get; set; }
        public string DsTipoDocumento { get; set; } = null!;
        public decimal PgtoJudicial { get; set; }
        public int? NrOrdemFinanceira { get; set; }
        public DateTime? DaConversaoRenda { get; set; }
        public decimal VlConversaoRenda { get; set; }
        public DateTime? DaDepositoJudicial { get; set; }
        public decimal? VlDocumentoCorreto { get; set; }
        public int? SqGrupoDocumento { get; set; }
        public int SqSuperintendencia { get; set; }
        public int SqFaseDocumento { get; set; }
        public int SqTipoDocumento { get; set; }
        public int? CoVersaoLayout { get; set; }
        public byte? SqOrigemDocumento { get; set; }
        public DateTime? DaParcelamento { get; set; }
        public string StVlComplemento { get; set; } = null!;
        public int? SqDepositoJudicial { get; set; }
        public string? ConversaoEmRenda { get; set; }
        public int? IdTpQuitacao { get; set; }
        public decimal? Doc { get; set; }
        public decimal? Valor { get; set; }
    }
}
