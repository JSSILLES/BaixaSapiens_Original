using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblDocumento
    {
        public TblDocumento()
        {
            TbImputacaoParcelamentos = new HashSet<TbImputacaoParcelamento>();
            TblDocumentoEnvios = new HashSet<TblDocumentoEnvio>();
            TblLogBaixaFeriadoMunicipals = new HashSet<TblLogBaixaFeriadoMunicipal>();
            TblRestituicoesDocumentos = new HashSet<TblRestituicoesDocumento>();
        }

        public decimal SqDocumento { get; set; }
        public string CoChaveDocumentoOrigem { get; set; } = null!;
        public string? NrPlacaVeiculo { get; set; }
        public string? SgUfPlacaVeiculo { get; set; }
        public string? CoInfracao { get; set; }
        public DateTime? DaInfracao { get; set; }
        public string? NoLocalidadeInfracao { get; set; }
        public string? NrCnpjAutuado { get; set; }
        public string? SgUfInfracao { get; set; }
        public string? NoDescricaoInfracao { get; set; }
        public string? NrAutoInfracao { get; set; }
        public string? NrCpfAutuado { get; set; }
        public int SqTipoDocumento { get; set; }
        public int SqFaseDocumento { get; set; }
        public int SqOrgaoAutuador { get; set; }
        public byte? NrSubtipo { get; set; }
        public string CoClassificacaoDocumento { get; set; } = null!;
        public string? HrInfracao { get; set; }
        public int? IddivisaoOrgaoConveniado { get; set; }
        public int? NrSenhaAcesso { get; set; }
        public int? CoVersaoLayout { get; set; }
        public string? DsAutoridadeAntt { get; set; }
        public string? DsLegislacao { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsAutoridadeOrgaoAutuador { get; set; }
        public int? IdLegislacao { get; set; }
        public int? NrDefesaRecursoResultado { get; set; }
        public string? SqStDocumento { get; set; }
        public bool? StConfissao { get; set; }
        public bool? StEnviaEct { get; set; }
        public string? RadicalCnpj { get; set; }

        public virtual TblFaseDocumento SqFaseDocumentoNavigation { get; set; } = null!;
        public virtual TblOrgaoAutuador SqOrgaoAutuadorNavigation { get; set; } = null!;
        public virtual TblTipoDocumento SqTipoDocumentoNavigation { get; set; } = null!;
        public virtual TblAtit TblAtit { get; set; } = null!;
        public virtual TblExcessoPeso TblExcessoPeso { get; set; } = null!;
        public virtual TblExcessoVelocidade TblExcessoVelocidade { get; set; } = null!;
        public virtual TblInfracaoSupa TblInfracaoSupa { get; set; } = null!;
        public virtual TblPef TblPef { get; set; } = null!;
        public virtual TblPer TblPer { get; set; } = null!;
        public virtual TblRntrc TblRntrc { get; set; } = null!;
        public virtual TblSac TblSac { get; set; } = null!;
        public virtual TblTrpp TblTrpp { get; set; } = null!;
        public virtual TblValePedagio TblValePedagio { get; set; } = null!;
        public virtual ICollection<TbImputacaoParcelamento> TbImputacaoParcelamentos { get; set; }
        public virtual ICollection<TblDocumentoEnvio> TblDocumentoEnvios { get; set; }
        public virtual ICollection<TblLogBaixaFeriadoMunicipal> TblLogBaixaFeriadoMunicipals { get; set; }
        public virtual ICollection<TblRestituicoesDocumento> TblRestituicoesDocumentos { get; set; }
    }
}
