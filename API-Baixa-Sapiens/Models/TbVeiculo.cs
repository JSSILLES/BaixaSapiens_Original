using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbVeiculo
    {
        public TbVeiculo()
        {
            RlLicencaVeiculos = new HashSet<RlLicencaVeiculo>();
            TbProprietarios = new HashSet<TbProprietario>();
        }

        public int CdSeqVeiculo { get; set; }
        public string NoPlaca { get; set; } = null!;
        public string NuChassi { get; set; } = null!;
        public int CdTipoVeiculo { get; set; }
        public int CdTipoCarroceria { get; set; }
        public int? CdProprietario { get; set; }
        public int NuAnoFabricacao { get; set; }
        public string NoMarca { get; set; } = null!;
        public int QtEixo { get; set; }
        public decimal QtPbt { get; set; }
        public string? DsTipoEixo { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool StCabineDormitorio { get; set; }
        public bool StVeiculoProprio { get; set; }
        public string? DsObservacao { get; set; }

        public virtual TbCarrocerium CdTipoCarroceriaNavigation { get; set; } = null!;
        public virtual TdTipoVeiculo CdTipoVeiculoNavigation { get; set; } = null!;
        public virtual ICollection<RlLicencaVeiculo> RlLicencaVeiculos { get; set; }
        public virtual ICollection<TbProprietario> TbProprietarios { get; set; }
    }
}
