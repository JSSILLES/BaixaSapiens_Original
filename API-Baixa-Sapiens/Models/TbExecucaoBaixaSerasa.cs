using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbExecucaoBaixaSerasa
    {
        public TbExecucaoBaixaSerasa()
        {
            TbExecucaoBaixaSerasaArquivos = new HashSet<TbExecucaoBaixaSerasaArquivo>();
        }

        public int CdSeqExecucaoBaixaSerasa { get; set; }
        public DateTime DtHrExecucaoBaixa { get; set; }
        public string EnderecoRepositorioSerasa { get; set; } = null!;
        public string EnderecoRepositorioArrecadacao { get; set; } = null!;

        public virtual ICollection<TbExecucaoBaixaSerasaArquivo> TbExecucaoBaixaSerasaArquivos { get; set; }
    }
}
