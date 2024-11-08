using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblCodigoLog
    {
        public TblCodigoLog()
        {
            TblLogSistemas = new HashSet<TblLogSistema>();
        }

        public short CoLog { get; set; }
        public string DsLog { get; set; } = null!;

        public virtual ICollection<TblLogSistema> TblLogSistemas { get; set; }
    }
}
