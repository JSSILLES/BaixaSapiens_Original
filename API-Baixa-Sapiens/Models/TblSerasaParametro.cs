using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaParametro
    {
        public string NrCnpjAntt { get; set; } = null!;
        public string NrDddTelefoneAntt { get; set; } = null!;
        public string NrTelefoneAntt { get; set; } = null!;
        public string NrRamalContatoAntt { get; set; } = null!;
        public string NoContatoAntt { get; set; } = null!;
        public string NrIdentificacaoArquivo { get; set; } = null!;
        public string NrFilialDigitoCnpjAntt { get; set; } = null!;
        public string CoNaturezaOperacao { get; set; } = null!;
    }
}
