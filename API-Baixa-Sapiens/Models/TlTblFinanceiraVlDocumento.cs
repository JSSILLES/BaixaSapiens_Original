using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TlTblFinanceiraVlDocumento
    {
        public DateTime? DtAlteracao { get; set; }
        public int? SqDocumento { get; set; }
        public decimal? VlAnterior { get; set; }
        public decimal? VlAlterado { get; set; }
        public string? Ip { get; set; }
        public string? Programa { get; set; }
        public string? Host { get; set; }
        public string? Usuario { get; set; }
    }
}
