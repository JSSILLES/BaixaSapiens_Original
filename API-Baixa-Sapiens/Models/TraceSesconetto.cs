using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TraceSesconetto
    {
        public int RowNumber { get; set; }
        public int? EventClass { get; set; }
        public string? TextData { get; set; }
        public string? ApplicationName { get; set; }
        public string? NtuserName { get; set; }
        public string? LoginName { get; set; }
        public int? Cpu { get; set; }
        public long? Reads { get; set; }
        public long? Writes { get; set; }
        public long? Duration { get; set; }
        public int? ClientProcessId { get; set; }
        public int? Spid { get; set; }
        public DateTime? StartTime { get; set; }
        public int? DatabaseId { get; set; }
        public byte[]? BinaryData { get; set; }
    }
}
