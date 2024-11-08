using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbRepresentanteEmpresa
    {
        public TbRepresentanteEmpresa()
        {
            TbLicencaComplementars = new HashSet<TbLicencaComplementar>();
        }

        public int CdSeqRepresentante { get; set; }
        public int CdSeqEmpresa { get; set; }
        public int CodSeqPais { get; set; }
        public string NuRegistroRepresentante { get; set; } = null!;
        public string NoRepresentante { get; set; } = null!;
        public string DsUfRepresentante { get; set; } = null!;
        public string DsEmail { get; set; } = null!;
        public string NuTelefone { get; set; } = null!;
        public bool StAtivo { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtVencimentoMandato { get; set; }

        public virtual TbEmpresa CdSeqEmpresaNavigation { get; set; } = null!;
        public virtual TbPai CodSeqPaisNavigation { get; set; } = null!;
        public virtual ICollection<TbLicencaComplementar> TbLicencaComplementars { get; set; }
    }
}
