using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TdMarcaVeiculo
    {
        public TdMarcaVeiculo()
        {
            RlMarcaPais = new HashSet<RlMarcaPai>();
        }

        public int CdMarcaVeiculo { get; set; }
        public string DsMarcaVeiculo { get; set; } = null!;
        public string? SgMarcaVeiculo { get; set; }

        public virtual ICollection<RlMarcaPai> RlMarcaPais { get; set; }
    }
}
