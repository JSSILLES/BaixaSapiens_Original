using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwExtratoPagamentoAi
    {
        public string? AutoInfracao { get; set; }
        public string? NomeAutuado { get; set; }
        public string? CpfCnpj { get; set; }
        public decimal? ValorMulta { get; set; }
        public DateTime? DataLimitePagamentoDesconto { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataCredito { get; set; }
        public decimal ValorDescontoDevido1 { get; set; }
        public decimal ValorJurosSelicDevido1 { get; set; }
        public decimal ValorJurosMoraDiaria1 { get; set; }
        public decimal ValorPago { get; set; }
        public decimal? SaldoCredito { get; set; }
        public int? TotalOcorrencia { get; set; }
        public decimal? ValorDebito { get; set; }
        public DateTime DataLimitePagamento { get; set; }
        public decimal ValorDescontoDevido2 { get; set; }
        public decimal ValorJurosSelicDevido2 { get; set; }
        public decimal ValorJurosMoraDiaria2 { get; set; }
        public decimal? DebitoAtualizado { get; set; }
    }
}
