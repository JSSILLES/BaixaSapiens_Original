using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbPostagemStatus
    {
        public int CdSeqPostagemStatus { get; set; }
        public string? CdObjeto { get; set; }
        public DateTime? DtEntrega { get; set; }
        public DateTime? DtPostagem { get; set; }
        public string? DsEtiquetaPostagem { get; set; }
        public string? DsEtiquetaObjeto { get; set; }
        public byte[]? ImAvisoRecebimento { get; set; }
        public int? StPostagem { get; set; }
        public int? TpIncosistencia { get; set; }
    }
}
