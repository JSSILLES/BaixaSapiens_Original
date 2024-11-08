using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class ViwDivisaoOrgaoConveniado
    {
        public int IddivisaoOrgaoConveniado { get; set; }
        public string SiglaDivisaoOrgaoConveniado { get; set; } = null!;
        public string NomeDivisaoOrgaoConveniado { get; set; } = null!;
        public string CodigoHierarquiaDivisaoOrgaoConveniado { get; set; } = null!;
        public int IdorgaoConveniado { get; set; }
        public string EnderecoDivisaoOrgaoConveniado { get; set; } = null!;
        public string? CepdivisaoOrgaoConveniado { get; set; }
        public string? TelefoneDivisaoOrgaoConveniado { get; set; }
        public string? ContatoPrimarioDivisaoOrgaoConveniado { get; set; }
        public string? ContatoSecundarioDivisaoOrgaoConveniado { get; set; }
        public string? BairroDivisaoOrgaoConveniado { get; set; }
        public string DescricaoMunicipio { get; set; } = null!;
    }
}
