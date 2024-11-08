using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblGrupoDocumento
    {
        public TblGrupoDocumento()
        {
            TblParcelamentos = new HashSet<TblParcelamento>();
            TblTipoDocumentos = new HashSet<TblTipoDocumento>();
        }

        public int SqGrupoDocumento { get; set; }
        public string DsGrupoDocumento { get; set; } = null!;
        public DateTime DtInclusao { get; set; }
        public string? SgGrupoDocumento { get; set; }
        public int? IdtipoDocumento { get; set; }

        public virtual ICollection<TblParcelamento> TblParcelamentos { get; set; }
        public virtual ICollection<TblTipoDocumento> TblTipoDocumentos { get; set; }
    }
}
