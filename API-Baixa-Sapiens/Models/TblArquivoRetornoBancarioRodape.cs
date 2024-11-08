using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblArquivoRetornoBancarioRodape
    {
        public long IdArquivo { get; set; }
        public string NoLinha { get; set; } = null!;
        public string NoArquivo { get; set; } = null!;
        public DateTime? DtInclusao { get; set; }

        public virtual TblArquivoRetornoBancario IdArquivoNavigation { get; set; } = null!;
    }
}
