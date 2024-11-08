using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblTipoIndicador
    {
        public TblTipoIndicador()
        {
            TblIndicadors = new HashSet<TblIndicador>();
        }

        public int SqTipoIndicador { get; set; }
        public string CoSiglaIndicador { get; set; } = null!;
        public string NoDescricaoIndicador { get; set; } = null!;
        public string CoIdentificadorPeriodicidade { get; set; } = null!;

        public virtual ICollection<TblIndicador> TblIndicadors { get; set; }
    }
}
