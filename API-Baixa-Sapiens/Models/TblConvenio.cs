using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblConvenio
    {
        public int SqConvenio { get; set; }
        public string? DsConvenio { get; set; }
        public string? CoCarteira { get; set; }
        public string? CoConvenio { get; set; }
        public string? CoContrato { get; set; }
        public string? CoRecolhimento { get; set; }
    }
}
