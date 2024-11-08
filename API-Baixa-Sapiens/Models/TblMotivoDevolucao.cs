using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblMotivoDevolucao
    {
        public TblMotivoDevolucao()
        {
            TblDocumentoEnvios = new HashSet<TblDocumentoEnvio>();
        }

        public int SqMotivoDevolucao { get; set; }
        public byte CoMotivoDevolucao { get; set; }
        public string DsMotivoDevolucao { get; set; } = null!;

        public virtual ICollection<TblDocumentoEnvio> TblDocumentoEnvios { get; set; }
    }
}
