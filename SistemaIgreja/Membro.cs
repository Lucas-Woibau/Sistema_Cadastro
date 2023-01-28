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
        public string CPF { get; set; }
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

        public Membro(string nome, string sexo, string endereco, string numero, string bairro, string cidade, string uf, string cep, string telefone_celular, string email, string escolaridade, string profissao, string data_nascimento, string naturalidade, string rg, string org, string cpf, string data_casamento, string conjugue, string cel_conjugue, string nome_filho1, string nome_filho2, string nome_filho3, string nome_filho4, string nome_filho5, string data_nascimento_filho1, string data_nascimento_filho2, string data_nascimento_filho3, string data_nascimento_filho4, string data_nascimento_filho5, string sexo_filho1, string sexo_filho2, string sexo_filho3, string sexo_filho4, string sexo_filho5, string nome_pai, string nome_mae, string data_batismo, string nome_igreja_batismo, string nome_igreja_anterior, string nome_pastor_batizou, string cargos_exercidos, string requisicao_cargos, string talentos, string tipo, string aceito_por)
        {
            NOME = nome;
            SEXO = sexo;
            ENDERECO = endereco;
            NUMERO = numero;
            BAIRRO = bairro;
            CIDADE = cidade;
            UF = uf;
            CEP = cep;
            TELEFONE_CELULAR = telefone_celular;
            EMAIL = email;
            ESCOLARIDADE = escolaridade;
            PROFISSAO = profissao;
            DATA_NASCIMENTO = data_nascimento;
            NATURALIDADE = naturalidade;
            RG = rg;
            ORG = org;
            CPF = cpf;
            DATA_CASAMENTO = data_casamento;
            CONJUGUE = conjugue;
            CEL_CONJUGUE = cel_conjugue;
            NOME_FILHO1 = nome_filho1;
            NOME_FILHO2 = nome_filho2;
            NOME_FILHO3 = nome_filho3;
            NOME_FILHO4 = nome_filho4;
            NOME_FILHO5 = nome_filho5;
            DATA_NASCIMENTO_FILHO1 = data_nascimento_filho1;
            DATA_NASCIMENTO_FILHO2 = data_nascimento_filho2;
            DATA_NASCIMENTO_FILHO3 = data_nascimento_filho3;
            DATA_NASCIMENTO_FILHO4 = data_nascimento_filho4;
            DATA_NASCIMENTO_FILHO5 = data_nascimento_filho5;
            SEXO_FILHO1 = sexo_filho1;
            SEXO_FILHO2 = sexo_filho2;
            SEXO_FILHO3 = sexo_filho3;
            SEXO_FILHO4 = sexo_filho4;
            SEXO_FILHO5 = sexo_filho5;
            NOME_PAI = nome_pai;
            NOME_MAE = nome_mae;
            DATA_BATISMO = data_batismo;
            NOME_IGREJA_BATISMO = nome_igreja_batismo;
            NOME_IGREJA_ANTERIOR = nome_igreja_anterior;
            NOME_PASTOR_BATIZOU = nome_pastor_batizou;
            CARGOS_EXERCIDOS = cargos_exercidos;
            REQUISICAO_CARGOS = requisicao_cargos;
            TALENTOS = talentos;
            TIPO = tipo;
            ACEITO_POR = aceito_por;
        }
    }
}
