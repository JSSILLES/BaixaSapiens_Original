using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblAr
    {
        public decimal SqAr { get; set; }
        public string CoUsuario { get; set; } = null!;
        public decimal NrLimiteInicialAr { get; set; }
        public decimal NrLimiteFinalAr { get; set; }
        public decimal? NrAtualAr { get; set; }
        public DateTime DaCadastroAr { get; set; }
        public string StAr { get; set; } = null!;
        public string SgPrefixo { get; set; } = null!;
        public string SgSufixo { get; set; } = null!;

        public virtual TblUsuario CoUsuarioNavigation { get; set; } = null!;
    }
}
