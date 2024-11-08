using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblExcessoVelocidade
    {
        public decimal SqDocumento { get; set; }
        public string? NoMarcaVeiculo { get; set; }
        public string? NoModeloVeiculo { get; set; }
        public string? NoEspecieVeiculo { get; set; }
        public string? NoCategoriaVeiculo { get; set; }
        public string? NoLocalInfracao { get; set; }
        public int? NrVelocidadePermitida { get; set; }
        public int? NrVelocidadeMedida { get; set; }
        public string? NoRodoviaInfracao { get; set; }
        public string? NrKmInfracao { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
