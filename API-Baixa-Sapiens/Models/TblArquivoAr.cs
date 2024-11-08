using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblArquivoAr
    {
        public int SqArquivoAr { get; set; }
        public string NoArquivoAr { get; set; } = null!;
        public bool FlgLeituraFinalizada { get; set; }
    }
}
