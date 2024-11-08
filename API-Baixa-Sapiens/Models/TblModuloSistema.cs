using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblModuloSistema
    {
        public TblModuloSistema()
        {
            TblPerfils = new HashSet<TblPerfil>();
        }

        public short CoModuloSistema { get; set; }
        public string NoModuloSistema { get; set; } = null!;
        public string DsPerfilModulo { get; set; } = null!;

        public virtual ICollection<TblPerfil> TblPerfils { get; set; }
    }
}
