using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblConvenioRecolhimentoBb
    {
        public int IdConvenioRecolhimento { get; set; }
        public string? Carteira { get; set; }
        public string NuConvenio { get; set; } = null!;
        public string NoAutuador { get; set; } = null!;
        public string DsModal { get; set; } = null!;
        public string NuRecolhimento { get; set; } = null!;
    }
}
