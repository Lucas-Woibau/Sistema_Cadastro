using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SistemaIgreja
{
    internal class DbMembro
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(ConfiguracoesDb.stringConexao + ";Trust Server Certificate=true");

            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Minha conexão SQL ", $"Error{ex}\nSe o problema persistir, entre em contado com o Lucas Woibau! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void AdicionarMembro(Membro membro)
        {
            string sql = "INSERT INTO membros VALUES (@NOME, @SEXO, @ENDERECO, @NÚMERO, @BAIRRO, @CIDADE, @UF, @CEP, @TELEFONE_CELULAR, @EMAIL, @ESCOLARIDADE, @PROFISSAO, @DATA_NASCIMENTO, @NATURALIDADE, @RG, @ORG, @CPF, @DATA_CASAMENTO, @CONJUGUE, @CEL_CONJUGUE, @NOME_FILHO1, @NOME_FILHO2, @NOME_FILHO3, @NOME_FILHO4, @NOME_FILHO5, @DATA_NASCIMENTO_FILHO1, @DATA_NASCIMENTO_FILHO2, @DATA_NASCIMENTO_FILHO3, @DATA_NASCIMENTO_FILHO4, @DATA_NASCIMENTO_FILHO5, @SEXO_FILHO1, @SEXO_FILHO2, @SEXO_FILHO3, @SEXO_FILHO4, @SEXO_FILHO5, @NOME_PAI, @NOME_MAE, @DATA_BATISMO, @NOME_IGREJA_BATISMO, @NOME_IGREJA_ANTERIOR, @NOME_PASTOR_BATIZOU, @CARGOS_EXERCIDOS, @REQUISICAO_CARGO, @TALENTOS, @TIPO, @ACEITO_POR) ";
            SqlConnection connection = GetConnection();
            SqlCommand comand = new SqlCommand(sql, connection);
            comand.CommandType = CommandType.Text;

            comand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = membro.NOME;
            comand.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = membro.SEXO;
            comand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = membro.ENDERECO;
            comand.Parameters.Add("@NÚMERO", SqlDbType.VarChar).Value = membro.NUMERO;
            comand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = membro.BAIRRO;
            comand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = membro.CIDADE;
            comand.Parameters.Add("@UF", SqlDbType.VarChar).Value = membro.UF;
            comand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = membro.CEP;
            comand.Parameters.Add("@TELEFONE_CELULAR", SqlDbType.VarChar).Value = membro.TELEFONE_CELULAR;
            comand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = membro.EMAIL;
            comand.Parameters.Add("@ESCOLARIDADE", SqlDbType.VarChar).Value = membro.ESCOLARIDADE;
            comand.Parameters.Add("@PROFISSAO", SqlDbType.VarChar).Value = membro.PROFISSAO;
            comand.Parameters.Add("@DATA_NASCIMENTO", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO;
            comand.Parameters.Add("@NATURALIDADE", SqlDbType.VarChar).Value = membro.NATURALIDADE;
            comand.Parameters.Add("@RG", SqlDbType.VarChar).Value = membro.RG;
            comand.Parameters.Add("@ORG", SqlDbType.VarChar).Value = membro.ORG;
            comand.Parameters.Add("@CPF", SqlDbType.VarChar).Value = membro.CPF;
            comand.Parameters.Add("@DATA_CASAMENTO", SqlDbType.VarChar).Value = membro.DATA_CASAMENTO;
            comand.Parameters.Add("@CONJUGUE", SqlDbType.VarChar).Value = membro.CONJUGUE;
            comand.Parameters.Add("@CEL_CONJUGUE", SqlDbType.VarChar).Value = membro.CEL_CONJUGUE;
            comand.Parameters.Add("@NOME_FILHO1", SqlDbType.VarChar).Value = membro.NOME_FILHO1;
            comand.Parameters.Add("@NOME_FILHO2", SqlDbType.VarChar).Value = membro.NOME_FILHO2;
            comand.Parameters.Add("@NOME_FILHO3", SqlDbType.VarChar).Value = membro.NOME_FILHO3;
            comand.Parameters.Add("@NOME_FILHO4", SqlDbType.VarChar).Value = membro.NOME_FILHO4;
            comand.Parameters.Add("@NOME_FILHO5", SqlDbType.VarChar).Value = membro.NOME_FILHO5;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO1", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO1;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO2", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO2;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO3", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO3;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO4", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO4;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO5", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO5;
            comand.Parameters.Add("@SEXO_FILHO1", SqlDbType.VarChar).Value = membro.SEXO_FILHO1;
            comand.Parameters.Add("@SEXO_FILHO2", SqlDbType.VarChar).Value = membro.SEXO_FILHO2;
            comand.Parameters.Add("@SEXO_FILHO3", SqlDbType.VarChar).Value = membro.SEXO_FILHO3;
            comand.Parameters.Add("@SEXO_FILHO4", SqlDbType.VarChar).Value = membro.SEXO_FILHO4;
            comand.Parameters.Add("@SEXO_FILHO5", SqlDbType.VarChar).Value = membro.SEXO_FILHO5;
            comand.Parameters.Add("@NOME_PAI", SqlDbType.VarChar).Value = membro.NOME_PAI;
            comand.Parameters.Add("@NOME_MAE", SqlDbType.VarChar).Value = membro.NOME_MAE;
            comand.Parameters.Add("@DATA_BATISMO", SqlDbType.VarChar).Value = membro.DATA_BATISMO;
            comand.Parameters.Add("@NOME_IGREJA_BATISMO", SqlDbType.VarChar).Value = membro.NOME_IGREJA_BATISMO;
            comand.Parameters.Add("@NOME_IGREJA_ANTERIOR", SqlDbType.VarChar).Value = membro.NOME_IGREJA_ANTERIOR;
            comand.Parameters.Add("@NOME_PASTOR_BATIZOU", SqlDbType.VarChar).Value = membro.NOME_PASTOR_BATIZOU;
            comand.Parameters.Add("@CARGOS_EXERCIDOS", SqlDbType.VarChar).Value = membro.CARGOS_EXERCIDOS;
            comand.Parameters.Add("@REQUISICAO_CARGO", SqlDbType.VarChar).Value = membro.REQUISICAO_CARGOS;
            comand.Parameters.Add("@TALENTOS", SqlDbType.VarChar).Value = membro.TALENTOS;
            comand.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = membro.TIPO;
            comand.Parameters.Add("@ACEITO_POR", SqlDbType.VarChar).Value = membro.ACEITO_POR;

            try
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("Membro adicionado com sucesso! ", "Informação", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("O membro não foi adicionado!\nSe o problema persistir, entre em contado com o Lucas Woibau! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EditarMembro(Membro membro, string id)
        {
            string sql = "UPDATE membros SET NOME=@NOME, SEXO=@SEXO, ENDERECO=@ENDERECO, NÚMERO=@NÚMERO, BAIRRO=@BAIRRO, CIDADE=@CIDADE, UF=@UF, CEP=@CEP, TELEFONE_CELULAR=@TELEFONE_CELULAR, EMAIL=@EMAIL, ESCOLARIDADE=@ESCOLARIDADE, PROFISSAO=@PROFISSAO, DATA_NASCIMENTO=@DATA_NASCIMENTO, NATURALIDADE=@NATURALIDADE, RG=@RG, ORG=@ORG, CPF=@CPF, DATA_CASAMENTO=@DATA_CASAMENTO, CONJUGUE=@CONJUGUE, CEL_CONJUGUE=@CEL_CONJUGUE, NOME_FILHO1=@NOME_FILHO1, NOME_FILHO2=@NOME_FILHO2, NOME_FILHO3=@NOME_FILHO3, NOME_FILHO4=@NOME_FILHO4, NOME_FILHO5=@NOME_FILHO5, DATA_NASCIMENTO_FILHO1=@DATA_NASCIMENTO_FILHO1, DATA_NASCIMENTO_FILHO2=@DATA_NASCIMENTO_FILHO2, DATA_NASCIMENTO_FILHO3=@DATA_NASCIMENTO_FILHO3, DATA_NASCIMENTO_FILHO4=@DATA_NASCIMENTO_FILHO4, DATA_NASCIMENTO_FILHO5=@DATA_NASCIMENTO_FILHO5, SEXO_FILHO1=@SEXO_FILHO1, SEXO_FILHO2=@SEXO_FILHO2, SEXO_FILHO3=@SEXO_FILHO3, SEXO_FILHO4=@SEXO_FILHO4, SEXO_FILHO5=@SEXO_FILHO5, NOME_PAI=@NOME_PAI, NOME_MAE=@NOME_MAE, DATA_BATISMO=@DATA_BATISMO, NOME_IGREJA_BATISMO=@NOME_IGREJA_BATISMO, NOME_IGREJA_ANTERIOR=@NOME_IGREJA_ANTERIOR, NOME_PASTOR_BATIZOU=@NOME_PASTOR_BATIZOU, CARGOS_EXERCIDOS=@CARGOS_EXERCIDOS, REQUISICAO_CARGO=@REQUISICAO_CARGO, TALENTOS=@TALENTOS, TIPO=@TIPO, ACEITO_POR=@ACEITO_POR WHERE ID = @ID";
            SqlConnection connection = GetConnection();
            SqlCommand comand = new SqlCommand(sql, connection);
            comand.CommandType = CommandType.Text;

            comand.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            comand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = membro.NOME;
            comand.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = membro.SEXO;
            comand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = membro.ENDERECO;
            comand.Parameters.Add("@NÚMERO", SqlDbType.VarChar).Value = membro.NUMERO;
            comand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = membro.BAIRRO;
            comand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = membro.CIDADE;
            comand.Parameters.Add("@UF", SqlDbType.VarChar).Value = membro.UF;
            comand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = membro.CEP;
            comand.Parameters.Add("@TELEFONE_CELULAR", SqlDbType.VarChar).Value = membro.TELEFONE_CELULAR;
            comand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = membro.EMAIL;
            comand.Parameters.Add("@ESCOLARIDADE", SqlDbType.VarChar).Value = membro.ESCOLARIDADE;
            comand.Parameters.Add("@PROFISSAO", SqlDbType.VarChar).Value = membro.PROFISSAO;
            comand.Parameters.Add("@DATA_NASCIMENTO", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO;
            comand.Parameters.Add("@NATURALIDADE", SqlDbType.VarChar).Value = membro.NATURALIDADE;
            comand.Parameters.Add("@RG", SqlDbType.VarChar).Value = membro.RG;
            comand.Parameters.Add("@ORG", SqlDbType.VarChar).Value = membro.ORG;
            comand.Parameters.Add("@CPF", SqlDbType.VarChar).Value = membro.CPF;
            comand.Parameters.Add("@DATA_CASAMENTO", SqlDbType.VarChar).Value = membro.DATA_CASAMENTO;
            comand.Parameters.Add("@CONJUGUE", SqlDbType.VarChar).Value = membro.CONJUGUE;
            comand.Parameters.Add("@CEL_CONJUGUE", SqlDbType.VarChar).Value = membro.CEL_CONJUGUE;
            comand.Parameters.Add("@NOME_FILHO1", SqlDbType.VarChar).Value = membro.NOME_FILHO1;
            comand.Parameters.Add("@NOME_FILHO2", SqlDbType.VarChar).Value = membro.NOME_FILHO2;
            comand.Parameters.Add("@NOME_FILHO3", SqlDbType.VarChar).Value = membro.NOME_FILHO3;
            comand.Parameters.Add("@NOME_FILHO4", SqlDbType.VarChar).Value = membro.NOME_FILHO4;
            comand.Parameters.Add("@NOME_FILHO5", SqlDbType.VarChar).Value = membro.NOME_FILHO5;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO1", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO1;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO2", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO2;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO3", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO3;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO4", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO4;
            comand.Parameters.Add("@DATA_NASCIMENTO_FILHO5", SqlDbType.VarChar).Value = membro.DATA_NASCIMENTO_FILHO5;
            comand.Parameters.Add("@SEXO_FILHO1", SqlDbType.VarChar).Value = membro.SEXO_FILHO1;
            comand.Parameters.Add("@SEXO_FILHO2", SqlDbType.VarChar).Value = membro.SEXO_FILHO2;
            comand.Parameters.Add("@SEXO_FILHO3", SqlDbType.VarChar).Value = membro.SEXO_FILHO3;
            comand.Parameters.Add("@SEXO_FILHO4", SqlDbType.VarChar).Value = membro.SEXO_FILHO4;
            comand.Parameters.Add("@SEXO_FILHO5", SqlDbType.VarChar).Value = membro.SEXO_FILHO5;
            comand.Parameters.Add("@NOME_PAI", SqlDbType.VarChar).Value = membro.NOME_PAI;
            comand.Parameters.Add("@NOME_MAE", SqlDbType.VarChar).Value = membro.NOME_MAE;
            comand.Parameters.Add("@DATA_BATISMO", SqlDbType.VarChar).Value = membro.DATA_BATISMO;
            comand.Parameters.Add("@NOME_IGREJA_BATISMO", SqlDbType.VarChar).Value = membro.NOME_IGREJA_BATISMO;
            comand.Parameters.Add("@NOME_IGREJA_ANTERIOR", SqlDbType.VarChar).Value = membro.NOME_IGREJA_ANTERIOR;
            comand.Parameters.Add("@NOME_PASTOR_BATIZOU", SqlDbType.VarChar).Value = membro.NOME_PASTOR_BATIZOU;
            comand.Parameters.Add("@CARGOS_EXERCIDOS", SqlDbType.VarChar).Value = membro.CARGOS_EXERCIDOS;
            comand.Parameters.Add("@REQUISICAO_CARGO", SqlDbType.VarChar).Value = membro.REQUISICAO_CARGOS;
            comand.Parameters.Add("@TALENTOS", SqlDbType.VarChar).Value = membro.TALENTOS;
            comand.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = membro.TIPO;
            comand.Parameters.Add("@ACEITO_POR", SqlDbType.VarChar).Value = membro.ACEITO_POR;

            try
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("Os dados do membro foram atualizados com sucesso! ", "Informação", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Os dados do membro não foram atualizados!\nSe o problema persistir, entre em contado com o Lucas Woibau! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                connection.Close();
            }
        }

        public static void DeletarMembro(string id)
        {
            string sql = "DELETE FROM membros WHERE ID = @MEMBRO_ID";
            SqlConnection connection = GetConnection();
            SqlCommand comand = new SqlCommand(sql, connection);
            comand.CommandType = CommandType.Text;
            comand.Parameters.Add("@MEMBRO_ID", SqlDbType.VarChar).Value = id;

            try
            {
                comand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("O membro não foi deletado!\nSe o problema persistir, entre em contado com o Lucas Woibau! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void PesquisarMembro(string consulta, DataGridView gridView)
        {
            string sql = consulta;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gridView.DataSource = dataTable;
            connection.Close();
        }
    }
}