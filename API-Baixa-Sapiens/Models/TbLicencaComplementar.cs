using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbLicencaComplementar
    {
        public int CdSeqLicencaComplementar { get; set; }
        public string NuLicencaComplementar { get; set; } = null!;
        public int CdLicencaOriginaria { get; set; }
        public int CdPaisOrigem { get; set; }
        public int CdPaisDestino { get; set; }
        public int CdPaisTransitado { get; set; }
        public int CdRepresentante { get; set; }
        public int CdTipoLicencaComp { get; set; }
        public string NoAutoridadeEmiteLicenca { get; set; } = null!;
        public DateTime DtEmissaoLicenca { get; set; }
        public DateTime DtVencimentoLicenca { get; set; }
        public string? DsObservacao { get; set; }
        public bool StLicencaCancelada { get; set; }
        public DateTime? DtCancelamento { get; set; }

        public virtual TbLicenca CdLicencaOriginariaNavigation { get; set; } = null!;
        public virtual TbPai CdPaisDestinoNavigation { get; set; } = null!;
        public virtual TbPai CdPaisOrigemNavigation { get; set; } = null!;
        public virtual TbPai CdPaisTransitadoNavigation { get; set; } = null!;
        public virtual TbRepresentanteEmpresa CdRepresentanteNavigation { get; set; } = null!;
        public virtual TbTipoLicencaComplementar CdTipoLicencaCompNavigation { get; set; } = null!;
    }
}
