using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbPai
    {
        public TbPai()
        {
            RlMarcaPais = new HashSet<RlMarcaPai>();
            TbEmpresas = new HashSet<TbEmpresa>();
            TbLicencaCdPaisDestinoNavigations = new HashSet<TbLicenca>();
            TbLicencaCdPaisOrigemNavigations = new HashSet<TbLicenca>();
            TbLicencaCdPaisTransitadoNavigations = new HashSet<TbLicenca>();
            TbLicencaComplementarCdPaisDestinoNavigations = new HashSet<TbLicencaComplementar>();
            TbLicencaComplementarCdPaisOrigemNavigations = new HashSet<TbLicencaComplementar>();
            TbLicencaComplementarCdPaisTransitadoNavigations = new HashSet<TbLicencaComplementar>();
            TbRepresentanteEmpresas = new HashSet<TbRepresentanteEmpresa>();
        }

        public int CodSeqPais { get; set; }
        public string SgPais { get; set; } = null!;
        public string NoPais { get; set; } = null!;

        public virtual ICollection<RlMarcaPai> RlMarcaPais { get; set; }
        public virtual ICollection<TbEmpresa> TbEmpresas { get; set; }
        public virtual ICollection<TbLicenca> TbLicencaCdPaisDestinoNavigations { get; set; }
        public virtual ICollection<TbLicenca> TbLicencaCdPaisOrigemNavigations { get; set; }
        public virtual ICollection<TbLicenca> TbLicencaCdPaisTransitadoNavigations { get; set; }
        public virtual ICollection<TbLicencaComplementar> TbLicencaComplementarCdPaisDestinoNavigations { get; set; }
        public virtual ICollection<TbLicencaComplementar> TbLicencaComplementarCdPaisOrigemNavigations { get; set; }
        public virtual ICollection<TbLicencaComplementar> TbLicencaComplementarCdPaisTransitadoNavigations { get; set; }
        public virtual ICollection<TbRepresentanteEmpresa> TbRepresentanteEmpresas { get; set; }
    }
}
