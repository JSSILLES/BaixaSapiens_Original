using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblParcelamentoParcela
    {
        public TblParcelamentoParcela()
        {
            TblRestituicoesParcelamentos = new HashSet<TblRestituicoesParcelamento>();
        }

        public int SqParcelamentoParcela { get; set; }
        public int SqParcelamento { get; set; }
        public short NrParcela { get; set; }
        public DateTime DaVencimentoParcela { get; set; }
        public decimal VlVencimentoParcela { get; set; }
        public DateTime? DaPagamentoParcela { get; set; }
        public decimal? VlPagamentoParcela { get; set; }
        public bool InPagamentoIntegral { get; set; }
        public DateTime DaMensagemParcela { get; set; }
        public int? SqDocumento { get; set; }
        public decimal? VlDiferencaPagamentoParcela { get; set; }
        public bool? InAproveitamentoCredito { get; set; }

        public virtual TblParcelamento SqParcelamentoNavigation { get; set; } = null!;
        public virtual ICollection<TblRestituicoesParcelamento> TblRestituicoesParcelamentos { get; set; }
    }
}
