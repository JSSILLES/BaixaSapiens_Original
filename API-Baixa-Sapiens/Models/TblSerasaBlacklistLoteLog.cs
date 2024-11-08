using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaBlacklistLoteLog
    {
        public int IdblackListLoteLog { get; set; }
        public int IdblackListLote { get; set; }
        public DateTime? DaProcessamento { get; set; }
        public int? LinhaExcel { get; set; }
        public string? ErroRegistro { get; set; }
        public string CoUsuario { get; set; } = null!;
        public int? NumeroDocumento { get; set; }
    }
}
