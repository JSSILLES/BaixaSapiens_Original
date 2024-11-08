using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TdTipoVeiculo
    {
        public TdTipoVeiculo()
        {
            TbCapacidadeCargas = new HashSet<TbCapacidadeCarga>();
            TbVeiculos = new HashSet<TbVeiculo>();
        }

        public int CdTipoVeiculo { get; set; }
        public string SgTipoVeiculo { get; set; } = null!;
        public string NoTipoVeiculo { get; set; } = null!;

        public virtual ICollection<TbCapacidadeCarga> TbCapacidadeCargas { get; set; }
        public virtual ICollection<TbVeiculo> TbVeiculos { get; set; }
    }
}
