using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblRntrc
    {
        public string? NrProcesso { get; set; }
        public string? NrRenavam { get; set; }
        public string? NrCrntrc { get; set; }
        public string? NoMunicipioInfracao { get; set; }
        public string? NoMotorista { get; set; }
        public string? NrCpfMotorista { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? DsMotivoIndeferimento { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }
        public decimal SqDocumento { get; set; }
        public string? NoMunicipioPlacaVeiculo { get; set; }
        public string? DsTipoTransportador { get; set; }
        public string? NrCnhMotorista { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
