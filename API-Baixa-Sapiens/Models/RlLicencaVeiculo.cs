using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class RlLicencaVeiculo
    {
        public int CdSeqLicencaVeiculo { get; set; }
        public int CdLicenca { get; set; }
        public int CdVeiculo { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string? DsObservacao { get; set; }

        public virtual TbLicenca CdLicencaNavigation { get; set; } = null!;
        public virtual TbVeiculo CdVeiculoNavigation { get; set; } = null!;
    }
}
