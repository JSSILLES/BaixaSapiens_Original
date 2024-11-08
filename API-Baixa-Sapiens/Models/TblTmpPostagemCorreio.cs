using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblTmpPostagemCorreio
    {
        public string TxLinhaConfirmacaoPostagem { get; set; } = null!;
        public long? NrArDoc { get; set; }
    }
}
