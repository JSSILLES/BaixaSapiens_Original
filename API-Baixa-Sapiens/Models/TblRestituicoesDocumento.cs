using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    /// <summary>
    /// Entidade responsavel pelas restituições dos documentos. 
    /// </summary>
    public partial class TblRestituicoesDocumento
    {
        /// <summary>
        /// Código sequencial da tabela tbl_restituicoes_parcelamento
        /// </summary>
        public int SqRestituicoesDocumento { get; set; }
        public decimal SqDocumento { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        /// <summary>
        /// Valor a resituir para o cliente referente aos documentos.
        /// </summary>
        public decimal VlRestituir { get; set; }
        /// <summary>
        /// Valor da Selic referente aos documentos.
        /// </summary>
        public decimal VlSelic { get; set; }
        /// <summary>
        /// Data do pagamento referente as resituiçoes do documentos.
        /// </summary>
        public DateTime DtPagamento { get; set; }
        /// <summary>
        /// Número do Processo
        /// </summary>
        public string NrProcesso { get; set; } = null!;
        /// <summary>
        /// Número da ordem bancária do documentos referente a restituição
        /// </summary>
        public string NrOrdemBancaria { get; set; } = null!;
        /// <summary>
        /// Observações que serão feitas referente as resituiçoes dos documentos.
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

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
