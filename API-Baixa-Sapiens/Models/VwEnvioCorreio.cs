using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class VwEnvioCorreio
    {
        public int NrLote { get; set; }
        public decimal? NrArDocumento { get; set; }
        public DateTime DaGeracao { get; set; }
        public DateTime? DaTransmissao { get; set; }
        public DateTime? DaRetornoCorreio { get; set; }
        public string? StDocumento { get; set; }
        public int? AaEnvio { get; set; }
        public int? MmEnvio { get; set; }
    }
}
