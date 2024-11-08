using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class RelatorioCdum
    {
        public string? NºCda { get; set; }
        public string? NºToda { get; set; }
        public string? ProcessoAdm { get; set; }
        public string? DataDeInscrição { get; set; }
        public string? Origem { get; set; }
        public string? AutoDeInfração { get; set; }
        public string? CnpjCpf { get; set; }
        public string? Devedor { get; set; }
        public double? ValorPrincipal { get; set; }
        public string? TermoInicial { get; set; }
        public double? EncargosLegais { get; set; }
        public string? SituaçãoDoCrédito { get; set; }
    }
}
