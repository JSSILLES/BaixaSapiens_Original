using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ObjetosNaoBaixadosRetornoObjetosCorreio
    {
        public string? NumeroAr { get; set; }
        public DateTime? DataEntregaSro { get; set; }
        public DateTime? DataPrevisaoPostagem { get; set; }
        public DateTime? DataPostagemFisica { get; set; }
        public double? NumeroArquivoRetornoAr { get; set; }
        public double? NumeroLoteImagem { get; set; }
        public string? DataDevolucao { get; set; }
        public string? CodigoMotivoDevolucao { get; set; }
    }
}
