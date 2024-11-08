using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblVisao
    {
        public TblVisao()
        {
            TblDetalheVisaos = new HashSet<TblDetalheVisao>();
        }

        public int SqVisao { get; set; }
        public byte CoVisao { get; set; }
        public string DsVisao { get; set; } = null!;
        public string? DsTextoRodape { get; set; }
        public string InClassificaSuperintendencia { get; set; } = null!;

        public virtual ICollection<TblDetalheVisao> TblDetalheVisaos { get; set; }
    }
}
