using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbCarrocerium
    {
        public TbCarrocerium()
        {
            TbVeiculos = new HashSet<TbVeiculo>();
        }

        public int CdSeqTipoCarroceria { get; set; }
        public string SgTipoCarroceria { get; set; } = null!;
        public string NoTipoCarroceria { get; set; } = null!;

        public virtual ICollection<TbVeiculo> TbVeiculos { get; set; }
    }
}
