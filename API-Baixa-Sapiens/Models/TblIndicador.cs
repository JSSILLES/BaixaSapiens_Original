using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblIndicador
    {
        public decimal SqIndicador { get; set; }
        public int SqTipoIndicador { get; set; }
        public short NrAnoReferencia { get; set; }
        public byte? NrMesReferencia { get; set; }
        public byte? NrDiaReferencia { get; set; }
        public decimal? VlValorIndice { get; set; }

        public virtual TblTipoIndicador SqTipoIndicadorNavigation { get; set; } = null!;
    }
}
