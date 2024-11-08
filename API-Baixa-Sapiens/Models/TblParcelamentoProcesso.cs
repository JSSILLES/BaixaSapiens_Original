using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblParcelamentoProcesso
    {
        public int SqParcelamentoProcessso { get; set; }
        public int Iddocumento { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public int SqDocumento { get; set; }
        public int SqParcelamento { get; set; }
        public decimal VlAtualizado { get; set; }
        public int Idsituacao { get; set; }
        public bool IndicadorPagamentoIntegral { get; set; }
        public DateTime? DaLoteBanco { get; set; }
        public int? NrSequencialArquivoBanco { get; set; }
        public short? NrSequencialLinhaBanco { get; set; }
        public string? FlImputar { get; set; }

        public virtual TblParcelamento SqParcelamentoNavigation { get; set; } = null!;
    }
}
