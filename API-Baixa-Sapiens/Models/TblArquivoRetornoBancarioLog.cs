using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblArquivoRetornoBancarioLog
    {
        public int CdSeqLog { get; set; }
        public DateTime? DaLog { get; set; }
        public string? DsLog { get; set; }
    }
}
