using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblFinanceiraHmlBkp20180404
    {
        public DateTime? DaDocumento { get; set; }
        public decimal? NrAgenciaRecebedora { get; set; }
        public DateTime? DaVencimento { get; set; }
        public decimal? NrBancoRecebedor { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlMoraMulta { get; set; }
        public DateTime? DaPagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public byte? CoTipoCodigoBarra { get; set; }
        public DateTime? DaLoteBanco { get; set; }
        public DateTime? DaLimitePagamento { get; set; }
        public decimal? VlLimitePagamento { get; set; }
        public int SqTipoArrecadacao { get; set; }
        public decimal SqDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public int? NrSequencialArquivoBanco { get; set; }
        public short? NrSequencialLinhaBanco { get; set; }
        public string? DsObservacao { get; set; }
        public bool InBaixaAutomatica { get; set; }
        public decimal? VlDocumentoDolar { get; set; }
        public decimal? VlIndicePtax { get; set; }
        public DateTime? DaInicioSelic { get; set; }
        public DateTime? DaFimSelic { get; set; }
        public decimal? PercentualSelicMaisUmPorcento { get; set; }
        public decimal? VlJurosSelicMaisUmPorcento { get; set; }
        public decimal? VlPercentualMultaMora { get; set; }
        public bool InValorComplementar { get; set; }
        public int? IdTpQuitacao { get; set; }
        public DateTime? DaConversaoRenda { get; set; }
        public decimal? VlConversaoRenda { get; set; }
        public decimal? VlResidual { get; set; }
        public int? SqStatusFinanceiro { get; set; }
        public decimal? VlHistDocumento { get; set; }
        public decimal? VlHistPagamento { get; set; }
        public DateTime? DaVencimentoParcelamento { get; set; }
    }
}
