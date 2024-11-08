using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblArquivoRetornoBancario
    {
        public long IdArquivo { get; set; }
        public string? NoArquivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? DtProcessamento { get; set; }
        public byte? StProcessar { get; set; }
        public byte? StErroProcessamento { get; set; }
        public short? StReprocessar { get; set; }
        public string? DsLogBaixaArquivo { get; set; }
        public string? NuConvenio { get; set; }
        public string? NuSequencialArquivo { get; set; }
    }
}
