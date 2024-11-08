using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblOrigemDocumento
    {
        public TblOrigemDocumento()
        {
            TblVersaoLayouts = new HashSet<TblVersaoLayout>();
        }

        public byte SqOrigemDocumento { get; set; }
        public string NoOrigemDocumento { get; set; } = null!;

        public virtual ICollection<TblVersaoLayout> TblVersaoLayouts { get; set; }
    }
}
