using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblDetalheVisao
    {
        public TblDetalheVisao()
        {
            SqTipoDocumentos = new HashSet<TblTipoDocumento>();
        }

        public int SqDetalheVisao { get; set; }
        public byte CoDetalheVisao { get; set; }
        public string DsDetalheVisao { get; set; } = null!;
        public int SqVisao { get; set; }

        public virtual TblVisao SqVisaoNavigation { get; set; } = null!;

        public virtual ICollection<TblTipoDocumento> SqTipoDocumentos { get; set; }
    }
}
