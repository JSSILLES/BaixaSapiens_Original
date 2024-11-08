using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_Baixa_Sapiens.Models
{
    public partial class BD_COBRANCAContext : DbContext
    {
        public BD_COBRANCAContext()
        {
        }

        public BD_COBRANCAContext(DbContextOptions<BD_COBRANCAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auto> Autos { get; set; } = null!;
        public virtual DbSet<Cbr6433111812201723905Analise> Cbr6433111812201723905Analises { get; set; } = null!;
        public virtual DbSet<Cbr64362461912201713721> Cbr64362461912201713721s { get; set; } = null!;
        public virtual DbSet<ObjetosNaoBaixadosRetornoObjetosCorreio> ObjetosNaoBaixadosRetornoObjetosCorreios { get; set; } = null!;
        public virtual DbSet<ObjetosNaoBaixadosSuinf> ObjetosNaoBaixadosSuinfs { get; set; } = null!;
        public virtual DbSet<ObjetosNaoBaixadosSupa> ObjetosNaoBaixadosSupas { get; set; } = null!;
        public virtual DbSet<RelatorioCdum> RelatorioCda { get; set; } = null!;
        public virtual DbSet<RlLicencaVeiculo> RlLicencaVeiculos { get; set; } = null!;
        public virtual DbSet<RlMarcaPai> RlMarcaPais { get; set; } = null!;
        public virtual DbSet<RlMarcaVeiculo> RlMarcaVeiculos { get; set; } = null!;
        public virtual DbSet<TbCapacidadeCarga> TbCapacidadeCargas { get; set; } = null!;
        public virtual DbSet<TbCarrocerium> TbCarroceria { get; set; } = null!;
        public virtual DbSet<TbEmpresa> TbEmpresas { get; set; } = null!;
        public virtual DbSet<TbExecucaoBaixaSerasa> TbExecucaoBaixaSerasas { get; set; } = null!;
        public virtual DbSet<TbExecucaoBaixaSerasaArquivo> TbExecucaoBaixaSerasaArquivos { get; set; } = null!;
        public virtual DbSet<TbImputacaoParcelamento> TbImputacaoParcelamentos { get; set; } = null!;
        public virtual DbSet<TbLicenca> TbLicencas { get; set; } = null!;
        public virtual DbSet<TbLicencaComplementar> TbLicencaComplementars { get; set; } = null!;
        public virtual DbSet<TbLogExecSeresaExclusao> TbLogExecSeresaExclusaos { get; set; } = null!;
        public virtual DbSet<TbModalidadeTrafego> TbModalidadeTrafegos { get; set; } = null!;
        public virtual DbSet<TbPai> TbPais { get; set; } = null!;
        public virtual DbSet<TbPostagemStatus> TbPostagemStatuses { get; set; } = null!;
        public virtual DbSet<TbProprietario> TbProprietarios { get; set; } = null!;
        public virtual DbSet<TbRepresentanteEmpresa> TbRepresentanteEmpresas { get; set; } = null!;
        public virtual DbSet<TbTipoInsercaoVeiculo> TbTipoInsercaoVeiculos { get; set; } = null!;
        public virtual DbSet<TbTipoLicencaComplementar> TbTipoLicencaComplementars { get; set; } = null!;
        public virtual DbSet<TbTipoPagamento> TbTipoPagamentos { get; set; } = null!;
        public virtual DbSet<TbUltimoMovimentoFinanceiro> TbUltimoMovimentoFinanceiros { get; set; } = null!;
        public virtual DbSet<TbVeiculo> TbVeiculos { get; set; } = null!;
        public virtual DbSet<TblAr> TblArs { get; set; } = null!;
        public virtual DbSet<TblArquivoAr> TblArquivoArs { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoBancario> TblArquivoRetornoBancarios { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoBancarioCabecalho> TblArquivoRetornoBancarioCabecalhos { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoBancarioLog> TblArquivoRetornoBancarioLogs { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoBancarioRegistro> TblArquivoRetornoBancarioRegistros { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoBancarioRodape> TblArquivoRetornoBancarioRodapes { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoBancarioTemp> TblArquivoRetornoBancarioTemps { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoComando> TblArquivoRetornoComandos { get; set; } = null!;
        public virtual DbSet<TblArquivoRetornoTemp> TblArquivoRetornoTemps { get; set; } = null!;
        public virtual DbSet<TblAtit> TblAtits { get; set; } = null!;
        public virtual DbSet<TblBaixaDivergencium> TblBaixaDivergencia { get; set; } = null!;
        public virtual DbSet<TblBoletoControle> TblBoletoControles { get; set; } = null!;
        public virtual DbSet<TblCodigoLog> TblCodigoLogs { get; set; } = null!;
        public virtual DbSet<TblComandoPagamentoBaixa> TblComandoPagamentoBaixas { get; set; } = null!;
        public virtual DbSet<TblControleProcessamento> TblControleProcessamentos { get; set; } = null!;
        public virtual DbSet<TblConvenio> TblConvenios { get; set; } = null!;
        public virtual DbSet<TblConvenioRecolhimentoBb> TblConvenioRecolhimentoBbs { get; set; } = null!;
        public virtual DbSet<TblDepositoJudicial> TblDepositoJudicials { get; set; } = null!;
        public virtual DbSet<TblDetalheVisao> TblDetalheVisaos { get; set; } = null!;
        public virtual DbSet<TblDocumento> TblDocumentos { get; set; } = null!;
        public virtual DbSet<TblDocumentoEct> TblDocumentoEcts { get; set; } = null!;
        public virtual DbSet<TblDocumentoEnvio> TblDocumentoEnvios { get; set; } = null!;
        public virtual DbSet<TblDocumentosIncluirSerasaEp> TblDocumentosIncluirSerasaEps { get; set; } = null!;
        public virtual DbSet<TblErroBancario> TblErroBancarios { get; set; } = null!;
        public virtual DbSet<TblErroPostagem> TblErroPostagems { get; set; } = null!;
        public virtual DbSet<TblExcessoPeso> TblExcessoPesos { get; set; } = null!;
        public virtual DbSet<TblExcessoVelocidade> TblExcessoVelocidades { get; set; } = null!;
        public virtual DbSet<TblFaseDocumento> TblFaseDocumentos { get; set; } = null!;
        public virtual DbSet<TblFinanceira> TblFinanceiras { get; set; } = null!;
        public virtual DbSet<TblFinanceiraHmlBkp20180404> TblFinanceiraHmlBkp20180404s { get; set; } = null!;
        public virtual DbSet<TblFinanceiraLog> TblFinanceiraLogs { get; set; } = null!;
        public virtual DbSet<TblFinanceiraParcelamento> TblFinanceiraParcelamentos { get; set; } = null!;
        public virtual DbSet<TblGrupoDocumento> TblGrupoDocumentos { get; set; } = null!;
        public virtual DbSet<TblHistoricoVeiculo> TblHistoricoVeiculos { get; set; } = null!;
        public virtual DbSet<TblImpressao> TblImpressaos { get; set; } = null!;
        public virtual DbSet<TblImpressaoBoletoBancarioAtit> TblImpressaoBoletoBancarioAtits { get; set; } = null!;
        public virtual DbSet<TblImpressaoBoletoBancarioAtitLog> TblImpressaoBoletoBancarioAtitLogs { get; set; } = null!;
        public virtual DbSet<TblIndicador> TblIndicadors { get; set; } = null!;
        public virtual DbSet<TblIndicadorBkp> TblIndicadorBkps { get; set; } = null!;
        public virtual DbSet<TblInfracaoSupa> TblInfracaoSupas { get; set; } = null!;
        public virtual DbSet<TblLancamentoManual> TblLancamentoManuals { get; set; } = null!;
        public virtual DbSet<TblLogBaixaFeriadoMunicipal> TblLogBaixaFeriadoMunicipals { get; set; } = null!;
        public virtual DbSet<TblLogFinanceira> TblLogFinanceiras { get; set; } = null!;
        public virtual DbSet<TblLogImputacao> TblLogImputacaos { get; set; } = null!;
        public virtual DbSet<TblLogLancamento> TblLogLancamentos { get; set; } = null!;
        public virtual DbSet<TblLogRestituicoesDocumento> TblLogRestituicoesDocumentos { get; set; } = null!;
        public virtual DbSet<TblLogRestituicoesParcelamento> TblLogRestituicoesParcelamentos { get; set; } = null!;
        public virtual DbSet<TblLogSistema> TblLogSistemas { get; set; } = null!;
        public virtual DbSet<TblLote> TblLotes { get; set; } = null!;
        public virtual DbSet<TblModuloSistema> TblModuloSistemas { get; set; } = null!;
        public virtual DbSet<TblMotivoBaixa> TblMotivoBaixas { get; set; } = null!;
        public virtual DbSet<TblMotivoCancelamentoParcelamento> TblMotivoCancelamentoParcelamentos { get; set; } = null!;
        public virtual DbSet<TblMotivoDevolucao> TblMotivoDevolucaos { get; set; } = null!;
        public virtual DbSet<TblOrgaoAutuador> TblOrgaoAutuadors { get; set; } = null!;
        public virtual DbSet<TblOrigemDocumento> TblOrigemDocumentos { get; set; } = null!;
        public virtual DbSet<TblParcelamento> TblParcelamentos { get; set; } = null!;
        public virtual DbSet<TblParcelamentoParcela> TblParcelamentoParcelas { get; set; } = null!;
        public virtual DbSet<TblParcelamentoProcessamento> TblParcelamentoProcessamentos { get; set; } = null!;
        public virtual DbSet<TblParcelamentoProcesso> TblParcelamentoProcessos { get; set; } = null!;
        public virtual DbSet<TblPef> TblPefs { get; set; } = null!;
        public virtual DbSet<TblPer> TblPers { get; set; } = null!;
        public virtual DbSet<TblPerfil> TblPerfils { get; set; } = null!;
        public virtual DbSet<TblRestituicoesDocumento> TblRestituicoesDocumentos { get; set; } = null!;
        public virtual DbSet<TblRestituicoesParcelamento> TblRestituicoesParcelamentos { get; set; } = null!;
        public virtual DbSet<TblRntrc> TblRntrcs { get; set; } = null!;
        public virtual DbSet<TblSac> TblSacs { get; set; } = null!;
        public virtual DbSet<TblSequencialBoletoBancarioAtit> TblSequencialBoletoBancarioAtits { get; set; } = null!;
        public virtual DbSet<TblSequencialDocumentoCobranca> TblSequencialDocumentoCobrancas { get; set; } = null!;
        public virtual DbSet<TblSerasaAnaliseSugestao> TblSerasaAnaliseSugestaos { get; set; } = null!;
        public virtual DbSet<TblSerasaBlacklist> TblSerasaBlacklists { get; set; } = null!;
        public virtual DbSet<TblSerasaBlacklistLog> TblSerasaBlacklistLogs { get; set; } = null!;
        public virtual DbSet<TblSerasaBlacklistLote> TblSerasaBlacklistLotes { get; set; } = null!;
        public virtual DbSet<TblSerasaBlacklistLoteLog> TblSerasaBlacklistLoteLogs { get; set; } = null!;
        public virtual DbSet<TblSerasaBlacklistSistema> TblSerasaBlacklistSistemas { get; set; } = null!;
        public virtual DbSet<TblSerasaBlacklistStatus> TblSerasaBlacklistStatuses { get; set; } = null!;
        public virtual DbSet<TblSerasaBlacklistTipoDocumento> TblSerasaBlacklistTipoDocumentos { get; set; } = null!;
        public virtual DbSet<TblSerasaCodigoErro> TblSerasaCodigoErros { get; set; } = null!;
        public virtual DbSet<TblSerasaDocumento> TblSerasaDocumentos { get; set; } = null!;
        public virtual DbSet<TblSerasaDocumentoLog> TblSerasaDocumentoLogs { get; set; } = null!;
        public virtual DbSet<TblSerasaHistoricoAlteracaoLote> TblSerasaHistoricoAlteracaoLotes { get; set; } = null!;
        public virtual DbSet<TblSerasaInformacional> TblSerasaInformacionals { get; set; } = null!;
        public virtual DbSet<TblSerasaLote> TblSerasaLotes { get; set; } = null!;
        public virtual DbSet<TblSerasaMotivoBaixa> TblSerasaMotivoBaixas { get; set; } = null!;
        public virtual DbSet<TblSerasaParametro> TblSerasaParametros { get; set; } = null!;
        public virtual DbSet<TblSerasaSituacaoDocumento> TblSerasaSituacaoDocumentos { get; set; } = null!;
        public virtual DbSet<TblSerasaSugestao> TblSerasaSugestaos { get; set; } = null!;
        public virtual DbSet<TblSituacaoDocumento> TblSituacaoDocumentos { get; set; } = null!;
        public virtual DbSet<TblStatusDocumento> TblStatusDocumentos { get; set; } = null!;
        public virtual DbSet<TblStatusFinanceiro> TblStatusFinanceiros { get; set; } = null!;
        public virtual DbSet<TblSuperintendencium> TblSuperintendencia { get; set; } = null!;
        public virtual DbSet<TblTipoArrecadacao> TblTipoArrecadacaos { get; set; } = null!;
        public virtual DbSet<TblTipoDocumento> TblTipoDocumentos { get; set; } = null!;
        public virtual DbSet<TblTipoIndicador> TblTipoIndicadors { get; set; } = null!;
        public virtual DbSet<TblTipoQuitacao> TblTipoQuitacaos { get; set; } = null!;
        public virtual DbSet<TblTmpPostagemCorreio> TblTmpPostagemCorreios { get; set; } = null!;
        public virtual DbSet<TblTmpPostagemCorreiosOld> TblTmpPostagemCorreiosOlds { get; set; } = null!;
        public virtual DbSet<TblTrpp> TblTrpps { get; set; } = null!;
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; } = null!;
        public virtual DbSet<TblValePedagio> TblValePedagios { get; set; } = null!;
        public virtual DbSet<TblVersaoLayout> TblVersaoLayouts { get; set; } = null!;
        public virtual DbSet<TblVisao> TblVisaos { get; set; } = null!;
        public virtual DbSet<TdMarcaVeiculo> TdMarcaVeiculos { get; set; } = null!;
        public virtual DbSet<TdTipoVeiculo> TdTipoVeiculos { get; set; } = null!;
        public virtual DbSet<Temp> Temps { get; set; } = null!;
        public virtual DbSet<Temp170Serasa> Temp170Serasas { get; set; } = null!;
        public virtual DbSet<TempAuto> TempAutos { get; set; } = null!;
        public virtual DbSet<TempDocumentoEnvio> TempDocumentoEnvios { get; set; } = null!;
        public virtual DbSet<TempPublicoFuncao> TempPublicoFuncaos { get; set; } = null!;
        public virtual DbSet<TempRelMovimentoPeriodo> TempRelMovimentoPeriodos { get; set; } = null!;
        public virtual DbSet<TempRelatorioArrecadacao03082018> TempRelatorioArrecadacao03082018s { get; set; } = null!;
        public virtual DbSet<TlTblFinanceiraVlDocumento> TlTblFinanceiraVlDocumentos { get; set; } = null!;
        public virtual DbSet<TmpRelatorioArrecadacao> TmpRelatorioArrecadacaos { get; set; } = null!;
        public virtual DbSet<TraceSesconetto> TraceSesconettos { get; set; } = null!;
        public virtual DbSet<Viewer> Viewers { get; set; } = null!;
        public virtual DbSet<ViwArEnviado> ViwArEnviados { get; set; } = null!;
        public virtual DbSet<ViwCalculoAcrescimoDesconto> ViwCalculoAcrescimoDescontos { get; set; } = null!;
        public virtual DbSet<ViwCalculoAcrescimoDescontoDolar> ViwCalculoAcrescimoDescontoDolars { get; set; } = null!;
        public virtual DbSet<ViwDataAtual> ViwDataAtuals { get; set; } = null!;
        public virtual DbSet<ViwDivisaoOrgaoConveniado> ViwDivisaoOrgaoConveniados { get; set; } = null!;
        public virtual DbSet<ViwExtratoPagamentoAi> ViwExtratoPagamentoAis { get; set; } = null!;
        public virtual DbSet<ViwFaseArDocumento> ViwFaseArDocumentos { get; set; } = null!;
        public virtual DbSet<ViwFeriado> ViwFeriados { get; set; } = null!;
        public virtual DbSet<ViwFiltroRelatorioMovimentoPeriodo> ViwFiltroRelatorioMovimentoPeriodos { get; set; } = null!;
        public virtual DbSet<ViwInformacoesPagamentoDocumento> ViwInformacoesPagamentoDocumentos { get; set; } = null!;
        public virtual DbSet<ViwMovimentoDivergentePeriodo> ViwMovimentoDivergentePeriodos { get; set; } = null!;
        public virtual DbSet<ViwMovimentoDivergentePeriodoDolar> ViwMovimentoDivergentePeriodoDolars { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodo> ViwMovimentoPeriodos { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodoHml042023> ViwMovimentoPeriodoHml042023s { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodoHml042023Hml> ViwMovimentoPeriodoHml042023Hmls { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodoHml092022> ViwMovimentoPeriodoHml092022s { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodoPrd> ViwMovimentoPeriodoPrds { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodoPrd042023> ViwMovimentoPeriodoPrd042023s { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodoPrd072022> ViwMovimentoPeriodoPrd072022s { get; set; } = null!;
        public virtual DbSet<ViwMovimentoPeriodoV2> ViwMovimentoPeriodoV2s { get; set; } = null!;
        public virtual DbSet<ViwObservacaoNotificacao> ViwObservacaoNotificacaos { get; set; } = null!;
        public virtual DbSet<ViwPagamentoCorretoReaisDolar> ViwPagamentoCorretoReaisDolars { get; set; } = null!;
        public virtual DbSet<ViwSuinfExcessoPeso> ViwSuinfExcessoPesos { get; set; } = null!;
        public virtual DbSet<ViwSuinfValePedagio> ViwSuinfValePedagios { get; set; } = null!;
        public virtual DbSet<ViwValoresInternacionaisTrpp> ViwValoresInternacionaisTrpps { get; set; } = null!;
        public virtual DbSet<Vlindicador> Vlindicadors { get; set; } = null!;
        public virtual DbSet<VwAtitnotificacao> VwAtitnotificacaos { get; set; } = null!;
        public virtual DbSet<VwEnvioCorreio> VwEnvioCorreios { get; set; } = null!;
        public virtual DbSet<VwObjetosEnviadosConfirmacao> VwObjetosEnviadosConfirmacaos { get; set; } = null!;
        public virtual DbSet<VwPostagemCorreio> VwPostagemCorreios { get; set; } = null!;
        public virtual DbSet<VwPostagemCorreiosConfirmacao> VwPostagemCorreiosConfirmacaos { get; set; } = null!;
        public virtual DbSet<VwProcessaParcelamento> VwProcessaParcelamentos { get; set; } = null!;
        public virtual DbSet<VwRelacionamento> VwRelacionamentos { get; set; } = null!;
        public virtual DbSet<VwRelatorioParcelamento> VwRelatorioParcelamentos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ANTTSQLDEV01;Database=BD_COBRANCA;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<Auto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AUTOS");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("AA_SEQUENCIAL_DOCUMENTO");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("CO_ORGAO_AUTUADOR");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("CO_SUPERINTENDENCIA");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("CO_TIPO_ARRECADACAO");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("CO_VERSAO_LAYOUT");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("DA_CONVERSAO_RENDA");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("DA_DEPOSITO_JUDICIAL");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DA_LIMITE_PAGAMENTO");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DA_PAGAMENTO");

                entity.Property(e => e.DaPagamentoParcela)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DA_PAGAMENTO_PARCELA");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DA_PARCELAMENTO");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DA_VENCIMENTO");

                entity.Property(e => e.DaVencimentoParcela)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DA_VENCIMENTO_PARCELA");

                entity.Property(e => e.DjSqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DJ_SQ_DOCUMENTO");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DS_STATUS_FINANCEIRO");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DS_TIPO_DOCUMENTO");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DS_TP_QUITACAO");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("ID_TP_QUITACAO");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("IN_APROVEITAMENTO_CREDITO");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NO_SUPERINTENDENCIA");

                entity.Property(e => e.Nossonumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOSSONUMERO");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("NR_AUTO_INFRACAO");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NR_CNPJ_AUTUADO")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("NR_CPF_AUTUADO")
                    .IsFixedLength();

                entity.Property(e => e.NrNossoNumeroRegistrado)
                    .IsUnicode(false)
                    .HasColumnName("NR_NOSSO_NUMERO_REGISTRADO");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("NR_ORDEM_FINANCEIRA");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("NR_SEQUENCIAL_DOCUMENTO");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("PGTO_JUDICIAL");

                entity.Property(e => e.SqAutos)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SQ_AUTOS");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("SQ_DEPOSITO_JUDICIAL");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SQ_DOCUMENTO");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("SQ_FASE_DOCUMENTO");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("SQ_GRUPO_DOCUMENTO");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("SQ_ORIGEM_DOCUMENTO");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("SQ_STATUS_FINANCEIRO");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("SQ_SUPERINTENDENCIA");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("SQ_TIPO_DOCUMENTO");

                entity.Property(e => e.StSituacaoAMaior).HasColumnName("ST_SITUACAO_A_MAIOR");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_CONVERSAO_RENDA");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_DESCONTO");

                entity.Property(e => e.VlDevido)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_DEVIDO");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_DOCUMENTO");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_MORA_MULTA");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_PAGAMENTO");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_RESIDUAL");
            });

            modelBuilder.Entity<Cbr6433111812201723905Analise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CBR6433111812201723905_analise");

                entity.Property(e => e.Coluna0)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Coluna 0");
            });

            modelBuilder.Entity<Cbr64362461912201713721>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CBR64362461912201713721");

                entity.Property(e => e.Coluna0)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Coluna 0");
            });

            modelBuilder.Entity<ObjetosNaoBaixadosRetornoObjetosCorreio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ObjetosNaoBaixados_RetornoObjetosCorreios");

                entity.Property(e => e.CodigoMotivoDevolucao).HasMaxLength(255);

                entity.Property(e => e.DataDevolucao).HasMaxLength(255);

                entity.Property(e => e.DataEntregaSro)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DataEntregaSRO");

                entity.Property(e => e.DataPostagemFisica).HasColumnType("smalldatetime");

                entity.Property(e => e.DataPrevisaoPostagem).HasColumnType("smalldatetime");

                entity.Property(e => e.NumeroAr)
                    .HasMaxLength(255)
                    .HasColumnName("NumeroAR");

                entity.Property(e => e.NumeroArquivoRetornoAr).HasColumnName("NumeroArquivoRetornoAR");
            });

            modelBuilder.Entity<ObjetosNaoBaixadosSuinf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ObjetosNaoBaixados_SUINF");

                entity.Property(e => e.DataPostagem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NumeroAR");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVia)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObjetosNaoBaixadosSupa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ObjetosNaoBaixados_SUPAS");

                entity.Property(e => e.DataPostagem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NumeroAR");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVia)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RelatorioCdum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'RelatorioCDA'");

                entity.Property(e => e.AutoDeInfração)
                    .HasMaxLength(255)
                    .HasColumnName("AUTO DE INFRAÇÃO");

                entity.Property(e => e.CnpjCpf)
                    .HasMaxLength(255)
                    .HasColumnName("CNPJ_CPF");

                entity.Property(e => e.DataDeInscrição)
                    .HasMaxLength(255)
                    .HasColumnName("DATA DE INSCRIÇÃO");

                entity.Property(e => e.Devedor).HasMaxLength(255);

                entity.Property(e => e.EncargosLegais).HasColumnName("ENCARGOS LEGAIS (%)");

                entity.Property(e => e.NºCda)
                    .HasMaxLength(255)
                    .HasColumnName("Nº CDA");

                entity.Property(e => e.NºToda)
                    .HasMaxLength(255)
                    .HasColumnName("Nº TODA");

                entity.Property(e => e.Origem)
                    .HasMaxLength(255)
                    .HasColumnName("ORIGEM");

                entity.Property(e => e.ProcessoAdm)
                    .HasMaxLength(255)
                    .HasColumnName("PROCESSO ADM");

                entity.Property(e => e.SituaçãoDoCrédito)
                    .HasMaxLength(255)
                    .HasColumnName("SITUAÇÃO DO CRÉDITO");

                entity.Property(e => e.TermoInicial)
                    .HasMaxLength(255)
                    .HasColumnName("TERMO INICIAL");

                entity.Property(e => e.ValorPrincipal).HasColumnName("VALOR PRINCIPAL");
            });

            modelBuilder.Entity<RlLicencaVeiculo>(entity =>
            {
                entity.HasKey(e => e.CdSeqLicencaVeiculo);

                entity.ToTable("RL_LICENCA_VEICULO");

                entity.HasIndex(e => new { e.CdLicenca, e.CdVeiculo }, "UK_LICENCA_VEICULO")
                    .IsUnique();

                entity.Property(e => e.CdSeqLicencaVeiculo).HasColumnName("CD_SEQ_LICENCA_VEICULO");

                entity.Property(e => e.CdLicenca).HasColumnName("CD_LICENCA");

                entity.Property(e => e.CdVeiculo).HasColumnName("CD_VEICULO");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DS_OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DtCancelamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_CANCELAMENTO");

                entity.HasOne(d => d.CdLicencaNavigation)
                    .WithMany(p => p.RlLicencaVeiculos)
                    .HasForeignKey(d => d.CdLicenca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RL_LICENCA_VEICULO_TB_LICENCA");

                entity.HasOne(d => d.CdVeiculoNavigation)
                    .WithMany(p => p.RlLicencaVeiculos)
                    .HasForeignKey(d => d.CdVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RL_LICENCA_VEICULO_TB_VEICULO");
            });

            modelBuilder.Entity<RlMarcaPai>(entity =>
            {
                entity.HasKey(e => e.CdSeqMarcaPais);

                entity.ToTable("RL_MARCA_PAIS");

                entity.Property(e => e.CdSeqMarcaPais).HasColumnName("CD_SEQ_MARCA_PAIS");

                entity.Property(e => e.CdMarcaPais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CD_MARCA_PAIS");

                entity.Property(e => e.CdMarcaVeiculo).HasColumnName("CD_MARCA_VEICULO");

                entity.Property(e => e.CdPais).HasColumnName("CD_PAIS");

                entity.HasOne(d => d.CdMarcaVeiculoNavigation)
                    .WithMany(p => p.RlMarcaPais)
                    .HasForeignKey(d => d.CdMarcaVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RL_MARCA_REFERENCE_TD_MARCA");

                entity.HasOne(d => d.CdPaisNavigation)
                    .WithMany(p => p.RlMarcaPais)
                    .HasForeignKey(d => d.CdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RL_MARCA_REFERENCE_TB_PAIS");
            });

            modelBuilder.Entity<RlMarcaVeiculo>(entity =>
            {
                entity.HasKey(e => e.CdSeqMarcaVeiculo);

                entity.ToTable("RL_MARCA_VEICULO");

                entity.Property(e => e.CdSeqMarcaVeiculo).HasColumnName("CD_SEQ_MARCA_VEICULO");
            });

            modelBuilder.Entity<TbCapacidadeCarga>(entity =>
            {
                entity.HasKey(e => e.CdSeqCapacidadeCarga);

                entity.ToTable("TB_CAPACIDADE_CARGA");

                entity.Property(e => e.CdSeqCapacidadeCarga).HasColumnName("CD_SEQ_CAPACIDADE_CARGA");

                entity.Property(e => e.CdTipoVeiculo).HasColumnName("CD_TIPO_VEICULO");

                entity.Property(e => e.QtCmt)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("QT_CMT");

                entity.Property(e => e.QtEixo).HasColumnName("QT_EIXO");

                entity.Property(e => e.QtPbt)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("QT_PBT");

                entity.Property(e => e.QtTara)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("QT_TARA");

                entity.Property(e => e.St2m40EntreEixos).HasColumnName("ST_2m40_ENTRE_EIXOS");

                entity.HasOne(d => d.CdTipoVeiculoNavigation)
                    .WithMany(p => p.TbCapacidadeCargas)
                    .HasForeignKey(d => d.CdTipoVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_CAPACIDADE_CARGA_TB_TIPO_VEICULO");
            });

            modelBuilder.Entity<TbCarrocerium>(entity =>
            {
                entity.HasKey(e => e.CdSeqTipoCarroceria);

                entity.ToTable("TB_CARROCERIA");

                entity.Property(e => e.CdSeqTipoCarroceria).HasColumnName("CD_SEQ_TIPO_CARROCERIA");

                entity.Property(e => e.NoTipoCarroceria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NO_TIPO_CARROCERIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SgTipoCarroceria)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SG_TIPO_CARROCERIA")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbEmpresa>(entity =>
            {
                entity.HasKey(e => e.CdSeqEmpresa);

                entity.ToTable("TB_EMPRESA");

                entity.HasIndex(e => e.NuRegistroEmpresa, "UK_REGISTRO_EMPRESA")
                    .IsUnique();

                entity.Property(e => e.CdSeqEmpresa).HasColumnName("CD_SEQ_EMPRESA");

                entity.Property(e => e.CdPais).HasColumnName("CD_PAIS");

                entity.Property(e => e.DsChaveAcesso)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DS_CHAVE_ACESSO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsCodigoPostalEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DS_CODIGO_POSTAL_EMPRESA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DS_EMAIL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsEnderecoEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DS_ENDERECO_EMPRESA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DS_LOGIN")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsSenha)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DS_SENHA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsUfEmpresa)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DS_UF_EMPRESA")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_CADASTRO");

                entity.Property(e => e.NoCidadeEmpresa)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NO_CIDADE_EMPRESA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NoEmpresa)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NO_EMPRESA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NuRegistroEmpresa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NU_REGISTRO_EMPRESA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NuTelefone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NU_TELEFONE");

                entity.Property(e => e.SgEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SG_EMPRESA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StAtivo).HasColumnName("ST_ATIVO");

                entity.HasOne(d => d.CdPaisNavigation)
                    .WithMany(p => p.TbEmpresas)
                    .HasForeignKey(d => d.CdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_EMPRESA_TB_PAIS");
            });

            modelBuilder.Entity<TbExecucaoBaixaSerasa>(entity =>
            {
                entity.HasKey(e => e.CdSeqExecucaoBaixaSerasa);

                entity.ToTable("TB_EXECUCAO_BAIXA_SERASA");

                entity.Property(e => e.CdSeqExecucaoBaixaSerasa).HasColumnName("CD_SEQ_EXECUCAO_BAIXA_SERASA");

                entity.Property(e => e.DtHrExecucaoBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HR_EXECUCAO_BAIXA");

                entity.Property(e => e.EnderecoRepositorioArrecadacao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO_REPOSITORIO_ARRECADACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EnderecoRepositorioSerasa)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO_REPOSITORIO_SERASA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbExecucaoBaixaSerasaArquivo>(entity =>
            {
                entity.HasKey(e => e.CdSeqExecucaoBaixaSerasaArquivos)
                    .HasName("PK_TB_REGRA_ENVIO_EMAIL");

                entity.ToTable("TB_EXECUCAO_BAIXA_SERASA_ARQUIVOS");

                entity.HasIndex(e => e.CdSeqExecucaoBaixaSerasa, "IN_FK_TB_EXECUCAO_BAIXA_SERASA_ARQUIVOS_CD_SEQ_EXECUCAO_BAIXA_SERASA");

                entity.Property(e => e.CdSeqExecucaoBaixaSerasaArquivos).HasColumnName("CD_SEQ_EXECUCAO_BAIXA_SERASA_ARQUIVOS");

                entity.Property(e => e.CdSeqExecucaoBaixaSerasa).HasColumnName("CD_SEQ_EXECUCAO_BAIXA_SERASA");

                entity.Property(e => e.NomeArquivoSerasa)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOME_ARQUIVO_SERASA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StBaixado).HasColumnName("ST_BAIXADO");

                entity.HasOne(d => d.CdSeqExecucaoBaixaSerasaNavigation)
                    .WithMany(p => p.TbExecucaoBaixaSerasaArquivos)
                    .HasForeignKey(d => d.CdSeqExecucaoBaixaSerasa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_EXECUCAO_BAIXA_SERASA_TB_EXECUCAO_BAIXA_SERASA_ARQUIVOS");
            });

            modelBuilder.Entity<TbImputacaoParcelamento>(entity =>
            {
                entity.HasKey(e => e.CdSeqImputacaoParcelamento)
                    .HasName("PK__TB_IMPUT__9FA6E6E77D7503A6");

                entity.ToTable("TB_IMPUTACAO_PARCELAMENTO");

                entity.Property(e => e.CdSeqImputacaoParcelamento).HasColumnName("CD_SEQ_IMPUTACAO_PARCELAMENTO");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INCLUSAO")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPagamentoParcela)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DT_PAGAMENTO_PARCELA");

                entity.Property(e => e.DtVencimeno)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DT_VENCIMENO");

                entity.Property(e => e.NuAutoInfracao).HasColumnName("NU_AUTO_INFRACAO");

                entity.Property(e => e.NuParcela).HasColumnName("NU_PARCELA");

                entity.Property(e => e.QtDiasAtraso).HasColumnName("QT_DIAS_ATRASO");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SQ_DOCUMENTO");

                entity.Property(e => e.SqParcelamento).HasColumnName("SQ_PARCELAMENTO");

                entity.Property(e => e.StProcessado).HasColumnName("ST_PROCESSADO");

                entity.Property(e => e.VlAmortizacao)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_AMORTIZACAO");

                entity.Property(e => e.VlAtualizado)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_ATUALIZADO");

                entity.Property(e => e.VlHistorico)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_HISTORICO");

                entity.Property(e => e.VlImputacao)
                    .HasColumnType("numeric(13, 9)")
                    .HasColumnName("VL_IMPUTACAO");

                entity.Property(e => e.VlMaiorAtualizado)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_MAIOR_ATUALIZADO");

                entity.Property(e => e.VlMultaMora)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_MULTA_MORA");

                entity.Property(e => e.VlPagamentoParcela)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_PAGAMENTO_PARCELA");

                entity.Property(e => e.VlPrincipal)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_PRINCIPAL");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_RESIDUAL");

                entity.Property(e => e.VlSelicAtualizado)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_SELIC_ATUALIZADO");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithMany(p => p.TbImputacaoParcelamentos)
                    .HasForeignKey(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCUMENTO_IMPUTACAO_SQ_DOC");

                entity.HasOne(d => d.SqParcelamentoNavigation)
                    .WithMany(p => p.TbImputacaoParcelamentos)
                    .HasForeignKey(d => d.SqParcelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCUMENTO_IMPUTACAO_SQ_PAR");
            });

            modelBuilder.Entity<TbLicenca>(entity =>
            {
                entity.HasKey(e => e.CdSeqLicenca);

                entity.ToTable("TB_LICENCA");

                entity.HasIndex(e => e.NuLicencaOriginaria, "UK_LICENCA_ORIGINARIA")
                    .IsUnique();

                entity.Property(e => e.CdSeqLicenca).HasColumnName("CD_SEQ_LICENCA");

                entity.Property(e => e.CdEmpresa).HasColumnName("CD_EMPRESA");

                entity.Property(e => e.CdModalidadeTrafego).HasColumnName("CD_MODALIDADE_TRAFEGO");

                entity.Property(e => e.CdPaisDestino).HasColumnName("CD_PAIS_DESTINO");

                entity.Property(e => e.CdPaisOrigem).HasColumnName("CD_PAIS_ORIGEM");

                entity.Property(e => e.CdPaisTransitado).HasColumnName("CD_PAIS_TRANSITADO");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DS_OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsTipoCarga)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DS_TIPO_CARGA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_CADASTRO");

                entity.Property(e => e.DtCancelamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_CANCELAMENTO");

                entity.Property(e => e.DtEmissaoLicenca)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_EMISSAO_LICENCA");

                entity.Property(e => e.DtVencimentoLicenca)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCIMENTO_LICENCA");

                entity.Property(e => e.NoAutoridadeEmiteLicenca)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NO_AUTORIDADE_EMITE_LICENCA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NuLicencaOriginaria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NU_LICENCA_ORIGINARIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StLicencaCancelada).HasColumnName("ST_LICENCA_CANCELADA");

                entity.HasOne(d => d.CdEmpresaNavigation)
                    .WithMany(p => p.TbLicencas)
                    .HasForeignKey(d => d.CdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_TB_EMPRESA");

                entity.HasOne(d => d.CdModalidadeTrafegoNavigation)
                    .WithMany(p => p.TbLicencas)
                    .HasForeignKey(d => d.CdModalidadeTrafego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_TB_MODALIDADE_TRAFEGO");

                entity.HasOne(d => d.CdPaisDestinoNavigation)
                    .WithMany(p => p.TbLicencaCdPaisDestinoNavigations)
                    .HasForeignKey(d => d.CdPaisDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_TB_PAIS1");

                entity.HasOne(d => d.CdPaisOrigemNavigation)
                    .WithMany(p => p.TbLicencaCdPaisOrigemNavigations)
                    .HasForeignKey(d => d.CdPaisOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_TB_PAIS");

                entity.HasOne(d => d.CdPaisTransitadoNavigation)
                    .WithMany(p => p.TbLicencaCdPaisTransitadoNavigations)
                    .HasForeignKey(d => d.CdPaisTransitado)
                    .HasConstraintName("FK_TB_LICENCA_TB_PAIS2");
            });

            modelBuilder.Entity<TbLicencaComplementar>(entity =>
            {
                entity.HasKey(e => e.CdSeqLicencaComplementar);

                entity.ToTable("TB_LICENCA_COMPLEMENTAR");

                entity.HasIndex(e => e.NuLicencaComplementar, "LICENCA_COMPLEMENTAR")
                    .IsUnique();

                entity.Property(e => e.CdSeqLicencaComplementar).HasColumnName("CD_SEQ_LICENCA_COMPLEMENTAR");

                entity.Property(e => e.CdLicencaOriginaria).HasColumnName("CD_LICENCA_ORIGINARIA");

                entity.Property(e => e.CdPaisDestino).HasColumnName("CD_PAIS_DESTINO");

                entity.Property(e => e.CdPaisOrigem).HasColumnName("CD_PAIS_ORIGEM");

                entity.Property(e => e.CdPaisTransitado).HasColumnName("CD_PAIS_TRANSITADO");

                entity.Property(e => e.CdRepresentante).HasColumnName("CD_REPRESENTANTE");

                entity.Property(e => e.CdTipoLicencaComp).HasColumnName("CD_TIPO_LICENCA_COMP");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DS_OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DtCancelamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_CANCELAMENTO");

                entity.Property(e => e.DtEmissaoLicenca)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_EMISSAO_LICENCA");

                entity.Property(e => e.DtVencimentoLicenca)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCIMENTO_LICENCA");

                entity.Property(e => e.NoAutoridadeEmiteLicenca)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NO_AUTORIDADE_EMITE_LICENCA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NuLicencaComplementar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NU_LICENCA_COMPLEMENTAR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StLicencaCancelada).HasColumnName("ST_LICENCA_CANCELADA");

                entity.HasOne(d => d.CdLicencaOriginariaNavigation)
                    .WithMany(p => p.TbLicencaComplementars)
                    .HasForeignKey(d => d.CdLicencaOriginaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_COMPLEMENTAR_TB_LICENCA");

                entity.HasOne(d => d.CdPaisDestinoNavigation)
                    .WithMany(p => p.TbLicencaComplementarCdPaisDestinoNavigations)
                    .HasForeignKey(d => d.CdPaisDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_COMPLEMENTAR_TB_PAIS1");

                entity.HasOne(d => d.CdPaisOrigemNavigation)
                    .WithMany(p => p.TbLicencaComplementarCdPaisOrigemNavigations)
                    .HasForeignKey(d => d.CdPaisOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_COMPLEMENTAR_TB_PAIS");

                entity.HasOne(d => d.CdPaisTransitadoNavigation)
                    .WithMany(p => p.TbLicencaComplementarCdPaisTransitadoNavigations)
                    .HasForeignKey(d => d.CdPaisTransitado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_COMPLEMENTAR_TB_PAIS2");

                entity.HasOne(d => d.CdRepresentanteNavigation)
                    .WithMany(p => p.TbLicencaComplementars)
                    .HasForeignKey(d => d.CdRepresentante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_COMPLEMENTAR_TB_REPRESENTANTE_EMPRESA");

                entity.HasOne(d => d.CdTipoLicencaCompNavigation)
                    .WithMany(p => p.TbLicencaComplementars)
                    .HasForeignKey(d => d.CdTipoLicencaComp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LICENCA_COMPLEMENTAR_TB_TIPO_LICENCA_COMPLEMENTAR");
            });

            modelBuilder.Entity<TbLogExecSeresaExclusao>(entity =>
            {
                entity.HasKey(e => e.CdSeqLogSerasaExclusao)
                    .HasName("PK__TB_LOG_E__23652417F8B4D0DA");

                entity.ToTable("TB_LOG_EXEC_SERESA_EXCLUSAO");

                entity.Property(e => e.CdSeqLogSerasaExclusao).HasColumnName("CD_SEQ_LOG_SERASA_EXCLUSAO");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DsMensagem)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DS_MENSAGEM");

                entity.Property(e => e.DtRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_REGISTRO");

                entity.Property(e => e.IddocumentoSgm).HasColumnName("IDDocumentoSGM");

                entity.Property(e => e.IddocumentoSismultas).HasColumnName("IDDocumentoSismultas");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.SqSerasaDocumento).HasColumnName("sq_serasa_documento");
            });

            modelBuilder.Entity<TbModalidadeTrafego>(entity =>
            {
                entity.HasKey(e => e.CdSeqModalidadeTrafego);

                entity.ToTable("TB_MODALIDADE_TRAFEGO");

                entity.Property(e => e.CdSeqModalidadeTrafego).HasColumnName("CD_SEQ_MODALIDADE_TRAFEGO");

                entity.Property(e => e.DsModalidadeTrafego)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DS_MODALIDADE_TRAFEGO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbPai>(entity =>
            {
                entity.HasKey(e => e.CodSeqPais);

                entity.ToTable("TB_PAIS");

                entity.Property(e => e.CodSeqPais).HasColumnName("COD_SEQ_PAIS");

                entity.Property(e => e.NoPais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NO_PAIS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SgPais)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SG_PAIS")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbPostagemStatus>(entity =>
            {
                entity.HasKey(e => e.CdSeqPostagemStatus)
                    .HasName("PK_TBL_POSTAGEM_STATUS");

                entity.ToTable("TB_POSTAGEM_STATUS");

                entity.Property(e => e.CdSeqPostagemStatus).HasColumnName("CD_SEQ_POSTAGEM_STATUS");

                entity.Property(e => e.CdObjeto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CD_OBJETO");

                entity.Property(e => e.DsEtiquetaObjeto)
                    .IsUnicode(false)
                    .HasColumnName("DS_ETIQUETA_OBJETO");

                entity.Property(e => e.DsEtiquetaPostagem)
                    .IsUnicode(false)
                    .HasColumnName("DS_ETIQUETA_POSTAGEM");

                entity.Property(e => e.DtEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ENTREGA");

                entity.Property(e => e.DtPostagem)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_POSTAGEM");

                entity.Property(e => e.ImAvisoRecebimento).HasColumnName("IM_AVISO_RECEBIMENTO");

                entity.Property(e => e.StPostagem).HasColumnName("ST_POSTAGEM");

                entity.Property(e => e.TpIncosistencia).HasColumnName("TP_INCOSISTENCIA");
            });

            modelBuilder.Entity<TbProprietario>(entity =>
            {
                entity.HasKey(e => e.CdSeqProprietario);

                entity.ToTable("TB_PROPRIETARIO");

                entity.Property(e => e.CdSeqProprietario).HasColumnName("CD_SEQ_PROPRIETARIO");

                entity.Property(e => e.CdVeiculo).HasColumnName("CD_VEICULO");

                entity.Property(e => e.NoProprietario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NO_PROPRIETARIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NoRegistroProprietario)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NO_REGISTRO_PROPRIETARIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.CdVeiculoNavigation)
                    .WithMany(p => p.TbProprietarios)
                    .HasForeignKey(d => d.CdVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PROPR_REFERENCE_TB_VEICU");
            });

            modelBuilder.Entity<TbRepresentanteEmpresa>(entity =>
            {
                entity.HasKey(e => e.CdSeqRepresentante);

                entity.ToTable("TB_REPRESENTANTE_EMPRESA");

                entity.HasIndex(e => e.NuRegistroRepresentante, "UK_REPRESENTANTE_EMPRESA")
                    .IsUnique();

                entity.Property(e => e.CdSeqRepresentante).HasColumnName("CD_SEQ_REPRESENTANTE");

                entity.Property(e => e.CdSeqEmpresa).HasColumnName("CD_SEQ_EMPRESA");

                entity.Property(e => e.CodSeqPais).HasColumnName("COD_SEQ_PAIS");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DS_EMAIL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsUfRepresentante)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DS_UF_REPRESENTANTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_CADASTRO");

                entity.Property(e => e.DtVencimentoMandato)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCIMENTO_MANDATO");

                entity.Property(e => e.NoRepresentante)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NO_REPRESENTANTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NuRegistroRepresentante)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NU_REGISTRO_REPRESENTANTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NuTelefone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NU_TELEFONE");

                entity.Property(e => e.StAtivo).HasColumnName("ST_ATIVO");

                entity.HasOne(d => d.CdSeqEmpresaNavigation)
                    .WithMany(p => p.TbRepresentanteEmpresas)
                    .HasForeignKey(d => d.CdSeqEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_REPRESENTANTE_EMPRESA_TB_EMPRESA");

                entity.HasOne(d => d.CodSeqPaisNavigation)
                    .WithMany(p => p.TbRepresentanteEmpresas)
                    .HasForeignKey(d => d.CodSeqPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_REPRESENTANTE_EMPRESA_TB_PAIS");
            });

            modelBuilder.Entity<TbTipoInsercaoVeiculo>(entity =>
            {
                entity.HasKey(e => e.CdSeqTipoInsercao);

                entity.ToTable("TB_TIPO_INSERCAO_VEICULO");

                entity.Property(e => e.CdSeqTipoInsercao)
                    .ValueGeneratedNever()
                    .HasColumnName("CD_SEQ_TIPO_INSERCAO");

                entity.Property(e => e.DsTipoInsercao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DS_TIPO_INSERCAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbTipoLicencaComplementar>(entity =>
            {
                entity.HasKey(e => e.CdSeqTipoLicenComplementar);

                entity.ToTable("TB_TIPO_LICENCA_COMPLEMENTAR");

                entity.Property(e => e.CdSeqTipoLicenComplementar).HasColumnName("CD_SEQ_TIPO_LICEN_COMPLEMENTAR");

                entity.Property(e => e.DsTipoLicencaComplementar)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DS_TIPO_LICENCA_COMPLEMENTAR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbTipoPagamento>(entity =>
            {
                entity.HasKey(e => e.CdTipoPagamento)
                    .HasName("PK__TB_TIPO___A6DCE6036BEB4121");

                entity.ToTable("TB_TIPO_PAGAMENTO");

                entity.Property(e => e.CdTipoPagamento)
                    .ValueGeneratedNever()
                    .HasColumnName("CD_TIPO_PAGAMENTO");

                entity.Property(e => e.DsTipoPagamento)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DS_TIPO_PAGAMENTO");

                entity.Property(e => e.DtIncluso)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INCLUSO");

                entity.Property(e => e.NoTipoPagamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NO_TIPO_PAGAMENTO");
            });

            modelBuilder.Entity<TbUltimoMovimentoFinanceiro>(entity =>
            {
                entity.HasKey(e => e.CdSeqUltimoMovimentoFinanceiro)
                    .HasName("PK_ULTIMO_MOVIMENTO_FINANCEIRO");

                entity.ToTable("TB_ULTIMO_MOVIMENTO_FINANCEIRO");

                entity.HasComment("Entidade respnsável por armazenar dados do ultimo movimento financeiro da tabela tbl_financeira. Dados mantidos através da trigger TAI_ULTIMO_MOVIMENTO_FINANCEITO");

                entity.Property(e => e.CdSeqUltimoMovimentoFinanceiro)
                    .HasColumnName("CD_SEQ_ULTIMO_MOVIMENTO_FINANCEIRO")
                    .HasComment("Código sequencial da tabela TB_ULTIMO_MOVIMENTO_FINANCEIRO (PK)");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem")
                    .HasComment("código da chave do documento de origem - - tbl_documento");

                entity.Property(e => e.DescricaoSituacaoMultas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DescricaoSituacao_MULTAS");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ALTERACAO")
                    .HasComment("Data da alteração do registro na tabela");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INCLUSAO")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Data da inclusão do registro na tabela");

                entity.Property(e => e.IdsituacaoMultas).HasColumnName("IDSituacao_MULTAS");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao")
                    .HasComment("número do auto de infração - tbl_documento");

                entity.Property(e => e.NrOrdemDocumentoEnvio)
                    .HasColumnName("nr_ordem_documento_envio")
                    .HasComment("Parte da chave primária da tabela tbl_financeira\r\n   sq_documento ,nr_ordem_documento_envio ,nr_ordem_financeira");

                entity.Property(e => e.NrOrdemFinanceira)
                    .HasColumnName("nr_ordem_financeira")
                    .HasComment("Parte da chave primária da tabela tbl_financeira\r\n   sq_documento ,nr_ordem_documento_envio ,nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento")
                    .HasComment("PK da tabela tbl_documento - (ultimo registro da tabela para o auto)\r\n    \r\n   Parte da chave primária da tabela tbl_financeira\r\n   sq_documento ,nr_ordem_documento_envio ,nr_ordem_financeira");

                entity.Property(e => e.SqFaseDocumento)
                    .HasColumnName("sq_fase_documento")
                    .HasComment("Número sequencial da ultima fase  do documento  - tbl_documento");

                entity.Property(e => e.SqTipoDocumento)
                    .HasColumnName("sq_tipo_documento")
                    .HasComment("Número sequencial do ultimo tipo do documento - tbl_documento");

                entity.Property(e => e.StExcluido)
                    .HasColumnName("ST_EXCLUIDO")
                    .HasComment("Situação do registro na tabela tbl_financeira; 1 - Excluído, 0 - Não excluído (ativo)");
            });

            modelBuilder.Entity<TbVeiculo>(entity =>
            {
                entity.HasKey(e => e.CdSeqVeiculo);

                entity.ToTable("TB_VEICULO");

                entity.HasIndex(e => new { e.NoPlaca, e.NuChassi }, "UN_PLACA_CHASSI")
                    .IsUnique();

                entity.Property(e => e.CdSeqVeiculo).HasColumnName("CD_SEQ_VEICULO");

                entity.Property(e => e.CdProprietario).HasColumnName("CD_PROPRIETARIO");

                entity.Property(e => e.CdTipoCarroceria).HasColumnName("CD_TIPO_CARROCERIA");

                entity.Property(e => e.CdTipoVeiculo).HasColumnName("CD_TIPO_VEICULO");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DS_OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsTipoEixo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DS_TIPO_EIXO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_CADASTRO");

                entity.Property(e => e.NoMarca)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NO_MARCA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NoPlaca)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NO_PLACA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NuAnoFabricacao).HasColumnName("NU_ANO_FABRICACAO");

                entity.Property(e => e.NuChassi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NU_CHASSI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.QtEixo).HasColumnName("QT_EIXO");

                entity.Property(e => e.QtPbt)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("QT_PBT");

                entity.Property(e => e.StCabineDormitorio).HasColumnName("ST_CABINE_DORMITORIO");

                entity.Property(e => e.StVeiculoProprio).HasColumnName("ST_VEICULO_PROPRIO");

                entity.HasOne(d => d.CdTipoCarroceriaNavigation)
                    .WithMany(p => p.TbVeiculos)
                    .HasForeignKey(d => d.CdTipoCarroceria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_VEICULO_TB_CARROCERIA");

                entity.HasOne(d => d.CdTipoVeiculoNavigation)
                    .WithMany(p => p.TbVeiculos)
                    .HasForeignKey(d => d.CdTipoVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_VEICULO_TB_TIPO_VEICULO");
            });

            modelBuilder.Entity<TblAr>(entity =>
            {
                entity.HasKey(e => e.SqAr)
                    .HasName("PK__tbl_ar__1D4655FB");

                entity.ToTable("tbl_ar");

                entity.HasIndex(e => e.CoUsuario, "XIF14tbl_ar")
                    .HasFillFactor(50);

                entity.Property(e => e.SqAr)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_ar");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaCadastroAr)
                    .HasColumnType("datetime")
                    .HasColumnName("da_cadastro_ar");

                entity.Property(e => e.NrAtualAr)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nr_atual_ar");

                entity.Property(e => e.NrLimiteFinalAr)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nr_limite_final_ar");

                entity.Property(e => e.NrLimiteInicialAr)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nr_limite_inicial_ar");

                entity.Property(e => e.SgPrefixo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_prefixo");

                entity.Property(e => e.SgSufixo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_sufixo");

                entity.Property(e => e.StAr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_ar")
                    .IsFixedLength();

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.TblArs)
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_ar__co_usuar__0C90CB45");
            });

            modelBuilder.Entity<TblArquivoAr>(entity =>
            {
                entity.HasKey(e => e.SqArquivoAr);

                entity.ToTable("tbl_arquivo_ar");

                entity.Property(e => e.SqArquivoAr).HasColumnName("sq_arquivo_ar");

                entity.Property(e => e.FlgLeituraFinalizada).HasColumnName("flg_leitura_finalizada");

                entity.Property(e => e.NoArquivoAr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_arquivo_ar");
            });

            modelBuilder.Entity<TblArquivoRetornoBancario>(entity =>
            {
                entity.HasKey(e => e.IdArquivo)
                    .HasName("PK__tbl_arqu__F5CD27A228E0DF09");

                entity.ToTable("tbl_arquivo_retorno_bancario");

                entity.Property(e => e.IdArquivo).HasColumnName("id_arquivo");

                entity.Property(e => e.DsLogBaixaArquivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ds_log_baixa_arquivo");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_inclusao");

                entity.Property(e => e.DtProcessamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_processamento");

                entity.Property(e => e.NoArquivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_arquivo");

                entity.Property(e => e.NuConvenio)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nu_convenio");

                entity.Property(e => e.NuSequencialArquivo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nu_sequencial_arquivo");

                entity.Property(e => e.StErroProcessamento).HasColumnName("st_erro_processamento");

                entity.Property(e => e.StProcessar).HasColumnName("st_processar");

                entity.Property(e => e.StReprocessar).HasColumnName("st_reprocessar");
            });

            modelBuilder.Entity<TblArquivoRetornoBancarioCabecalho>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_arquivo_retorno_bancario_cabecalhos");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_inclusao");

                entity.Property(e => e.IdArquivo).HasColumnName("id_arquivo");

                entity.Property(e => e.NoArquivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_arquivo");

                entity.Property(e => e.NoLinha)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_linha");

                entity.HasOne(d => d.IdArquivoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdArquivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbl_arquivo_retorno_bancario_cabecalhos_id_arquivo");
            });

            modelBuilder.Entity<TblArquivoRetornoBancarioLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_arquivo_retorno_bancario_log");

                entity.Property(e => e.CdSeqLog)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cd_seq_log");

                entity.Property(e => e.DaLog)
                    .HasColumnType("datetime")
                    .HasColumnName("da_log");

                entity.Property(e => e.DsLog)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ds_log");
            });

            modelBuilder.Entity<TblArquivoRetornoBancarioRegistro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_arquivo_retorno_bancario_registros");

                entity.Property(e => e.AaSequencialRetorno)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("aa_sequencial_retorno");

                entity.Property(e => e.Branco01)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("branco01");

                entity.Property(e => e.Branco02)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branco02");

                entity.Property(e => e.Branco03)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("branco03");

                entity.Property(e => e.Branco04)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("branco04");

                entity.Property(e => e.Branco05)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("branco05");

                entity.Property(e => e.CanalPagamento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("canal_pagamento");

                entity.Property(e => e.Carteira)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("carteira");

                entity.Property(e => e.CdBancoRecebedor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cd_banco_recebedor");

                entity.Property(e => e.Comando)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("comando");

                entity.Property(e => e.ContaCaucao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("conta_caucao");

                entity.Property(e => e.DsLogBaixaRegistro)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ds_log_baixa_registro");

                entity.Property(e => e.DtCredito)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("dt_credito");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_inclusao");

                entity.Property(e => e.DtLiquidacao)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("dt_liquidacao");

                entity.Property(e => e.DtLoteBanco)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("dt_lote_banco");

                entity.Property(e => e.DtVencimento)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("dt_vencimento");

                entity.Property(e => e.DvContaCorrente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dv_conta_corrente");

                entity.Property(e => e.DvPrefixoAgencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dv_prefixo_agencia");

                entity.Property(e => e.DvPrefixoAgenciaRecebedora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dv_prefixo_agencia_recebedora");

                entity.Property(e => e.EspecieTitulo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("especie_titulo");

                entity.Property(e => e.IdArquivo).HasColumnName("id_arquivo");

                entity.Property(e => e.IdRegistro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("id_registro");

                entity.Property(e => e.IndicadorValor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("indicador_valor");

                entity.Property(e => e.IndicativoAutorizacaoLiquidacaoParcial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("indicativo_autorizacao_liquidacao_parcial");

                entity.Property(e => e.IndicativoDebitoCredito)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("indicativo_debito_credito");

                entity.Property(e => e.NaturezaRecebimento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("natureza_recebimento");

                entity.Property(e => e.NoSistema)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_sistema");

                entity.Property(e => e.NuContaCorrente)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nu_conta_corrente");

                entity.Property(e => e.NuControleParticipante)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nu_controle_participante");

                entity.Property(e => e.NuConvenio)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("nu_convenio");

                entity.Property(e => e.NuConvenioCobranca)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("nu_convenio_cobranca");

                entity.Property(e => e.NuDiasCalculo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("nu_dias_calculo");

                entity.Property(e => e.NuNossoNumero)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nu_nosso_numero");

                entity.Property(e => e.NuPrefixoAgencia)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("nu_prefixo_agencia");

                entity.Property(e => e.NuPrefixoAgenciaRecebedora)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("nu_prefixo_agencia_recebedora");

                entity.Property(e => e.NuPrefixoTitulo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("nu_prefixo_titulo");

                entity.Property(e => e.NuSequencialArquivo)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("nu_sequencial_arquivo");

                entity.Property(e => e.NuSequencialRetorno)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nu_sequencial_retorno");

                entity.Property(e => e.NuTituloCedente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nu_titulo_cedente");

                entity.Property(e => e.SequencialRegistro)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sequencial_registro");

                entity.Property(e => e.StErroProcessamento).HasColumnName("st_erro_processamento");

                entity.Property(e => e.StProcessado).HasColumnName("st_processado");

                entity.Property(e => e.StReprocessar)
                    .HasColumnName("st_reprocessar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxaDesconto)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("taxa_desconto");

                entity.Property(e => e.TaxaIof)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("taxa_iof");

                entity.Property(e => e.TpCobranca)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tp_cobranca");

                entity.Property(e => e.TpCobrancaEspecifico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tp_cobranca_especifico");

                entity.Property(e => e.VariacaoCarteira)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("variacao_carteira");

                entity.Property(e => e.VlAbatimento)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_abatimento");

                entity.Property(e => e.VlAbatimentoNaoAproveitado)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_abatimento_nao_aproveitado");

                entity.Property(e => e.VlAjuste)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("vl_ajuste");

                entity.Property(e => e.VlDescontoConcedido)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_desconto_concedido");

                entity.Property(e => e.VlIofDesconto)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_iof_desconto");

                entity.Property(e => e.VlJuroMora)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_juro_mora");

                entity.Property(e => e.VlJurosDesconto)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_juros_desconto");

                entity.Property(e => e.VlLancamento)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_lancamento");

                entity.Property(e => e.VlOutrasDespesas)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_outras_despesas");

                entity.Property(e => e.VlOutrosRecebimentos)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_outros_recebimentos");

                entity.Property(e => e.VlParcialRecebido)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_parcial_recebido");

                entity.Property(e => e.VlTarifa)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("vl_tarifa");

                entity.Property(e => e.VlTitulo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("vl_titulo");

                entity.Property(e => e.Zero01)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("zero01");

                entity.Property(e => e.Zero02)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("zero02");

                entity.Property(e => e.Zero03)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("zero03");

                entity.Property(e => e.Zero04)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("zero04");

                entity.Property(e => e.Zero05)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("zero05");

                entity.Property(e => e.Zero06)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("zero06");

                entity.Property(e => e.Zero07)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("zero07");

                entity.Property(e => e.Zero08)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("zero08");

                entity.HasOne(d => d.IdArquivoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdArquivo)
                    .HasConstraintName("fk_tbl_arquivo_retorno_bancario_registros_id_arquivo");
            });

            modelBuilder.Entity<TblArquivoRetornoBancarioRodape>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_arquivo_retorno_bancario_rodapes");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_inclusao");

                entity.Property(e => e.IdArquivo).HasColumnName("id_arquivo");

                entity.Property(e => e.NoArquivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_arquivo");

                entity.Property(e => e.NoLinha)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_linha");

                entity.HasOne(d => d.IdArquivoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdArquivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbl_arquivo_retorno_bancario_rodapes_id_arquivo");
            });

            modelBuilder.Entity<TblArquivoRetornoBancarioTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_arquivo_retorno_bancario_temp");

                entity.Property(e => e.NoArquivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_arquivo");

                entity.Property(e => e.Registro)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REGISTRO");
            });

            modelBuilder.Entity<TblArquivoRetornoComando>(entity =>
            {
                entity.HasKey(e => e.IdComandoBaixa)
                    .HasName("PK__tbl_arqu__927579B87FA265D1");

                entity.ToTable("tbl_arquivo_retorno_comando");

                entity.Property(e => e.IdComandoBaixa).HasColumnName("id_comando_baixa");

                entity.Property(e => e.CdComando)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cd_comando")
                    .IsFixedLength();

                entity.Property(e => e.DsComando)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_comando");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_inclusao");
            });

            modelBuilder.Entity<TblArquivoRetornoTemp>(entity =>
            {
                entity.ToTable("tbl_arquivo_retorno_temp");

                entity.Property(e => e.NoArquivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_arquivo");

                entity.Property(e => e.NoLinha)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_linha");

                entity.Property(e => e.TpLinha).HasColumnName("tp_linha");
            });

            modelBuilder.Entity<TblAtit>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_atit__4DB4832C");

                entity.ToTable("tbl_atit");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.DsMotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_indeferimento");

                entity.Property(e => e.NoAutuadoReal)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado_real");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMotorista)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("no_motorista");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoMunicipioPlacaVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_placa_veiculo");

                entity.Property(e => e.NoPaisOrigem)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("no_pais_origem");

                entity.Property(e => e.NoPaisPlacaVeiculo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("no_pais_placa_veiculo");

                entity.Property(e => e.NrAnoLicencaOriginariaComplementar).HasColumnName("nr_ano_licenca_originaria_complementar");

                entity.Property(e => e.NrChassiVeiculo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_chassi_veiculo");

                entity.Property(e => e.NrCnhMotorista)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnh_motorista");

                entity.Property(e => e.NrCpfMotorista)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_motorista");

                entity.Property(e => e.NrCrntrc)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_crntrc");

                entity.Property(e => e.NrLicencaOriginariaComplementar)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("nr_licenca_originaria_complementar");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblAtit)
                    .HasForeignKey<TblAtit>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_atit__sq_doc__0D84EF7E");
            });

            modelBuilder.Entity<TblBaixaDivergencium>(entity =>
            {
                entity.HasKey(e => e.SqBaixaDivergencia)
                    .HasName("PK93");

                entity.ToTable("tbl_baixa_divergencia");

                entity.Property(e => e.SqBaixaDivergencia).HasColumnName("sq_baixa_divergencia");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaBaixaDivergencia)
                    .HasColumnType("datetime")
                    .HasColumnName("da_baixa_divergencia");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.TxObservacao)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("tx_observacao");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.TblBaixaDivergencia)
                    .HasForeignKey(d => d.CoUsuario)
                    .HasConstraintName("FK__tbl_baixa__co_us__5614BF03");

                entity.HasOne(d => d.TblFinanceira)
                    .WithMany(p => p.TblBaixaDivergencia)
                    .HasForeignKey(d => new { d.SqDocumento, d.NrOrdemDocumentoEnvio, d.NrOrdemFinanceira })
                    .HasConstraintName("FK__tbl_baixa_diverg__57FD0775");
            });

            modelBuilder.Entity<TblBoletoControle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_boleto_controle");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoRecolhimento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_recolhimento");

                entity.Property(e => e.CoTipoDocumento).HasColumnName("co_tipo_documento");

                entity.Property(e => e.CoVariacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_variacao");

                entity.Property(e => e.CpfCnpjSacado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ_Sacado");

                entity.Property(e => e.DataDocumento)
                    .HasColumnType("datetime")
                    .HasColumnName("data_documento");

                entity.Property(e => e.DataLimite)
                    .HasColumnType("datetime")
                    .HasColumnName("data_limite");

                entity.Property(e => e.DataLimiteDesconto)
                    .HasColumnType("datetime")
                    .HasColumnName("data_limite_desconto");

                entity.Property(e => e.DataRegistroBb)
                    .HasColumnType("datetime")
                    .HasColumnName("data_registro_bb");

                entity.Property(e => e.DescricaoRegistro)
                    .IsUnicode(false)
                    .HasColumnName("descricao_registro");

                entity.Property(e => e.Endereco)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.IndicadorPessoa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("indicador_pessoa")
                    .IsFixedLength();

                entity.Property(e => e.NomeSacado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome_sacado");

                entity.Property(e => e.NrCodigoBarras)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nr_codigo_barras");

                entity.Property(e => e.NrConvenio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_convenio");

                entity.Property(e => e.NrLinhaDigitavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nr_linha_digitavel");

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.SqBoleto)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_boleto");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.StBoleto).HasColumnName("st_boleto");

                entity.Property(e => e.StPagamento).HasColumnName("st_pagamento");

                entity.Property(e => e.StringGeracaoBoleto1)
                    .IsUnicode(false)
                    .HasColumnName("string_geracao_boleto1");

                entity.Property(e => e.StringGeracaoBoleto2)
                    .IsUnicode(false)
                    .HasColumnName("string_geracao_boleto2");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf")
                    .IsFixedLength();

                entity.Property(e => e.ValorDivida)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("valor_divida");
            });

            modelBuilder.Entity<TblCodigoLog>(entity =>
            {
                entity.HasKey(e => e.CoLog)
                    .HasName("PK__tbl_codigo_log__047AA831");

                entity.ToTable("tbl_codigo_log");

                entity.Property(e => e.CoLog)
                    .ValueGeneratedNever()
                    .HasColumnName("co_log");

                entity.Property(e => e.DsLog)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_log");
            });

            modelBuilder.Entity<TblComandoPagamentoBaixa>(entity =>
            {
                entity.HasKey(e => e.IdComandoBaixa)
                    .HasName("PK__tbl_coma__927579B8EF27C785");

                entity.ToTable("tbl_comando_pagamento_baixa");

                entity.Property(e => e.IdComandoBaixa).HasColumnName("id_comando_baixa");

                entity.Property(e => e.CdComando)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cd_comando")
                    .IsFixedLength();

                entity.Property(e => e.DsComando)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_comando");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_inclusao");
            });

            modelBuilder.Entity<TblControleProcessamento>(entity =>
            {
                entity.HasKey(e => e.SqControleProcessamento)
                    .HasName("pk_tbl_controle_processamento")
                    .IsClustered(false);

                entity.ToTable("tbl_controle_processamento");

                entity.Property(e => e.SqControleProcessamento).HasColumnName("sq_controle_processamento");

                entity.Property(e => e.CoIndicadorReprocessamento).HasColumnName("co_indicador_reprocessamento");

                entity.Property(e => e.CoTipoArquivo).HasColumnName("co_tipo_arquivo");

                entity.Property(e => e.NrAnoLote).HasColumnName("nr_ano_lote");

                entity.Property(e => e.NrDocumentosLote).HasColumnName("nr_documentos_lote");

                entity.Property(e => e.NrLote).HasColumnName("nr_lote");
            });

            modelBuilder.Entity<TblConvenio>(entity =>
            {
                entity.HasKey(e => e.SqConvenio)
                    .HasName("PK__tbl_conv__59918EB2BB2F519B");

                entity.ToTable("tbl_convenio");

                entity.Property(e => e.SqConvenio).HasColumnName("sq_convenio");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira");

                entity.Property(e => e.CoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_contrato");

                entity.Property(e => e.CoConvenio)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_convenio");

                entity.Property(e => e.CoRecolhimento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_recolhimento");

                entity.Property(e => e.DsConvenio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ds_convenio");
            });

            modelBuilder.Entity<TblConvenioRecolhimentoBb>(entity =>
            {
                entity.HasKey(e => e.IdConvenioRecolhimento);

                entity.ToTable("tbl_convenio_recolhimentoBB");

                entity.Property(e => e.IdConvenioRecolhimento).HasColumnName("id_convenio_recolhimento");

                entity.Property(e => e.Carteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("carteira")
                    .IsFixedLength();

                entity.Property(e => e.DsModal)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ds_modal");

                entity.Property(e => e.NoAutuador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuador");

                entity.Property(e => e.NuConvenio)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("nu_convenio");

                entity.Property(e => e.NuRecolhimento)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("nu_recolhimento");
            });

            modelBuilder.Entity<TblDepositoJudicial>(entity =>
            {
                entity.HasKey(e => e.SqDepositoJudicial)
                    .HasName("PK_deposito_judicial01");

                entity.ToTable("tbl_deposito_judicial");

                entity.HasIndex(e => e.SqDocumento, "in_deposito_judicial_sq_documento");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.HasOne(d => d.TblFinanceira)
                    .WithMany(p => p.TblDepositoJudicials)
                    .HasForeignKey(d => new { d.SqDocumento, d.NrOrdemDocumentoEnvio, d.NrOrdemFinanceira })
                    .HasConstraintName("FK_tbl_deposito_judicial_tbl_financeira01");
            });

            modelBuilder.Entity<TblDetalheVisao>(entity =>
            {
                entity.HasKey(e => e.SqDetalheVisao)
                    .HasName("PK__tbl_detalhe_visa__3F9B6DFF");

                entity.ToTable("tbl_detalhe_visao");

                entity.Property(e => e.SqDetalheVisao).HasColumnName("sq_detalhe_visao");

                entity.Property(e => e.CoDetalheVisao).HasColumnName("co_detalhe_visao");

                entity.Property(e => e.DsDetalheVisao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_detalhe_visao");

                entity.Property(e => e.SqVisao).HasColumnName("sq_visao");

                entity.HasOne(d => d.SqVisaoNavigation)
                    .WithMany(p => p.TblDetalheVisaos)
                    .HasForeignKey(d => d.SqVisao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_detal__sq_vi__0F6D37F0");

                entity.HasMany(d => d.SqTipoDocumentos)
                    .WithMany(p => p.SqDetalheVisaos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TblDetalhevisaoTipodocumento",
                        l => l.HasOne<TblTipoDocumento>().WithMany().HasForeignKey("SqTipoDocumento").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__tbl_detal__sq_ti__11558062"),
                        r => r.HasOne<TblDetalheVisao>().WithMany().HasForeignKey("SqDetalheVisao").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__tbl_detal__sq_de__10615C29"),
                        j =>
                        {
                            j.HasKey("SqDetalheVisao", "SqTipoDocumento").HasName("PK__tbl_detalhevisao__436BFEE3");

                            j.ToTable("tbl_detalhevisao_tipodocumento");

                            j.IndexerProperty<int>("SqDetalheVisao").HasColumnName("sq_detalhe_visao");

                            j.IndexerProperty<int>("SqTipoDocumento").HasColumnName("sq_tipo_documento");
                        });
            });

            modelBuilder.Entity<TblDocumento>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_documento__27F8EE98");

                entity.ToTable("tbl_documento");

                entity.HasIndex(e => new { e.CoChaveDocumentoOrigem, e.SqFaseDocumento }, "IN_ChaveDocumentoOrigemFaseDocumento");

                entity.HasIndex(e => e.CoChaveDocumentoOrigem, "IN_tbl_documento_co_chave_documento_origem")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.NrAutoInfracao, "IN_tbl_documento_nr_auto_infracao")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqFaseDocumento, "IN_tbl_documento_sq_fase_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqTipoDocumento, "IN_tbl_documento_sq_tipo_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.NrCnpjAutuado, "IX_tbl_documento_nr_cnpj_autuado");

                entity.HasIndex(e => e.CoChaveDocumentoOrigem, "XIE1tbl_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqTipoDocumento, "XIF1tbl_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqFaseDocumento, "XIF2tbl_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqOrgaoAutuador, "XIF3tbl_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SqTipoDocumento, e.SqFaseDocumento }, "XIF4_tbl_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.NrAutoInfracao, "XIF5_tbl_documento")
                    .HasFillFactor(80);

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_documento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoClassificacaoDocumento)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("co_classificacao_documento")
                    .HasDefaultValueSql("('AI')")
                    .IsFixedLength();

                entity.Property(e => e.CoInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("co_infracao");

                entity.Property(e => e.CoVersaoLayout)
                    .HasColumnName("co_versao_layout")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.DaInfracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_infracao");

                entity.Property(e => e.DsAutoridadeAntt)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ds_autoridade_ANTT");

                entity.Property(e => e.DsAutoridadeOrgaoAutuador)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ds_autoridade_Orgao_Autuador");

                entity.Property(e => e.DsLegislacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_legislacao");

                entity.Property(e => e.DsObservacao)
                    .HasColumnType("text")
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.HrInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hr_infracao")
                    .IsFixedLength();

                entity.Property(e => e.IddivisaoOrgaoConveniado).HasColumnName("IDDivisaoOrgaoConveniado");

                entity.Property(e => e.NoDescricaoInfracao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao_infracao");

                entity.Property(e => e.NoLocalidadeInfracao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_localidade_infracao");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrDefesaRecursoResultado).HasColumnName("nr_defesa_recurso_resultado");

                entity.Property(e => e.NrPlacaVeiculo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_placa_veiculo");

                entity.Property(e => e.NrSenhaAcesso).HasColumnName("nr_senha_acesso");

                entity.Property(e => e.NrSubtipo).HasColumnName("nr_subtipo");

                entity.Property(e => e.RadicalCnpj)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RadicalCNPJ");

                entity.Property(e => e.SgUfInfracao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_infracao")
                    .IsFixedLength();

                entity.Property(e => e.SgUfPlacaVeiculo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_placa_veiculo")
                    .IsFixedLength();

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqOrgaoAutuador).HasColumnName("sq_orgao_autuador");

                entity.Property(e => e.SqStDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sq_st_documento");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.StConfissao).HasColumnName("ST_CONFISSAO");

                entity.Property(e => e.StEnviaEct).HasColumnName("ST_ENVIA_ECT");

                entity.HasOne(d => d.SqFaseDocumentoNavigation)
                    .WithMany(p => p.TblDocumentos)
                    .HasForeignKey(d => d.SqFaseDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_docum__sq_fa__2BC97F7C");

                entity.HasOne(d => d.SqOrgaoAutuadorNavigation)
                    .WithMany(p => p.TblDocumentos)
                    .HasForeignKey(d => d.SqOrgaoAutuador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_docum__sq_or__2AD55B43");

                entity.HasOne(d => d.SqTipoDocumentoNavigation)
                    .WithMany(p => p.TblDocumentos)
                    .HasForeignKey(d => d.SqTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_docum__sq_ti__0B47A151");
            });

            modelBuilder.Entity<TblDocumentoEct>(entity =>
            {
                entity.HasKey(e => e.SqDocumentoEct);

                entity.ToTable("tbl_documento_ect");

                entity.Property(e => e.SqDocumentoEct).HasColumnName("sq_documento_ect");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoTipoDocumento).HasColumnName("co_tipo_documento");

                entity.Property(e => e.DsEnvioEct)
                    .IsUnicode(false)
                    .HasColumnName("ds_envio_ect");

                entity.Property(e => e.DtEnvioEct)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_envio_ect");

                entity.Property(e => e.DtRetornoEct)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_retorno_ect");

                entity.Property(e => e.NoLote)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_lote");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NuAr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nu_ar");

                entity.Property(e => e.SqBoleto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_boleto");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.StEnvioEct).HasColumnName("st_envio_ect");
            });

            modelBuilder.Entity<TblDocumentoEnvio>(entity =>
            {
                entity.HasKey(e => new { e.SqDocumento, e.NrOrdemDocumentoEnvio })
                    .HasName("PK__tbl_documento_en__12FDD1B2");

                entity.ToTable("tbl_documento_envio");

                entity.HasIndex(e => new { e.SqDocumento, e.SqLote, e.DaTransmissao, e.DaRetornoCorreio }, "IX_tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.NrSequencialDocumento, e.AaSequencialDocumento }, "XAK2tbl_documento_envio")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.DaGeracao, "XIE1tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.DaTransmissao, "XIE2tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.NrArDocumento, "XIE3tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.DaRetornoCorreio, "XIE4tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqDocumento, "XIF1tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqLote, "XIF2tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqMotivoBaixa, "XIF3tbl_documento_envio")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqMotivoDevolucao, "XIF4tbl_documento_envio")
                    .HasFillFactor(80);

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.DaBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("da_baixa");

                entity.Property(e => e.DaCancelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_cancelamento");

                entity.Property(e => e.DaExpedicao)
                    .HasColumnType("datetime")
                    .HasColumnName("da_expedicao");

                entity.Property(e => e.DaGeracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_geracao");

                entity.Property(e => e.DaImpressao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_impressao");

                entity.Property(e => e.DaPenalidade)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_penalidade");

                entity.Property(e => e.DaProcessamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_processamento");

                entity.Property(e => e.DaRetornoCorreio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_retorno_correio");

                entity.Property(e => e.DaTransmissao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_transmissao");

                entity.Property(e => e.DsDetalheErro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DS_DETALHE_ERRO")
                    .HasComment("Este campo somente será preenchido quando o campo ST_REGISTRO possuir o valor 4 (Com erro).");

                entity.Property(e => e.EmailAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email_autuado");

                entity.Property(e => e.NoAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado");

                entity.Property(e => e.NoAutuadoReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado_real");

                entity.Property(e => e.NoBairroAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_autuado");

                entity.Property(e => e.NoEnderecoAutuado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_autuado");

                entity.Property(e => e.NoEnderecoImagemAr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_imagem_ar");

                entity.Property(e => e.NoImagemAr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_imagem_ar");

                entity.Property(e => e.NoMunicipioAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_autuado");

                entity.Property(e => e.NrArDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nr_ar_documento");

                entity.Property(e => e.NrCepAutuado)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.RPost).HasColumnName("r_post");

                entity.Property(e => e.SgUfAutuado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.SqLote)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_lote");

                entity.Property(e => e.SqLoteOrigem).HasColumnName("sq_lote_origem");

                entity.Property(e => e.SqMotivoBaixa).HasColumnName("sq_motivo_baixa");

                entity.Property(e => e.SqMotivoDevolucao).HasColumnName("sq_motivo_devolucao");

                entity.Property(e => e.StDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_documento")
                    .IsFixedLength();

                entity.Property(e => e.StRegistro)
                    .HasColumnName("ST_REGISTRO")
                    .HasComment("Campo criado para manter o status do registro. 3 = Registrado, 4 = Com Erro.");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithMany(p => p.TblDocumentoEnvios)
                    .HasForeignKey(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_docum__sq_do__318258D2");

                entity.HasOne(d => d.SqLoteNavigation)
                    .WithMany(p => p.TblDocumentoEnvios)
                    .HasForeignKey(d => d.SqLote)
                    .HasConstraintName("FK__tbl_docum__sq_lo__15DA3E5D");

                entity.HasOne(d => d.SqMotivoBaixaNavigation)
                    .WithMany(p => p.TblDocumentoEnvios)
                    .HasForeignKey(d => d.SqMotivoBaixa)
                    .HasConstraintName("FK__tbl_docum__sq_mo__14E61A24");

                entity.HasOne(d => d.SqMotivoDevolucaoNavigation)
                    .WithMany(p => p.TblDocumentoEnvios)
                    .HasForeignKey(d => d.SqMotivoDevolucao)
                    .HasConstraintName("FK__tbl_docum__sq_mo__13F1F5EB");
            });

            modelBuilder.Entity<TblDocumentosIncluirSerasaEp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DocumentosIncluirSERASA_EP");

                entity.Property(e => e.CdLocAutoInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdLocInfratorCadastro)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsEndInfrator)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DsLoc)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DtInfracao).HasColumnType("datetime");

                entity.Property(e => e.DtVencimento).HasColumnType("datetime");

                entity.Property(e => e.NoBairroInfrator)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoInfrator)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrCepInfrator)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrCnpjCpfInfrator)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NrTipoInfrator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SgTipoInfrator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SgUfInfrator)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VlMulta).HasColumnType("decimal(13, 2)");
            });

            modelBuilder.Entity<TblErroBancario>(entity =>
            {
                entity.HasKey(e => e.SqErroBancario)
                    .HasName("PK__tbl_erro_bancari__42ACE4D4");

                entity.ToTable("tbl_erro_bancario");

                entity.HasIndex(e => e.DaUltimoProcessamento, "XIE1tbl_erro_bancario")
                    .HasFillFactor(50);

                entity.Property(e => e.SqErroBancario)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_erro_bancario");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira")
                    .IsFixedLength();

                entity.Property(e => e.DaUltimoProcessamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_ultimo_processamento");

                entity.Property(e => e.DsMotivoErroBancario)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_erro_bancario");

                entity.Property(e => e.NoArquivoBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_arquivo_banco");

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblErroPostagem>(entity =>
            {
                entity.HasKey(e => e.IdErroPostagem);

                entity.ToTable("tbl_erro_postagem");

                entity.Property(e => e.IdErroPostagem).HasColumnName("idErroPostagem");

                entity.Property(e => e.DtErro)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_erro");

                entity.Property(e => e.NmArquivo)
                    .HasMaxLength(50)
                    .HasColumnName("nm_arquivo");

                entity.Property(e => e.NrLotePostagem).HasColumnName("nr_lote_postagem");
            });

            modelBuilder.Entity<TblExcessoPeso>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_excesso_peso__4F47C5E3");

                entity.ToTable("tbl_excesso_peso");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.CoMunicipioInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("co_municipio_infracao");

                entity.Property(e => e.CoMunicipioVeiculo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("co_municipio_veiculo");

                entity.Property(e => e.CodigoTipoDocumento).HasDefaultValueSql("(1)");

                entity.Property(e => e.DaDocumentoEmbarque)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento_embarque");

                entity.Property(e => e.DaLimite)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite");

                entity.Property(e => e.ExcessoVerificadoCmt).HasColumnName("ExcessoVerificadoCMT");

                entity.Property(e => e.MedicaoPermitidaCmt).HasColumnName("MedicaoPermitidaCMT");

                entity.Property(e => e.NoCategoriaAutuado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("no_categoria_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NoCategoriaVeiculo)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("no_categoria_veiculo");

                entity.Property(e => e.NoEspecieCarga)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_especie_carga");

                entity.Property(e => e.NoEspecieVeiculo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("no_especie_veiculo");

                entity.Property(e => e.NoInstrumentoUtilizado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("no_instrumento_utilizado");

                entity.Property(e => e.NoMarcaVeiculo)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("no_marca_veiculo");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoModeloVeiculo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("no_modelo_veiculo");

                entity.Property(e => e.NoMunicipioVeiculo)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_veiculo");

                entity.Property(e => e.NoPenalidade)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("no_penalidade");

                entity.Property(e => e.NoRodoviaInfracao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_rodovia_infracao");

                entity.Property(e => e.NrAet)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nr_aet");

                entity.Property(e => e.NrChassi)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("nr_chassi");

                entity.Property(e => e.NrDocumentoEmbarque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_documento_embarque");

                entity.Property(e => e.NrExcessoVerificado).HasColumnName("nr_excesso_verificado");

                entity.Property(e => e.NrKmInfracao)
                    .HasColumnType("numeric(6, 1)")
                    .HasColumnName("nr_km_infracao");

                entity.Property(e => e.NrPesagemPermitida).HasColumnName("nr_pesagem_permitida");

                entity.Property(e => e.NrPesagemRealizada).HasColumnName("nr_pesagem_realizada");

                entity.Property(e => e.NrRenavam)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nr_renavam");

                entity.Property(e => e.NrSenhaAcessoNoProcesso)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nr_senha_acesso_no_processo");

                entity.Property(e => e.NrTaraDeclarada)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("nr_tara_declarada");

                entity.Property(e => e.PenalidadeLinha1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PenalidadeLinha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorMultaExcessoEixo).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.VlBaseMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_base_multa");

                entity.Property(e => e.VlMultaComDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_multa_com_desconto");

                entity.Property(e => e.VlPorExcesso)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_por_excesso");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblExcessoPeso)
                    .HasForeignKey<TblExcessoPeso>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_exces__sq_do__308E3499");
            });

            modelBuilder.Entity<TblExcessoVelocidade>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_excesso_velo__060DEAE8");

                entity.ToTable("tbl_excesso_velocidade");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.NoCategoriaVeiculo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("no_categoria_veiculo");

                entity.Property(e => e.NoEspecieVeiculo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("no_especie_veiculo");

                entity.Property(e => e.NoLocalInfracao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_local_infracao");

                entity.Property(e => e.NoMarcaVeiculo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("no_marca_veiculo");

                entity.Property(e => e.NoModeloVeiculo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("no_modelo_veiculo");

                entity.Property(e => e.NoRodoviaInfracao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_rodovia_infracao");

                entity.Property(e => e.NrKmInfracao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nr_km_infracao");

                entity.Property(e => e.NrVelocidadeMedida).HasColumnName("nr_velocidade_medida");

                entity.Property(e => e.NrVelocidadePermitida).HasColumnName("nr_velocidade_permitida");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblExcessoVelocidade)
                    .HasForeignKey<TblExcessoVelocidade>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_exces__sq_do__2F9A1060");
            });

            modelBuilder.Entity<TblFaseDocumento>(entity =>
            {
                entity.HasKey(e => e.SqFaseDocumento)
                    .HasName("PK__tbl_fase_documen__531856C7");

                entity.ToTable("tbl_fase_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.CoFaseDocumento).HasColumnName("co_fase_documento");

                entity.Property(e => e.DsFaseDocumento)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_fase_documento");

                entity.Property(e => e.InEmissaoCobranca)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("in_emissao_cobranca")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblFinanceira>(entity =>
            {
                entity.HasKey(e => new { e.SqDocumento, e.NrOrdemDocumentoEnvio, e.NrOrdemFinanceira })
                    .HasName("PK__tbl_fi_08012007201658001");

                entity.ToTable("tbl_financeira");

                entity.HasIndex(e => new { e.IdTpQuitacao, e.VlDocumento }, "IN_tbl_financeira_id_tp_quitacao_vl_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.DaVencimento, "XIE1tbl_financeira")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.DaPagamento, "XIE2tbl_financeira")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqTipoArrecadacao, "XIF1tbl_financeira")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SqDocumento, e.NrOrdemDocumentoEnvio }, "XIF2tbl_financeira")
                    .HasFillFactor(80);

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira)
                    .HasColumnName("nr_ordem_financeira")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CoTipoCodigoBarra).HasColumnName("co_tipo_codigo_barra");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDocumento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento");

                entity.Property(e => e.DaFimSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Fim_Selic");

                entity.Property(e => e.DaInicioSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Inicio_Selic");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaLoteBanco)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_lote_banco");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DaVencimentoParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento_parcelamento");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InBaixaAutomatica)
                    .IsRequired()
                    .HasColumnName("in_baixa_automatica")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.InValorComplementar).HasColumnName("in_valor_complementar");

                entity.Property(e => e.NrAgenciaRecebedora)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("nr_agencia_recebedora");

                entity.Property(e => e.NrBancoRecebedor)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("nr_banco_recebedor");

                entity.Property(e => e.NrSequencialArquivoBanco).HasColumnName("nr_sequencial_arquivo_banco");

                entity.Property(e => e.NrSequencialLinhaBanco).HasColumnName("nr_sequencial_linha_banco");

                entity.Property(e => e.PercentualSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Percentual_Selic_MaisUmPorcento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoDolar)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_documento_dolar");

                entity.Property(e => e.VlHistDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_hist_documento");

                entity.Property(e => e.VlHistPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_hist_pagamento");

                entity.Property(e => e.VlIndicePtax)
                    .HasColumnType("numeric(5, 4)")
                    .HasColumnName("vl_indice_ptax");

                entity.Property(e => e.VlJurosSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Juros_Selic_MaisUmPorcento");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlPercentualMultaMora)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Percentual_Multa_Mora");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_residual");

                entity.HasOne(d => d.SqStatusFinanceiroNavigation)
                    .WithMany(p => p.TblFinanceiras)
                    .HasForeignKey(d => d.SqStatusFinanceiro)
                    .HasConstraintName("FK__tbl_finan__sq_st__0524B3A7");

                entity.HasOne(d => d.SqTipoArrecadacaoNavigation)
                    .WithMany(p => p.TblFinanceiras)
                    .HasForeignKey(d => d.SqTipoArrecadacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_finan__sq_ti__22FF2F51");
            });

            modelBuilder.Entity<TblFinanceiraHmlBkp20180404>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_financeira_hml_bkp_2018_04_04", "lc");

                entity.Property(e => e.CoTipoCodigoBarra).HasColumnName("co_tipo_codigo_barra");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDocumento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento");

                entity.Property(e => e.DaFimSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Fim_Selic");

                entity.Property(e => e.DaInicioSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Inicio_Selic");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaLoteBanco)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_lote_banco");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DaVencimentoParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento_parcelamento");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InBaixaAutomatica).HasColumnName("in_baixa_automatica");

                entity.Property(e => e.InValorComplementar).HasColumnName("in_valor_complementar");

                entity.Property(e => e.NrAgenciaRecebedora)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("nr_agencia_recebedora");

                entity.Property(e => e.NrBancoRecebedor)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("nr_banco_recebedor");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialArquivoBanco).HasColumnName("nr_sequencial_arquivo_banco");

                entity.Property(e => e.NrSequencialLinhaBanco).HasColumnName("nr_sequencial_linha_banco");

                entity.Property(e => e.PercentualSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Percentual_Selic_MaisUmPorcento");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoDolar)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_documento_dolar");

                entity.Property(e => e.VlHistDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_hist_documento");

                entity.Property(e => e.VlHistPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_hist_pagamento");

                entity.Property(e => e.VlIndicePtax)
                    .HasColumnType("numeric(5, 4)")
                    .HasColumnName("vl_indice_ptax");

                entity.Property(e => e.VlJurosSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Juros_Selic_MaisUmPorcento");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlPercentualMultaMora)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Percentual_Multa_Mora");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<TblFinanceiraLog>(entity =>
            {
                entity.HasKey(e => e.CdLogFinanceiro)
                    .HasName("PK_LOG_FINANCEIRO");

                entity.ToTable("tbl_financeira_log");

                entity.Property(e => e.CdLogFinanceiro).HasColumnName("CD_LOG_FINANCEIRO");

                entity.Property(e => e.CoTipoCodigoBarra).HasColumnName("co_tipo_codigo_barra");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDocumento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento");

                entity.Property(e => e.DaFimSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Fim_Selic");

                entity.Property(e => e.DaInicioSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Inicio_Selic");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaLoteBanco)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_lote_banco");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DaVencimentoParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento_parcelamento");

                entity.Property(e => e.DescricaoAcao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Acao");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ALTERACAO");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InBaixaAutomatica).HasColumnName("in_baixa_automatica");

                entity.Property(e => e.InValorComplementar).HasColumnName("in_valor_complementar");

                entity.Property(e => e.NrAgenciaRecebedora)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("nr_agencia_recebedora");

                entity.Property(e => e.NrBancoRecebedor)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("nr_banco_recebedor");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialArquivoBanco).HasColumnName("nr_sequencial_arquivo_banco");

                entity.Property(e => e.NrSequencialLinhaBanco).HasColumnName("nr_sequencial_linha_banco");

                entity.Property(e => e.PercentualSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Percentual_Selic_MaisUmPorcento");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.UsrAlteracao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USR_ALTERACAO");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoDolar)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_documento_dolar");

                entity.Property(e => e.VlHistDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_hist_documento");

                entity.Property(e => e.VlHistPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_hist_pagamento");

                entity.Property(e => e.VlIndicePtax)
                    .HasColumnType("numeric(5, 4)")
                    .HasColumnName("vl_indice_ptax");

                entity.Property(e => e.VlJurosSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Juros_Selic_MaisUmPorcento");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlPercentualMultaMora)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Percentual_Multa_Mora");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<TblFinanceiraParcelamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_financeira_parcelamento");

                entity.Property(e => e.CoTipoCodigoBarra).HasColumnName("co_tipo_codigo_barra");

                entity.Property(e => e.DaDocumento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento");

                entity.Property(e => e.DaFimSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Fim_Selic");

                entity.Property(e => e.DaInicioSelic)
                    .HasColumnType("datetime")
                    .HasColumnName("Da_Inicio_Selic");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaLoteBanco)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_lote_banco");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.InBaixaAutomatica).HasColumnName("in_baixa_automatica");

                entity.Property(e => e.InValorComplementar).HasColumnName("in_valor_complementar");

                entity.Property(e => e.NrAgenciaRecebedora)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("nr_agencia_recebedora");

                entity.Property(e => e.NrBancoRecebedor)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("nr_banco_recebedor");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialArquivoBanco).HasColumnName("nr_sequencial_arquivo_banco");

                entity.Property(e => e.NrSequencialLinhaBanco).HasColumnName("nr_sequencial_linha_banco");

                entity.Property(e => e.PercentualSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Percentual_Selic_MaisUmPorcento");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoDolar)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_documento_dolar");

                entity.Property(e => e.VlIndicePtax)
                    .HasColumnType("numeric(5, 4)")
                    .HasColumnName("vl_indice_ptax");

                entity.Property(e => e.VlJurosSelicMaisUmPorcento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Juros_Selic_MaisUmPorcento");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlPercentualMultaMora)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("Vl_Percentual_Multa_Mora");
            });

            modelBuilder.Entity<TblGrupoDocumento>(entity =>
            {
                entity.HasKey(e => e.SqGrupoDocumento)
                    .HasName("PK96");

                entity.ToTable("tbl_grupo_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.DsGrupoDocumento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ds_grupo_documento");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_inclusao");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");

                entity.Property(e => e.SgGrupoDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sg_grupo_documento");
            });

            modelBuilder.Entity<TblHistoricoVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoHistoricoVeiculo)
                    .HasName("prktblHistoricoVeiculo")
                    .IsClustered(false);

                entity.ToTable("tblHistoricoVeiculo");

                entity.Property(e => e.DataUltimaAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.NumeroChassi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPlaca)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAcao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblImpressao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_impressao");

                entity.HasIndex(e => e.CoUsuario, "XIE1tbl_impressao")
                    .HasFillFactor(50);

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira")
                    .IsFixedLength();

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.NrAutoInfracaoDv)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao_dv")
                    .IsFixedLength();

                entity.Property(e => e.NrCodigoBarra)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("nr_codigo_barra")
                    .IsFixedLength();

                entity.Property(e => e.NrLinhaDigitavel)
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasColumnName("nr_linha_digitavel")
                    .IsFixedLength();

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");
            });

            modelBuilder.Entity<TblImpressaoBoletoBancarioAtit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_impressao_boleto_bancario_ATIT");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira")
                    .IsFixedLength();

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.NrCodigoBarra)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("nr_codigo_barra")
                    .IsFixedLength();

                entity.Property(e => e.NrConvenioBanco).HasColumnName("nr_convenio_banco");

                entity.Property(e => e.NrLinhaDigitavel)
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasColumnName("nr_linha_digitavel")
                    .IsFixedLength();

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblImpressaoBoletoBancarioAtitLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_impressao_boleto_bancario_ATIT_log");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaOperacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_operacao");

                entity.Property(e => e.NrFinal).HasColumnName("nr_final");

                entity.Property(e => e.NrInicial).HasColumnName("nr_inicial");
            });

            modelBuilder.Entity<TblIndicador>(entity =>
            {
                entity.HasKey(e => e.SqIndicador);

                entity.ToTable("tbl_indicador");

                entity.HasIndex(e => e.SqTipoIndicador, "IN_tbl_indicador_sq_tipo_indicador")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SqTipoIndicador, e.NrAnoReferencia, e.NrMesReferencia }, "IN_tbl_indicador_sq_tipo_indicador_02")
                    .HasFillFactor(80);

                entity.Property(e => e.SqIndicador)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_indicador");

                entity.Property(e => e.NrAnoReferencia).HasColumnName("nr_ano_referencia");

                entity.Property(e => e.NrDiaReferencia).HasColumnName("nr_dia_referencia");

                entity.Property(e => e.NrMesReferencia).HasColumnName("nr_mes_referencia");

                entity.Property(e => e.SqTipoIndicador).HasColumnName("sq_tipo_indicador");

                entity.Property(e => e.VlValorIndice)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("vl_valor_indice");

                entity.HasOne(d => d.SqTipoIndicadorNavigation)
                    .WithMany(p => p.TblIndicadors)
                    .HasForeignKey(d => d.SqTipoIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_indicador_tbl_tipo_indicador");
            });

            modelBuilder.Entity<TblIndicadorBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_indicador_bkp");

                entity.Property(e => e.NrAnoReferencia).HasColumnName("nr_ano_referencia");

                entity.Property(e => e.NrDiaReferencia).HasColumnName("nr_dia_referencia");

                entity.Property(e => e.NrMesReferencia).HasColumnName("nr_mes_referencia");

                entity.Property(e => e.SqIndicador)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_indicador");

                entity.Property(e => e.SqTipoIndicador).HasColumnName("sq_tipo_indicador");

                entity.Property(e => e.VlValorIndice)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("vl_valor_indice");
            });

            modelBuilder.Entity<TblInfracaoSupa>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_infracao_sup__0C1BC9F9");

                entity.ToTable("tbl_infracao_supas");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.CoGrupoInfracao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_grupo_infracao")
                    .IsFixedLength();

                entity.Property(e => e.DsMotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_indeferimento");

                entity.Property(e => e.NoLinhaServico)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("no_linha_servico");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMotorista)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("no_motorista");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoPrefixo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("no_prefixo");

                entity.Property(e => e.NrCnhMotorista)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnh_motorista");

                entity.Property(e => e.NrDrfInfracao).HasColumnName("nr_drf_infracao");

                entity.Property(e => e.NrOrdemVeiculo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nr_ordem_veiculo");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblInfracaoSupa)
                    .HasForeignKey<TblInfracaoSupa>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_infra__sq_do__0B27A5C0");
            });

            modelBuilder.Entity<TblLancamentoManual>(entity =>
            {
                entity.HasKey(e => e.SqLancamento)
                    .HasName("PK__tbl_lancamento_m__595B4002");

                entity.ToTable("tbl_lancamento_manual");

                entity.HasIndex(e => new { e.NrSequencialArquivoBanco, e.NrSequencialLinhaBanco }, "ix_lancamento_manual")
                    .HasFillFactor(50);

                entity.Property(e => e.SqLancamento).HasColumnName("sq_lancamento");

                entity.Property(e => e.DsLancamento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ds_lancamento");

                entity.Property(e => e.DsNossoNumero)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ds_nosso_numero");

                entity.Property(e => e.DtLancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_lancamento");

                entity.Property(e => e.NrSequencialArquivoBanco).HasColumnName("nr_sequencial_arquivo_banco");

                entity.Property(e => e.NrSequencialLinhaBanco).HasColumnName("nr_sequencial_linha_banco");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VaLancamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("va_lancamento");

                entity.HasOne(d => d.SqTipoDocumentoNavigation)
                    .WithMany(p => p.TblLancamentoManuals)
                    .HasForeignKey(d => d.SqTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_lanca__sq_ti__170E59B8");
            });

            modelBuilder.Entity<TblLogBaixaFeriadoMunicipal>(entity =>
            {
                entity.HasKey(e => e.SqLogBaixaFeriadoMunicipal);

                entity.ToTable("tbl_log_baixa_feriado_municipal");

                entity.Property(e => e.SqLogBaixaFeriadoMunicipal).HasColumnName("sq_log_baixa_feriado_municipal");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.DaLogBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("da_log_baixa");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.NrAgenciaRecebedora)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("nr_agencia_recebedora");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrBancoRecebedor)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("nr_banco_recebedor");

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithMany(p => p.TblLogBaixaFeriadoMunicipals)
                    .HasForeignKey(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_documento_tbl_log_baixa_feriado_municipal");

                entity.HasOne(d => d.TblFinanceira)
                    .WithMany(p => p.TblLogBaixaFeriadoMunicipals)
                    .HasForeignKey(d => new { d.SqDocumento, d.NrOrdemDocumentoEnvio, d.NrOrdemFinanceira })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_financeira_tbl_log_baixa_feriado_municipal");
            });

            modelBuilder.Entity<TblLogFinanceira>(entity =>
            {
                entity.HasKey(e => e.SqLogFinanceira);

                entity.ToTable("tbl_log_financeira");

                entity.Property(e => e.SqLogFinanceira).HasColumnName("sq_log_financeira");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaRealizacaoBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("da_realizacao_baixa");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.TblLogFinanceiras)
                    .HasForeignKey(d => d.CoUsuario)
                    .HasConstraintName("FK_tbl_usuario_tbl_log_financeira");

                entity.HasOne(d => d.TblFinanceira)
                    .WithMany(p => p.TblLogFinanceiras)
                    .HasForeignKey(d => new { d.SqDocumento, d.NrOrdemDocumentoEnvio, d.NrOrdemFinanceira })
                    .HasConstraintName("FK_tbl_financeira_tbl_log_financeira");
            });

            modelBuilder.Entity<TblLogImputacao>(entity =>
            {
                entity.HasKey(e => e.SqLogImputacao);

                entity.ToTable("tbl_log_imputacao");

                entity.Property(e => e.SqLogImputacao).HasColumnName("sq_log_imputacao");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaImputacao)
                    .HasColumnType("datetime")
                    .HasColumnName("da_imputacao");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqParcelamento).HasColumnName("sq_parcelamento");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.TblLogImputacaos)
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_usuario_tbl_log_imputacao");

                entity.HasOne(d => d.SqParcelamentoNavigation)
                    .WithMany(p => p.TblLogImputacaos)
                    .HasForeignKey(d => d.SqParcelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_parcelamento_tbl_log_imputacao");

                entity.HasOne(d => d.TblFinanceira)
                    .WithMany(p => p.TblLogImputacaos)
                    .HasForeignKey(d => new { d.SqDocumento, d.NrOrdemDocumentoEnvio, d.NrOrdemFinanceira })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_financeira_tbl_log_imputacao");
            });

            modelBuilder.Entity<TblLogLancamento>(entity =>
            {
                entity.HasKey(e => e.SqLogLancamento);

                entity.ToTable("tbl_log_lancamento");

                entity.Property(e => e.SqLogLancamento).HasColumnName("sq_log_lancamento");

                entity.Property(e => e.CoUsuarioLancamento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario_lancamento");

                entity.Property(e => e.DsLancamento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_lancamento");

                entity.Property(e => e.DsNossoNumero)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ds_nosso_numero");

                entity.Property(e => e.DtLancamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_lancamento");

                entity.Property(e => e.DtRealizacaoLancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_realizacao_lancamento");

                entity.Property(e => e.InLancamento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("in_lancamento")
                    .IsFixedLength();

                entity.Property(e => e.SqLancamento).HasColumnName("sq_lancamento");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlLancamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_lancamento");
            });

            modelBuilder.Entity<TblLogRestituicoesDocumento>(entity =>
            {
                entity.HasKey(e => e.SqLogRestituicoesDocumento)
                    .HasName("PK_TBL_LOG_RESTITUICOES_DOCUME");

                entity.ToTable("tbl_log_restituicoes_documento");

                entity.HasComment("Entidade de log responsavel pelas restituições dos documentos. ");

                entity.Property(e => e.SqLogRestituicoesDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_log_restituicoes_documento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao")
                    .HasComment("Observações que serão feitas referente as resituiçoes dos documentos.");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_alteracao")
                    .HasComment("Data de alteração");

                entity.Property(e => e.DtOperacaoLog)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_operacao_log")
                    .HasComment("Data que foi realizada a operação do log.");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_pagamento")
                    .HasComment("Data do pagamento referente as resituiçoes do documentos.");

                entity.Property(e => e.NrOrdemBancaria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_ordem_bancaria")
                    .HasComment("Número da ordem bancária do documentos referente a restituição");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo")
                    .HasComment("Número do Processo");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqRestituicoesDocumento)
                    .HasColumnName("sq_restituicoes_documento")
                    .HasComment("Código sequencial da tabela tbl_restituicoes_parcelamento");

                entity.Property(e => e.TpOperacaoLog)
                    .HasColumnName("tp_operacao_log")
                    .HasComment("Tipo da operação que foi realizada (1 - insert, 2 - update).");

                entity.Property(e => e.UsrOperacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usr_operacao")
                    .HasComment("Usuário que realizou a operação");

                entity.Property(e => e.VlRestituir)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_restituir")
                    .HasComment("Valor a resituir para o cliente referente aos documentos.");

                entity.Property(e => e.VlSelic)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_selic")
                    .HasComment("Valor da Selic referente aos documentos.");
            });

            modelBuilder.Entity<TblLogRestituicoesParcelamento>(entity =>
            {
                entity.HasKey(e => e.SqLogRestituicoesParcelamento)
                    .HasName("PK_TBL_LOG_RESTITUICOES_PARCEL");

                entity.ToTable("tbl_log_restituicoes_parcelamento");

                entity.HasComment("Entidade de log que armazena informações das restituições dos parcelamentos. ");

                entity.Property(e => e.SqLogRestituicoesParcelamento)
                    .HasColumnName("sq_log_restituicoes_parcelamento")
                    .HasComment("Código sequencial da tabela tbl_log_restituicoes_parcelamento");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao")
                    .HasComment("Observações que serão feitas referente as resituiçoes dos parcelamentos");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_alteracao")
                    .HasComment("Data de alteração");

                entity.Property(e => e.DtOperacaoLog)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_operacao_log")
                    .HasComment("Data que foi realizada a operação do log.");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_pagamento")
                    .HasComment("Data do pagamento referente as resituiçoes do parcelamento");

                entity.Property(e => e.NrOrdemBancaria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_ordem_bancaria")
                    .HasComment("Número da ordem bancária para o pagamento da restituição");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo")
                    .HasComment("Número do Processo");

                entity.Property(e => e.SqParcelamento)
                    .HasColumnName("sq_parcelamento")
                    .HasComment("Código sequencial da tabela tbl_parcelamento");

                entity.Property(e => e.SqParcelamentoParcela)
                    .HasColumnName("sq_parcelamento_parcela")
                    .HasComment("Código sequencial da tabela tbl_parcelamento_parcela");

                entity.Property(e => e.SqRestituicoesParcelamento)
                    .HasColumnName("sq_restituicoes_parcelamento")
                    .HasComment("Código sequencial da tabela tbl_restituicoes_parcelamento");

                entity.Property(e => e.TpOperacaoLog)
                    .HasColumnName("tp_operacao_log")
                    .HasComment("Tipo da operação que foi realizada (1 - insert, 2 - update).");

                entity.Property(e => e.UsrOperacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usr_operacao")
                    .HasComment("Usuário que realizou a operação");

                entity.Property(e => e.VlRestituir)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_restituir")
                    .HasComment("Valor a resituir para o cliente referente aos parcelamentos.");

                entity.Property(e => e.VlSelic)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_selic")
                    .HasComment("Valor da Selic referente aos parcelamentos.");
            });

            modelBuilder.Entity<TblLogSistema>(entity =>
            {
                entity.HasKey(e => e.SqLogSistema)
                    .HasName("PK__tbl_log_sistema__093F5D4E");

                entity.ToTable("tbl_log_sistema");

                entity.HasIndex(e => e.CoUsuario, "XIF1tbl_log_sistema")
                    .HasFillFactor(50);

                entity.HasIndex(e => new { e.SqDocumento, e.NrOrdemDocumentoEnvio }, "XIF2tbl_log_sistema")
                    .HasFillFactor(50);

                entity.HasIndex(e => e.CoLog, "XIF3tbl_log_sistema")
                    .HasFillFactor(50);

                entity.Property(e => e.SqLogSistema)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_log_sistema");

                entity.Property(e => e.CoLog).HasColumnName("co_log");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaLogSistema)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_log_sistema");

                entity.Property(e => e.DsLogSistema)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ds_log_sistema");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.HasOne(d => d.CoLogNavigation)
                    .WithMany(p => p.TblLogSistemas)
                    .HasForeignKey(d => d.CoLog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_log_s__co_lo__0662F0A3");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.TblLogSistemas)
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_log_s__co_us__18F6A22A");

                entity.HasOne(d => d.TblDocumentoEnvio)
                    .WithMany(p => p.TblLogSistemas)
                    .HasForeignKey(d => new { d.SqDocumento, d.NrOrdemDocumentoEnvio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_log_sistema__075714DC");
            });

            modelBuilder.Entity<TblLote>(entity =>
            {
                entity.HasKey(e => e.SqLote)
                    .HasName("PK__tbl_lote__7C8480AE");

                entity.ToTable("tbl_lote");

                entity.HasIndex(e => new { e.NrLote, e.NrAnoLote }, "XAK1tbl_lote")
                    .IsUnique()
                    .HasFillFactor(50);

                entity.HasIndex(e => e.CoUsuarioCancelamento, "XIF1tbl_lote")
                    .HasFillFactor(50);

                entity.HasIndex(e => e.CoUsuario, "XIF2tbl_lote")
                    .HasFillFactor(50);

                entity.Property(e => e.SqLote)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_lote");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.CoUsuarioCancelamento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario_cancelamento");

                entity.Property(e => e.DaCancelamentoLote)
                    .HasColumnType("datetime")
                    .HasColumnName("da_cancelamento_lote");

                entity.Property(e => e.DaProcessamentoLote)
                    .HasColumnType("datetime")
                    .HasColumnName("da_processamento_lote");

                entity.Property(e => e.DaRetornoLote)
                    .HasColumnType("datetime")
                    .HasColumnName("da_retorno_lote");

                entity.Property(e => e.NoMotivoCancelamento)
                    .HasColumnType("text")
                    .HasColumnName("no_motivo_cancelamento");

                entity.Property(e => e.NrAnoLote).HasColumnName("nr_ano_lote");

                entity.Property(e => e.NrDocumentosLote).HasColumnName("nr_documentos_lote");

                entity.Property(e => e.NrLote).HasColumnName("nr_lote");

                entity.Property(e => e.StRetornoLote)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_retorno_lote")
                    .IsFixedLength();

                entity.Property(e => e.VlDocumentosLote)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documentos_lote");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.TblLoteCoUsuarioNavigations)
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_lote__co_usu__0E240DFC");

                entity.HasOne(d => d.CoUsuarioCancelamentoNavigation)
                    .WithMany(p => p.TblLoteCoUsuarioCancelamentoNavigations)
                    .HasForeignKey(d => d.CoUsuarioCancelamento)
                    .HasConstraintName("FK__tbl_lote__co_usu__0F183235");
            });

            modelBuilder.Entity<TblModuloSistema>(entity =>
            {
                entity.HasKey(e => e.CoModuloSistema)
                    .HasName("PK__tbl_modulo_siste__0BC6C43E");

                entity.ToTable("tbl_modulo_sistema");

                entity.Property(e => e.CoModuloSistema)
                    .ValueGeneratedNever()
                    .HasColumnName("co_modulo_sistema");

                entity.Property(e => e.DsPerfilModulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_perfil_modulo");

                entity.Property(e => e.NoModuloSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_modulo_sistema");
            });

            modelBuilder.Entity<TblMotivoBaixa>(entity =>
            {
                entity.HasKey(e => e.SqMotivoBaixa)
                    .HasName("PK__tbl_motivo_baixa__47A6A41B");

                entity.ToTable("tbl_motivo_baixa");

                entity.Property(e => e.SqMotivoBaixa).HasColumnName("sq_motivo_baixa");

                entity.Property(e => e.CoMotivoBaixa).HasColumnName("co_motivo_baixa");

                entity.Property(e => e.DsMotivoBaixa)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_baixa");
            });

            modelBuilder.Entity<TblMotivoCancelamentoParcelamento>(entity =>
            {
                entity.HasKey(e => e.SqMotivoCancelamentoParcelamento)
                    .HasName("PK__tbl_motivo_cancelamento_parcelamento__1");

                entity.ToTable("tbl_motivo_cancelamento_parcelamento");

                entity.Property(e => e.SqMotivoCancelamentoParcelamento)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_motivo_cancelamento_parcelamento");

                entity.Property(e => e.DsMotivoCancelamentoParcelamento)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_cancelamento_parcelamento");

                entity.Property(e => e.InReparcelamento).HasColumnName("in_reparcelamento");

                entity.Property(e => e.InRescisao).HasColumnName("in_rescisao");
            });

            modelBuilder.Entity<TblMotivoDevolucao>(entity =>
            {
                entity.HasKey(e => e.SqMotivoDevolucao)
                    .HasName("PK__tbl_motivo_devol__498EEC8D");

                entity.ToTable("tbl_motivo_devolucao");

                entity.Property(e => e.SqMotivoDevolucao).HasColumnName("sq_motivo_devolucao");

                entity.Property(e => e.CoMotivoDevolucao).HasColumnName("co_motivo_devolucao");

                entity.Property(e => e.DsMotivoDevolucao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_devolucao");
            });

            modelBuilder.Entity<TblOrgaoAutuador>(entity =>
            {
                entity.HasKey(e => e.SqOrgaoAutuador)
                    .HasName("PK__tbl_orgao_autuad__32E0915F");

                entity.ToTable("tbl_orgao_autuador");

                entity.Property(e => e.SqOrgaoAutuador).HasColumnName("sq_orgao_autuador");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.NoBairroOrgaoAutuador)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_orgao_autuador");

                entity.Property(e => e.NoEnderecoOrgaoAutuador)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_orgao_autuador");

                entity.Property(e => e.NoMunicipioOrgaoAutuador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_orgao_autuador");

                entity.Property(e => e.NoOrgaoAutuador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_orgao_autuador");

                entity.Property(e => e.NrCepOrgaoAutuador)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_orgao_autuador")
                    .IsFixedLength();

                entity.Property(e => e.SgUfOrgaoAutuador)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_orgao_autuador")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblOrigemDocumento>(entity =>
            {
                entity.HasKey(e => e.SqOrigemDocumento)
                    .HasName("PK__tbl_origem_docum__1EC48A19");

                entity.ToTable("tbl_origem_documento");

                entity.Property(e => e.SqOrigemDocumento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_origem_documento");

                entity.Property(e => e.NoOrigemDocumento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_origem_documento");
            });

            modelBuilder.Entity<TblParcelamento>(entity =>
            {
                entity.HasKey(e => e.SqParcelamento)
                    .HasName("PK__tbl_parcelamento__53385258");

                entity.ToTable("tbl_parcelamento");

                entity.HasIndex(e => e.StParcelamento, "IN_tbl_parcelamento_st_parcelamento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqGrupoDocumento, "XIF2tbl_documento_grupo")
                    .HasFillFactor(50);

                entity.Property(e => e.SqParcelamento).HasColumnName("sq_parcelamento");

                entity.Property(e => e.AaParcelamento).HasColumnName("aa_parcelamento");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.CoUsuarioAnalise)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario_analise");

                entity.Property(e => e.CoUsuarioCancelamento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario_cancelamento");

                entity.Property(e => e.DaConcessaoParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_concessao_parcelamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DsMotivoCancelamentoParcelamento)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_cancelamento_parcelamento");

                entity.Property(e => e.DsNumeroResolucao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_numero_resolucao");

                entity.Property(e => e.DsObservacoes)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacoes");

                entity.Property(e => e.DtAnalise)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_analise");

                entity.Property(e => e.DtCancelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_cancelamento");

                entity.Property(e => e.Idpessoa).HasColumnName("IDPessoa");

                entity.Property(e => e.InBloqueiaBoleto).HasColumnName("in_bloqueia_boleto");

                entity.Property(e => e.InReparcelamento).HasColumnName("in_reparcelamento");

                entity.Property(e => e.NrParcelamento).HasColumnName("nr_parcelamento");

                entity.Property(e => e.NrParcelas).HasColumnName("nr_parcelas");

                entity.Property(e => e.NrParecer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_parecer");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqMotivoCancelamentoParcelamento).HasColumnName("sq_motivo_cancelamento_parcelamento");

                entity.Property(e => e.StParcelamento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_parcelamento")
                    .IsFixedLength();

                entity.Property(e => e.VlParcelamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_parcelamento");

                entity.HasOne(d => d.SqGrupoDocumentoNavigation)
                    .WithMany(p => p.TblParcelamentos)
                    .HasForeignKey(d => d.SqGrupoDocumento)
                    .HasConstraintName("FK_tbl_parcelamento_grupo_documento");
            });

            modelBuilder.Entity<TblParcelamentoParcela>(entity =>
            {
                entity.HasKey(e => e.SqParcelamentoParcela)
                    .HasName("PK__tbl_parcelamento__3D491139");

                entity.ToTable("tbl_parcelamento_parcela");

                entity.HasIndex(e => e.SqParcelamento, "XIF2tbl_parcelamento_parcela")
                    .HasFillFactor(50);

                entity.Property(e => e.SqParcelamentoParcela).HasColumnName("sq_parcelamento_parcela");

                entity.Property(e => e.DaMensagemParcela)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_mensagem_parcela");

                entity.Property(e => e.DaPagamentoParcela)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento_parcela");

                entity.Property(e => e.DaVencimentoParcela)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento_parcela");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.InPagamentoIntegral).HasColumnName("in_pagamento_integral");

                entity.Property(e => e.NrParcela).HasColumnName("nr_parcela");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.SqParcelamento).HasColumnName("sq_parcelamento");

                entity.Property(e => e.VlDiferencaPagamentoParcela)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_diferenca_pagamento_parcela");

                entity.Property(e => e.VlPagamentoParcela)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento_parcela");

                entity.Property(e => e.VlVencimentoParcela)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_vencimento_parcela");

                entity.HasOne(d => d.SqParcelamentoNavigation)
                    .WithMany(p => p.TblParcelamentoParcelas)
                    .HasForeignKey(d => d.SqParcelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_parcelamento_parcelamento_parcela");
            });

            modelBuilder.Entity<TblParcelamentoProcessamento>(entity =>
            {
                entity.HasKey(e => e.SqParcelamentoProcessamento);

                entity.ToTable("tbl_parcelamento_processamento");

                entity.Property(e => e.SqParcelamentoProcessamento).HasColumnName("sq_parcelamento_processamento");

                entity.Property(e => e.DaLoteBanco)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_lote_banco");

                entity.Property(e => e.DaProcessamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_processamento");

                entity.Property(e => e.DsProcessamento)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_processamento");

                entity.Property(e => e.NrSequencialArquivoBanco).HasColumnName("nr_sequencial_arquivo_banco");

                entity.Property(e => e.NrSequencialLinhaBanco).HasColumnName("nr_sequencial_linha_banco");

                entity.Property(e => e.SqParcelamentoParcela).HasColumnName("sq_parcelamento_parcela");

                entity.Property(e => e.StProcessamento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_processamento")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblParcelamentoProcesso>(entity =>
            {
                entity.HasKey(e => e.SqParcelamentoProcessso)
                    .HasName("PK__tbl_parcelamento__3F3159AB");

                entity.ToTable("tbl_parcelamento_processo");

                entity.HasIndex(e => e.SqDocumento, "IN_tbl_parcelamento_processo_sq_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqParcelamento, "XIF2tbl_parcelamento_processo")
                    .HasFillFactor(50);

                entity.Property(e => e.SqParcelamentoProcessso).HasColumnName("sq_parcelamento_processso");

                entity.Property(e => e.DaLoteBanco)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_lote_banco");

                entity.Property(e => e.DataOcorrencia).HasColumnType("smalldatetime");

                entity.Property(e => e.FlImputar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fl_imputar")
                    .IsFixedLength();

                entity.Property(e => e.Iddocumento).HasColumnName("IDDocumento");

                entity.Property(e => e.Idsituacao).HasColumnName("IDSituacao");

                entity.Property(e => e.NrSequencialArquivoBanco).HasColumnName("nr_sequencial_arquivo_banco");

                entity.Property(e => e.NrSequencialLinhaBanco).HasColumnName("nr_sequencial_linha_banco");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.SqParcelamento).HasColumnName("sq_parcelamento");

                entity.Property(e => e.VlAtualizado)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_atualizado");

                entity.HasOne(d => d.SqParcelamentoNavigation)
                    .WithMany(p => p.TblParcelamentoProcessos)
                    .HasForeignKey(d => d.SqParcelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_parcelamento_parcelamento_processo");
            });

            modelBuilder.Entity<TblPef>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_pef__0C1BC9F9");

                entity.ToTable("tbl_pef");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.Ciot)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CIOT");

                entity.Property(e => e.CoGrupoInfracao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_grupo_infracao")
                    .IsFixedLength();

                entity.Property(e => e.Cpfmotorista)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CPFMotorista");

                entity.Property(e => e.DataEmissaoNf)
                    .HasColumnType("datetime")
                    .HasColumnName("DataEmissaoNF");

                entity.Property(e => e.DocumentoEmbarque)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsMotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_indeferimento");

                entity.Property(e => e.NoLinhaServico)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("no_linha_servico");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMotorista)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("no_motorista");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoPrefixo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("no_prefixo");

                entity.Property(e => e.NrCnhMotorista)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnh_motorista");

                entity.Property(e => e.NrDrfInfracao).HasColumnName("nr_drf_infracao");

                entity.Property(e => e.NrOrdemVeiculo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nr_ordem_veiculo");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo");

                entity.Property(e => e.TipoDocumentoEmbarque)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblPef)
                    .HasForeignKey<TblPef>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_pef__sq_do__0B27A5C0");
            });

            modelBuilder.Entity<TblPer>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_per__30592A6F");

                entity.ToTable("tbl_per");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.DaLimite)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblPer)
                    .HasForeignKey<TblPer>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_per__sq_docu__18A19C6F");
            });

            modelBuilder.Entity<TblPerfil>(entity =>
            {
                entity.HasKey(e => e.SqPerfil)
                    .HasName("PK__tbl_perfil__0DAF0CB0");

                entity.ToTable("tbl_perfil");

                entity.HasIndex(e => e.CoUsuario, "XIF12tbl_perfil")
                    .HasFillFactor(50);

                entity.HasIndex(e => e.CoModuloSistema, "XIF13tbl_perfil")
                    .HasFillFactor(50);

                entity.Property(e => e.SqPerfil)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_perfil");

                entity.Property(e => e.CoModuloSistema).HasColumnName("co_modulo_sistema");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DsPerfil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_perfil");

                entity.HasOne(d => d.CoModuloSistemaNavigation)
                    .WithMany(p => p.TblPerfils)
                    .HasForeignKey(d => d.CoModuloSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_perfi__co_mo__1A14E395");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.TblPerfils)
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_perfi__co_us__1699586C");
            });

            modelBuilder.Entity<TblRestituicoesDocumento>(entity =>
            {
                entity.HasKey(e => e.SqRestituicoesDocumento)
                    .HasName("PK_TBL_RESTITUICOES_DOCUMENTO");

                entity.ToTable("tbl_restituicoes_documento");

                entity.HasComment("Entidade responsavel pelas restituições dos documentos. ");

                entity.Property(e => e.SqRestituicoesDocumento)
                    .HasColumnName("sq_restituicoes_documento")
                    .HasComment("Código sequencial da tabela tbl_restituicoes_parcelamento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao")
                    .HasComment("Observações que serão feitas referente as resituiçoes dos documentos.");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_alteracao")
                    .HasComment("Data de alteração");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_pagamento")
                    .HasComment("Data do pagamento referente as resituiçoes do documentos.");

                entity.Property(e => e.NrOrdemBancaria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_ordem_bancaria")
                    .HasComment("Número da ordem bancária do documentos referente a restituição");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo")
                    .HasComment("Número do Processo");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.UsrOperacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usr_operacao")
                    .HasComment("Usuário que realizou a operação");

                entity.Property(e => e.VlRestituir)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_restituir")
                    .HasComment("Valor a resituir para o cliente referente aos documentos.");

                entity.Property(e => e.VlSelic)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_selic")
                    .HasComment("Valor da Selic referente aos documentos.");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithMany(p => p.TblRestituicoesDocumentos)
                    .HasForeignKey(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_REST_REFERENCE_TBL_DOCU");
            });

            modelBuilder.Entity<TblRestituicoesParcelamento>(entity =>
            {
                entity.HasKey(e => e.SqRestituicoesParcelamento)
                    .HasName("PK_TBL_RESTITUICOES_PARCELAMEN");

                entity.ToTable("tbl_restituicoes_parcelamento");

                entity.HasComment("Entidade responsavel pelas restituições dos parcelamentos. ");

                entity.HasIndex(e => e.SqParcelamento, "in_fk_tbl_restituicoes_parcelamento_sq_parcelamento");

                entity.HasIndex(e => e.SqParcelamentoParcela, "in_fk_tbl_restituicoes_parcelamento_sq_parcelamento_parcela");

                entity.Property(e => e.SqRestituicoesParcelamento)
                    .HasColumnName("sq_restituicoes_parcelamento")
                    .HasComment("Código sequencial da tabela tbl_restituicoes_parcelamento");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ds_observacao")
                    .HasComment("Observações que serão feitas referente as resituiçoes dos parcelamentos");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_alteracao")
                    .HasComment("Data de alteração");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_pagamento")
                    .HasComment("Data do pagamento referente as resituiçoes do parcelamento");

                entity.Property(e => e.NrOrdemBancaria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_ordem_bancaria")
                    .HasComment("Número da ordem bancária para o pagamento da restituição");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo")
                    .HasComment("Número do Processo");

                entity.Property(e => e.SqParcelamento)
                    .HasColumnName("sq_parcelamento")
                    .HasComment("Código sequencial da tabela tbl_parcelamento");

                entity.Property(e => e.SqParcelamentoParcela)
                    .HasColumnName("sq_parcelamento_parcela")
                    .HasComment("Código sequencial da tabela tbl_parcelamento_parcela");

                entity.Property(e => e.UsrOperacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usr_operacao")
                    .HasComment("Usuário que realizou a operação");

                entity.Property(e => e.VlRestituir)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_restituir")
                    .HasComment("Valor a resituir para o cliente referente aos parcelamentos.");

                entity.Property(e => e.VlSelic)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_selic")
                    .HasComment("Valor da Selic referente aos parcelamentos.");

                entity.HasOne(d => d.SqParcelamentoNavigation)
                    .WithMany(p => p.TblRestituicoesParcelamentos)
                    .HasForeignKey(d => d.SqParcelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbl_parcelamento_tbl_restituicoes_parcelamento");

                entity.HasOne(d => d.SqParcelamentoParcelaNavigation)
                    .WithMany(p => p.TblRestituicoesParcelamentos)
                    .HasForeignKey(d => d.SqParcelamentoParcela)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbl_parcelamento_parcela_tbl_restituicoes_parcelamento");
            });

            modelBuilder.Entity<TblRntrc>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_rntrc__2882FE7D");

                entity.ToTable("tbl_rntrc");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.DsMotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_indeferimento");

                entity.Property(e => e.DsTipoTransportador)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_transportador");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMotorista)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("no_motorista");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoMunicipioPlacaVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_placa_veiculo");

                entity.Property(e => e.NrCnhMotorista)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnh_motorista");

                entity.Property(e => e.NrCpfMotorista)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_motorista");

                entity.Property(e => e.NrCrntrc)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_crntrc");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo");

                entity.Property(e => e.NrRenavam)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("nr_renavam");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblRntrc)
                    .HasForeignKey<TblRntrc>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_rntrc__sq_do__16B953FD");
            });

            modelBuilder.Entity<TblSac>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_sac__0C1BC9F9");

                entity.ToTable("tbl_sac");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.CoGrupoInfracao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_grupo_infracao")
                    .IsFixedLength();

                entity.Property(e => e.DsMotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_indeferimento");

                entity.Property(e => e.NoLinhaServico)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("no_linha_servico");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMotorista)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("no_motorista");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoPrefixo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("no_prefixo");

                entity.Property(e => e.NrCnhMotorista)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnh_motorista");

                entity.Property(e => e.NrDrfInfracao).HasColumnName("nr_drf_infracao");

                entity.Property(e => e.NrOrdemVeiculo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nr_ordem_veiculo");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo");

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblSac)
                    .HasForeignKey<TblSac>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_sac__sq_do__0B27A5C0");
            });

            modelBuilder.Entity<TblSequencialBoletoBancarioAtit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sequencial_boleto_bancario_ATIT");

                entity.Property(e => e.AaUltimoSequencialBoletoBancarioAtit).HasColumnName("aa_ultimo_sequencial_boleto_bancario_atit");

                entity.Property(e => e.NrUltimoSequencialBoletoBancarioAtit).HasColumnName("nr_ultimo_sequencial_boleto_bancario_atit");
            });

            modelBuilder.Entity<TblSequencialDocumentoCobranca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sequencial_documento_cobranca");

                entity.Property(e => e.AaUltimoSequencialDocumentoCobranca).HasColumnName("aa_ultimo_sequencial_documento_cobranca");

                entity.Property(e => e.NrUltimoSequencialDocumentoCobranca).HasColumnName("nr_ultimo_sequencial_documento_cobranca");
            });

            modelBuilder.Entity<TblSerasaAnaliseSugestao>(entity =>
            {
                entity.HasKey(e => e.InAnalise);

                entity.ToTable("tbl_serasa_analise_sugestao");

                entity.Property(e => e.InAnalise)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("in_analise");

                entity.Property(e => e.DsAnalise)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_analise");
            });

            modelBuilder.Entity<TblSerasaBlacklist>(entity =>
            {
                entity.HasKey(e => e.IdblackList)
                    .HasName("PK__tbl_sera__051B52317246E95D");

                entity.ToTable("tbl_serasa_blacklist");

                entity.Property(e => e.IdblackList).HasColumnName("IDBlackList");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaAtualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_atualizacao");

                entity.Property(e => e.DaCiencia)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_ciencia");

                entity.Property(e => e.DaRevogacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_revogacao");

                entity.Property(e => e.IdblackListLote).HasColumnName("IDBlackListLote");

                entity.Property(e => e.Idsistema).HasColumnName("IDSistema");

                entity.Property(e => e.Idstatus).HasColumnName("IDStatus");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");

                entity.Property(e => e.NoJustificativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_justificativa");

                entity.Property(e => e.NrCnpjCpfPessoa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_cpf_pessoa");
            });

            modelBuilder.Entity<TblSerasaBlacklistLog>(entity =>
            {
                entity.HasKey(e => e.IdblackListLog)
                    .HasName("PK__tbl_sera__73CBFDD376177A41");

                entity.ToTable("tbl_serasa_blacklist_log");

                entity.Property(e => e.IdblackListLog).HasColumnName("IDBlackList_log");

                entity.Property(e => e.CoOperacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_operacao");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaAtualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_atualizacao");

                entity.Property(e => e.DaCiencia)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_ciencia");

                entity.Property(e => e.DaRevogacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_revogacao");

                entity.Property(e => e.IdblackList).HasColumnName("IDBlackList");

                entity.Property(e => e.IdblackListLote).HasColumnName("IDBlackListLote");

                entity.Property(e => e.Idsistema).HasColumnName("IDSistema");

                entity.Property(e => e.Idstatus).HasColumnName("IDStatus");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");

                entity.Property(e => e.NoJustificativa)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_justificativa");

                entity.Property(e => e.NrCnpjCpfPessoa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_cpf_pessoa");
            });

            modelBuilder.Entity<TblSerasaBlacklistLote>(entity =>
            {
                entity.HasKey(e => e.IdblackListLote)
                    .HasName("PK__tbl_sera__DEF98F6A009508B4");

                entity.ToTable("tbl_serasa_blacklist_lote");

                entity.Property(e => e.IdblackListLote).HasColumnName("IDBlackListLote");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaCiencia)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_ciencia");

                entity.Property(e => e.DaProcessamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_processamento");

                entity.Property(e => e.DaRevogacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_revogacao");

                entity.Property(e => e.Idstatus).HasColumnName("IDStatus");

                entity.Property(e => e.NoJustificativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_justificativa");

                entity.Property(e => e.NrLote)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_lote");
            });

            modelBuilder.Entity<TblSerasaBlacklistLoteLog>(entity =>
            {
                entity.HasKey(e => e.IdblackListLoteLog)
                    .HasName("PK__tbl_sera__35E896747CC477D0");

                entity.ToTable("tbl_serasa_blacklist_lote_log");

                entity.Property(e => e.IdblackListLoteLog).HasColumnName("IDBlackListLote_log");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaProcessamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_processamento");

                entity.Property(e => e.ErroRegistro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdblackListLote).HasColumnName("IDBlackListLote");
            });

            modelBuilder.Entity<TblSerasaBlacklistSistema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_serasa_blacklist_sistema");

                entity.Property(e => e.Idsistema).HasColumnName("IDSistema");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSerasaBlacklistStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_serasa_blacklist_status");

                entity.Property(e => e.DescricaoStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idstatus).HasColumnName("IDStatus");
            });

            modelBuilder.Entity<TblSerasaBlacklistTipoDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_serasa_blacklist_tipo_documento");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idsistema).HasColumnName("IDSistema");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");
            });

            modelBuilder.Entity<TblSerasaCodigoErro>(entity =>
            {
                entity.HasKey(e => e.SqSerasaCodigoErro)
                    .HasName("PK__tbl_serasa_codig__0F4D3C5F");

                entity.ToTable("tbl_serasa_codigo_erro");

                entity.Property(e => e.SqSerasaCodigoErro).HasColumnName("sq_serasa_codigo_erro");

                entity.Property(e => e.CoSerasaErro)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("co_serasa_erro")
                    .IsFixedLength();

                entity.Property(e => e.DsSerasaErro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ds_serasa_erro");
            });

            modelBuilder.Entity<TblSerasaDocumento>(entity =>
            {
                entity.HasKey(e => e.SqSerasaDocumento)
                    .HasName("PK__tbl_serasa_docum__57FD0775");

                entity.ToTable("tbl_serasa_documento");

                entity.HasIndex(e => e.InDividaAtiva, "IN_tbl_serasa_documento_sq_documento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SqDocumento, "IN_tbl_serasa_documento_sq_documento_02")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.CoOperacao, "in_serasa_documento_co_operacao")
                    .HasFillFactor(80);

                entity.Property(e => e.SqSerasaDocumento).HasColumnName("sq_serasa_documento");

                entity.Property(e => e.CoOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_operacao")
                    .IsFixedLength();

                entity.Property(e => e.CoSerasaErro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("co_serasa_erro");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaRetorno)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_retorno");

                entity.Property(e => e.IddocumentoSgm).HasColumnName("IDDocumentoSgm");

                entity.Property(e => e.IddocumentoSismultas).HasColumnName("IDDocumentoSismultas");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");

                entity.Property(e => e.InDividaAtiva).HasColumnName("in_divida_ativa");

                entity.Property(e => e.InSituacao).HasColumnName("in_situacao");

                entity.Property(e => e.InTipoPessoa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("in_tipo_pessoa")
                    .IsFixedLength();

                entity.Property(e => e.NoBairroPessoa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_pessoa");

                entity.Property(e => e.NoEnderecoPessoa)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_pessoa");

                entity.Property(e => e.NoMunicipioPessoa)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_pessoa");

                entity.Property(e => e.NrCepPessoa)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_pessoa")
                    .IsFixedLength();

                entity.Property(e => e.NrCnpjCpfPessoa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_cpf_pessoa");

                entity.Property(e => e.NrContrato)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("nr_contrato");

                entity.Property(e => e.NrSequenciaRegistroLote).HasColumnName("nr_sequencia_registro_lote");

                entity.Property(e => e.SgUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf")
                    .IsFixedLength();

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.SqSerasaLote).HasColumnName("sq_serasa_lote");

                entity.Property(e => e.SqSerasaMotivoBaixa).HasColumnName("sq_serasa_motivo_baixa");

                entity.Property(e => e.VlInscrito)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_inscrito");

                entity.HasOne(d => d.InSituacaoNavigation)
                    .WithMany(p => p.TblSerasaDocumentos)
                    .HasForeignKey(d => d.InSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SerasaSituacaoDocumento_SerasaDocumento");

                entity.HasOne(d => d.SqSerasaLoteNavigation)
                    .WithMany(p => p.TblSerasaDocumentos)
                    .HasForeignKey(d => d.SqSerasaLote)
                    .HasConstraintName("FK__tbl_seras__sq_se__1411F17C");

                entity.HasOne(d => d.SqSerasaMotivoBaixaNavigation)
                    .WithMany(p => p.TblSerasaDocumentos)
                    .HasForeignKey(d => d.SqSerasaMotivoBaixa)
                    .HasConstraintName("FK__tbl_seras__sq_se__1229A90A");
            });

            modelBuilder.Entity<TblSerasaDocumentoLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_serasa_documento_log");

                entity.Property(e => e.CoOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_operacao")
                    .IsFixedLength();

                entity.Property(e => e.CoSerasaErro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("co_serasa_erro");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaRetorno)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_retorno");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_atualizacao");

                entity.Property(e => e.IddocumentoSgm).HasColumnName("IDDocumentoSgm");

                entity.Property(e => e.IddocumentoSismultas).HasColumnName("IDDocumentoSismultas");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");

                entity.Property(e => e.InDividaAtiva).HasColumnName("in_divida_ativa");

                entity.Property(e => e.InSituacao).HasColumnName("in_situacao");

                entity.Property(e => e.InTipoPessoa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("in_tipo_pessoa")
                    .IsFixedLength();

                entity.Property(e => e.NoBairroPessoa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_pessoa");

                entity.Property(e => e.NoEnderecoPessoa)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_pessoa");

                entity.Property(e => e.NoMunicipioPessoa)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_pessoa");

                entity.Property(e => e.NrCepPessoa)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_pessoa")
                    .IsFixedLength();

                entity.Property(e => e.NrCnpjCpfPessoa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_cpf_pessoa");

                entity.Property(e => e.NrContrato)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("nr_contrato");

                entity.Property(e => e.NrSequenciaRegistroLote).HasColumnName("nr_sequencia_registro_lote");

                entity.Property(e => e.SgUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf")
                    .IsFixedLength();

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.SqSerasaDocumento).HasColumnName("sq_serasa_documento");

                entity.Property(e => e.SqSerasaDocumentoLog)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_serasa_documento_log");

                entity.Property(e => e.SqSerasaLote).HasColumnName("sq_serasa_lote");

                entity.Property(e => e.SqSerasaMotivoBaixa).HasColumnName("sq_serasa_motivo_baixa");

                entity.Property(e => e.VlInscrito)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_inscrito");
            });

            modelBuilder.Entity<TblSerasaHistoricoAlteracaoLote>(entity =>
            {
                entity.HasKey(e => e.SqSerasaHistoricoAlteracaoLote);

                entity.ToTable("tbl_serasa_historico_alteracao_lote");

                entity.Property(e => e.SqSerasaHistoricoAlteracaoLote).HasColumnName("sq_serasa_historico_alteracao_lote");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("data");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("motivo");

                entity.Property(e => e.SqSerasaLoteDestino).HasColumnName("sq_serasa_lote_destino");

                entity.Property(e => e.SqSerasaLoteOrigem).HasColumnName("sq_serasa_lote_origem");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<TblSerasaInformacional>(entity =>
            {
                entity.HasKey(e => e.SqSerasaInformacional)
                    .HasName("PK__tbl_serasa_infor__74994623");

                entity.ToTable("tbl_serasa_informacional");

                entity.Property(e => e.SqSerasaInformacional).HasColumnName("sq_serasa_informacional");

                entity.Property(e => e.CoOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_operacao")
                    .IsFixedLength();

                entity.Property(e => e.DaExclusao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_exclusao");

                entity.Property(e => e.DaInclusao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_inclusao");

                entity.Property(e => e.DaRemessa)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_remessa");

                entity.Property(e => e.NrCnpjCpfPessoa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_cpf_pessoa");

                entity.Property(e => e.NrContrato)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("nr_contrato");

                entity.Property(e => e.SqSerasaCodigoErro).HasColumnName("sq_serasa_codigo_erro");

                entity.Property(e => e.SqSerasaMotivoBaixa).HasColumnName("sq_serasa_motivo_baixa");

                entity.HasOne(d => d.SqSerasaCodigoErroNavigation)
                    .WithMany(p => p.TblSerasaInformacionals)
                    .HasForeignKey(d => d.SqSerasaCodigoErro)
                    .HasConstraintName("FK__tbl_seras__sq_se__2CDD9F46");

                entity.HasOne(d => d.SqSerasaMotivoBaixaNavigation)
                    .WithMany(p => p.TblSerasaInformacionals)
                    .HasForeignKey(d => d.SqSerasaMotivoBaixa)
                    .HasConstraintName("FK__tbl_seras__sq_se__2AF556D4");
            });

            modelBuilder.Entity<TblSerasaLote>(entity =>
            {
                entity.HasKey(e => e.SqSerasaLote)
                    .HasName("PK__tbl_serasa_lote__72B0FDB1");

                entity.ToTable("tbl_serasa_lote");

                entity.Property(e => e.SqSerasaLote).HasColumnName("sq_serasa_lote");

                entity.Property(e => e.CoErroSerasa)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("co_erro_serasa");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaLote)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_lote");

                entity.Property(e => e.NrQuantidadeRegistros).HasColumnName("nr_quantidade_registros");

                entity.Property(e => e.NrRemessa).HasColumnName("nr_remessa");
            });

            modelBuilder.Entity<TblSerasaMotivoBaixa>(entity =>
            {
                entity.HasKey(e => e.SqSerasaMotivoBaixa)
                    .HasName("PK__tbl_serasa_motiv__113584D1");

                entity.ToTable("tbl_serasa_motivo_baixa");

                entity.Property(e => e.SqSerasaMotivoBaixa).HasColumnName("sq_serasa_motivo_baixa");

                entity.Property(e => e.CoSerasaMotivoBaixa)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("co_serasa_motivo_baixa")
                    .IsFixedLength();

                entity.Property(e => e.DsSerasaMotivoBaixa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ds_serasa_motivo_baixa");
            });

            modelBuilder.Entity<TblSerasaParametro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_serasa_parametro");

                entity.Property(e => e.CoNaturezaOperacao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("co_natureza_operacao")
                    .IsFixedLength();

                entity.Property(e => e.NoContatoAntt)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("no_contato_ANTT")
                    .IsFixedLength();

                entity.Property(e => e.NrCnpjAntt)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("nr_CNPJ_ANTT")
                    .IsFixedLength();

                entity.Property(e => e.NrDddTelefoneAntt)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("nr_DDD_telefone_ANTT")
                    .IsFixedLength();

                entity.Property(e => e.NrFilialDigitoCnpjAntt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("nr_Filial_digito_CNPJ_ANTT")
                    .IsFixedLength();

                entity.Property(e => e.NrIdentificacaoArquivo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nr_identificacao_arquivo")
                    .IsFixedLength();

                entity.Property(e => e.NrRamalContatoAntt)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("nr_ramal_contato_ANTT")
                    .IsFixedLength();

                entity.Property(e => e.NrTelefoneAntt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_telefone_ANTT")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblSerasaSituacaoDocumento>(entity =>
            {
                entity.HasKey(e => e.InSituacao);

                entity.ToTable("tbl_serasa_situacao_documento");

                entity.Property(e => e.InSituacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("in_situacao");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_situacao");
            });

            modelBuilder.Entity<TblSerasaSugestao>(entity =>
            {
                entity.HasKey(e => e.SqSerasaSugestao)
                    .HasName("PK__tbl_serasa_suges__1CF15040");

                entity.ToTable("tbl_serasa_sugestao");

                entity.Property(e => e.SqSerasaSugestao).HasColumnName("sq_serasa_sugestao");

                entity.Property(e => e.DaAnalise)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_analise");

                entity.Property(e => e.DaGeracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_geracao");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.IddocumentoSgm).HasColumnName("IDDocumentoSgm");

                entity.Property(e => e.IddocumentoSismultas).HasColumnName("IDDocumentoSismultas");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("IDTipoDocumento");

                entity.Property(e => e.InAnalise)
                    .HasColumnName("in_analise")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.VlDevidoGeracao)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_devido_geracao");

                entity.HasOne(d => d.InAnaliseNavigation)
                    .WithMany(p => p.TblSerasaSugestaos)
                    .HasForeignKey(d => d.InAnalise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SerasaAnaliseSugestao_SerasaSugestao");
            });

            modelBuilder.Entity<TblSituacaoDocumento>(entity =>
            {
                entity.HasKey(e => e.SqStDocumento);

                entity.ToTable("tbl_situacao_documento");

                entity.Property(e => e.SqStDocumento).HasColumnName("sq_st_documento");

                entity.Property(e => e.DsStDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_st_documento");
            });

            modelBuilder.Entity<TblStatusDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_status_documento");

                entity.Property(e => e.DsStDocumento)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_st_documento");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_inclusao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqStDocumento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sq_st_documento");

                entity.Property(e => e.StDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_documento")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblStatusFinanceiro>(entity =>
            {
                entity.HasKey(e => e.SqStatusFinanceiro);

                entity.ToTable("tbl_status_financeiro");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");
            });

            modelBuilder.Entity<TblSuperintendencium>(entity =>
            {
                entity.HasKey(e => e.SqSuperintendencia)
                    .HasName("PK__tbl_superintende__36B12243");

                entity.ToTable("tbl_superintendencia");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");
            });

            modelBuilder.Entity<TblTipoArrecadacao>(entity =>
            {
                entity.HasKey(e => e.SqTipoArrecadacao)
                    .HasName("PK__tbl_tipo_arrecad__3E52440B");

                entity.ToTable("tbl_tipo_arrecadacao");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.DsTipoArrecadacao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_arrecadacao");
            });

            modelBuilder.Entity<TblTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.SqTipoDocumento)
                    .HasName("PK__tbl_tipo_documen__52793849");

                entity.ToTable("tbl_tipo_documento");

                entity.HasIndex(e => e.SqSuperintendencia, "XIF1tbl_tipo_documento")
                    .HasFillFactor(50);

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira")
                    .IsFixedLength();

                entity.Property(e => e.CoGru).HasColumnName("co_gru");

                entity.Property(e => e.CoTipoDocumento).HasColumnName("co_tipo_documento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.InLancamentoManual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("in_lancamento_manual")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.InValoresReais)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("in_valores_reais")
                    .HasDefaultValueSql("('S')")
                    .IsFixedLength();

                entity.Property(e => e.NrConvenioBanco).HasColumnName("nr_convenio_banco");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.HasOne(d => d.SqGrupoDocumentoNavigation)
                    .WithMany(p => p.TblTipoDocumentos)
                    .HasForeignKey(d => d.SqGrupoDocumento)
                    .HasConstraintName("FK_tbl_tipo_documento_grupo_documento");

                entity.HasOne(d => d.SqSuperintendenciaNavigation)
                    .WithMany(p => p.TblTipoDocumentos)
                    .HasForeignKey(d => d.SqSuperintendencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_tipo___sq_su__086B34A6");
            });

            modelBuilder.Entity<TblTipoIndicador>(entity =>
            {
                entity.HasKey(e => e.SqTipoIndicador);

                entity.ToTable("tbl_tipo_indicador");

                entity.Property(e => e.SqTipoIndicador).HasColumnName("sq_tipo_indicador");

                entity.Property(e => e.CoIdentificadorPeriodicidade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_identificador_periodicidade")
                    .IsFixedLength();

                entity.Property(e => e.CoSiglaIndicador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("co_sigla_indicador");

                entity.Property(e => e.NoDescricaoIndicador)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao_indicador");
            });

            modelBuilder.Entity<TblTipoQuitacao>(entity =>
            {
                entity.HasKey(e => e.IdTpQuitacao);

                entity.ToTable("tbl_tipo_quitacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");
            });

            modelBuilder.Entity<TblTmpPostagemCorreio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_tmp_postagem_correios");

                entity.HasIndex(e => e.NrArDoc, "IX_tbl_tmp_postagem_correios")
                    .IsClustered()
                    .HasFillFactor(80);

                entity.Property(e => e.NrArDoc).HasColumnName("NR_AR_DOC");

                entity.Property(e => e.TxLinhaConfirmacaoPostagem)
                    .HasMaxLength(204)
                    .IsUnicode(false)
                    .HasColumnName("tx_linha_confirmacao_postagem")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTmpPostagemCorreiosOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_tmp_postagem_correios_old");

                entity.Property(e => e.TxLinhaConfirmacaoPostagem)
                    .HasMaxLength(204)
                    .IsUnicode(false)
                    .HasColumnName("tx_linha_confirmacao_postagem")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTrpp>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_trpp__F70021BB7211DF33");

                entity.ToTable("tbl_trpp");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.Alinea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CnpjcpfEmitente1)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJCPF_Emitente_1")
                    .IsFixedLength();

                entity.Property(e => e.CnpjcpfEmitente2)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJCPF_Emitente_2")
                    .IsFixedLength();

                entity.Property(e => e.DataEmissao1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DataEmissao_1");

                entity.Property(e => e.DataEmissao2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DataEmissao_2");

                entity.Property(e => e.DescricaoClassificacaoInfrator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoLegislacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoTipoDocumentoFiscal1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DescricaoTipoDocumentoFiscal_1");

                entity.Property(e => e.DescricaoTipoDocumentoFiscal2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DescricaoTipoDocumentoFiscal_2");

                entity.Property(e => e.DsMotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_indeferimento");

                entity.Property(e => e.DsTipoTransportador)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_transportador");

                entity.Property(e => e.IdtipoDocumentoFiscal1).HasColumnName("IDTipoDocumentoFiscal_1");

                entity.Property(e => e.IdtipoDocumentoFiscal2).HasColumnName("IDTipoDocumentoFiscal_2");

                entity.Property(e => e.Inciso)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MensagemNotificacao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoAutuadoReal)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado_real");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMotorista)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("no_motorista");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoMunicipioPlacaVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_placa_veiculo");

                entity.Property(e => e.NotificacaoAutuacaoEmitida).HasColumnType("smalldatetime");

                entity.Property(e => e.NotificacaoFinalMultaEmitida).HasColumnType("smalldatetime");

                entity.Property(e => e.NotificacaoMultaEmitida).HasColumnType("smalldatetime");

                entity.Property(e => e.NrCnhMotorista)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnh_motorista");

                entity.Property(e => e.NrCpfMotorista)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_motorista");

                entity.Property(e => e.NrCrntrc)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_crntrc");

                entity.Property(e => e.NrOnu1).HasColumnName("NrONU_1");

                entity.Property(e => e.NrOnu2).HasColumnName("NrONU_2");

                entity.Property(e => e.NrPlacaUnidComb1)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_placa_unid_comb_1");

                entity.Property(e => e.NrPlacaUnidComb2)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_placa_unid_comb_2");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo");

                entity.Property(e => e.NrRenavam)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("nr_renavam");

                entity.Property(e => e.NumeroDocumentoFiscal1).HasColumnName("NumeroDocumentoFiscal_1");

                entity.Property(e => e.NumeroDocumentoFiscal2).HasColumnName("NumeroDocumentoFiscal_2");

                entity.Property(e => e.PaisPlacaVeiculo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCargaTrpp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TipoCargaTRPP");

                entity.Property(e => e.VeiculoVazio)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblTrpp)
                    .HasForeignKey<TblTrpp>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_trpp__sq_doc__73FA27A5");
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.CoUsuario)
                    .HasName("PK__tbl_usuario__15A53433");

                entity.ToTable("tbl_usuario");

                entity.HasIndex(e => e.SqSuperintendencia, "XIF1tbl_usuario")
                    .HasFillFactor(50);

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaCadastroUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("da_cadastro_usuario");

                entity.Property(e => e.NoSenhaUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_senha_usuario");

                entity.Property(e => e.NoUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_usuario");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.StUsuario)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_usuario")
                    .IsFixedLength();

                entity.HasOne(d => d.SqSuperintendenciaNavigation)
                    .WithMany(p => p.TblUsuarios)
                    .HasForeignKey(d => d.SqSuperintendencia)
                    .HasConstraintName("FK__tbl_usuar__sq_su__0C3BC58A");
            });

            modelBuilder.Entity<TblValePedagio>(entity =>
            {
                entity.HasKey(e => e.SqDocumento)
                    .HasName("PK__tbl_vale_pedagio__4E1E9780");

                entity.ToTable("tbl_vale_pedagio");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.DaDocumentoEmbarque)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento_embarque");

                entity.Property(e => e.DsDetalheAmparoLegal)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ds_detalhe_amparo_legal");

                entity.Property(e => e.DsTipoDocumentoEmbarque)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento_embarque");

                entity.Property(e => e.NoAutuadoReal)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado_real");

                entity.Property(e => e.NoDescricao1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao1");

                entity.Property(e => e.NoDescricao2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao2");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMunicipioDestinoCarga)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_destino_carga");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoMunicipioOrigemCarga)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_origem_carga");

                entity.Property(e => e.NoResumoDescisao)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("no_resumo_descisao");

                entity.Property(e => e.NoRodoviaInfracao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("no_rodovia_infracao");

                entity.Property(e => e.NrDocumentoEmbarque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_documento_embarque");

                entity.Property(e => e.NrKmInfracao)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("nr_km_infracao");

                entity.Property(e => e.SgUfMunicipioDestinoCarga)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_municipio_destino_carga")
                    .IsFixedLength();

                entity.Property(e => e.SgUfMunicipioOrigemCarga)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_municipio_origem_carga")
                    .IsFixedLength();

                entity.HasOne(d => d.SqDocumentoNavigation)
                    .WithOne(p => p.TblValePedagio)
                    .HasForeignKey<TblValePedagio>(d => d.SqDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_vale___sq_do__4F12BBB9");
            });

            modelBuilder.Entity<TblVersaoLayout>(entity =>
            {
                entity.HasKey(e => new { e.CoVersaoLayout, e.SqFaseDocumento, e.SqTipoDocumento })
                    .HasName("PK85");

                entity.ToTable("tbl_versao_layout");

                entity.Property(e => e.CoVersaoLayout)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("co_versao_layout");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.CoSistemaOrigem).HasColumnName("co_sistema_origem");

                entity.Property(e => e.DaFinalVigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("da_final_vigencia");

                entity.Property(e => e.DaInicioVigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("da_inicio_vigencia");

                entity.Property(e => e.DsVersaoLayout)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_versao_layout");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.HasOne(d => d.SqFaseDocumentoNavigation)
                    .WithMany(p => p.TblVersaoLayouts)
                    .HasForeignKey(d => d.SqFaseDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_versa__sq_fa__13DCE752");

                entity.HasOne(d => d.SqOrigemDocumentoNavigation)
                    .WithMany(p => p.TblVersaoLayouts)
                    .HasForeignKey(d => d.SqOrigemDocumento)
                    .HasConstraintName("FK_versaolayout_origemdocumento");

                entity.HasOne(d => d.SqTipoDocumentoNavigation)
                    .WithMany(p => p.TblVersaoLayouts)
                    .HasForeignKey(d => d.SqTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_versa__sq_ti__14D10B8B");
            });

            modelBuilder.Entity<TblVisao>(entity =>
            {
                entity.HasKey(e => e.SqVisao)
                    .HasName("PK__tbl_visao__5C37ACAD");

                entity.ToTable("tbl_visao");

                entity.Property(e => e.SqVisao).HasColumnName("sq_visao");

                entity.Property(e => e.CoVisao).HasColumnName("co_visao");

                entity.Property(e => e.DsTextoRodape)
                    .HasColumnType("text")
                    .HasColumnName("ds_texto_rodape");

                entity.Property(e => e.DsVisao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_visao");

                entity.Property(e => e.InClassificaSuperintendencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("in_classifica_superintendencia")
                    .HasDefaultValueSql("('S')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TdMarcaVeiculo>(entity =>
            {
                entity.HasKey(e => e.CdMarcaVeiculo);

                entity.ToTable("TD_MARCA_VEICULO");

                entity.Property(e => e.CdMarcaVeiculo)
                    .ValueGeneratedNever()
                    .HasColumnName("CD_MARCA_VEICULO");

                entity.Property(e => e.DsMarcaVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DS_MARCA_VEICULO");

                entity.Property(e => e.SgMarcaVeiculo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SG_MARCA_VEICULO");
            });

            modelBuilder.Entity<TdTipoVeiculo>(entity =>
            {
                entity.HasKey(e => e.CdTipoVeiculo)
                    .HasName("PK_TB_TIPO_VEICULO");

                entity.ToTable("TD_TIPO_VEICULO");

                entity.Property(e => e.CdTipoVeiculo)
                    .ValueGeneratedNever()
                    .HasColumnName("CD_TIPO_VEICULO");

                entity.Property(e => e.NoTipoVeiculo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NO_TIPO_VEICULO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SgTipoVeiculo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SG_TIPO_VEICULO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp");

                entity.Property(e => e.C1).HasMaxLength(289);

                entity.Property(e => e.Teste2)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Temp170Serasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_170_serasa");

                entity.Property(e => e.CoOperacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_operacao");

                entity.Property(e => e.CoSerasaErro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_serasa_erro");

                entity.Property(e => e.DaLimitePagamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaRetorno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("da_retorno");

                entity.Property(e => e.IddocumentoSgm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDDocumentoSgm");

                entity.Property(e => e.IddocumentoSismultas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDDocumentoSismultas");

                entity.Property(e => e.IdtipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDTipoDocumento");

                entity.Property(e => e.InDividaAtiva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("in_divida_ativa");

                entity.Property(e => e.InSituacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("in_situacao");

                entity.Property(e => e.InTipoPessoa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("in_tipo_pessoa");

                entity.Property(e => e.NoBairroPessoa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_pessoa");

                entity.Property(e => e.NoEnderecoPessoa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_pessoa");

                entity.Property(e => e.NoMunicipioPessoa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_pessoa");

                entity.Property(e => e.NrCepPessoa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_pessoa");

                entity.Property(e => e.NrCnpjCpfPessoa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_cpf_pessoa");

                entity.Property(e => e.NrContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_contrato");

                entity.Property(e => e.NrSequenciaRegistroLote)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr_sequencia_registro_lote");

                entity.Property(e => e.SgUf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf");

                entity.Property(e => e.SqDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqSerasaDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sq_serasa_documento");

                entity.Property(e => e.SqSerasaLote)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sq_serasa_lote");

                entity.Property(e => e.SqSerasaMotivoBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sq_serasa_motivo_baixa");

                entity.Property(e => e.VlInscrito)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vl_inscrito");
            });

            modelBuilder.Entity<TempAuto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_AUTOS");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");
            });

            modelBuilder.Entity<TempDocumentoEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_documento_envio");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.DaBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("da_baixa");

                entity.Property(e => e.DaCancelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_cancelamento");

                entity.Property(e => e.DaExpedicao)
                    .HasColumnType("datetime")
                    .HasColumnName("da_expedicao");

                entity.Property(e => e.DaGeracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_geracao");

                entity.Property(e => e.DaImpressao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_impressao");

                entity.Property(e => e.DaPenalidade)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_penalidade");

                entity.Property(e => e.DaProcessamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_processamento");

                entity.Property(e => e.DaRetornoCorreio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_retorno_correio");

                entity.Property(e => e.DaTransmissao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_transmissao");

                entity.Property(e => e.EmailAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email_autuado");

                entity.Property(e => e.NoAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado");

                entity.Property(e => e.NoAutuadoReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado_real");

                entity.Property(e => e.NoBairroAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_autuado");

                entity.Property(e => e.NoEnderecoAutuado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_autuado");

                entity.Property(e => e.NoEnderecoImagemAr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_imagem_ar");

                entity.Property(e => e.NoImagemAr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_imagem_ar");

                entity.Property(e => e.NoMunicipioAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_autuado");

                entity.Property(e => e.NrArDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nr_ar_documento");

                entity.Property(e => e.NrCepAutuado)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.RPost).HasColumnName("r_post");

                entity.Property(e => e.SgUfAutuado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqLote)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_lote");

                entity.Property(e => e.SqLoteOrigem).HasColumnName("sq_lote_origem");

                entity.Property(e => e.SqMotivoBaixa).HasColumnName("sq_motivo_baixa");

                entity.Property(e => e.SqMotivoDevolucao).HasColumnName("sq_motivo_devolucao");

                entity.Property(e => e.StDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_documento")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempPublicoFuncao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_PUBLICO_FUNCAO");

                entity.Property(e => e.SqDocumento).HasColumnName("sq_documento");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDevido)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("VL_DEVIDO");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("VL_DOCUMENTO_CORRETO");

                entity.Property(e => e.VlMora)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("vl_mora");
            });

            modelBuilder.Entity<TempRelMovimentoPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_RelMovimentoPeriodo");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDevido)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("vl_devido");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<TempRelatorioArrecadacao03082018>(entity =>
            {
                entity.ToTable("TEMP_RELATORIO_ARRECADACAO_03082018");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");
            });

            modelBuilder.Entity<TlTblFinanceiraVlDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TL_TBL_FINANCEIRA_VL_DOCUMENTO");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ALTERACAO");

                entity.Property(e => e.Host)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOST");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Programa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMA");

                entity.Property(e => e.SqDocumento).HasColumnName("SQ_DOCUMENTO");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.Property(e => e.VlAlterado)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_ALTERADO");

                entity.Property(e => e.VlAnterior)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VL_ANTERIOR");
            });

            modelBuilder.Entity<TmpRelatorioArrecadacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_relatorio_arrecadacao");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlMoraMultaCorreta)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("vl_mora_multa_correta");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<TraceSesconetto>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__trace_sesconetto__7740A8A4");

                entity.ToTable("trace_sesconetto");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<Viewer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Viewer");

                entity.Property(e => e.CaminhoImagem)
                    .HasMaxLength(150)
                    .HasColumnName("caminho_imagem");

                entity.Property(e => e.CoImportado)
                    .HasColumnName("co_importado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodObjeto)
                    .HasMaxLength(13)
                    .HasColumnName("cod_objeto");

                entity.Property(e => e.CodObjetoNumerico).HasColumnName("cod_objetoNumerico");

                entity.Property(e => e.DtArmazenamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_Armazenamento");

                entity.Property(e => e.DtEntrega)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_Entrega");

                entity.Property(e => e.NomeImagem)
                    .HasMaxLength(30)
                    .HasColumnName("nome_Imagem");

                entity.Property(e => e.NumCd).HasColumnName("num_CD");

                entity.Property(e => e.NumLote).HasColumnName("num_Lote");
            });

            modelBuilder.Entity<ViwArEnviado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_ar_enviado");

                entity.Property(e => e.DaRetornoCorreio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_retorno_correio");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.NumeroAr)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NumeroAR");
            });

            modelBuilder.Entity<ViwCalculoAcrescimoDesconto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_calculo_acrescimo_desconto");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaTolerancia)
                    .HasColumnType("datetime")
                    .HasColumnName("da_tolerancia");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.ValorDolarAntesPagamento).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValorDolarVencimento).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValorSelic)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ValorSELIC");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMultaCorreta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa_correta");

                entity.Property(e => e.VlMoraMultaPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa_pagamento");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<ViwCalculoAcrescimoDescontoDolar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_calculo_acrescimo_desconto_dolar");

                entity.Property(e => e.DaIndice)
                    .HasColumnType("datetime")
                    .HasColumnName("da_indice");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.VlConvertido)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_convertido");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlIndice)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("vl_indice");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMultaCorreta)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_mora_multa_correta");

                entity.Property(e => e.VlMoraMultaPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa_pagamento");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<ViwDataAtual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_DataAtual");

                entity.Property(e => e.Data).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViwDivisaoOrgaoConveniado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viwDivisaoOrgaoConveniado");

                entity.Property(e => e.BairroDivisaoOrgaoConveniado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CepdivisaoOrgaoConveniado)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEPDivisaoOrgaoConveniado")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodigoHierarquiaDivisaoOrgaoConveniado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ContatoPrimarioDivisaoOrgaoConveniado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ContatoSecundarioDivisaoOrgaoConveniado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DescricaoMunicipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.EnderecoDivisaoOrgaoConveniado)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IddivisaoOrgaoConveniado).HasColumnName("IDDivisaoOrgaoConveniado");

                entity.Property(e => e.IdorgaoConveniado).HasColumnName("IDOrgaoConveniado");

                entity.Property(e => e.NomeDivisaoOrgaoConveniado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.SiglaDivisaoOrgaoConveniado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TelefoneDivisaoOrgaoConveniado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<ViwExtratoPagamentoAi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_extrato_pagamento_AI");

                entity.Property(e => e.AutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CpfCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ")
                    .IsFixedLength();

                entity.Property(e => e.DataCredito).HasColumnType("smalldatetime");

                entity.Property(e => e.DataLimitePagamento).HasColumnType("datetime");

                entity.Property(e => e.DataLimitePagamentoDesconto).HasColumnType("smalldatetime");

                entity.Property(e => e.DataVencimento).HasColumnType("smalldatetime");

                entity.Property(e => e.DebitoAtualizado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NomeAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoCredito).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.ValorDebito).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.ValorDescontoDevido1).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.ValorDescontoDevido2).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.ValorJurosMoraDiaria1).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.ValorJurosMoraDiaria2).HasColumnType("numeric(14, 2)");

                entity.Property(e => e.ValorJurosSelicDevido1).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.ValorJurosSelicDevido2).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.ValorMulta).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.ValorPago).HasColumnType("numeric(13, 2)");
            });

            modelBuilder.Entity<ViwFaseArDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_fase_ar_documento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.NoEnderecoImagemAr)
                    .HasMaxLength(201)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_imagem_ar");

                entity.Property(e => e.NoImagemAr)
                    .HasMaxLength(54)
                    .IsUnicode(false)
                    .HasColumnName("no_imagem_ar");

                entity.Property(e => e.NrArCompleto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_ar_completo");

                entity.Property(e => e.NrArDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nr_ar_documento");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");
            });

            modelBuilder.Entity<ViwFeriado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwFeriado");

                entity.Property(e => e.DataFeriado).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViwFiltroRelatorioMovimentoPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_filtro_relatorio_movimento_periodo");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");
            });

            modelBuilder.Entity<ViwInformacoesPagamentoDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_Informacoes_Pagamento_Documento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsTipoArrecadacao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_arrecadacao");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.NrAutoInfracao).HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDescontoCorreto)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("vl_desconto_correto");

                entity.Property(e => e.VlDevido)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_devido");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlMoraMultaCorreta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa_correta");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<ViwMovimentoDivergentePeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_movimento_divergente_periodo");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoTipoDocumento).HasColumnName("co_tipo_documento");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaTolerancia)
                    .HasColumnType("datetime")
                    .HasColumnName("da_tolerancia");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.Movimentoduplicado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("movimentoduplicado");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NrAgenciaRecebedora)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("nr_agencia_recebedora");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrBancoRecebedor)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("nr_banco_recebedor");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqOrgaoAutuador).HasColumnName("sq_orgao_autuador");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlMoraMultaCorreta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa_correta");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<ViwMovimentoDivergentePeriodoDolar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_movimento_divergente_periodo_dolar");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.DaLimitePagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite_pagamento");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.MovimentoDuplicado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqOrgaoAutuador).HasColumnName("sq_orgao_autuador");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConvertido)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_convertido");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlIndice)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("vl_indice");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlMoraMultaCorreta)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_mora_multa_correta");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<ViwMovimentoPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_movimento_periodo");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.FlRessarcido).HasColumnName("FL_RESSARCIDO");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<ViwMovimentoPeriodoHml042023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_MOVIMENTO_PERIODO_HML_04_2023");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<ViwMovimentoPeriodoHml042023Hml>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_MOVIMENTO_PERIODO_HML_04_2023_HML");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<ViwMovimentoPeriodoHml092022>(entity =>
            {
                entity.HasNoKey();

                entity.ToView(" viw_movimento_periodo_hml_09_2022");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<ViwMovimentoPeriodoPrd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_movimento_periodo_PRD");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<ViwMovimentoPeriodoPrd042023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_MOVIMENTO_PERIODO_PRD_04_2023");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<ViwMovimentoPeriodoPrd072022>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_movimento_periodo_prd_07_2022");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsStatusFinanceiro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ds_status_financeiro");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.InAproveitamentoCredito).HasColumnName("in_aproveitamento_credito");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqStatusFinanceiro).HasColumnName("sq_status_financeiro");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");

                entity.Property(e => e.VlResidual)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_residual");
            });

            modelBuilder.Entity<ViwMovimentoPeriodoV2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_movimento_periodo_V2");

                entity.Property(e => e.AaSequencialDocumento).HasColumnName("aa_sequencial_documento");

                entity.Property(e => e.CoOrgaoAutuador).HasColumnName("co_orgao_autuador");

                entity.Property(e => e.CoSuperintendencia).HasColumnName("co_superintendencia");

                entity.Property(e => e.CoTipoArrecadacao).HasColumnName("co_tipo_arrecadacao");

                entity.Property(e => e.CoVersaoLayout).HasColumnName("co_versao_layout");

                entity.Property(e => e.ConversaoEmRenda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DaConversaoRenda)
                    .HasColumnType("datetime")
                    .HasColumnName("da_conversao_renda");

                entity.Property(e => e.DaDepositoJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("da_deposito_judicial");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.Doc)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("doc");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.NrSequencialDocumento).HasColumnName("nr_sequencial_documento");

                entity.Property(e => e.PgtoJudicial)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("pgto_judicial");

                entity.Property(e => e.SqDepositoJudicial).HasColumnName("sq_deposito_judicial");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqGrupoDocumento).HasColumnName("sq_grupo_documento");

                entity.Property(e => e.SqOrigemDocumento).HasColumnName("sq_origem_documento");

                entity.Property(e => e.SqSuperintendencia).HasColumnName("sq_superintendencia");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.StVlComplemento)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("st_vl_complemento");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(15, 2)")
                    .HasColumnName("valor");

                entity.Property(e => e.VlConversaoRenda)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_conversao_renda");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlMoraMulta)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("vl_mora_multa");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<ViwObservacaoNotificacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_observacao_notificacao");

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.Obs)
                    .HasMaxLength(86)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwPagamentoCorretoReaisDolar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_pagamento_correto_reais_dolar");

                entity.Property(e => e.DaPagamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_pagamento");

                entity.Property(e => e.DaTolerancia)
                    .HasColumnType("datetime")
                    .HasColumnName("da_tolerancia");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrOrdemFinanceira).HasColumnName("nr_ordem_financeira");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqTipoArrecadacao).HasColumnName("sq_tipo_arrecadacao");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.ValorDolarAntesPagamento).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValorDolarVencimento).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValorSelic)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ValorSELIC");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_desconto");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoCorreto)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("vl_documento_correto");

                entity.Property(e => e.VlLimitePagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_limite_pagamento");

                entity.Property(e => e.VlMoraMultaCorreta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("vl_mora_multa_correta");

                entity.Property(e => e.VlMoraMultaPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_mora_multa_pagamento");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<ViwSuinfExcessoPeso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_suinf_excesso_peso");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira")
                    .IsFixedLength();

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaDocumentoEmbarque)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento_embarque");

                entity.Property(e => e.DaExpedicao)
                    .HasColumnType("datetime")
                    .HasColumnName("da_expedicao");

                entity.Property(e => e.DaGeracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_geracao");

                entity.Property(e => e.DaInfracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_infracao");

                entity.Property(e => e.DaLimite)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_limite");

                entity.Property(e => e.DaTransmissao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_transmissao");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsAutoridadeOrgaoAutuador)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ds_autoridade_Orgao_Autuador");

                entity.Property(e => e.DsObservacao)
                    .HasColumnType("text")
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.HrInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hr_infracao")
                    .IsFixedLength();

                entity.Property(e => e.MedicaoPermitidaCmt).HasColumnName("MedicaoPermitidaCMT");

                entity.Property(e => e.NoAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado");

                entity.Property(e => e.NoBairroAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_autuado");

                entity.Property(e => e.NoCategoriaVeiculo)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("no_categoria_veiculo");

                entity.Property(e => e.NoDescricaoInfracao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao_infracao");

                entity.Property(e => e.NoEnderecoAutuado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_autuado");

                entity.Property(e => e.NoEspecieCarga)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_especie_carga");

                entity.Property(e => e.NoEspecieVeiculo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("no_especie_veiculo");

                entity.Property(e => e.NoInstrumentoUtilizado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("no_instrumento_utilizado");

                entity.Property(e => e.NoMarcaVeiculo)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("no_marca_veiculo");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoModeloVeiculo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("no_modelo_veiculo");

                entity.Property(e => e.NoMunicipioAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_autuado");

                entity.Property(e => e.NoMunicipioVeiculo)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_veiculo");

                entity.Property(e => e.NoRodoviaInfracao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("no_rodovia_infracao");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrAutoInfracaoDv)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao_dv")
                    .IsFixedLength();

                entity.Property(e => e.NrCepAutuado)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrChassi)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("nr_chassi");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCodigoBarra)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("nr_codigo_barra")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrDocumentoEmbarque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_documento_embarque");

                entity.Property(e => e.NrExcessoVerificado).HasColumnName("nr_excesso_verificado");

                entity.Property(e => e.NrKmInfracao)
                    .HasColumnType("numeric(6, 1)")
                    .HasColumnName("nr_km_infracao");

                entity.Property(e => e.NrLinhaDigitavel)
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasColumnName("nr_linha_digitavel")
                    .IsFixedLength();

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrPesagemPermitida).HasColumnName("nr_pesagem_permitida");

                entity.Property(e => e.NrPesagemRealizada).HasColumnName("nr_pesagem_realizada");

                entity.Property(e => e.NrPlacaVeiculo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_placa_veiculo");

                entity.Property(e => e.NrRenavam)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nr_renavam");

                entity.Property(e => e.NrSubtipo).HasColumnName("nr_subtipo");

                entity.Property(e => e.NrTaraDeclarada)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("nr_tara_declarada");

                entity.Property(e => e.PenalidadeLinha1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PenalidadeLinha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SgUfAutuado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.SgUfInfracao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_infracao")
                    .IsFixedLength();

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqOrgaoAutuador).HasColumnName("sq_orgao_autuador");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.ValorMultaExcessoEixo).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.VlBaseMulta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_base_multa");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");
            });

            modelBuilder.Entity<ViwSuinfValePedagio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_suinf_vale_pedagio");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira")
                    .IsFixedLength();

                entity.Property(e => e.CoChaveDocumentoOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("co_chave_documento_origem");

                entity.Property(e => e.CoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("co_usuario");

                entity.Property(e => e.DaDocumentoEmbarque)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_documento_embarque");

                entity.Property(e => e.DaExpedicao)
                    .HasColumnType("datetime")
                    .HasColumnName("da_expedicao");

                entity.Property(e => e.DaGeracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_geracao");

                entity.Property(e => e.DaInfracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_infracao");

                entity.Property(e => e.DaTransmissao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_transmissao");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsAutoridadeOrgaoAutuador)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ds_autoridade_Orgao_Autuador");

                entity.Property(e => e.DsDetalheAmparoLegal)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ds_detalhe_amparo_legal");

                entity.Property(e => e.DsDetalheAmparoLegal2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ds_detalhe_amparo_legal_2");

                entity.Property(e => e.DsObservacao)
                    .HasColumnType("text")
                    .HasColumnName("ds_observacao");

                entity.Property(e => e.DsTipoDocumentoEmbarque)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento_embarque");

                entity.Property(e => e.HrInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hr_infracao")
                    .IsFixedLength();

                entity.Property(e => e.NoAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado");

                entity.Property(e => e.NoAutuadoReal)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado_real");

                entity.Property(e => e.NoBairroAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_autuado");

                entity.Property(e => e.NoDescricao1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao1");

                entity.Property(e => e.NoDescricao2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao2");

                entity.Property(e => e.NoEnderecoAutuado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_autuado");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMunicipioAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_autuado");

                entity.Property(e => e.NoMunicipioDestinoCarga)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_destino_carga");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoMunicipioOrigemCarga)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_origem_carga");

                entity.Property(e => e.NoResumoDescisao)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("no_resumo_descisao");

                entity.Property(e => e.NoRodoviaInfracao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("no_rodovia_infracao");

                entity.Property(e => e.NrAutoInfracaoDv)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao_dv")
                    .IsFixedLength();

                entity.Property(e => e.NrCepAutuado)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCodigoBarra)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("nr_codigo_barra")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrDocumentoEmbarque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_documento_embarque");

                entity.Property(e => e.NrKmInfracao)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("nr_km_infracao");

                entity.Property(e => e.NrLinhaDigitavel)
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasColumnName("nr_linha_digitavel")
                    .IsFixedLength();

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdemDocumentoEnvio).HasColumnName("nr_ordem_documento_envio");

                entity.Property(e => e.NrPlacaVeiculo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_placa_veiculo");

                entity.Property(e => e.NrSubtipo).HasColumnName("nr_subtipo");

                entity.Property(e => e.NumeroProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.SgUfAutuado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.SgUfInfracao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_infracao")
                    .IsFixedLength();

                entity.Property(e => e.SgUfMunicipioDestinoCarga)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_municipio_destino_carga")
                    .IsFixedLength();

                entity.Property(e => e.SgUfMunicipioOrigemCarga)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_municipio_origem_carga")
                    .IsFixedLength();

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqFaseDocumento).HasColumnName("sq_fase_documento");

                entity.Property(e => e.SqOrgaoAutuador).HasColumnName("sq_orgao_autuador");

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");
            });

            modelBuilder.Entity<ViwValoresInternacionaisTrpp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_valores_internacionais_trpp");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.VlInfracaoDolar)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vl_infracao_dolar");

                entity.Property(e => e.VlTaxaPtax)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("vl_taxa_ptax");
            });

            modelBuilder.Entity<Vlindicador>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vlindicador");

                entity.Property(e => e.ValorIndicador)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("VALOR_INDICADOR");
            });

            modelBuilder.Entity<VwAtitnotificacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ATITNotificacao");

                entity.Property(e => e.CoCarteira)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("co_carteira")
                    .IsFixedLength();

                entity.Property(e => e.CoInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("co_infracao");

                entity.Property(e => e.DaExpedicao)
                    .HasColumnType("datetime")
                    .HasColumnName("da_expedicao");

                entity.Property(e => e.DaGeracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_geracao");

                entity.Property(e => e.DaInfracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_infracao");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsMotivoIndeferimento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ds_motivo_indeferimento");

                entity.Property(e => e.HrInfracao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hr_infracao")
                    .IsFixedLength();

                entity.Property(e => e.Mensagemnotificacaoautuacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mensagemnotificacaoautuacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mensagemnotificacaofinalmulta)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mensagemnotificacaofinalmulta")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mensagemnotificacaomulta)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mensagemnotificacaomulta")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NoAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado");

                entity.Property(e => e.NoAutuadoReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_autuado_real");

                entity.Property(e => e.NoBairroAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_bairro_autuado");

                entity.Property(e => e.NoDescricaoInfracao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("no_descricao_infracao");

                entity.Property(e => e.NoEnderecoAutuado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_endereco_autuado");

                entity.Property(e => e.NoLocalidadeInfracao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_localidade_infracao");

                entity.Property(e => e.NoMensagem1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem1");

                entity.Property(e => e.NoMensagem2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem2");

                entity.Property(e => e.NoMensagem3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem3");

                entity.Property(e => e.NoMensagem4)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem4");

                entity.Property(e => e.NoMensagem5)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("no_mensagem5");

                entity.Property(e => e.NoMotorista)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("no_motorista");

                entity.Property(e => e.NoMunicipioAutuado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_autuado");

                entity.Property(e => e.NoMunicipioInfracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_infracao");

                entity.Property(e => e.NoMunicipioPlacaVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_municipio_placa_veiculo");

                entity.Property(e => e.NoPaisOrigem)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("no_pais_origem");

                entity.Property(e => e.NoPaisPlacaVeiculo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("no_pais_placa_veiculo");

                entity.Property(e => e.NrAnoLicencaOriginariaComplementar).HasColumnName("nr_ano_licenca_originaria_complementar");

                entity.Property(e => e.NrAutoInfracaoDv)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao_dv")
                    .IsFixedLength();

                entity.Property(e => e.NrCepAutuado)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_cep_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrChassiVeiculo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_chassi_veiculo");

                entity.Property(e => e.NrCnhMotorista)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnh_motorista");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCodigoBarra)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("nr_codigo_barra")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCrntrc)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_crntrc");

                entity.Property(e => e.NrLicencaOriginariaComplementar)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("nr_licenca_originaria_complementar");

                entity.Property(e => e.NrLinhaDigitavel)
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasColumnName("nr_linha_digitavel")
                    .IsFixedLength();

                entity.Property(e => e.NrNossoNumero)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nr_nosso_numero")
                    .IsFixedLength();

                entity.Property(e => e.NrPlacaVeiculo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_placa_veiculo");

                entity.Property(e => e.NrProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nr_processo");

                entity.Property(e => e.NrSubtipo).HasColumnName("nr_subtipo");

                entity.Property(e => e.SgUfAutuado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.SgUfInfracao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sg_uf_infracao")
                    .IsFixedLength();

                entity.Property(e => e.SqTipoDocumento).HasColumnName("sq_tipo_documento");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlDocumentoDolar)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("vl_documento_dolar");

                entity.Property(e => e.VlIndicePtax)
                    .HasColumnType("numeric(5, 4)")
                    .HasColumnName("vl_indice_ptax");
            });

            modelBuilder.Entity<VwEnvioCorreio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_envio_correios");

                entity.Property(e => e.AaEnvio).HasColumnName("aa_envio");

                entity.Property(e => e.DaGeracao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_geracao");

                entity.Property(e => e.DaRetornoCorreio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_retorno_correio");

                entity.Property(e => e.DaTransmissao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_transmissao");

                entity.Property(e => e.MmEnvio).HasColumnName("mm_envio");

                entity.Property(e => e.NrArDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nr_ar_documento");

                entity.Property(e => e.NrLote).HasColumnName("nr_lote");

                entity.Property(e => e.StDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_documento")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwObjetosEnviadosConfirmacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_objetos_enviados_confirmacao");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.DaTransmissao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_transmissao");

                entity.Property(e => e.Dia).HasColumnName("dia");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.NrLote).HasColumnName("nr_lote");

                entity.Property(e => e.NrObjetosConfirmados).HasColumnName("nr_objetos_confirmados");

                entity.Property(e => e.NrObjetosEnviados).HasColumnName("nr_objetos_enviados");

                entity.Property(e => e.NrObjetosRetorno).HasColumnName("nr_objetos_retorno");
            });

            modelBuilder.Entity<VwPostagemCorreio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_postagem_correios");

                entity.Property(e => e.CoTipoRegistro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("co_tipo_registro");

                entity.Property(e => e.NrAr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nr_ar");

                entity.Property(e => e.NrDvAr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nr_dv_ar");
            });

            modelBuilder.Entity<VwPostagemCorreiosConfirmacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_postagem_correios_confirmacao");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Dia).HasColumnName("dia");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.NrLote).HasColumnName("nr_lote");

                entity.Property(e => e.NrObjetosConfirmados).HasColumnName("nr_objetos_confirmados");

                entity.Property(e => e.NrObjetosEnviados).HasColumnName("nr_objetos_enviados");
            });

            modelBuilder.Entity<VwProcessaParcelamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Processa_Parcelamento");

                entity.Property(e => e.CnpjCpfAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DaVencimentoParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento_parcelamento");

                entity.Property(e => e.DescricaoSituacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DsStDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_st_documento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.DsTpQuitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tp_quitacao");

                entity.Property(e => e.Expr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlImputar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fl_imputar")
                    .IsFixedLength();

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrParcelas).HasColumnName("nr_parcelas");

                entity.Property(e => e.NumeroProcesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.SqDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sq_documento");

                entity.Property(e => e.SqParcelamento).HasColumnName("sq_parcelamento");

                entity.Property(e => e.VlAtualizado)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("vl_atualizado");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("vl_documento");

                entity.Property(e => e.VlRemanescente)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("vl_remanescente");
            });

            modelBuilder.Entity<VwRelacionamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_RELACIONAMENTO");

                entity.Property(e => e.ColunaTabelaReferenciada)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COLUNA_TABELA_REFERENCIADA");

                entity.Property(e => e.NomeColunaPai)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOME_COLUNA_PAI");

                entity.Property(e => e.NomeColunaPaiTipoDado)
                    .HasMaxLength(128)
                    .HasColumnName("NOME_COLUNA_PAI_TIPO_DADO");

                entity.Property(e => e.NomeConstraint)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOME_CONSTRAINT");

                entity.Property(e => e.NomeTabelaPai)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOME_TABELA_PAI");

                entity.Property(e => e.NomeTabelaReferenciada)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOME_TABELA_REFERENCIADA");

                entity.Property(e => e.TipoConstraint)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CONSTRAINT")
                    .UseCollation("Latin1_General_CI_AS_KS_WS");
            });

            modelBuilder.Entity<VwRelatorioParcelamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_relatorio_parcelamento");

                entity.Property(e => e.CnpjCpfAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.DaParcelamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_parcelamento");

                entity.Property(e => e.DaVencimento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("da_vencimento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_tipo_documento");

                entity.Property(e => e.IdTpQuitacao).HasColumnName("id_tp_quitacao");

                entity.Property(e => e.NoSuperintendencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_superintendencia");

                entity.Property(e => e.NrAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_auto_infracao");

                entity.Property(e => e.NrCnpjAutuado)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nr_cnpj_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrCpfAutuado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("nr_cpf_autuado")
                    .IsFixedLength();

                entity.Property(e => e.NrParcelas).HasColumnName("nr_parcelas");

                entity.Property(e => e.Numeroprocesso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numeroprocesso")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.SqParcelamento).HasColumnName("sq_parcelamento");

                entity.Property(e => e.VlAtualizado)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("vl_atualizado");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("vl_documento");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
