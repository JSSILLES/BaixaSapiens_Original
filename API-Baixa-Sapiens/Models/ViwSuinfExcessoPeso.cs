using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwSuinfExcessoPeso
    {
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public decimal SqDocumento { get; set; }
        public int SqTipoDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public string? NrPlacaVeiculo { get; set; }
        public string? NoRodoviaInfracao { get; set; }
        public decimal? NrKmInfracao { get; set; }
        public DateTime? DaInfracao { get; set; }
        public string? NoMunicipioVeiculo { get; set; }
        public string? SgUfInfracao { get; set; }
        public string? NrAutoInfracao { get; set; }
        public string? NrDocumentoEmbarque { get; set; }
        public DateTime? DaDocumentoEmbarque { get; set; }
        public string? NrCnpjAutuado { get; set; }
        public string? NrCpfAutuado { get; set; }
        public string? NoAutuado { get; set; }
        public string? NoEnderecoAutuado { get; set; }
        public string? NoMunicipioAutuado { get; set; }
        public string? NrCepAutuado { get; set; }
        public string? NoBairroAutuado { get; set; }
        public string? SgUfAutuado { get; set; }
        public string? NrAutoInfracaoDv { get; set; }
        public string? CoCarteira { get; set; }
        public string? NrNossoNumero { get; set; }
        public string? NrLinhaDigitavel { get; set; }
        public decimal? VlDocumento { get; set; }
        public DateTime? DaVencimento { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoDescricaoInfracao { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }
        public byte? NrSubtipo { get; set; }
        public string? NrCodigoBarra { get; set; }
        public DateTime DaGeracao { get; set; }
        public DateTime? DaExpedicao { get; set; }
        public string CoUsuario { get; set; } = null!;
        public string NoMarcaVeiculo { get; set; } = null!;
        public string? NoModeloVeiculo { get; set; }
        public string? NoEspecieVeiculo { get; set; }
        public int SqFaseDocumento { get; set; }
        public int SqOrgaoAutuador { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsAutoridadeOrgaoAutuador { get; set; }
        public DateTime? DaTransmissao { get; set; }
        public string? HrInfracao { get; set; }
        public string? NrChassi { get; set; }
        public string? NrRenavam { get; set; }
        public string? NoCategoriaVeiculo { get; set; }
        public string? NrTaraDeclarada { get; set; }
        public int? NrPesagemPermitida { get; set; }
        public int? NrPesagemRealizada { get; set; }
        public int? NrExcessoVerificado { get; set; }
        public string? NoEspecieCarga { get; set; }
        public string? NoInstrumentoUtilizado { get; set; }
        public decimal? VlBaseMulta { get; set; }
        public DateTime? DaLimite { get; set; }
        public int? MedicaoPermitidaCmt { get; set; }
        public int? MedicaoPermitidaEixo { get; set; }
        public int? ExcessoVerificadoEixo { get; set; }
        public decimal? ValorMultaExcessoEixo { get; set; }
        public int? MedicaoRealizadaEixo { get; set; }
        public string? PenalidadeLinha1 { get; set; }
        public string? PenalidadeLinha2 { get; set; }
    }
}
