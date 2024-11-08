using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwFaseArDocumento
    {
        public decimal SqDocumento { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public int SqTipoDocumento { get; set; }
        public int SqFaseDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public decimal? NrArDocumento { get; set; }
        public string? NrArCompleto { get; set; }
        public string? NoImagemAr { get; set; }
        public string? NoEnderecoImagemAr { get; set; }
    }
}
