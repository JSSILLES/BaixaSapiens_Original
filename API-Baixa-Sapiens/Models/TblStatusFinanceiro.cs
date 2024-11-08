using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblStatusFinanceiro
    {
        public TblStatusFinanceiro()
        {
            TblFinanceiras = new HashSet<TblFinanceira>();
        }

        public int SqStatusFinanceiro { get; set; }
        public string DsStatusFinanceiro { get; set; } = null!;

        public virtual ICollection<TblFinanceira> TblFinanceiras { get; set; }
    }
}
