using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    /// <summary>
    /// Entidade de log que armazena informações das restituições dos parcelamentos. 
    /// </summary>
    public partial class TblLogRestituicoesParcelamento
    {
        /// <summary>
        /// Código sequencial da tabela tbl_log_restituicoes_parcelamento
        /// </summary>
        public int SqLogRestituicoesParcelamento { get; set; }
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
        /// <summary>
        /// Data que foi realizada a operação do log.
        /// </summary>
        public DateTime DtOperacaoLog { get; set; }
        /// <summary>
        /// Tipo da operação que foi realizada (1 - insert, 2 - update).
        /// </summary>
        public byte TpOperacaoLog { get; set; }
    }
}
