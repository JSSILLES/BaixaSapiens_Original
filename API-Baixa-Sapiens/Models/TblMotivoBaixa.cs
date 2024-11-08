using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblMotivoBaixa
    {
        public TblMotivoBaixa()
        {
            TblDocumentoEnvios = new HashSet<TblDocumentoEnvio>();
        }

        public int SqMotivoBaixa { get; set; }
        public byte CoMotivoBaixa { get; set; }
        public string DsMotivoBaixa { get; set; } = null!;

        public virtual ICollection<TblDocumentoEnvio> TblDocumentoEnvios { get; set; }
    }
}
