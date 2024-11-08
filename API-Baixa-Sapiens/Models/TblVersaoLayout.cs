using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblVersaoLayout
    {
        public decimal CoVersaoLayout { get; set; }
        public int SqFaseDocumento { get; set; }
        public int SqTipoDocumento { get; set; }
        public string? DsVersaoLayout { get; set; }
        public byte? CoSistemaOrigem { get; set; }
        public byte? SqOrigemDocumento { get; set; }
        public DateTime? DaInicioVigencia { get; set; }
        public DateTime? DaFinalVigencia { get; set; }

        public virtual TblFaseDocumento SqFaseDocumentoNavigation { get; set; } = null!;
        public virtual TblOrigemDocumento? SqOrigemDocumentoNavigation { get; set; }
        public virtual TblTipoDocumento SqTipoDocumentoNavigation { get; set; } = null!;
    }
}
