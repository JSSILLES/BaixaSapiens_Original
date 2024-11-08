using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class RlMarcaPai
    {
        public int CdSeqMarcaPais { get; set; }
        public int CdPais { get; set; }
        public int CdMarcaVeiculo { get; set; }
        public string CdMarcaPais { get; set; } = null!;

        public virtual TdMarcaVeiculo CdMarcaVeiculoNavigation { get; set; } = null!;
        public virtual TbPai CdPaisNavigation { get; set; } = null!;
    }
}
