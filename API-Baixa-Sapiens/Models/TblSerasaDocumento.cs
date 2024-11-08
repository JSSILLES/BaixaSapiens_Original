using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaDocumento
    {
        public int SqSerasaDocumento { get; set; }
        public int? IddocumentoSismultas { get; set; }
        public int? IddocumentoSgm { get; set; }
        public string CoOperacao { get; set; } = null!;
        public int? NrSequenciaRegistroLote { get; set; }
        public byte InSituacao { get; set; }
        public DateTime DaLimitePagamento { get; set; }
        public string InTipoPessoa { get; set; } = null!;
        public string NrCnpjCpfPessoa { get; set; } = null!;
        public string NrContrato { get; set; } = null!;
        public string NoEnderecoPessoa { get; set; } = null!;
        public string? NoBairroPessoa { get; set; }
        public string? NoMunicipioPessoa { get; set; }
        public string SgUf { get; set; } = null!;
        public string NrCepPessoa { get; set; } = null!;
        public decimal VlInscrito { get; set; }
        public int? SqSerasaLote { get; set; }
        public DateTime? DaRetorno { get; set; }
        public string? CoSerasaErro { get; set; }
        public int? SqSerasaMotivoBaixa { get; set; }
        public int? SqDocumento { get; set; }
        public int? IdtipoDocumento { get; set; }
        public byte InDividaAtiva { get; set; }

        public virtual TblSerasaSituacaoDocumento InSituacaoNavigation { get; set; } = null!;
        public virtual TblSerasaLote? SqSerasaLoteNavigation { get; set; }
        public virtual TblSerasaMotivoBaixa? SqSerasaMotivoBaixaNavigation { get; set; }
    }
}
