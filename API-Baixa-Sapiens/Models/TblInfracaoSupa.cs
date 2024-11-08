using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblInfracaoSupa
    {
        public decimal SqDocumento { get; set; }
        public string? CoGrupoInfracao { get; set; }
        public string? NrOrdemVeiculo { get; set; }
        public byte? NrDrfInfracao { get; set; }
        public string? NoMunicipioInfracao { get; set; }
        public string? NoMotorista { get; set; }
        public string? NrCnhMotorista { get; set; }
        public string? NrProcesso { get; set; }
        public string? NoLinhaServico { get; set; }
        public string? NoPrefixo { get; set; }
        public string? DsMotivoIndeferimento { get; set; }
        public string? NoMensagem1 { get; set; }
        public string? NoMensagem2 { get; set; }
        public string? NoMensagem3 { get; set; }
        public string? NoMensagem4 { get; set; }
        public string? NoMensagem5 { get; set; }

        public virtual TblDocumento SqDocumentoNavigation { get; set; } = null!;
    }
}
