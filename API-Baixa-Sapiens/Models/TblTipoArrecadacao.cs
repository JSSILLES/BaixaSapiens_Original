using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblTipoArrecadacao
    {
        public TblTipoArrecadacao()
        {
            TblFinanceiras = new HashSet<TblFinanceira>();
        }

        public int SqTipoArrecadacao { get; set; }
        public byte CoTipoArrecadacao { get; set; }
        public string DsTipoArrecadacao { get; set; } = null!;

        public virtual ICollection<TblFinanceira> TblFinanceiras { get; set; }
    }
}
