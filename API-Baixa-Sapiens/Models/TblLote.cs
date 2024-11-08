using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblLote
    {
        public TblLote()
        {
            TblDocumentoEnvios = new HashSet<TblDocumentoEnvio>();
        }

        public decimal SqLote { get; set; }
        public short NrAnoLote { get; set; }
        public string CoUsuario { get; set; } = null!;
        public DateTime DaProcessamentoLote { get; set; }
        public int NrLote { get; set; }
        public int NrDocumentosLote { get; set; }
        public decimal VlDocumentosLote { get; set; }
        public DateTime? DaRetornoLote { get; set; }
        public string? StRetornoLote { get; set; }
        public string? CoUsuarioCancelamento { get; set; }
        public DateTime? DaCancelamentoLote { get; set; }
        public string? NoMotivoCancelamento { get; set; }

        [NotMapped]
        public virtual TblUsuario? CoUsuarioCancelamentoNavigation { get; set; }
        public virtual TblUsuario CoUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<TblDocumentoEnvio> TblDocumentoEnvios { get; set; }
    }
}
