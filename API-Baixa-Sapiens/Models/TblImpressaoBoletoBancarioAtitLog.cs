using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblImpressaoBoletoBancarioAtitLog
    {
        public string CoUsuario { get; set; } = null!;
        public int NrInicial { get; set; }
        public int NrFinal { get; set; }
        public byte CoOrgaoAutuador { get; set; }
        public DateTime DaOperacao { get; set; }
    }
}
