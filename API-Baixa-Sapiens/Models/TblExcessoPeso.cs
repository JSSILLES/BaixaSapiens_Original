using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblExcessoPeso
    {
        public decimal SqDocumento { get; set; }
        public string NoMarcaVeiculo { get; set; } = null!;
        public string? NoModeloVeiculo { get; set; }
        public string? NoEspecieVeiculo { get; set; }
        public string? NoCategoriaVeiculo { get; set; }
        public string? NrChassi { get; set; }
        public string? NrRenavam { get; set; }
        public string? NrTaraDeclarada { get; set; }
        public string? CoMunicipioVeiculo { get; set; }
        public string? NoMunicipioVeiculo { get; set; }
        public string? NoRodoviaInfracao { get; set; }
        public decimal? NrKmInfracao { get; set; }
        public string? CoMunicipioInfracao { get; set; }
        public int? NrPesagemPermitida { get; set; }
        public int? NrPesagemRealizada { get; set; }
        public string? NrAet { get; set; }
        public string? NoEspecieCarga { get; set; }
        public int? NrExcessoVerificado { get; set; }
        public string? NoInstrumentoUtilizado { get; set; }
        public decimal? VlPorExcesso { get; set; }
        public string? NoPenalidade { get; set; }
        public string? NoCategoriaAutuado { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public DateTime? DaLimite { get; set; }
        public string? NoMensagem4 { get; set; }
        public decimal? VlBaseMulta { get; set; }
        public string? NoMensagem5 { get; set; }
        public decimal? VlMultaComDesconto { get; set; }
        public string? NrDocumentoEmbarque { get; set; }
        public DateTime? DaDocumentoEmbarque { get; set; }
        public int? MedicaoPermitidaCmt { get; set; }
        public int? ExcessoVerificadoCmt { get; set; }
        public int? MedicaoPermitidaEixo { get; set; }
        public int? MedicaoRealizadaEixo { get; set; }
        public int? ExcessoVerificadoEixo { get; set; }
        public decimal? ValorMultaExcessoEixo { get; set; }
        public string? PenalidadeLinha1 { get; set; }
        public string? PenalidadeLinha2 { get; set; }
        public byte CodigoTipoDocumento { get; set; }
        public string? NrSenhaAcessoNoProcesso { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
