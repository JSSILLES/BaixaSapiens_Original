using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblValePedagio
    {
        public decimal SqDocumento { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }
        public string? NoRodoviaInfracao { get; set; }
        public string? NrKmInfracao { get; set; }
        public string? NoDescricao1 { get; set; }
        public string? NoDescricao2 { get; set; }
        public string? DsDetalheAmparoLegal { get; set; }
        public string? NoMunicipioInfracao { get; set; }
        public string? NrDocumentoEmbarque { get; set; }
        public DateTime? DaDocumentoEmbarque { get; set; }
        public string? NoMunicipioOrigemCarga { get; set; }
        public string? SgUfMunicipioOrigemCarga { get; set; }
        public string? DsTipoDocumentoEmbarque { get; set; }
        public string? NoMunicipioDestinoCarga { get; set; }
        public string? SgUfMunicipioDestinoCarga { get; set; }
        public string? NoResumoDescisao { get; set; }
        public string? NoAutuadoReal { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
