using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbProprietario
    {
        public int CdSeqProprietario { get; set; }
        public string NoRegistroProprietario { get; set; } = null!;
        public string NoProprietario { get; set; } = null!;
        public int CdVeiculo { get; set; }

        public virtual TbVeiculo CdVeiculoNavigation { get; set; } = null!;
    }
}
