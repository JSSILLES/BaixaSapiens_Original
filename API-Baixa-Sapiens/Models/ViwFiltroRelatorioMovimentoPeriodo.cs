using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwFiltroRelatorioMovimentoPeriodo
    {
        public decimal SqDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public int NrOrdemFinanceira { get; set; }
    }
}
