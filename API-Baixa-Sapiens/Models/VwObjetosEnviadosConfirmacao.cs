using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class VwObjetosEnviadosConfirmacao
    {
        public int NrLote { get; set; }
        public DateTime? DaTransmissao { get; set; }
        public int? NrObjetosEnviados { get; set; }
        public int? NrObjetosConfirmados { get; set; }
        public int? NrObjetosRetorno { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public int? Dia { get; set; }
    }
}
