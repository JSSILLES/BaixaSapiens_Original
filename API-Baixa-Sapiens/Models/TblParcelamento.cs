using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblParcelamento
    {
        public TblParcelamento()
        {
            TbImputacaoParcelamentos = new HashSet<TbImputacaoParcelamento>();
            TblLogImputacaos = new HashSet<TblLogImputacao>();
            TblParcelamentoParcelas = new HashSet<TblParcelamentoParcela>();
            TblParcelamentoProcessos = new HashSet<TblParcelamentoProcesso>();
            TblRestituicoesParcelamentos = new HashSet<TblRestituicoesParcelamento>();
        }

        public int SqParcelamento { get; set; }
        public short NrParcelamento { get; set; }
        public short AaParcelamento { get; set; }
        public string StParcelamento { get; set; } = null!;
        public decimal VlParcelamento { get; set; }
        public byte NrParcelas { get; set; }
        public DateTime DaParcelamento { get; set; }
        public bool InReparcelamento { get; set; }
        public string CoUsuario { get; set; } = null!;
        public int Idpessoa { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string? CoUsuarioCancelamento { get; set; }
        public int? SqMotivoCancelamentoParcelamento { get; set; }
        public string? DsMotivoCancelamentoParcelamento { get; set; }
        public DateTime? DaConcessaoParcelamento { get; set; }
        public int? SqGrupoDocumento { get; set; }
        public string? DsNumeroResolucao { get; set; }
        public bool InBloqueiaBoleto { get; set; }
        public string? NrParecer { get; set; }
        public string? DsObservacoes { get; set; }
        public DateTime? DtAnalise { get; set; }
        public string? CoUsuarioAnalise { get; set; }

        public virtual TblGrupoDocumento? SqGrupoDocumentoNavigation { get; set; }
        public virtual ICollection<TbImputacaoParcelamento> TbImputacaoParcelamentos { get; set; }
        public virtual ICollection<TblLogImputacao> TblLogImputacaos { get; set; }
        public virtual ICollection<TblParcelamentoParcela> TblParcelamentoParcelas { get; set; }
        public virtual ICollection<TblParcelamentoProcesso> TblParcelamentoProcessos { get; set; }
        public virtual ICollection<TblRestituicoesParcelamento> TblRestituicoesParcelamentos { get; set; }
    }
}
