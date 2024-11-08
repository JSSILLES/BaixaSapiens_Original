using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblSerasaLote
    {
        public TblSerasaLote()
        {
            TblSerasaDocumentos = new HashSet<TblSerasaDocumento>();
        }

        public int SqSerasaLote { get; set; }
        public int NrRemessa { get; set; }
        public DateTime DaLote { get; set; }
        public int NrQuantidadeRegistros { get; set; }
        public string? CoErroSerasa { get; set; }
        public string CoUsuario { get; set; } = null!;

        public virtual ICollection<TblSerasaDocumento> TblSerasaDocumentos { get; set; }
    }
}
