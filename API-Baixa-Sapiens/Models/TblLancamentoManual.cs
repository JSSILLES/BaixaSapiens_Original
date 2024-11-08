using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblLancamentoManual
    {
        public int SqLancamento { get; set; }
        public int SqTipoDocumento { get; set; }
        public DateTime DtLancamento { get; set; }
        public decimal VaLancamento { get; set; }
        public string? DsLancamento { get; set; }
        public int? NrSequencialArquivoBanco { get; set; }
        public short? NrSequencialLinhaBanco { get; set; }
        public decimal? DsNossoNumero { get; set; }

        public virtual TblTipoDocumento SqTipoDocumentoNavigation { get; set; } = null!;
    }
}
