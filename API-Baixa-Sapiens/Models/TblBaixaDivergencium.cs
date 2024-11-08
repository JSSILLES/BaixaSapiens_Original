using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblBaixaDivergencium
    {
        public int SqBaixaDivergencia { get; set; }
        public DateTime DaBaixaDivergencia { get; set; }
        public string? TxObservacao { get; set; }
        public string? CoUsuario { get; set; }
        public int? NrOrdemFinanceira { get; set; }
        public decimal? SqDocumento { get; set; }
        public short? NrOrdemDocumentoEnvio { get; set; }

        public virtual TblUsuario? CoUsuarioNavigation { get; set; }
        public virtual TblFinanceira? TblFinanceira { get; set; }
    }
}
