using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaBlacklist
    {
        public int IdblackList { get; set; }
        public int? Idsistema { get; set; }
        public int? IdtipoDocumento { get; set; }
        public int? Idstatus { get; set; }
        public int? NumeroDocumento { get; set; }
        public DateTime? DaCiencia { get; set; }
        public DateTime? DaAtualizacao { get; set; }
        public string? NrCnpjCpfPessoa { get; set; }
        public string? NoJustificativa { get; set; }
        public string CoUsuario { get; set; } = null!;
        public DateTime? DaRevogacao { get; set; }
        public int? IdblackListLote { get; set; }
    }
}
