using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbExecucaoBaixaSerasaArquivo
    {
        public int CdSeqExecucaoBaixaSerasaArquivos { get; set; }
        public int CdSeqExecucaoBaixaSerasa { get; set; }
        public string NomeArquivoSerasa { get; set; } = null!;
        public bool StBaixado { get; set; }

        public virtual TbExecucaoBaixaSerasa CdSeqExecucaoBaixaSerasaNavigation { get; set; } = null!;
    }
}
