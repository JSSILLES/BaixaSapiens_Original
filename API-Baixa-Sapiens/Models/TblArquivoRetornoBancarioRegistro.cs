using System;
using System.Collections.Generic;

namespace API_Baixa_Sapiens.Models
{
    public partial class TblArquivoRetornoBancarioRegistro
    {
        public string? IdRegistro { get; set; }
        public string? Zero01 { get; set; }
        public string? Zero02 { get; set; }
        public string? NuPrefixoAgencia { get; set; }
        public string? DvPrefixoAgencia { get; set; }
        public string? NuContaCorrente { get; set; }
        public string? DvContaCorrente { get; set; }
        public string? NuConvenioCobranca { get; set; }
        public string? NuControleParticipante { get; set; }
        public string? NuNossoNumero { get; set; }
        public string? TpCobranca { get; set; }
        public string? TpCobrancaEspecifico { get; set; }
        public string? NuDiasCalculo { get; set; }
        public string? NaturezaRecebimento { get; set; }
        public string? NuPrefixoTitulo { get; set; }
        public string? VariacaoCarteira { get; set; }
        public string? ContaCaucao { get; set; }
        public string? TaxaDesconto { get; set; }
        public string? TaxaIof { get; set; }
        public string? Branco01 { get; set; }
        public string? Carteira { get; set; }
        public string? Comando { get; set; }
        public string? DtLiquidacao { get; set; }
        public string? NuTituloCedente { get; set; }
        public string? Branco02 { get; set; }
        public string? DtVencimento { get; set; }
        public string? VlTitulo { get; set; }
        public string? CdBancoRecebedor { get; set; }
        public string? NuPrefixoAgenciaRecebedora { get; set; }
        public string? DvPrefixoAgenciaRecebedora { get; set; }
        public string? EspecieTitulo { get; set; }
        public string? DtCredito { get; set; }
        public string? VlTarifa { get; set; }
        public string? VlOutrasDespesas { get; set; }
        public string? VlJurosDesconto { get; set; }
        public string? VlIofDesconto { get; set; }
        public string? VlAbatimento { get; set; }
        public string? VlDescontoConcedido { get; set; }
        public string? VlParcialRecebido { get; set; }
        public string? VlJuroMora { get; set; }
        public string? VlOutrosRecebimentos { get; set; }
        public string? VlAbatimentoNaoAproveitado { get; set; }
        public string? VlLancamento { get; set; }
        public string? IndicativoDebitoCredito { get; set; }
        public string? IndicadorValor { get; set; }
        public string? VlAjuste { get; set; }
        public string? Branco03 { get; set; }
        public string? Branco04 { get; set; }
        public string? Zero03 { get; set; }
        public string? Zero04 { get; set; }
        public string? Zero05 { get; set; }
        public string? Zero06 { get; set; }
        public string? Zero07 { get; set; }
        public string? Zero08 { get; set; }
        public string? IndicativoAutorizacaoLiquidacaoParcial { get; set; }
        public string? Branco05 { get; set; }
        public string? CanalPagamento { get; set; }
        public string? SequencialRegistro { get; set; }
        public string? NoSistema { get; set; }
        public byte? StProcessado { get; set; }
        public byte? StErroProcessamento { get; set; }
        public long? IdArquivo { get; set; }
        public string? DtLoteBanco { get; set; }
        public string? NuSequencialRetorno { get; set; }
        public string? AaSequencialRetorno { get; set; }
        public string? NuConvenio { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? StReprocessar { get; set; }
        public string? NuSequencialArquivo { get; set; }
        public string? DsLogBaixaRegistro { get; set; }

        public virtual TblArquivoRetornoBancario? IdArquivoNavigation { get; set; }
    }
}
