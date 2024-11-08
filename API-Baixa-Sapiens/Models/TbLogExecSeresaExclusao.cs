using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbLogExecSeresaExclusao
    {
        public int CdSeqLogSerasaExclusao { get; set; }
        public int? SqSerasaDocumento { get; set; }
        public int? IddocumentoSismultas { get; set; }
        public int? IddocumentoSgm { get; set; }
        public int? SqDocumento { get; set; }
        public int? IdtipoDocumento { get; set; }
        public DateTime? DaLimitePagamento { get; set; }
        public DateTime? DtRegistro { get; set; }
        public string? DsMensagem { get; set; }
    }
}
