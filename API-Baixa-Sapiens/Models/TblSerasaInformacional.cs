using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaInformacional
    {
        public int SqSerasaInformacional { get; set; }
        public DateTime DaRemessa { get; set; }
        public string CoOperacao { get; set; } = null!;
        public string? NrCnpjCpfPessoa { get; set; }
        public string? NrContrato { get; set; }
        public DateTime? DaInclusao { get; set; }
        public DateTime? DaExclusao { get; set; }
        public int? SqSerasaCodigoErro { get; set; }
        public int? SqSerasaMotivoBaixa { get; set; }

        public virtual TblSerasaCodigoErro? SqSerasaCodigoErroNavigation { get; set; }
        public virtual TblSerasaMotivoBaixa? SqSerasaMotivoBaixaNavigation { get; set; }
    }
}
