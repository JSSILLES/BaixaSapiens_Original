using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblUsuario
    {
        public TblUsuario()
        {
            TblArs = new HashSet<TblAr>();
            TblBaixaDivergencia = new HashSet<TblBaixaDivergencium>();
            TblLogFinanceiras = new HashSet<TblLogFinanceira>();
            TblLogImputacaos = new HashSet<TblLogImputacao>();
            TblLogSistemas = new HashSet<TblLogSistema>();
            TblLoteCoUsuarioCancelamentoNavigations = new HashSet<TblLote>();
            TblLoteCoUsuarioNavigations = new HashSet<TblLote>();
            TblPerfils = new HashSet<TblPerfil>();
        }

        public string CoUsuario { get; set; } = null!;
        public string NoUsuario { get; set; } = null!;
        public string NoSenhaUsuario { get; set; } = null!;
        public DateTime DaCadastroUsuario { get; set; }
        public string StUsuario { get; set; } = null!;
        public int? SqSuperintendencia { get; set; }
        [NotMapped]
        public virtual TblSuperintendencium? SqSuperintendenciaNavigation { get; set; }
        public virtual ICollection<TblAr> TblArs { get; set; }
        public virtual ICollection<TblBaixaDivergencium> TblBaixaDivergencia { get; set; }
        public virtual ICollection<TblLogFinanceira> TblLogFinanceiras { get; set; }
        public virtual ICollection<TblLogImputacao> TblLogImputacaos { get; set; }
        public virtual ICollection<TblLogSistema> TblLogSistemas { get; set; }
        [NotMapped]
        public virtual ICollection<TblLote> TblLoteCoUsuarioCancelamentoNavigations { get; set; }
        [NotMapped]
        public virtual ICollection<TblLote> TblLoteCoUsuarioNavigations { get; set; }
        public virtual ICollection<TblPerfil> TblPerfils { get; set; }
    }
}
