using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblParcelamentoProcessamento
    {
        public int SqParcelamentoProcessamento { get; set; }
        public int SqParcelamentoParcela { get; set; }
        public DateTime DaProcessamento { get; set; }
        public DateTime DaLoteBanco { get; set; }
        public int NrSequencialArquivoBanco { get; set; }
        public short NrSequencialLinhaBanco { get; set; }
        public string StProcessamento { get; set; } = null!;
        public string DsProcessamento { get; set; } = null!;
    }
}
