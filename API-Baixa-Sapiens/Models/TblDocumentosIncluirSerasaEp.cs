using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblDocumentosIncluirSerasaEp
    {
        public DateTime? DtVencimento { get; set; }
        public string SgTipoInfrator { get; set; } = null!;
        public string NrTipoInfrator { get; set; } = null!;
        public string? NrCnpjCpfInfrator { get; set; }
        public string NoInfrator { get; set; } = null!;
        public string DsEndInfrator { get; set; } = null!;
        public string? NoBairroInfrator { get; set; }
        public string CdLocAutoInfracao { get; set; } = null!;
        public string DsLoc { get; set; } = null!;
        public string SgUfInfrator { get; set; } = null!;
        public string NrCepInfrator { get; set; } = null!;
        public decimal? VlMulta { get; set; }
        public string NrAutoInfracao { get; set; } = null!;
        public DateTime DtInfracao { get; set; }
        public string? CdLocInfratorCadastro { get; set; }
    }
}
