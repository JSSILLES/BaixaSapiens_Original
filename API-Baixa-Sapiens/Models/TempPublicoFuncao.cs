using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TempPublicoFuncao
    {
        public int? SqDocumento { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlMora { get; set; }
        public decimal? VlDocumentoCorreto { get; set; }
        public decimal? VlDevido { get; set; }
    }
}
