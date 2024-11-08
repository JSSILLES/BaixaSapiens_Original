using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbImputacaoParcelamento
    {
        public int CdSeqImputacaoParcelamento { get; set; }
        public int? NuAutoInfracao { get; set; }
        public DateTime? DtVencimeno { get; set; }
        public decimal? VlHistorico { get; set; }
        public decimal? VlPrincipal { get; set; }
        public DateTime? DtPagamentoParcela { get; set; }
        public decimal? VlSelicAtualizado { get; set; }
        public decimal? VlMultaMora { get; set; }
        public decimal? VlAtualizado { get; set; }
        public decimal? VlPagamentoParcela { get; set; }
        public decimal? VlImputacao { get; set; }
        public decimal? VlAmortizacao { get; set; }
        public int? NuParcela { get; set; }
        public int? QtDiasAtraso { get; set; }
        public decimal? VlMaiorAtualizado { get; set; }
        public decimal? VlResidual { get; set; }
        public bool StProcessado { get; set; }
        public decimal SqDocumento { get; set; }
        public int SqParcelamento { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
        public virtual TblParcelamento SqParcelamentoNavigation { get; set; } = null!;
    }
}
