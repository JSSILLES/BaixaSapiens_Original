using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblOrgaoAutuador
    {
        public TblOrgaoAutuador()
        {
            TblDocumentos = new HashSet<TblDocumento>();
        }

        public int SqOrgaoAutuador { get; set; }
        public byte CoOrgaoAutuador { get; set; }
        public string NoOrgaoAutuador { get; set; } = null!;
        public string? NoEnderecoOrgaoAutuador { get; set; }
        public string? NoBairroOrgaoAutuador { get; set; }
        public string? NoMunicipioOrgaoAutuador { get; set; }
        public string? SgUfOrgaoAutuador { get; set; }
        public string? NrCepOrgaoAutuador { get; set; }

        public virtual ICollection<TblDocumento> TblDocumentos { get; set; }
    }
}
