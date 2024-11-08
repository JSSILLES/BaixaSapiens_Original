using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblArquivoRetornoTemp
    {
        public int Id { get; set; }
        public string NoLinha { get; set; } = null!;
        public string NoArquivo { get; set; } = null!;
        public int? TpLinha { get; set; }
    }
}
