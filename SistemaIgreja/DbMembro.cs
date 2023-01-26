using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SistemaIgreja
{
    internal class DbMembro
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port3306;username=root;password=1234;database=membros_igreja";
            MySqlConnection connection = new MySqlConnection(sql);

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Minha conexão SQL ", $"Error{ex}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public void AdidiconarMembro(Membro membro)
        {
            string sql = "INSERT INTO membros VALUES (@NOME, @SEXO, @ENDERECO, @NÚMERO, @BAIRRO, @CIDADE, @UF, @CEP, @TELEFONE_CELULAR, @EMAIL, @ESCOLARIDADE, @PROFISSAO, @DATA_NASCIMENTO, @NATURALIDADE, @RG, @ORG, @DATA_CASAMENTO, @CONJUGUE, @CEL_CONJUGUE, @NOME_FILHO1, @NOME_FILHO2, @NOME_FILHO3, @NOME_FILHO4, @NOME_FILHO5, @DATA_NASCIMENTO_FILHO1, @DATA_NASCIMENTO_FILHO2, @DATA_NASCIMENTO_FILHO3, @DATA_NASCIMENTO_FILHO4, @DATA_NASCIMENTO_FILHO5, @SEXO_FILHO1, @SEXO_FILHO2, @SEXO_FILHO3, @SEXO_FILHO4, @SEXO_FILHO5, " +
                "@NOME_PAI, @NOME_MAE, @DATA_BATISMO, @NOME_IGREJA_BATISMO, @NOME_IGREJA_ANTERIOR, @NOME_PASTOR_BATIZOU, @CARGOS_EXERCIDOS, @REQUISICAO_CARGO, @TALENTOS, @TIPO, @ACEITO_POR ";
            MySqlConnection connection = GetConnection();
            MySqlCommand comand = new MySqlCommand(sql, connection);
            comand.CommandType = CommandType.Text;

            comand.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = membro.NOME;
            comand.Parameters.Add("@SEXO", MySqlDbType.VarChar).Value = membro.SEXO;
            comand.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = membro.ENDERECO;
            comand.Parameters.Add("@NÚMERO", MySqlDbType.VarChar).Value = membro.NUMERO;
            comand.Parameters.Add("@BAIRRO", MySqlDbType.VarChar).Value = membro.BAIRRO;
            comand.Parameters.Add("@CIDADE", MySqlDbType.VarChar).Value = membro.CIDADE;
            comand.Parameters.Add("@UF", MySqlDbType.VarChar).Value = membro.UF;
            comand.Parameters.Add("@CEP", MySqlDbType.VarChar).Value = membro.CEP;
            comand.Parameters.Add("@TELEFONE", MySqlDbType.VarChar).Value = membro.TELEFONE_CELULAR;
            comand.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = membro.EMAIL;
            comand.Parameters.Add("@ESCOLARIDADE", MySqlDbType.VarChar).Value = membro.ESCOLARIDADE;
            comand.Parameters.Add("@PROFISSAO", MySqlDbType.VarChar).Value = membro.PROFISSAO;
            comand.Parameters.Add("@DATA_NASCIMENTO", MySqlDbType.VarChar).Value = membro.DATA_NASCIMENTO;
            comand.Parameters.Add("@NATURALIDADE", MySqlDbType.VarChar).Value = membro.NATURALIDADE;
            comand.Parameters.Add("@RG", MySqlDbType.VarChar).Value = membro.RG;
            comand.Parameters.Add("@ORG", MySqlDbType.VarChar).Value = membro.ORG;
            comand.Parameters.Add("@DATA_CASAMENTO", MySqlDbType.VarChar).Value = membro.DATA_CASAMENTO;
            comand.Parameters.Add("@CONJUGUE", MySqlDbType.VarChar).Value = membro.CONJUGUE;
            comand.Parameters.Add("@CEL_CONJUGUE", MySqlDbType.VarChar).Value = membro.CEL_CONJUGUE;
            comand.Parameters.Add("@NOME_FILHO1", MySqlDbType.VarChar).Value = membro.NOME_FILHO1;
            comand.Parameters.Add("@NOME_FILHO2", MySqlDbType.VarChar).Value = membro.NOME_FILHO2;
            comand.Parameters.Add("@NOME_FILHO3", MySqlDbType.VarChar).Value = membro.NOME_FILHO3;
            comand.Parameters.Add("@NOME_FILHO4", MySqlDbType.VarChar).Value = membro.NOME_FILHO4;
            comand.Parameters.Add("@NOME_FILHO5", MySqlDbType.VarChar).Value = membro.NOME_FILHO5;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO1", MySqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO1;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO2", MySqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO2;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO3", MySqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO3;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO4", MySqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO4;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO5", MySqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO5;
            comand.Parameters.Add("@SEXO_FILHO1", MySqlDbType.VarChar).Value = membro.SEXO_FILHO1;
            comand.Parameters.Add("@SEXO_FILHO2", MySqlDbType.VarChar).Value = membro.SEXO_FILHO2;
            comand.Parameters.Add("@SEXO_FILHO3", MySqlDbType.VarChar).Value = membro.SEXO_FILHO3;
            comand.Parameters.Add("@SEXO_FILHO4", MySqlDbType.VarChar).Value = membro.SEXO_FILHO4;
            comand.Parameters.Add("@SEXO_FILHO5", MySqlDbType.VarChar).Value = membro.SEXO_FILHO5;
            comand.Parameters.Add("@NOME_PAI", MySqlDbType.VarChar).Value = membro.NOME_PAI;
            comand.Parameters.Add("@NOME_MAE", MySqlDbType.VarChar).Value = membro.NOME_MAE;
            comand.Parameters.Add("@DATA_BATISMO", MySqlDbType.VarChar).Value = membro.DATA_BATISMO;
            comand.Parameters.Add("@NOME_IGREJA_BATISMO", MySqlDbType.VarChar).Value = membro.NOME_IGREJA_BATISMO;
            comand.Parameters.Add("@NOME_IGREJA_ANTERIOR", MySqlDbType.VarChar).Value = membro.NOME_IGREJA_ANTERIOR;
            comand.Parameters.Add("@NOME_PASTOR_BATIZOU", MySqlDbType.VarChar).Value = membro.NOME_PASTOR_BATIZOU;
            comand.Parameters.Add("@CARGOS_EXERCIDOS", MySqlDbType.VarChar).Value = membro.CARGOS_EXERCIDOS;
            comand.Parameters.Add("@REQUISICAO_CARGO", MySqlDbType.VarChar).Value = membro.REQUISICAO_CARGOS;
            comand.Parameters.Add("@REQUISICAO_CARGO", MySqlDbType.VarChar).Value = membro.REQUISICAO_CARGOS;
            comand.Parameters.Add("@TALENTOS", MySqlDbType.VarChar).Value = membro.TALENTOS;
            comand.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = membro.TIPO;
            comand.Parameters.Add("@ACEITO_POR", MySqlDbType.VarChar).Value = membro.ACEITO_POR;
        }
    }
}