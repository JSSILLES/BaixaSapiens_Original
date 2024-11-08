using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaCodigoErro
    {
        public TblSerasaCodigoErro()
        {
            TblSerasaInformacionals = new HashSet<TblSerasaInformacional>();
        }

        public int SqSerasaCodigoErro { get; set; }
        public string CoSerasaErro { get; set; } = null!;
        public string DsSerasaErro { get; set; } = null!;

        public virtual ICollection<TblSerasaInformacional> TblSerasaInformacionals { get; set; }
    }
}
