using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class VwRelacionamento
    {
        public string? NomeConstraint { get; set; }
        public string? TipoConstraint { get; set; }
        public string? NomeTabelaPai { get; set; }
        public string? NomeColunaPai { get; set; }
        public string? NomeColunaPaiTipoDado { get; set; }
        public string? NomeTabelaReferenciada { get; set; }
        public string? ColunaTabelaReferenciada { get; set; }
    }
}
