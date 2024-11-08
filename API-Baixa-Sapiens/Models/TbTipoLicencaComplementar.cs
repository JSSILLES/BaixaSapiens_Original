using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TbTipoLicencaComplementar
    {
        public TbTipoLicencaComplementar()
        {
            TbLicencaComplementars = new HashSet<TbLicencaComplementar>();
        }

        public int CdSeqTipoLicenComplementar { get; set; }
        public string DsTipoLicencaComplementar { get; set; } = null!;

        public virtual ICollection<TbLicencaComplementar> TbLicencaComplementars { get; set; }
    }
}
