using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbEmpresa
    {
        public TbEmpresa()
        {
            TbLicencas = new HashSet<TbLicenca>();
            TbRepresentanteEmpresas = new HashSet<TbRepresentanteEmpresa>();
        }

        public int CdSeqEmpresa { get; set; }
        public int CdPais { get; set; }
        public string NuRegistroEmpresa { get; set; } = null!;
        public string NoEmpresa { get; set; } = null!;
        public string SgEmpresa { get; set; } = null!;
        public string DsUfEmpresa { get; set; } = null!;
        public string NuTelefone { get; set; } = null!;
        public string DsEnderecoEmpresa { get; set; } = null!;
        public string NoCidadeEmpresa { get; set; } = null!;
        public string? DsCodigoPostalEmpresa { get; set; }
        public string DsEmail { get; set; } = null!;
        public string DsLogin { get; set; } = null!;
        public string? DsSenha { get; set; }
        public string? DsChaveAcesso { get; set; }
        public bool StAtivo { get; set; }
        public DateTime DtCadastro { get; set; }

        public virtual TbPai CdPaisNavigation { get; set; } = null!;
        public virtual ICollection<TbLicenca> TbLicencas { get; set; }
        public virtual ICollection<TbRepresentanteEmpresa> TbRepresentanteEmpresas { get; set; }
    }
}
