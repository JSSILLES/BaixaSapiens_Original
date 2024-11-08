using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwSuinfValePedagio
    {
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public decimal SqDocumento { get; set; }
        public int SqTipoDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public string? NrPlacaVeiculo { get; set; }
        public string? NoRodoviaInfracao { get; set; }
        public string? NrKmInfracao { get; set; }
        public DateTime? DaInfracao { get; set; }
        public string? NoDescricao1 { get; set; }
        public string? NoDescricao2 { get; set; }
        public string? NoMunicipioInfracao { get; set; }
        public string? SgUfInfracao { get; set; }
        public string? NrDocumentoEmbarque { get; set; }
        public string? DsTipoDocumentoEmbarque { get; set; }
        public DateTime? DaDocumentoEmbarque { get; set; }
        public string? NoMunicipioOrigemCarga { get; set; }
        public string? SgUfMunicipioOrigemCarga { get; set; }
        public string? NoMunicipioDestinoCarga { get; set; }
        public string? SgUfMunicipioDestinoCarga { get; set; }
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
        public string? DsDetalheAmparoLegal { get; set; }
        public string? DsDetalheAmparoLegal2 { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }
        public byte? NrSubtipo { get; set; }
        public string? NrCodigoBarra { get; set; }
        public string? NoResumoDescisao { get; set; }
        public DateTime DaGeracao { get; set; }
        public DateTime? DaExpedicao { get; set; }
        public string CoUsuario { get; set; } = null!;
        public int SqFaseDocumento { get; set; }
        public int SqOrgaoAutuador { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsAutoridadeOrgaoAutuador { get; set; }
        public DateTime? DaTransmissao { get; set; }
        public string? HrInfracao { get; set; }
        public string? NumeroProcesso { get; set; }
        public string? NoAutuadoReal { get; set; }
    }
}
