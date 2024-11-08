using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using API_Baixa_Sapiens;
using API_Baixa_Sapiens.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Text;
using Microsoft.Extensions.Configuration;
using DocumentFormat.OpenXml.InkML;
using System.Text.Json;
using static System.Net.WebRequestMethods;
using Microsoft.Extensions.Caching.Memory;


namespace API_Baixa_Sapiens.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class ExcelController : ControllerBase
    {

        
        private readonly IMemoryCache _memoryCache;
        private readonly IConfiguration _configuration;
        //private readonly string _connectionString;

        public ExcelController(IConfiguration configuration, IMemoryCache memoryCache)
        {
            _configuration = configuration;
            _memoryCache = memoryCache;
            //_connectionString = _configuration.GetConnectionString("DefaultConnection");

        }


        [HttpPost("ConvertToSql")]
        public IActionResult ConvertToSql()
        {
            try
            {
                var file = Request.Form.Files[0];

                if (file.Length == 0)
                {
                    return BadRequest("Nenhum arquivo enviado");
                }

                var fileExtension = Path.GetExtension(file.FileName);
                var fileName = Guid.NewGuid().ToString() + fileExtension;
                var filePath = Path.Combine(Path.GetTempPath(), fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // Armazena o SQL gerado no cache com uma chave
                _memoryCache.Set("ArquivoScriptGerado", ConvertExcelToSql(filePath));
                _memoryCache.Set("ArquivoScriptGerado1", ConvertExcelToSql1(filePath));
                _memoryCache.Set("ArquivoScriptGerado2", ConvertExcelToSqlParc(filePath));

                string arquivoScriptGerado = _memoryCache.Get<string>("ArquivoScriptGerado");

                if (string.IsNullOrEmpty(arquivoScriptGerado))
                {
                    return StatusCode(500, "Ocorreu um erro ao converter o arquivo");
                }

                // Retorna o SQL gerado como conteúdo da resposta HTTP
                return Content(arquivoScriptGerado, "text/plain");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro ao processar o arquivo: {ex.Message}");
            }
        }


        private string ConvertExcelToSql(string filePath)
        {
            try
            {
                var workbook = new XLWorkbook(filePath);
                var worksheet = workbook.Worksheet("Planilha1");

                var totalLinhas = worksheet.Rows().Count();
                StringBuilder scriptBuilder = new StringBuilder(); // Usamos StringBuilder para acumular o script SQL.

                scriptBuilder.AppendLine("SET DATEFORMAT YMD");
                scriptBuilder.AppendLine("DECLARE @qtdAutos INT,");
                scriptBuilder.AppendLine("@NR_AUTO_INFRACAO VARCHAR(20),");
                scriptBuilder.AppendLine("@CO_CHAVE_ORIGEM VARCHAR(20),");
                scriptBuilder.AppendLine("@DT_PAGAMENTO DATETIME,");
                scriptBuilder.AppendLine("@VL_PAGAMENTO NUMERIC(13,2),");
                scriptBuilder.AppendLine("@SQ_DOCUMENTO INT,");
                scriptBuilder.AppendLine("@NR_ORDEM_DOC_ENVIO INT,");
                scriptBuilder.AppendLine("@IDSITUACAOANTERIOR_MULTAS INT");
                scriptBuilder.AppendLine();

                if (totalLinhas < 2)
                {
                    return scriptBuilder.ToString(); // Retorna o script atual até este ponto.
                }

                scriptBuilder.AppendLine("IF OBJECT_ID('TEMPDB.DBO.#TBL_TEMP_AUTOS_BAIXA_MANUAL') IS NOT NULL");
                scriptBuilder.AppendLine("DROP TABLE #TBL_TEMP_AUTOS_BAIXA_MANUAL");

                scriptBuilder.AppendLine("CREATE TABLE #TBL_TEMP_AUTOS_BAIXA_MANUAL(Id INT IDENTITY(1, 1), CPF_CNPJ VARCHAR(20),");
                scriptBuilder.AppendLine("NR_AUTO_INFRACAO VARCHAR(20), CO_CHAVE_DOCUMENTO_ORIGEM VARCHAR(20), DT_PAGAMENTO DATETIME, VL_PAGAMENTO NUMERIC(13,2))");
                scriptBuilder.AppendLine();

                int comentarioLinha = 0;
                string ultimaLinhaCol_A = "";

                for (int l = 2; l <= totalLinhas; l++)
                {
                    ultimaLinhaCol_A = worksheet.Cell(l, "A").Value.ToString();

                    if (!string.IsNullOrEmpty(ultimaLinhaCol_A))
                    {
                        comentarioLinha++;
                        string cpfCnpj = worksheet.Cell(l, "C").Value.ToString().Trim().Replace("/", "").Replace("-", "");
                        string colunaE = worksheet.Cell(l, "E").Value.ToString().Trim() == "" ? "NULL" : worksheet.Cell(l, "E").Value.ToString().Trim();
                        string colunaData = Convert.ToDateTime(worksheet.Cell(l, "I").Value).ToString("yyyy/MM/dd HH:mm:ss");
                        string strSqlInsert = $"/* Linha {comentarioLinha} */" + $@"INSERT INTO #TBL_TEMP_AUTOS_BAIXA_MANUAL VALUES('{cpfCnpj}','{worksheet.Cell(l, "D").Value.ToString().Trim()}','{colunaE}' ,'{colunaData}' , CAST(REPLACE(REPLACE('{worksheet.Cell(l, "J").Value.ToString().Trim()}',' ', ''),',','.') AS NUMERIC(13,2)))" + "\n";
                        scriptBuilder.AppendLine(strSqlInsert);
                    }
                }

                scriptBuilder.AppendLine("SELECT DISTINCT\r\n\tCASE \r\n\t\tWHEN TD.CO_CHAVE_DOCUMENTO_ORIGEM IS NOT NULL THEN\r\n\t\t\t'AUTO BAIXADO NO ARRECADAÇÃO'\r\n\t\t\t\r\n\t\tELSE\r\n\t\t\t'NÃO FOI POSSIVEL BAIXAR NO ARRECADAÇÃO'\r\n\tEND AS 'EXISTE_ARRECADAÇÃO',\t\r\n\tTABM.ID,\r\n\tTABM.CPF_CNPJ,\r\n\tTABM.NR_AUTO_INFRACAO,\r\n\tTABM.DT_PAGAMENTO,\r\n\tTABM.VL_PAGAMENTO\t\r\nFROM \r\n\t\t\t\t#TBL_TEMP_AUTOS_BAIXA_MANUAL\tTABM\r\n\tLEFT JOIN\tBD_COBRANCA.DBO.TBL_DOCUMENTO\tTD\t\tWITH(NOLOCK) ON (\t(TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS)  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tAND (TD.NR_CNPJ_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_CPF_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS ))\r\n\r\nORDER BY 2\r\n\r\n-- Adiciona a lógica aos \"Encontrado no arrecadação\"\r\nIF EXISTS (SELECT * FROM #TBL_TEMP_AUTOS_BAIXA_MANUAL)\r\n\tBEGIN\r\n\t\tSELECT @qtdAutos = COUNT(*) FROM #TBL_TEMP_AUTOS_BAIXA_MANUAL \r\n\r\n\t\tPRINT 'ALTERAÇÃO DE ' + CAST(@qtdAutos AS VARCHAR(4))\r\n\r\n\r\nWHILE (@qtdAutos > 0)\r\n\tBEGIN\r\n\t\t\r\n\t\tSET @NR_AUTO_INFRACAO\t\t= NULL\t\t\r\n\t\tSET @CO_CHAVE_ORIGEM\t\t= NULL\t\t\r\n\t\tSET @DT_PAGAMENTO\t\t\t= NULL\r\n\t\tSET @VL_PAGAMENTO\t\t\t= NULL\r\n\t\tSET @SQ_DOCUMENTO\t\t\t= NULL\r\n\t\tSET @NR_ORDEM_DOC_ENVIO\t\t= NULL\r\n\r\n\t\tSELECT \r\n\t\t\t@NR_AUTO_INFRACAO\t= TABM.NR_AUTO_INFRACAO, \r\n\t\t\t@CO_CHAVE_ORIGEM\t= TD.CO_CHAVE_DOCUMENTO_ORIGEM, \r\n\t\t\t@DT_PAGAMENTO\t\t= DT_PAGAMENTO, \r\n\t\t\t@VL_PAGAMENTO\t\t= VL_PAGAMENTO \r\n\t\tFROM \r\n\t\t\t\t\t\t#TBL_TEMP_AUTOS_BAIXA_MANUAL\tTABM\r\n\t\t\tINNER JOIN\tBD_COBRANCA.DBO.TBL_DOCUMENTO\tTD\t\tWITH(NOLOCK) ON (\t(TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS)   \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tAND (TD.NR_CNPJ_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_CPF_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS ))\r\n\t\tWHERE \r\n\t\t\tID = @QTDAUTOS \r\n\r\n\t\tSELECT \r\n\t\t\t@SQ_DOCUMENTO\t\t= TD.SQ_DOCUMENTO,\r\n\t\t\t@NR_ORDEM_DOC_ENVIO = (SELECT MAX(NR_ORDEM_DOCUMENTO_ENVIO) FROM BD_COBRANCA.DBO.TBL_DOCUMENTO_ENVIO WITH(NOLOCK) WHERE SQ_DOCUMENTO = TD.SQ_DOCUMENTO)\r\n\t\tFROM\t\r\n\t\t\tBD_COBRANCA.DBO.TBL_DOCUMENTO\t\tTD\tWITH(NOLOCK) \r\n\t\tWHERE \r\n\t\t\t\tCO_CHAVE_DOCUMENTO_ORIGEM = @CO_CHAVE_ORIGEM \r\n\t\t\tAND SQ_FASE_DOCUMENTO = (\tSELECT MAX(SQ_FASE_DOCUMENTO) \r\n\t\t\t\t\t\t\t\t\t\tFROM BD_COBRANCA.DBO.TBL_DOCUMENTO WITH(NOLOCK) \r\n\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCO_CHAVE_DOCUMENTO_ORIGEM = @CO_CHAVE_ORIGEM \r\n\t\t\t\t\t\t\t\t\t\t\tAND SQ_FASE_DOCUMENTO <> 12\r\n\t\t\t\t\t\t\t\t\t)\r\n\r\n\t\tIF\t\t(@NR_AUTO_INFRACAO = '1833338' AND @CO_CHAVE_ORIGEM <> '1348606')\r\n\t\t\tOR  (@NR_AUTO_INFRACAO = '2438153' AND @CO_CHAVE_ORIGEM <> '1501827')\r\n\t\t\tBEGIN\r\n\t\t\t\tSET @NR_AUTO_INFRACAO\t\t= NULL\t\t\r\n\t\t\t\tSET @CO_CHAVE_ORIGEM\t\t= NULL\t\t\r\n\t\t\t\tSET @DT_PAGAMENTO\t\t\t= NULL\r\n\t\t\t\tSET @VL_PAGAMENTO\t\t\t= NULL\r\n\t\t\t\tSET @SQ_DOCUMENTO\t\t\t= NULL\r\n\t\t\t\tSET @NR_ORDEM_DOC_ENVIO\t\t= NULL\r\n\t\t\tEND\r\n\r\n\r\n\t\tPRINT 'EXECUÇÃO DE BAIXA MANUAL PARA O AI: ' + @NR_AUTO_INFRACAO + ' - CO_CHAVE_DOCUMENTO_ORIGEM: ' + @CO_CHAVE_ORIGEM + ' - DT_PAGAMENTO: ' + CAST(@DT_PAGAMENTO AS VARCHAR(20)) + ' - VL_PAGAMENTO: ' + CAST(@VL_PAGAMENTO AS VARCHAR(20))\r\n\r\n\t\tIF NOT EXISTS (SELECT 1\r\n\t\t\t\t\t\tFROM\t\r\n\t\t\t\t\t\t\tBD_COBRANCA.DBO.TBL_FINANCEIRA\tTF WITH(NOLOCK) \r\n\t\t\t\t\t\tWHERE\r\n\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\tAND DA_PAGAMENTO IS NOT NULL\r\n\t\t\t\t\t\t\tAND ID_TP_QUITACAO IN (26, 25)\r\n\t\t\t\t\t\t)\r\n\t\t\tBEGIN\t\t\t\t\t\t\t\t\t\r\n\t\t\t\tIF NOT EXISTS (\tSELECT 1\r\n\t\t\t\t\t\t\t\tFROM\t\r\n\t\t\t\t\t\t\t\t\tBD_COBRANCA.DBO.TBL_FINANCEIRA\tTF WITH(NOLOCK) \r\n\t\t\t\t\t\t\t\tWHERE\r\n\t\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\t\t\tAND DA_PAGAMENTO IS NOT NULL\r\n\t\t\t\t\t\t\t\t)\r\n\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\tPRINT ' SEM PAGAMENTO PRÉVIO '\r\n\r\n\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t\tUPDATE BD_COBRANCA.DBO.TBL_FINANCEIRA\r\n\t\t\t\t\t\t\tSET DA_PAGAMENTO\t\t= @DT_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tVL_PAGAMENTO\t\t= @VL_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tIN_BAIXA_AUTOMATICA = 0,\r\n\t\t\t\t\t\t\t\tDS_OBSERVACAO\t\t= 'AI BAIXADO ATRAVÉS DE ROTINA EM BANCO DE DADOS CONFORME SOLICITADO.',\r\n\t\t\t\t\t\t\t\tID_TP_QUITACAO\t\t= 26\r\n\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA FINANCEIRA DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA FINANCEIRA DO COBRANCA.'\r\n\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\tUPDATE BD_COBRANCA.DBO.TBL_DOCUMENTO_ENVIO\r\n\t\t\t\t\t\t\t\tSET ST_DOCUMENTO = 'P'\r\n\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA.'\r\n\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM)\r\n\t\t\t\t\t\t\tBEGIN\r\n\r\n\t\t\t\t\t\t\t\tPRINT 'É UM AI DO SISMULTAS'\r\n\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND IDSITUACAO <> 14)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tSET IDSITUACAO = 14 \r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\r\n\r\n\t\t\t\t\t\t\t\t\t\tSELECT \r\n\t\t\t\t\t\t\t\t\t\t\t@IDSITUACAOANTERIOR_MULTAS =  IDSITUACAOATUAL \r\n\t\t\t\t\t\t\t\t\t\tFROM \r\n\t\t\t\t\t\t\t\t\t\t\tBD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA \r\n\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM \r\n\t\t\t\t\t\t\t\t\t\t\tAND IDDOCUMENTOSITUACAOAUDITORIA = (SELECT MAX(IDDOCUMENTOSITUACAOAUDITORIA) FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM)\r\n\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tINSERT INTO BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA\r\n\t\t\t\t\t\t\t\t\t\t\tVALUES(GETDATE(), @CO_CHAVE_ORIGEM, 7707, @IDSITUACAOANTERIOR_MULTAS, 14, NULL) \r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND PAGAMENTO IS NULL)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO\r\n\t\t\t\t\t\t\t\t\t\t\tSET PAGAMENTO = @DT_PAGAMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tPRINT 'NÃO É UM AI DO SISMULTAS'\r\n\r\n\t\t\t\t\tEND \t\t\t\r\n\t\t\t\tELSE \r\n\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\tPRINT ' HOUVE UM PAGAMENTO PRÉVIO '\r\n\t\t\t\t\r\n\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\tINSERT INTO BD_COBRANCA.DBO.TBL_FINANCEIRA\r\n\t\t\t\t\t\t\tSELECT \r\n\t\t\t\t\t\t\t\tDA_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\tDA_VENCIMENTO,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\t(NR_ORDEM_FINANCEIRA + 1),\r\n\t\t\t\t\t\t\t\tVL_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tVL_DESCONTO,\r\n\t\t\t\t\t\t\t\tVL_MORA_MULTA,\r\n\t\t\t\t\t\t\t\t@DT_PAGAMENTO,\r\n\t\t\t\t\t\t\t\t@VL_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tCO_TIPO_CODIGO_BARRA,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\tDA_LIMITE_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tVL_LIMITE_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tSQ_TIPO_ARRECADACAO,\r\n\t\t\t\t\t\t\t\tSQ_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tNR_ORDEM_DOCUMENTO_ENVIO,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\t'AI BAIXADO ATRAVÉS DE ROTINA EM BANCO DE DADOS',\r\n\t\t\t\t\t\t\t\t0,\r\n\t\t\t\t\t\t\t\tVL_DOCUMENTO_DOLAR,\r\n\t\t\t\t\t\t\t\tVL_INDICE_PTAX,\r\n\t\t\t\t\t\t\t\tDA_INICIO_SELIC,\r\n\t\t\t\t\t\t\t\tDA_FIM_SELIC,\r\n\t\t\t\t\t\t\t\tPERCENTUAL_SELIC_MAISUMPORCENTO,\r\n\t\t\t\t\t\t\t\tVL_JUROS_SELIC_MAISUMPORCENTO,\r\n\t\t\t\t\t\t\t\tVL_PERCENTUAL_MULTA_MORA,\r\n\t\t\t\t\t\t\t\tIN_VALOR_COMPLEMENTAR,\r\n\t\t\t\t\t\t\t\t26,\r\n\t\t\t\t\t\t\t\tDA_CONVERSAO_RENDA,\r\n\t\t\t\t\t\t\t\tVL_CONVERSAO_RENDA,\r\n\t\t\t\t\t\t\t\tVL_RESIDUAL,\r\n\t\t\t\t\t\t\t\tSQ_STATUS_FINANCEIRO,\r\n\t\t\t\t\t\t\t\tVL_HIST_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tVL_HIST_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tDA_VENCIMENTO_PARCELAMENTO\r\n\t\t\t\t\t\t\tFROM \r\n\t\t\t\t\t\t\t\tBD_COBRANCA.DBO.TBL_FINANCEIRA WITH(NOLOCK) \r\n\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\t\tFROM BD_COBRANCA.DBO.TBL_FINANCEIRA WITH(NOLOCK) WHERE SQ_DOCUMENTO = @SQ_DOCUMENTO AND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO)\r\n\t\t\t\t\r\n\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA FINANCEIRA DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA FINANCEIRA DO COBRANCA.'\r\n\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\tUPDATE BD_COBRANCA.DBO.TBL_DOCUMENTO_ENVIO\r\n\t\t\t\t\t\t\tSET ST_DOCUMENTO = 'P'\r\n\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\r\n\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA.'\r\n\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\tEND \r\n\r\n\r\n\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM)\r\n\t\t\t\t\t\t\tBEGIN\r\n\r\n\t\t\t\t\t\t\t\tPRINT 'É UM AI DO SISMULTAS'\r\n\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND IDSITUACAO <> 14)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tSET IDSITUACAO = 14 \r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\t\t \r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\r\n\r\n\t\t\t\t\t\t\t\t\t\tSELECT \r\n\t\t\t\t\t\t\t\t\t\t\t@IDSITUACAOANTERIOR_MULTAS =  IDSITUACAOATUAL \r\n\t\t\t\t\t\t\t\t\t\tFROM \r\n\t\t\t\t\t\t\t\t\t\t\tBD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA \r\n\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\tAND IDDOCUMENTOSITUACAOAUDITORIA = (SELECT MAX(IDDOCUMENTOSITUACAOAUDITORIA) FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM)\r\n\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tINSERT INTO BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA\r\n\t\t\t\t\t\t\t\t\t\t\tVALUES(GETDATE(), @CO_CHAVE_ORIGEM, 7707, @IDSITUACAOANTERIOR_MULTAS, 14, NULL) \r\n\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND PAGAMENTO IS NULL)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO\r\n\t\t\t\t\t\t\t\t\t\t\tSET PAGAMENTO = @DT_PAGAMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tPRINT 'NÃO É UM AI DO SISMULTAS'\r\n\t\t\t\t\tEND\r\n\t\t\tEND\r\n\t\tELSE\r\n\t\t\tBEGIN\r\n\t\t\t\tPRINT ' JÁ HOUVE BAIXA SAPIENS PARA ESTE AUTO.'\r\n\t\t\tEND\r\n\t\t\t\t\t\r\n\t\tSET @qtdAutos = @qtdAutos - 1\r\n\tEND\r\n\r\n\tPRINT 'SCRIPT FINALIZADO!' + CAST(@qtdAutos AS VARCHAR(5)) + 'REGISTROS ATUALIZADOS'\r\n\r\n\tEND");

                return scriptBuilder.ToString(); // Retorna o script SQL completo como uma string.
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao converter o arquivo: {ex.Message}");
            }
        }

        private string ConvertExcelToSqlParc(string filePath)
        {
            try
            {
                var workbook = new XLWorkbook(filePath);
                var worksheet = workbook.Worksheet("Planilha1");

                var totalLinhas = worksheet.Rows().Count();
                StringBuilder scriptBuilder = new StringBuilder(); // Usamos StringBuilder para acumular o script SQL.

                scriptBuilder.AppendLine("SET DATEFORMAT YMD");
                scriptBuilder.AppendLine("DECLARE @qtdAutos INT,");
                scriptBuilder.AppendLine("@NR_AUTO_INFRACAO VARCHAR(20),");
                scriptBuilder.AppendLine("@CO_CHAVE_ORIGEM VARCHAR(20),");
                scriptBuilder.AppendLine("@DT_PAGAMENTO DATETIME,");
                scriptBuilder.AppendLine("@VL_PAGAMENTO NUMERIC(13,2),");
                scriptBuilder.AppendLine("@SQ_DOCUMENTO INT,");
                scriptBuilder.AppendLine("@NR_ORDEM_DOC_ENVIO INT,");
                scriptBuilder.AppendLine("@IDSITUACAOANTERIOR_MULTAS INT");
                scriptBuilder.AppendLine();

                if (totalLinhas < 2)
                {
                    return scriptBuilder.ToString(); // Retorna o script atual até este ponto.
                }

                scriptBuilder.AppendLine("IF OBJECT_ID('TEMPDB.DBO.#TBL_TEMP_AUTOS_BAIXA_MANUAL') IS NOT NULL");
                scriptBuilder.AppendLine("DROP TABLE #TBL_TEMP_AUTOS_BAIXA_MANUAL");

                scriptBuilder.AppendLine("CREATE TABLE #TBL_TEMP_AUTOS_BAIXA_MANUAL(Id INT IDENTITY(1, 1), CPF_CNPJ VARCHAR(20),");
                scriptBuilder.AppendLine("NR_AUTO_INFRACAO VARCHAR(20), CO_CHAVE_DOCUMENTO_ORIGEM VARCHAR(20), DT_PAGAMENTO DATETIME, VL_PAGAMENTO NUMERIC(13,2))");
                scriptBuilder.AppendLine();

                int comentarioLinha = 0;
                string ultimaLinhaCol_A = "";

                for (int l = 2; l <= totalLinhas; l++)
                {
                    ultimaLinhaCol_A = worksheet.Cell(l, "A").Value.ToString();

                    if (!string.IsNullOrEmpty(ultimaLinhaCol_A))
                    {
                        comentarioLinha++;
                        string cpfCnpj = worksheet.Cell(l, "C").Value.ToString().Trim().Replace("/", "").Replace("-", "");
                        string colunaE = worksheet.Cell(l, "E").Value.ToString().Trim() == "" ? "NULL" : worksheet.Cell(l, "E").Value.ToString().Trim();
                        string colunaData = Convert.ToDateTime(worksheet.Cell(l, "I").Value).ToString("yyyy/MM/dd HH:mm:ss");
                        string strSqlInsert = $"/* Linha {comentarioLinha} */" + $@"INSERT INTO #TBL_TEMP_AUTOS_BAIXA_MANUAL VALUES('{cpfCnpj}','{worksheet.Cell(l, "D").Value.ToString().Trim()}','{colunaE}' ,'{colunaData}' , CAST(REPLACE(REPLACE('{worksheet.Cell(l, "J").Value.ToString().Trim()}',' ', ''),',','.') AS NUMERIC(13,2)))" + "\n";
                        scriptBuilder.AppendLine(strSqlInsert);
                    }
                }

                scriptBuilder.AppendLine("SELECT DISTINCT\r\n\tCASE \r\n\t\tWHEN TD.CO_CHAVE_DOCUMENTO_ORIGEM IS NOT NULL THEN\r\n\t\t\t'AUTO BAIXADO NO ARRECADAÇÃO'\r\n\t\t\t\r\n\t\tELSE\r\n\t\t\t'NÃO FOI POSSIVEL BAIXAR NO ARRECADAÇÃO'\r\n\tEND AS 'EXISTE_ARRECADAÇÃO',\t\r\n\tTABM.ID,\r\n\tTABM.CPF_CNPJ,\r\n\tTABM.NR_AUTO_INFRACAO,\r\n\tTABM.DT_PAGAMENTO,\r\n\tTABM.VL_PAGAMENTO\t\r\nFROM \r\n\t\t\t\t#TBL_TEMP_AUTOS_BAIXA_MANUAL\tTABM\r\n\tLEFT JOIN\tBD_COBRANCA.DBO.TBL_DOCUMENTO\tTD\t\tWITH(NOLOCK) ON (\t(TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS)  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tAND (TD.NR_CNPJ_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_CPF_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS ))\r\n\r\nORDER BY 2\r\n\r\n-- Adiciona a lógica aos \"Encontrado no arrecadação\"\r\nIF EXISTS (SELECT * FROM #TBL_TEMP_AUTOS_BAIXA_MANUAL)\r\n\tBEGIN\r\n\t\tSELECT @qtdAutos = COUNT(*) FROM #TBL_TEMP_AUTOS_BAIXA_MANUAL \r\n\r\n\t\tPRINT 'ALTERAÇÃO DE ' + CAST(@qtdAutos AS VARCHAR(4))\r\n\r\n\r\nWHILE (@qtdAutos > 0)\r\n\tBEGIN\r\n\t\t\r\n\t\tSET @NR_AUTO_INFRACAO\t\t= NULL\t\t\r\n\t\tSET @CO_CHAVE_ORIGEM\t\t= NULL\t\t\r\n\t\tSET @DT_PAGAMENTO\t\t\t= NULL\r\n\t\tSET @VL_PAGAMENTO\t\t\t= NULL\r\n\t\tSET @SQ_DOCUMENTO\t\t\t= NULL\r\n\t\tSET @NR_ORDEM_DOC_ENVIO\t\t= NULL\r\n\r\n\t\tSELECT \r\n\t\t\t@NR_AUTO_INFRACAO\t= TABM.NR_AUTO_INFRACAO, \r\n\t\t\t@CO_CHAVE_ORIGEM\t= TD.CO_CHAVE_DOCUMENTO_ORIGEM, \r\n\t\t\t@DT_PAGAMENTO\t\t= DT_PAGAMENTO, \r\n\t\t\t@VL_PAGAMENTO\t\t= VL_PAGAMENTO \r\n\t\tFROM \r\n\t\t\t\t\t\t#TBL_TEMP_AUTOS_BAIXA_MANUAL\tTABM\r\n\t\t\tINNER JOIN\tBD_COBRANCA.DBO.TBL_DOCUMENTO\tTD\t\tWITH(NOLOCK) ON (\t(TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS)   \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tAND (TD.NR_CNPJ_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_CPF_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS ))\r\n\t\tWHERE \r\n\t\t\tID = @QTDAUTOS \r\n\r\n\t\tSELECT \r\n\t\t\t@SQ_DOCUMENTO\t\t= TD.SQ_DOCUMENTO,\r\n\t\t\t@NR_ORDEM_DOC_ENVIO = (SELECT MAX(NR_ORDEM_DOCUMENTO_ENVIO) FROM BD_COBRANCA.DBO.TBL_DOCUMENTO_ENVIO WITH(NOLOCK) WHERE SQ_DOCUMENTO = TD.SQ_DOCUMENTO)\r\n\t\tFROM\t\r\n\t\t\tBD_COBRANCA.DBO.TBL_DOCUMENTO\t\tTD\tWITH(NOLOCK) \r\n\t\tWHERE \r\n\t\t\t\tCO_CHAVE_DOCUMENTO_ORIGEM = @CO_CHAVE_ORIGEM \r\n\t\t\tAND SQ_FASE_DOCUMENTO = (\tSELECT MAX(SQ_FASE_DOCUMENTO) \r\n\t\t\t\t\t\t\t\t\t\tFROM BD_COBRANCA.DBO.TBL_DOCUMENTO WITH(NOLOCK) \r\n\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCO_CHAVE_DOCUMENTO_ORIGEM = @CO_CHAVE_ORIGEM \r\n\t\t\t\t\t\t\t\t\t\t\tAND SQ_FASE_DOCUMENTO <> 12\r\n\t\t\t\t\t\t\t\t\t)\r\n\r\n\t\tIF\t\t(@NR_AUTO_INFRACAO = '1833338' AND @CO_CHAVE_ORIGEM <> '1348606')\r\n\t\t\tOR  (@NR_AUTO_INFRACAO = '2438153' AND @CO_CHAVE_ORIGEM <> '1501827')\r\n\t\t\tBEGIN\r\n\t\t\t\tSET @NR_AUTO_INFRACAO\t\t= NULL\t\t\r\n\t\t\t\tSET @CO_CHAVE_ORIGEM\t\t= NULL\t\t\r\n\t\t\t\tSET @DT_PAGAMENTO\t\t\t= NULL\r\n\t\t\t\tSET @VL_PAGAMENTO\t\t\t= NULL\r\n\t\t\t\tSET @SQ_DOCUMENTO\t\t\t= NULL\r\n\t\t\t\tSET @NR_ORDEM_DOC_ENVIO\t\t= NULL\r\n\t\t\tEND\r\n\r\n\r\n\t\tPRINT 'EXECUÇÃO DE BAIXA MANUAL PARA O AI: ' + @NR_AUTO_INFRACAO + ' - CO_CHAVE_DOCUMENTO_ORIGEM: ' + @CO_CHAVE_ORIGEM + ' - DT_PAGAMENTO: ' + CAST(@DT_PAGAMENTO AS VARCHAR(20)) + ' - VL_PAGAMENTO: ' + CAST(@VL_PAGAMENTO AS VARCHAR(20))\r\n\r\n\t\tIF NOT EXISTS (SELECT 1\r\n\t\t\t\t\t\tFROM\t\r\n\t\t\t\t\t\t\tBD_COBRANCA.DBO.TBL_FINANCEIRA\tTF WITH(NOLOCK) \r\n\t\t\t\t\t\tWHERE\r\n\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\tAND DA_PAGAMENTO IS NOT NULL\r\n\t\t\t\t\t\t\tAND ID_TP_QUITACAO IN (26, 25)\r\n\t\t\t\t\t\t)\r\n\t\t\tBEGIN\t\t\t\t\t\t\t\t\t\r\n\t\t\t\tIF NOT EXISTS (\tSELECT 1\r\n\t\t\t\t\t\t\t\tFROM\t\r\n\t\t\t\t\t\t\t\t\tBD_COBRANCA.DBO.TBL_FINANCEIRA\tTF WITH(NOLOCK) \r\n\t\t\t\t\t\t\t\tWHERE\r\n\t\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\t\t\tAND DA_PAGAMENTO IS NOT NULL\r\n\t\t\t\t\t\t\t\t)\r\n\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\tPRINT ' SEM PAGAMENTO PRÉVIO '\r\n\r\n\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t\tUPDATE BD_COBRANCA.DBO.TBL_FINANCEIRA\r\n\t\t\t\t\t\t\tSET DA_PAGAMENTO\t\t= @DT_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tVL_PAGAMENTO\t\t= @VL_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tIN_BAIXA_AUTOMATICA = 0,\r\n\t\t\t\t\t\t\t\tDS_OBSERVACAO\t\t= 'AI BAIXADO ATRAVÉS DE ROTINA EM BANCO DE DADOS CONFORME SOLICITADO.',\r\n\t\t\t\t\t\t\t\tID_TP_QUITACAO\t\t= 25\r\n\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA FINANCEIRA DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA FINANCEIRA DO COBRANCA.'\r\n\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\tUPDATE BD_COBRANCA.DBO.TBL_DOCUMENTO_ENVIO\r\n\t\t\t\t\t\t\t\tSET ST_DOCUMENTO = 'P'\r\n\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA.'\r\n\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM)\r\n\t\t\t\t\t\t\tBEGIN\r\n\r\n\t\t\t\t\t\t\t\tPRINT 'É UM AI DO SISMULTAS'\r\n\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND IDSITUACAO <> 14)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tSET IDSITUACAO = 14 \r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\r\n\r\n\t\t\t\t\t\t\t\t\t\tSELECT \r\n\t\t\t\t\t\t\t\t\t\t\t@IDSITUACAOANTERIOR_MULTAS =  IDSITUACAOATUAL \r\n\t\t\t\t\t\t\t\t\t\tFROM \r\n\t\t\t\t\t\t\t\t\t\t\tBD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA \r\n\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM \r\n\t\t\t\t\t\t\t\t\t\t\tAND IDDOCUMENTOSITUACAOAUDITORIA = (SELECT MAX(IDDOCUMENTOSITUACAOAUDITORIA) FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM)\r\n\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tINSERT INTO BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA\r\n\t\t\t\t\t\t\t\t\t\t\tVALUES(GETDATE(), @CO_CHAVE_ORIGEM, 7707, @IDSITUACAOANTERIOR_MULTAS, 14, NULL) \r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND PAGAMENTO IS NULL)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO\r\n\t\t\t\t\t\t\t\t\t\t\tSET PAGAMENTO = @DT_PAGAMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tPRINT 'NÃO É UM AI DO SISMULTAS'\r\n\r\n\t\t\t\t\tEND \t\t\t\r\n\t\t\t\tELSE \r\n\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\tPRINT ' HOUVE UM PAGAMENTO PRÉVIO '\r\n\t\t\t\t\r\n\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\tINSERT INTO BD_COBRANCA.DBO.TBL_FINANCEIRA\r\n\t\t\t\t\t\t\tSELECT \r\n\t\t\t\t\t\t\t\tDA_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\tDA_VENCIMENTO,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\t(NR_ORDEM_FINANCEIRA + 1),\r\n\t\t\t\t\t\t\t\tVL_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tVL_DESCONTO,\r\n\t\t\t\t\t\t\t\tVL_MORA_MULTA,\r\n\t\t\t\t\t\t\t\t@DT_PAGAMENTO,\r\n\t\t\t\t\t\t\t\t@VL_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tCO_TIPO_CODIGO_BARRA,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\tDA_LIMITE_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tVL_LIMITE_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tSQ_TIPO_ARRECADACAO,\r\n\t\t\t\t\t\t\t\tSQ_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tNR_ORDEM_DOCUMENTO_ENVIO,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\tNULL,\r\n\t\t\t\t\t\t\t\t'AI BAIXADO ATRAVÉS DE ROTINA EM BANCO DE DADOS',\r\n\t\t\t\t\t\t\t\t0,\r\n\t\t\t\t\t\t\t\tVL_DOCUMENTO_DOLAR,\r\n\t\t\t\t\t\t\t\tVL_INDICE_PTAX,\r\n\t\t\t\t\t\t\t\tDA_INICIO_SELIC,\r\n\t\t\t\t\t\t\t\tDA_FIM_SELIC,\r\n\t\t\t\t\t\t\t\tPERCENTUAL_SELIC_MAISUMPORCENTO,\r\n\t\t\t\t\t\t\t\tVL_JUROS_SELIC_MAISUMPORCENTO,\r\n\t\t\t\t\t\t\t\tVL_PERCENTUAL_MULTA_MORA,\r\n\t\t\t\t\t\t\t\tIN_VALOR_COMPLEMENTAR,\r\n\t\t\t\t\t\t\t\t25,\r\n\t\t\t\t\t\t\t\tDA_CONVERSAO_RENDA,\r\n\t\t\t\t\t\t\t\tVL_CONVERSAO_RENDA,\r\n\t\t\t\t\t\t\t\tVL_RESIDUAL,\r\n\t\t\t\t\t\t\t\tSQ_STATUS_FINANCEIRO,\r\n\t\t\t\t\t\t\t\tVL_HIST_DOCUMENTO,\r\n\t\t\t\t\t\t\t\tVL_HIST_PAGAMENTO,\r\n\t\t\t\t\t\t\t\tDA_VENCIMENTO_PARCELAMENTO\r\n\t\t\t\t\t\t\tFROM \r\n\t\t\t\t\t\t\t\tBD_COBRANCA.DBO.TBL_FINANCEIRA WITH(NOLOCK) \r\n\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\t\t\t\tAND NR_ORDEM_FINANCEIRA = (SELECT MAX(NR_ORDEM_FINANCEIRA) FROM BD_COBRANCA.DBO.TBL_FINANCEIRA WITH(NOLOCK) WHERE SQ_DOCUMENTO = @SQ_DOCUMENTO AND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO)\r\n\t\t\t\t\r\n\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA FINANCEIRA DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA FINANCEIRA DO COBRANCA.'\r\n\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\tUPDATE BD_COBRANCA.DBO.TBL_DOCUMENTO_ENVIO\r\n\t\t\t\t\t\t\tSET ST_DOCUMENTO = 'P'\r\n\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\tSQ_DOCUMENTO = @SQ_DOCUMENTO\r\n\t\t\t\t\t\t\t\tAND NR_ORDEM_DOCUMENTO_ENVIO = @NR_ORDEM_DOC_ENVIO\r\n\t\t\t\t\r\n\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA!!'\r\n\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE NA TABELA DOCUMENTO ENVIO DO COBRANCA.'\r\n\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\tEND \r\n\r\n\r\n\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM)\r\n\t\t\t\t\t\t\tBEGIN\r\n\r\n\t\t\t\t\t\t\t\tPRINT 'É UM AI DO SISMULTAS'\r\n\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND IDSITUACAO <> 14)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tSET IDSITUACAO = 14 \r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\t\t \r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DE QUITAÇÃO NA TABELA DOCUMENTO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\r\n\r\n\t\t\t\t\t\t\t\t\t\tSELECT \r\n\t\t\t\t\t\t\t\t\t\t\t@IDSITUACAOANTERIOR_MULTAS =  IDSITUACAOATUAL \r\n\t\t\t\t\t\t\t\t\t\tFROM \r\n\t\t\t\t\t\t\t\t\t\t\tBD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA \r\n\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\tAND IDDOCUMENTOSITUACAOAUDITORIA = (SELECT MAX(IDDOCUMENTOSITUACAOAUDITORIA) FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) =  @CO_CHAVE_ORIGEM)\r\n\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tINSERT INTO BD_MULTAS.DBO.TBLDOCUMENTOSITUACAOAUDITORIA\r\n\t\t\t\t\t\t\t\t\t\t\tVALUES(GETDATE(), @CO_CHAVE_ORIGEM, 7707, @IDSITUACAOANTERIOR_MULTAS, 14, NULL) \r\n\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O INSERT NA TABELA TBLDOCUMENTOSITUACAOAUDITORIA DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\r\n\t\t\t\t\t\t\t\tIF EXISTS (SELECT 1 FROM BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO WITH(NOLOCK) WHERE CAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM AND PAGAMENTO IS NULL)\r\n\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\tBEGIN TRANSACTION\r\n\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE BD_MULTAS.DBO.TBLDOCUMENTOSITUACAO\r\n\t\t\t\t\t\t\t\t\t\t\tSET PAGAMENTO = @DT_PAGAMENTO\r\n\t\t\t\t\t\t\t\t\t\t\tWHERE \r\n\t\t\t\t\t\t\t\t\t\t\t\tCAST(IDDOCUMENTO AS VARCHAR(20)) = @CO_CHAVE_ORIGEM\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tIF @@ERROR <> 0\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'ERRO AO TENTAR FAZER O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS!!'\r\n\t\t\t\t\t\t\t\t\t\t\t\tROLLBACK\r\n\t\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t\t\tPRINT 'EXECUTOU O UPDATE DA DATA DE PAGAMENTO DA TABELA TBLDOCUMENTOSITUACAO DO MULTAS.'\r\n\t\t\t\t\t\t\t\t\t\t\t\tCOMMIT\r\n\t\t\t\t\t\t\t\t\t\t\tEND \r\n\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\tPRINT 'NÃO É UM AI DO SISMULTAS'\r\n\t\t\t\t\tEND\r\n\t\t\tEND\r\n\t\tELSE\r\n\t\t\tBEGIN\r\n\t\t\t\tPRINT ' JÁ HOUVE BAIXA SAPIENS PARA ESTE AUTO.'\r\n\t\t\tEND\r\n\t\t\t\t\t\r\n\t\tSET @qtdAutos = @qtdAutos - 1\r\n\tEND\r\n\r\n\tPRINT 'SCRIPT FINALIZADO!' + CAST(@qtdAutos AS VARCHAR(5)) + 'REGISTROS ATUALIZADOS'\r\n\r\n\tEND");

                return scriptBuilder.ToString(); // Retorna o script SQL completo como uma string.
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao converter o arquivo: {ex.Message}");
            }
        }

        private string ConvertExcelToSql1(string filePath1)
        {
            try
            {
                var workbook = new XLWorkbook(filePath1);
                var worksheet = workbook.Worksheet("Planilha1");

                var totalLinhas = worksheet.Rows().Count();
                StringBuilder scriptBuilder = new StringBuilder(); // Usamos StringBuilder para acumular o script SQL.

                scriptBuilder.AppendLine("SET DATEFORMAT YMD");
                scriptBuilder.AppendLine("DECLARE @qtdAutos INT,");
                scriptBuilder.AppendLine("@NR_AUTO_INFRACAO VARCHAR(20),");
                scriptBuilder.AppendLine("@CO_CHAVE_ORIGEM VARCHAR(20),");
                scriptBuilder.AppendLine("@DT_PAGAMENTO DATETIME,");
                scriptBuilder.AppendLine("@VL_PAGAMENTO NUMERIC(13,2),");
                scriptBuilder.AppendLine("@SQ_DOCUMENTO INT,");
                scriptBuilder.AppendLine("@NR_ORDEM_DOC_ENVIO INT,");
                scriptBuilder.AppendLine("@IDSITUACAOANTERIOR_MULTAS INT");
                scriptBuilder.AppendLine();

                if (totalLinhas < 2)
                {
                    return scriptBuilder.ToString(); // Retorna o script atual até este ponto.
                }

                scriptBuilder.AppendLine("IF OBJECT_ID('TEMPDB.DBO.#TBL_TEMP_AUTOS_BAIXA_MANUAL') IS NOT NULL");
                scriptBuilder.AppendLine("DROP TABLE #TBL_TEMP_AUTOS_BAIXA_MANUAL");

                scriptBuilder.AppendLine("CREATE TABLE #TBL_TEMP_AUTOS_BAIXA_MANUAL(Id INT IDENTITY(1, 1), CPF_CNPJ VARCHAR(20),");
                scriptBuilder.AppendLine("NR_AUTO_INFRACAO VARCHAR(20), CO_CHAVE_DOCUMENTO_ORIGEM VARCHAR(20), DT_PAGAMENTO DATETIME, VL_PAGAMENTO NUMERIC(13,2))");
                scriptBuilder.AppendLine();

                int comentarioLinha = 0;
                string ultimaLinhaCol_A = "";

                for (int l = 2; l <= totalLinhas; l++)
                {
                    ultimaLinhaCol_A = worksheet.Cell(l, "A").Value.ToString();

                    if (!string.IsNullOrEmpty(ultimaLinhaCol_A))
                    {
                        comentarioLinha++;
                        string cpfCnpj = worksheet.Cell(l, "C").Value.ToString().Trim().Replace("/", "").Replace("-", "");
                        string colunaE = worksheet.Cell(l, "E").Value.ToString().Trim() == "" ? "NULL" : worksheet.Cell(l, "E").Value.ToString().Trim();
                        string colunaData = Convert.ToDateTime(worksheet.Cell(l, "I").Value).ToString("yyyy/MM/dd HH:mm:ss");
                        string strSqlInsert = $"/* Linha {comentarioLinha} */" + $@"INSERT INTO #TBL_TEMP_AUTOS_BAIXA_MANUAL VALUES('{cpfCnpj}','{worksheet.Cell(l, "D").Value.ToString().Trim()}','{colunaE}' ,'{colunaData}' , CAST(REPLACE(REPLACE('{worksheet.Cell(l, "J").Value.ToString().Trim()}',' ', ''),',','.') AS NUMERIC(13,2)))" + "\n";
                        scriptBuilder.AppendLine(strSqlInsert);
                    }
                }

                scriptBuilder.AppendLine("SELECT DISTINCT\r\n\tCASE \r\n\t\tWHEN TD.CO_CHAVE_DOCUMENTO_ORIGEM IS NOT NULL THEN\r\n\t\t\t'ENCONTRADO NO ARRECADAÇÃO'\r\n\t\tELSE\r\n\t\t\t'CPF/CNPJ NÃO COINCIDE COM NÚMERO DO AUTO'\r\n\tEND AS 'EXISTE_ARRECADAÇÃO',\t\r\n\tTABM.ID,\r\n\tTABM.CPF_CNPJ,\r\n\tTABM.NR_AUTO_INFRACAO,\r\n\tTABM.DT_PAGAMENTO,\r\n\tTABM.VL_PAGAMENTO\t\r\nFROM \r\n\t\t\t\t#TBL_TEMP_AUTOS_BAIXA_MANUAL\tTABM\r\n\tLEFT JOIN\tBD_COBRANCA.DBO.TBL_DOCUMENTO\tTD\t\tWITH(NOLOCK) ON (\t(TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.CO_CHAVE_DOCUMENTO_ORIGEM COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS = TABM.NR_AUTO_INFRACAO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS)  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tAND (TD.NR_CNPJ_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOR TD.NR_CPF_AUTUADO COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS  = TABM.CPF_CNPJ COLLATE SQL_LATIN1_GENERAL_CP1_CI_AS ))\r\n\r\nWhere  TD.CO_CHAVE_DOCUMENTO_ORIGEM IS NULL\r\nORDER BY 2");

                return scriptBuilder.ToString(); // Retorna o script SQL completo como uma string.
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao converter o arquivo: {ex.Message}");
            }
        }



        private readonly string _connectionString = "Data Source=ANTTSQLDEV01;Database=BD_COBRANCA;Integrated Security=true;";


        [HttpGet("ExecuteScript")]
        public IActionResult TestarConexao()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Recupera o SQL gerado do cache com a mesma chave
                    string script = _memoryCache.Get<string>("ArquivoScriptGerado");

                    if (string.IsNullOrEmpty(script))
                    {
                        return StatusCode(500, "O SQL gerado não está disponível");
                    }

                    // Execute o comando SQL com base no script
                    using (SqlCommand command = new SqlCommand(script, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var resultList = new List<Dictionary<string, object>>();

                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader[i];
                                }

                                resultList.Add(row);
                            }

                            return Ok(resultList);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro ao testar a conexão: " + ex.Message);
            }
        }
        [HttpGet("ExecuteScriptParc")]
        public IActionResult TestarConexaoParc()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Recupera o SQL gerado do cache com a mesma chave
                    string script = _memoryCache.Get<string>("ArquivoScriptGerado2");

                    if (string.IsNullOrEmpty(script))
                    {
                        return StatusCode(500, "O SQL gerado não está disponível");
                    }

                    // Execute o comando SQL com base no script
                    using (SqlCommand command = new SqlCommand(script, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var resultList = new List<Dictionary<string, object>>();

                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader[i];
                                }

                                resultList.Add(row);
                            }

                            return Ok(resultList);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro ao testar a conexão: " + ex.Message);
            }
        }
        [HttpGet("ExecuteConsulta")]
        public IActionResult ExecutaConsulta()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Recupera o SQL gerado do cache com a mesma chave
                    string script = _memoryCache.Get<string>("ArquivoScriptGerado1");

                    if (string.IsNullOrEmpty(script))
                    {
                        return StatusCode(500, "O SQL gerado não está disponível");
                    }

                    // Execute o comando SQL com base no script
                    using (SqlCommand command = new SqlCommand(script, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var resultList = new List<Dictionary<string, object>>();

                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader[i];
                                }

                                resultList.Add(row);
                            }

                            return Ok(resultList);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro ao testar a conexão: " + ex.Message);
            }
        }



    }
}
