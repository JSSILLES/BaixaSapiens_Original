using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    /// <summary>
    /// Entidade respnsável por armazenar dados do ultimo movimento financeiro da tabela tbl_financeira. Dados mantidos através da trigger TAI_ULTIMO_MOVIMENTO_FINANCEITO
    /// </summary>
    public partial class TbUltimoMovimentoFinanceiro
    {
        /// <summary>
        /// Código sequencial da tabela TB_ULTIMO_MOVIMENTO_FINANCEIRO (PK)
        /// </summary>
        public int CdSeqUltimoMovimentoFinanceiro { get; set; }
        /// <summary>
        /// código da chave do documento de origem - - tbl_documento
        /// </summary>
        public string? CoChaveDocumentoOrigem { get; set; }
        /// <summary>
        /// PK da tabela tbl_documento - (ultimo registro da tabela para o auto)
        ///     
        ///    Parte da chave primária da tabela tbl_financeira
        ///    sq_documento ,nr_ordem_documento_envio ,nr_ordem_financeira
        /// </summary>
        public decimal? SqDocumento { get; set; }
        /// <summary>
        /// número do auto de infração - tbl_documento
        /// </summary>
        public string? NrAutoInfracao { get; set; }
        /// <summary>
        /// Número sequencial da ultima fase  do documento  - tbl_documento
        /// </summary>
        public int? SqFaseDocumento { get; set; }
        /// <summary>
        /// Número sequencial do ultimo tipo do documento - tbl_documento
        /// </summary>
        public int? SqTipoDocumento { get; set; }
        /// <summary>
        /// Parte da chave primária da tabela tbl_financeira
        ///    sq_documento ,nr_ordem_documento_envio ,nr_ordem_financeira
        /// </summary>
        public int? NrOrdemFinanceira { get; set; }
        /// <summary>
        /// Parte da chave primária da tabela tbl_financeira
        ///    sq_documento ,nr_ordem_documento_envio ,nr_ordem_financeira
        /// </summary>
        public short? NrOrdemDocumentoEnvio { get; set; }
        public int? IdsituacaoMultas { get; set; }
        public string? DescricaoSituacaoMultas { get; set; }
        /// <summary>
        /// Data da inclusão do registro na tabela
        /// </summary>
        public DateTime DtInclusao { get; set; }
        /// <summary>
        /// Data da alteração do registro na tabela
        /// </summary>
        public DateTime? DtAlteracao { get; set; }
        /// <summary>
        /// Situação do registro na tabela tbl_financeira; 1 - Excluído, 0 - Não excluído (ativo)
        /// </summary>
        public bool StExcluido { get; set; }
    }
}
