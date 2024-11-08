using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblHistoricoVeiculo
    {
        public int CodigoHistoricoVeiculo { get; set; }
        public string NumeroPlaca { get; set; } = null!;
        public string? NumeroChassi { get; set; }
        public short? AnoFabricação { get; set; }
        public short? AnoModelo { get; set; }
        public int? CapacidadeVeiculo { get; set; }
        public DateTime? DataUltimaAtualizacao { get; set; }
        public int? CodigoVeiculo { get; set; }
        public int? CodigoEntidade { get; set; }
        public string? TipoAcao { get; set; }
        public int CodigoHistoricoProcessamento { get; set; }
    }
}
