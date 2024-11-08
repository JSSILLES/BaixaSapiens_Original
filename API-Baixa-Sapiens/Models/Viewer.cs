using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class Viewer
    {
        public int? NumCd { get; set; }
        public string? CodObjeto { get; set; }
        public DateTime? DtArmazenamento { get; set; }
        public DateTime? DtEntrega { get; set; }
        public int? NumLote { get; set; }
        public string? NomeImagem { get; set; }
        public int? CodObjetoNumerico { get; set; }
        public string? CaminhoImagem { get; set; }
        public bool? CoImportado { get; set; }
    }
}
