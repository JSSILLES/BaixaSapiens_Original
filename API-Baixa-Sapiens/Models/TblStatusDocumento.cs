using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblStatusDocumento
    {
        public int SqStDocumento { get; set; }
        public string StDocumento { get; set; } = null!;
        public string DsStDocumento { get; set; } = null!;
        public DateTime? DtInclusao { get; set; }
    }
}
