using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblBoletoControle
    {
        public decimal SqBoleto { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public short CoTipoDocumento { get; set; }
        public string? IndicadorPessoa { get; set; }
        public string? CpfCnpjSacado { get; set; }
        public string? NomeSacado { get; set; }
        public decimal? ValorDivida { get; set; }
        public DateTime? DataDocumento { get; set; }
        public DateTime? DataRegistroBb { get; set; }
        public DateTime? DataLimite { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Cep { get; set; }
        public string? NrNossoNumero { get; set; }
        public string? NrConvenio { get; set; }
        public string? CoRecolhimento { get; set; }
        public string? CoCarteira { get; set; }
        public string? CoVariacao { get; set; }
        public string? NrCodigoBarras { get; set; }
        public string? NrLinhaDigitavel { get; set; }
        public string? StringGeracaoBoleto1 { get; set; }
        public string? StringGeracaoBoleto2 { get; set; }
        public string? DescricaoRegistro { get; set; }
        public int StBoleto { get; set; }
        public int SqDocumento { get; set; }
        public int NrOrdemDocumentoEnvio { get; set; }
        public int? StPagamento { get; set; }
        public DateTime? DataLimiteDesconto { get; set; }
    }
}
