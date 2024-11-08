using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbCapacidadeCarga
    {
        public int CdSeqCapacidadeCarga { get; set; }
        public int CdTipoVeiculo { get; set; }
        public int QtEixo { get; set; }
        public decimal QtCmt { get; set; }
        public decimal QtTara { get; set; }
        public decimal QtPbt { get; set; }
        public bool St2m40EntreEixos { get; set; }

        public virtual TdTipoVeiculo CdTipoVeiculoNavigation { get; set; } = null!;
    }
}
