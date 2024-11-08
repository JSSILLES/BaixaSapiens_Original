using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblDocumentoEnvio
    {
        public TblDocumentoEnvio()
        {
            TblLogSistemas = new HashSet<TblLogSistema>();
        }

        public decimal SqDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public string? NoAutuado { get; set; }
        public string? NoEnderecoAutuado { get; set; }
        public string? NoBairroAutuado { get; set; }
        public string? NoMunicipioAutuado { get; set; }
        public string? SgUfAutuado { get; set; }
        public string? NrCepAutuado { get; set; }
        public decimal? SqLote { get; set; }
        public int? SqMotivoBaixa { get; set; }
        public int NrSequencialDocumento { get; set; }
        public DateTime? DaBaixa { get; set; }
        public short? AaSequencialDocumento { get; set; }
        public int? SqMotivoDevolucao { get; set; }
        public string? StDocumento { get; set; }
        public DateTime? DaExpedicao { get; set; }
        public decimal? NrArDocumento { get; set; }
        public int? SqLoteOrigem { get; set; }
        public DateTime DaGeracao { get; set; }
        public DateTime? DaTransmissao { get; set; }
        public DateTime? DaImpressao { get; set; }
        public DateTime? DaCancelamento { get; set; }
        public DateTime? DaRetornoCorreio { get; set; }
        public string? NoImagemAr { get; set; }
        public string? NoEnderecoImagemAr { get; set; }
        public string? NoAutuadoReal { get; set; }
        public DateTime? DaPenalidade { get; set; }
        public string? EmailAutuado { get; set; }
        public bool? RPost { get; set; }
        public DateTime? DaProcessamento { get; set; }
        /// <summary>
        /// Campo criado para manter o status do registro. 3 = Registrado, 4 = Com Erro.
        /// </summary>
        public short? StRegistro { get; set; }
        /// <summary>
        /// Este campo somente será preenchido quando o campo ST_REGISTRO possuir o valor 4 (Com erro).
        /// </summary>
        public string? DsDetalheErro { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
        public virtual TblLote? SqLoteNavigation { get; set; }
        public virtual TblMotivoBaixa? SqMotivoBaixaNavigation { get; set; }
        public virtual TblMotivoDevolucao? SqMotivoDevolucaoNavigation { get; set; }
        public virtual ICollection<TblLogSistema> TblLogSistemas { get; set; }
    }
}
