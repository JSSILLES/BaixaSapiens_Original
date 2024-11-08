using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbModalidadeTrafego
    {
        public TbModalidadeTrafego()
        {
            TbLicencas = new HashSet<TbLicenca>();
        }

        public int CdSeqModalidadeTrafego { get; set; }
        public string DsModalidadeTrafego { get; set; } = null!;

        public virtual ICollection<TbLicenca> TbLicencas { get; set; }
    }
}
