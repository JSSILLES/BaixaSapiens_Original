using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaHistoricoAlteracaoLote
    {
        public int SqSerasaHistoricoAlteracaoLote { get; set; }
        public int? SqSerasaLoteOrigem { get; set; }
        public int? SqSerasaLoteDestino { get; set; }
        public DateTime Data { get; set; }
        public string Usuario { get; set; } = null!;
        public string? Motivo { get; set; }
    }
}
