using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblLogFinanceira
    {
        public int SqLogFinanceira { get; set; }
        public string? CoUsuario { get; set; }
        public DateTime? DaRealizacaoBaixa { get; set; }
        public DateTime? DaPagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlMoraMulta { get; set; }
        public string? DsObservacao { get; set; }
        public int NrOrdemFinanceira { get; set; }
        public decimal? SqDocumento { get; set; }
        public short? NrOrdemDocumentoEnvio { get; set; }

        public virtual TblUsuario? CoUsuarioNavigation { get; set; }
        public virtual TblFinanceira? TblFinanceira { get; set; }
    }
}
