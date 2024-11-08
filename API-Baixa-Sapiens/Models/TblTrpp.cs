using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblTrpp
    {
        public string? NrProcesso { get; set; }
        public string? NrRenavam { get; set; }
        public string? NrCrntrc { get; set; }
        public string? NoMunicipioInfracao { get; set; }
        public string? NoMotorista { get; set; }
        public string? NrCpfMotorista { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? DsMotivoIndeferimento { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }
        public decimal SqDocumento { get; set; }
        public string? NoMunicipioPlacaVeiculo { get; set; }
        public string? DsTipoTransportador { get; set; }
        public string? NrCnhMotorista { get; set; }
        public string? TipoCargaTrpp { get; set; }
        public string? NrPlacaUnidComb1 { get; set; }
        public string? NrPlacaUnidComb2 { get; set; }
        public string? VeiculoVazio { get; set; }
        public int? IdtipoDocumentoFiscal1 { get; set; }
        public string? DescricaoTipoDocumentoFiscal1 { get; set; }
        public int? NumeroDocumentoFiscal1 { get; set; }
        public DateTime? DataEmissao1 { get; set; }
        public int? NrOnu1 { get; set; }
        public string? CnpjcpfEmitente1 { get; set; }
        public int? IdtipoDocumentoFiscal2 { get; set; }
        public string? DescricaoTipoDocumentoFiscal2 { get; set; }
        public int? NumeroDocumentoFiscal2 { get; set; }
        public DateTime? DataEmissao2 { get; set; }
        public int? NrOnu2 { get; set; }
        public string? CnpjcpfEmitente2 { get; set; }
        public DateTime? NotificacaoAutuacaoEmitida { get; set; }
        public string? PaisPlacaVeiculo { get; set; }
        public int? Artigo { get; set; }
        public string? Inciso { get; set; }
        public string? Alinea { get; set; }
        public string? DescricaoLegislacao { get; set; }
        public string? DescricaoClassificacaoInfrator { get; set; }
        public DateTime? NotificacaoMultaEmitida { get; set; }
        public string? MotivoIndeferimento { get; set; }
        public string? MensagemNotificacao { get; set; }
        public DateTime? NotificacaoFinalMultaEmitida { get; set; }
        public string? NoAutuadoReal { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
