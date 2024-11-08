using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwArEnviado
    {
        public string DsTipoDocumento { get; set; } = null!;
        public string? NumeroAr { get; set; }
        public DateTime? DaRetornoCorreio { get; set; }
    }
}
