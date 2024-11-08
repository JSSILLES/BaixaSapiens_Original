using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblDocumentoEct
    {
        public int SqDocumentoEct { get; set; }
        public string? CoChaveDocumentoOrigem { get; set; }
        public short? CoTipoDocumento { get; set; }
        public string? NoLote { get; set; }
        public int? StEnvioEct { get; set; }
        public string? NuAr { get; set; }
        public string? DsEnvioEct { get; set; }
        public DateTime? DtEnvioEct { get; set; }
        public DateTime? DtRetornoEct { get; set; }
        public decimal? SqBoleto { get; set; }
        public int? NrOrdemDocumentoEnvio { get; set; }
        public int? SqDocumento { get; set; }
    }
}
