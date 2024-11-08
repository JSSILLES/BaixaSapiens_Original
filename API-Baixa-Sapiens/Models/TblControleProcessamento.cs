using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblControleProcessamento
    {
        public int SqControleProcessamento { get; set; }
        public int CoTipoArquivo { get; set; }
        public int NrLote { get; set; }
        public int NrAnoLote { get; set; }
        public int? NrDocumentosLote { get; set; }
        public bool? CoIndicadorReprocessamento { get; set; }
    }
}
