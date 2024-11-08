using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbLicenca
    {
        public TbLicenca()
        {
            RlLicencaVeiculos = new HashSet<RlLicencaVeiculo>();
            TbLicencaComplementars = new HashSet<TbLicencaComplementar>();
        }

        public int CdSeqLicenca { get; set; }
        public string NuLicencaOriginaria { get; set; } = null!;
        public int CdPaisOrigem { get; set; }
        public int CdPaisDestino { get; set; }
        public int? CdPaisTransitado { get; set; }
        public int CdEmpresa { get; set; }
        public int CdModalidadeTrafego { get; set; }
        public string NoAutoridadeEmiteLicenca { get; set; } = null!;
        public DateTime DtEmissaoLicenca { get; set; }
        public DateTime DtVencimentoLicenca { get; set; }
        public string? DsTipoCarga { get; set; }
        public string? DsObservacao { get; set; }
        public bool StLicencaCancelada { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public DateTime DtCadastro { get; set; }

        public virtual TbEmpresa CdEmpresaNavigation { get; set; } = null!;
        public virtual TbModalidadeTrafego CdModalidadeTrafegoNavigation { get; set; } = null!;
        public virtual TbPai CdPaisDestinoNavigation { get; set; } = null!;
        public virtual TbPai CdPaisOrigemNavigation { get; set; } = null!;
        public virtual TbPai? CdPaisTransitadoNavigation { get; set; }
        public virtual ICollection<RlLicencaVeiculo> RlLicencaVeiculos { get; set; }
        public virtual ICollection<TbLicencaComplementar> TbLicencaComplementars { get; set; }
    }
}
