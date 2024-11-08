using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblLogSistema
    {
        public decimal SqLogSistema { get; set; }
        public DateTime DaLogSistema { get; set; }
        public string? DsLogSistema { get; set; }
        public string CoUsuario { get; set; } = null!;
        public decimal SqDocumento { get; set; }
        public short NrOrdemDocumentoEnvio { get; set; }
        public short CoLog { get; set; }

        public virtual TblCodigoLog CoLogNavigation { get; set; } = null!;
        public virtual TblUsuario CoUsuarioNavigation { get; set; } = null!;
        public virtual TblDocumentoEnvio TblDocumentoEnvio { get; set; } = null!;
    }
}
