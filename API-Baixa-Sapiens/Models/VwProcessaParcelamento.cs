using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class VwProcessaParcelamento
    {
        public string NoSuperintendencia { get; set; } = null!;
        public string? NrCnpjAutuado { get; set; }
        public string? NrCpfAutuado { get; set; }
        public string? NrAutoInfracao { get; set; }
        public string DsTipoDocumento { get; set; } = null!;
        public int? IdTpQuitacao { get; set; }
        public string? DsTpQuitacao { get; set; }
        public int SqParcelamento { get; set; }
        public byte NrParcelas { get; set; }
        public string? NumeroProcesso { get; set; }
        public DateTime DaParcelamento { get; set; }
        public decimal? VlDocumento { get; set; }
        public string? CnpjCpfAutuado { get; set; }
        public DateTime? DaVencimento { get; set; }
        public decimal? VlAtualizado { get; set; }
        public decimal SqDocumento { get; set; }
        public string? DsStDocumento { get; set; }
        public DateTime? DaVencimentoParcelamento { get; set; }
        public string? Expr1 { get; set; }
        public string? DescricaoSituacao { get; set; }
        public string FlImputar { get; set; } = null!;
        public decimal VlRemanescente { get; set; }
    }
}
