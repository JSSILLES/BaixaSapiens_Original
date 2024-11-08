using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaDocumentoLog
    {
        public int SqSerasaDocumentoLog { get; set; }
        public int? SqSerasaDocumento { get; set; }
        public int? IddocumentoSismultas { get; set; }
        public int? IddocumentoSgm { get; set; }
        public string? CoOperacao { get; set; }
        public int? NrSequenciaRegistroLote { get; set; }
        public byte? InSituacao { get; set; }
        public DateTime? DaLimitePagamento { get; set; }
        public string? InTipoPessoa { get; set; }
        public string? NrCnpjCpfPessoa { get; set; }
        public string? NrContrato { get; set; }
        public string? NoEnderecoPessoa { get; set; }
        public string? NoBairroPessoa { get; set; }
        public string? NoMunicipioPessoa { get; set; }
        public string? SgUf { get; set; }
        public string? NrCepPessoa { get; set; }
        public decimal? VlInscrito { get; set; }
        public int? SqSerasaLote { get; set; }
        public DateTime? DaRetorno { get; set; }
        public string? CoSerasaErro { get; set; }
        public int? SqSerasaMotivoBaixa { get; set; }
        public int? SqDocumento { get; set; }
        public int? IdtipoDocumento { get; set; }
        public byte? InDividaAtiva { get; set; }
        public string? CoUsuario { get; set; }
        public DateTime? DtAtualizacao { get; set; }
    }
}
