using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    /// <summary>
    /// Entidade responsavel pelas restituições dos parcelamentos. 
    /// </summary>
    public partial class TblRestituicoesParcelamento
    {
        /// <summary>
        /// Código sequencial da tabela tbl_restituicoes_parcelamento
        /// </summary>
        public int SqRestituicoesParcelamento { get; set; }
        /// <summary>
        /// Código sequencial da tabela tbl_parcelamento
        /// </summary>
        public int SqParcelamento { get; set; }
        /// <summary>
        /// Código sequencial da tabela tbl_parcelamento_parcela
        /// </summary>
        public int SqParcelamentoParcela { get; set; }
        /// <summary>
        /// Valor a resituir para o cliente referente aos parcelamentos.
        /// </summary>
        public decimal VlRestituir { get; set; }
        /// <summary>
        /// Valor da Selic referente aos parcelamentos.
        /// </summary>
        public decimal VlSelic { get; set; }
        /// <summary>
        /// Data do pagamento referente as resituiçoes do parcelamento
        /// </summary>
        public DateTime DtPagamento { get; set; }
        /// <summary>
        /// Número do Processo
        /// </summary>
        public string NrProcesso { get; set; } = null!;
        /// <summary>
        /// Número da ordem bancária para o pagamento da restituição
        /// </summary>
        public string NrOrdemBancaria { get; set; } = null!;
        /// <summary>
        /// Observações que serão feitas referente as resituiçoes dos parcelamentos
        /// </summary>
        public string DsObservacao { get; set; } = null!;
        /// <summary>
        /// Data de alteração
        /// </summary>
        public DateTime DtAlteracao { get; set; }
        /// <summary>
        /// Usuário que realizou a operação
        /// </summary>
        public string UsrOperacao { get; set; } = null!;

        public virtual TblParcelamento SqParcelamentoNavigation { get; set; } = null!;
        public virtual TblParcelamentoParcela SqParcelamentoParcelaNavigation { get; set; } = null!;
    }
}
