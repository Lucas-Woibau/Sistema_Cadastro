using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIgreja
{
    internal class Membro
    {
        public string NOME { get; set; }
        public string SEXO { get; set; }
        public string ENDERECO { get; set; }
        public string NUMERO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string TELEFONE_CELULAR { get; set; }
        public string EMAIL { get; set; }
        public string ESCOLARIDADE { get; set; }
        public string PROFISSAO { get; set; }
        public string DATA_NASCIMENTO { get; set; }
        public string NATURALIDADE { get; set; }
        public string RG { get; set; }
        public string ORG { get; set; }
        public string DATA_CASAMENTO { get; set; }
        public string CONJUGUE { get; set; }
        public string CEL_CONJUGUE { get; set; }
        public string NOME_FILHO1 { get; set; }
        public string NOME_FILHO2 { get; set; }
        public string NOME_FILHO3 { get; set; }
        public string NOME_FILHO4 { get; set; }
        public string NOME_FILHO5 { get; set; }
        public string DATA_NASCIMENTO_FILHO1 { get; set; }
        public string DATA_NASCIMENTO_FILHO2 { get; set; }
        public string DATA_NASCIMENTO_FILHO3 { get; set; }
        public string DATA_NASCIMENTO_FILHO4 { get; set; }
        public string DATA_NASCIMENTO_FILHO5 { get; set; }
        public string SEXO_FILHO1 { get; set; }
        public string SEXO_FILHO2 { get; set; }
        public string SEXO_FILHO3 { get; set; }
        public string SEXO_FILHO4 { get; set; }
        public string SEXO_FILHO5 { get; set; }
        public string NOME_PAI { get; set; }
        public string NOME_MAE { get; set; }
        public string DATA_BATISMO { get; set; }
        public string NOME_IGREJA_BATISMO { get; set; }
        public string NOME_IGREJA_ANTERIOR { get; set; }
        public string NOME_PASTOR_BATIZOU { get; set; }
        public string CARGOS_EXERCIDOS { get; set; }
        public string REQUISICAO_CARGOS { get; set; }
        public string TALENTOS { get; set; }
        public string TIPO { get; set; }
        public string ACEITO_POR { get; set; }

        public Membro(string nome, string sexo, string eNDERECO, string nUMERO, string bAIRRO, string cIDADE, string uF, string cEP, string tELEFONE_CELULAR, string eMAIL, string eSCOLARIDADE, string pROFISSAO, string dATA_NASCIMENTO, string nATURALIDADE, string rG, string oRG, string dATA_CASAMENTO, string cONJUGUE, string cEL_CONJUGUE, string nOME_FILHO1, string nOME_FILHO2, string nOME_FILHO3, string nOME_FILHO4, string nOME_FILHO5, string dATA_NASCIMENTO_FILHO1, string dATA_NASCIMENTO_FILHO2, string dATA_NASCIMENTO_FILHO3, string dATA_NASCIMENTO_FILHO4, string dATA_NASCIMENTO_FILHO5, string sEXO_FILHO1, string sEXO_FILHO2, string sEXO_FILHO3, string sEXO_FILHO4, string sEXO_FILHO5, string nOME_PAI, string nOME_MAE, string dATA_BATISMO, string nOME_IGREJA_BATISMO, string nOME_IGREJA_ANTERIOR, string nOME_PASTOR_BATIZOU, string cARGOS_EXERCIDOS, string rEQUISICAO_CARGOS, string tALENTOS, string tIPO, string aCEITO_POR)
        {
            NOME = nome;
            SEXO = sexo;
            ENDERECO = eNDERECO;
            NUMERO = nUMERO;
            BAIRRO = bAIRRO;
            CIDADE = cIDADE;
            UF = uF;
            CEP = cEP;
            TELEFONE_CELULAR = tELEFONE_CELULAR;
            EMAIL = eMAIL;
            ESCOLARIDADE = eSCOLARIDADE;
            PROFISSAO = pROFISSAO;
            DATA_NASCIMENTO = dATA_NASCIMENTO;
            NATURALIDADE = nATURALIDADE;
            RG = rG;
            ORG = oRG;
            DATA_CASAMENTO = dATA_CASAMENTO;
            CONJUGUE = cONJUGUE;
            CEL_CONJUGUE = cEL_CONJUGUE;
            NOME_FILHO1 = nOME_FILHO1;
            NOME_FILHO2 = nOME_FILHO2;
            NOME_FILHO3 = nOME_FILHO3;
            NOME_FILHO4 = nOME_FILHO4;
            NOME_FILHO5 = nOME_FILHO5;
            DATA_NASCIMENTO_FILHO1 = dATA_NASCIMENTO_FILHO1;
            DATA_NASCIMENTO_FILHO2 = dATA_NASCIMENTO_FILHO2;
            DATA_NASCIMENTO_FILHO3 = dATA_NASCIMENTO_FILHO3;
            DATA_NASCIMENTO_FILHO4 = dATA_NASCIMENTO_FILHO4;
            DATA_NASCIMENTO_FILHO5 = dATA_NASCIMENTO_FILHO5;
            SEXO_FILHO1 = sEXO_FILHO1;
            SEXO_FILHO2 = sEXO_FILHO2;
            SEXO_FILHO3 = sEXO_FILHO3;
            SEXO_FILHO4 = sEXO_FILHO4;
            SEXO_FILHO5 = sEXO_FILHO5;
            NOME_PAI = nOME_PAI;
            NOME_MAE = nOME_MAE;
            DATA_BATISMO = dATA_BATISMO;
            NOME_IGREJA_BATISMO = nOME_IGREJA_BATISMO;
            NOME_IGREJA_ANTERIOR = nOME_IGREJA_ANTERIOR;
            NOME_PASTOR_BATIZOU = nOME_PASTOR_BATIZOU;
            CARGOS_EXERCIDOS = cARGOS_EXERCIDOS;
            REQUISICAO_CARGOS = rEQUISICAO_CARGOS;
            TALENTOS = tALENTOS;
            TIPO = tIPO;
            ACEITO_POR = aCEITO_POR;
        }
    }
}
