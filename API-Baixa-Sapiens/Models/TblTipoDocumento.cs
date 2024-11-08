using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblTipoDocumento
    {
        public TblTipoDocumento()
        {
            TblDocumentos = new HashSet<TblDocumento>();
            TblLancamentoManuals = new HashSet<TblLancamentoManual>();
            TblVersaoLayouts = new HashSet<TblVersaoLayout>();
            SqDetalheVisaos = new HashSet<TblDetalheVisao>();
        }

        public int SqTipoDocumento { get; set; }
        public short CoTipoDocumento { get; set; }
        public string DsTipoDocumento { get; set; } = null!;
        public int NrConvenioBanco { get; set; }
        public int SqSuperintendencia { get; set; }
        public string CoCarteira { get; set; } = null!;
        public int CoGru { get; set; }
        public string InLancamentoManual { get; set; } = null!;
        public string InValoresReais { get; set; } = null!;
        public int? SqGrupoDocumento { get; set; }

        public virtual TblGrupoDocumento? SqGrupoDocumentoNavigation { get; set; }
        public virtual TblSuperintendencium SqSuperintendenciaNavigation { get; set; } = null!;
        public virtual ICollection<TblDocumento> TblDocumentos { get; set; }
        public virtual ICollection<TblLancamentoManual> TblLancamentoManuals { get; set; }
        public virtual ICollection<TblVersaoLayout> TblVersaoLayouts { get; set; }

        public virtual ICollection<TblDetalheVisao> SqDetalheVisaos { get; set; }
    }
}
