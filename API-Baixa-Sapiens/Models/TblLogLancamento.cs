using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblLogLancamento
    {
        public int SqLogLancamento { get; set; }
        public string CoUsuarioLancamento { get; set; } = null!;
        public DateTime DtRealizacaoLancamento { get; set; }
        public DateTime DtLancamento { get; set; }
        public decimal VlLancamento { get; set; }
        public string DsLancamento { get; set; } = null!;
        public decimal? DsNossoNumero { get; set; }
        public string InLancamento { get; set; } = null!;
        public int SqTipoDocumento { get; set; }
        public int SqLancamento { get; set; }
    }
}
