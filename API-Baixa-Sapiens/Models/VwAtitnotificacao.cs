using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class VwAtitnotificacao
    {
        public DateTime? DaInfracao { get; set; }
        public string? NrAutoInfracaoDv { get; set; }
        public string? CoCarteira { get; set; }
        public string? NoAutuado { get; set; }
        public string? NoEnderecoAutuado { get; set; }
        public string? NoMunicipioAutuado { get; set; }
        public string? NrCepAutuado { get; set; }
        public string? NoBairroAutuado { get; set; }
        public string? SgUfAutuado { get; set; }
        public decimal? VlDocumento { get; set; }
        public string? NrNossoNumero { get; set; }
        public DateTime? DaVencimento { get; set; }
        public string? NrPlacaVeiculo { get; set; }
        public DateTime? DaExpedicao { get; set; }
        public string? CoInfracao { get; set; }
        public string? NoDescricaoInfracao { get; set; }
        public string? NrLinhaDigitavel { get; set; }
        public string? NrCnpjAutuado { get; set; }
        public string? NrCpfAutuado { get; set; }
        public byte? NrSubtipo { get; set; }
        public string? NoLocalidadeInfracao { get; set; }
        public string? NrProcesso { get; set; }
        public string? DsMotivoIndeferimento { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }
        public string? NoMotorista { get; set; }
        public string? NrCnhMotorista { get; set; }
        public DateTime DaGeracao { get; set; }
        public string? HrInfracao { get; set; }
        public string? NoPaisPlacaVeiculo { get; set; }
        public string? NoMunicipioPlacaVeiculo { get; set; }
        public string? NrChassiVeiculo { get; set; }
        public string? NrCrntrc { get; set; }
        public string? NrLicencaOriginariaComplementar { get; set; }
        public short? NrAnoLicencaOriginariaComplementar { get; set; }
        public string? NoMunicipioInfracao { get; set; }
        public string? SgUfInfracao { get; set; }
        public string? NoAutuadoReal { get; set; }
        public string? NoPaisOrigem { get; set; }
        public int SqTipoDocumento { get; set; }
        public decimal? VlIndicePtax { get; set; }
        public decimal? VlDocumentoDolar { get; set; }
        public string? NrCodigoBarra { get; set; }
        public string? Mensagemnotificacaoautuacao { get; set; }
        public string? Mensagemnotificacaomulta { get; set; }
        public string? Mensagemnotificacaofinalmulta { get; set; }
    }
}
