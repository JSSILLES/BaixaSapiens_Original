using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblPerfil
    {
        public decimal SqPerfil { get; set; }
        public short CoModuloSistema { get; set; }
        public string CoUsuario { get; set; } = null!;
        public string DsPerfil { get; set; } = null!;

        public virtual TblModuloSistema CoModuloSistemaNavigation { get; set; } = null!;
        public virtual TblUsuario CoUsuarioNavigation { get; set; } = null!;
    }
}
