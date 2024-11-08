using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaBlacklistLote
    {
        public int IdblackListLote { get; set; }
        public string NrLote { get; set; } = null!;
        public DateTime? DaProcessamento { get; set; }
        public DateTime? DaRevogacao { get; set; }
        public DateTime? DaCiencia { get; set; }
        public string CoUsuario { get; set; } = null!;
        public int? Idstatus { get; set; }
        public string? NoJustificativa { get; set; }
    }
}
