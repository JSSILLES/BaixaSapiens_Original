using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblErroPostagem
    {
        public long IdErroPostagem { get; set; }
        public DateTime DtErro { get; set; }
        public string NmArquivo { get; set; } = null!;
        public int NrLotePostagem { get; set; }
    }
}
