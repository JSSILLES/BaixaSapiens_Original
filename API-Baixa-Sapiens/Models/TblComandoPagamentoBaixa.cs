using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblComandoPagamentoBaixa
    {
        public int IdComandoBaixa { get; set; }
        public string? CdComando { get; set; }
        public string? DsComando { get; set; }
        public DateTime? DtInclusao { get; set; }
    }
}
