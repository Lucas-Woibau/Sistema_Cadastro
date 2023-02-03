using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SistemaIgreja
{
    public partial class FormMembro : Form
    {
        public string ID, NOME, SEXO, ENDERECO, NUMERO, BAIRRO, CIDADE, UF, CEP, TELEFONE_CELULAR, EMAIL, ESCOLARIDADE, PROFISSAO, DATA_NASCIMENTO, NATURALIDADE, RG, ORG, CPF, DATA_CASAMENTO, CONJUGUE, CEL_CONJUGUE, NOME_FILHO1, NOME_FILHO2, NOME_FILHO3,
                      NOME_FILHO4, NOME_FILHO5, DATA_NASCIMENTO_FILHO1, DATA_NASCIMENTO_FILHO2, DATA_NASCIMENTO_FILHO3, DATA_NASCIMENTO_FILHO4, DATA_NASCIMENTO_FILHO5, SEXO_FILHO1, SEXO_FILHO2, SEXO_FILHO3, SEXO_FILHO4, SEXO_FILHO5,
                      NOME_PAI, NOME_MAE, DATA_BATISMO, NOME_IGREJA_BATISMO, NOME_IGREJA_ANTERIOR, NOME_PASTOR_BATIZOU, CARGOS_EXERCIDOS, REQUISICAO_CARGOS, TALENTOS, TIPO, ACEITO_POR;

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        public void ContabilizarMembro()
        {
            string qtdMembros = dataGridView1.Rows.Count.ToString();
            labelQtd.Text = qtdMembros;
        }

        public bool Editavel = false;
        public bool Adicionavel;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            DesativarTextBoxes(true);
            Editavel = true;
        }

        private void FormMembro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaIgrejaDataSet.membros' table. You can move, or remove it, as needed.
            //this.membrosTableAdapter.Fill(this.sistemaIgrejaDataSet.membros);
            Limpar();
        }

        private void FormMembro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult verificacao = MessageBox.Show("Realmente deseja fechar o programa?", "Fechar", MessageBoxButtons.YesNo);

            if (verificacao == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Editavel = false;
            Limpar();
            DesativarTextBoxes(true);
            Adicionavel = true;
        }

        private bool DesativarTextBoxes(bool condicao)
        {
            textNome.Enabled = condicao;
            textSexo.Enabled = condicao;
            textEndereco.Enabled = condicao;
            textNumero.Enabled = condicao;
            textBairro.Enabled = condicao;
            textCidade.Enabled = condicao;
            textUf.Enabled = condicao;
            textCep.Enabled = condicao;
            textTelefone.Enabled = condicao;
            textEmail.Enabled = condicao;
            textEscolaridade.Enabled = condicao;
            textProfissao.Enabled = condicao;
            textNasc.Enabled = condicao;
            textNat.Enabled = condicao;
            textRg.Enabled = condicao;
            textOrg.Enabled = condicao;
            textCpf.Enabled = condicao;
            textDtCasamento.Enabled = condicao;
            textConj.Enabled = condicao;
            textTelConj.Enabled = condicao;
            textFilho.Enabled = condicao;
            textFilho2.Enabled = condicao;
            textFilho3.Enabled = condicao;
            textFilho4.Enabled = condicao;
            textFilho5.Enabled = condicao;
            textDtFilho.Enabled = condicao;
            textDtFilho2.Enabled = condicao;
            textDtFilho3.Enabled = condicao;
            textDtFilho4.Enabled = condicao;
            textDtFilho5.Enabled = condicao;
            textSexFilho.Enabled = condicao;
            textSexFilho2.Enabled = condicao;
            textSexFilho3.Enabled = condicao;
            textSexFilho4.Enabled = condicao;
            textSexFilho5.Enabled = condicao;
            textPai.Enabled = condicao;
            textMae.Enabled = condicao;
            textDtBat.Enabled = condicao;
            textIgrBat.Enabled = condicao;
            textIgrAnt.Enabled = condicao;
            textPasBat.Enabled = condicao;
            textCargExer.Enabled = condicao;
            textCargIgr.Enabled = condicao;
            textTalen.Enabled = condicao;
            textTipo.Enabled = condicao;
            textAcei.Enabled = condicao;

            return condicao;
        }

        public FormMembro()
        {
            InitializeComponent();
            Display();
            Editavel = false;
            Adicionavel = true;
            ContabilizarMembro();
            VersiculosDiarios();

            DoubleBuffered = true;
        }

        public void AtualizarMembro()
        {
            btnEditar.Text = "EDITAR";
            btnSalvar.Text = "SALVAR";

            textNome.Text = NOME;
            textSexo.Text = SEXO;
            textEndereco.Text = ENDERECO;
            textNumero.Text = NUMERO;
            textBairro.Text = BAIRRO;
            textCidade.Text = CIDADE;
            textUf.Text = UF;
            textCep.Text = CEP;
            textTelefone.Text = TELEFONE_CELULAR;
            textEmail.Text = EMAIL;
            textEscolaridade.Text = ESCOLARIDADE;
            textProfissao.Text = PROFISSAO;
            textNasc.Text = DATA_NASCIMENTO;
            textNat.Text = NATURALIDADE;
            textRg.Text = RG;
            textOrg.Text = ORG;
            textCpf.Text = CPF;
            textDtCasamento.Text = DATA_CASAMENTO;
            textConj.Text = CONJUGUE;
            textTelConj.Text = CEL_CONJUGUE;
            textFilho.Text = NOME_FILHO1;
            textFilho2.Text = NOME_FILHO2;
            textFilho3.Text = NOME_FILHO3;
            textFilho4.Text = NOME_FILHO4;
            textFilho5.Text = NOME_FILHO5;
            textDtFilho.Text = DATA_NASCIMENTO_FILHO1;
            textDtFilho2.Text = DATA_NASCIMENTO_FILHO2;
            textDtFilho3.Text = DATA_NASCIMENTO_FILHO3;
            textDtFilho4.Text = DATA_NASCIMENTO_FILHO4;
            textDtFilho5.Text = DATA_NASCIMENTO_FILHO5;
            textSexFilho.Text = SEXO_FILHO1;
            textSexFilho2.Text = SEXO_FILHO2;
            textSexFilho3.Text = SEXO_FILHO3;
            textSexFilho4.Text = SEXO_FILHO4;
            textSexFilho5.Text = SEXO_FILHO5;
            textPai.Text = NOME_PAI;
            textMae.Text = NOME_MAE;
            textDtBat.Text = DATA_BATISMO;
            textIgrBat.Text = NOME_IGREJA_BATISMO;
            textIgrAnt.Text = NOME_IGREJA_ANTERIOR;
            textPasBat.Text = NOME_PASTOR_BATIZOU;
            textCargExer.Text = CARGOS_EXERCIDOS;
            textCargIgr.Text = REQUISICAO_CARGOS;
            textTalen.Text = TALENTOS;
            textTipo.Text = TIPO;
            textAcei.Text = ACEITO_POR;
        }

        public void Limpar()
        {
            textNome.Text = textSexo.Text = textEndereco.Text = textNumero.Text = textBairro.Text = textCidade.Text = textUf.Text =
            textCep.Text = textTelefone.Text = textEmail.Text = textEscolaridade.Text = textProfissao.Text = textNasc.Text = textNat.Text = textRg.Text =
            textOrg.Text = textCpf.Text = textDtCasamento.Text = textConj.Text = textTelConj.Text = textFilho.Text = textFilho2.Text = textFilho3.Text =
            textFilho4.Text = textFilho5.Text = textDtFilho.Text = textDtFilho2.Text = textDtFilho3.Text = textDtFilho4.Text = textDtFilho5.Text =
            textSexFilho.Text = textSexFilho2.Text = textSexFilho3.Text = textSexFilho4.Text = textSexFilho5.Text = textPai.Text = textMae.Text =
            textDtBat.Text = textIgrBat.Text = textIgrAnt.Text = textPasBat.Text = textCargExer.Text = textCargIgr.Text = textTalen.Text = textTipo.Text = textAcei.Text = string.Empty;

            dataGridView1.ClearSelection();
        }

        public void Display()
        {
            int currentRowIndex = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                currentRowIndex = dataGridView1.CurrentRow.Index;
            }

            DbMembro.PesquisarMembro("select ID, NOME, TIPO, TELEFONE_CELULAR, CIDADE from membros", dataGridView1);
            dataGridView1.CurrentCell = null;

            if (currentRowIndex != -1 && currentRowIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[currentRowIndex].Selected = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'NOME'");
                return;
            }

            if (textCidade.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'CIDADE'");
                return;
            }

            if (textTipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'TIPO'");
                return;
            }

            if (btnSalvar.Text == "SALVAR" && Editavel == false && Adicionavel == true)
            {
                Membro membro = new Membro(textNome.Text.Trim(), textSexo.Text.Trim(), textEndereco.Text.Trim(), textNumero.Text.Trim(), textBairro.Text.Trim(), textCidade.Text.Trim(), textUf.Text.Trim(),
                    textCep.Text.Trim(), textTelefone.Text.Trim(), textEmail.Text.Trim(), textEscolaridade.Text.Trim(), textProfissao.Text.Trim(), textNasc.Text.Trim(), textNat.Text.Trim(), textRg.Text.Trim(),
                    textOrg.Text.Trim(), textCpf.Text.Trim(), textDtCasamento.Text.Trim(), textConj.Text.Trim(), textTelConj.Text.Trim(), textFilho.Text.Trim(), textFilho2.Text.Trim(), textFilho3.Text.Trim(),
                    textFilho4.Text.Trim(), textFilho5.Text.Trim(), textDtFilho.Text.Trim(), textDtFilho2.Text.Trim(), textDtFilho3.Text.Trim(), textDtFilho4.Text.Trim(), textDtFilho5.Text.Trim(),
                    textSexFilho.Text.Trim(), textSexFilho2.Text.Trim(), textSexFilho3.Text.Trim(), textSexFilho4.Text.Trim(), textSexFilho5.Text.Trim(), textPai.Text.Trim(), textMae.Text.Trim(),
                    textDtBat.Text.Trim(), textIgrBat.Text.Trim(), textIgrAnt.Text.Trim(), textPasBat.Text.Trim(), textCargExer.Text.Trim(), textCargIgr.Text.Trim(), textTalen.Text.Trim(), textTipo.Text.Trim(), textAcei.Text.Trim());

                DbMembro.AdicionarMembro(membro);
                Limpar();
            }

            else if (btnSalvar.Text == "SALVAR" && Editavel == true)
            {
                Membro membro = new Membro(textNome.Text.Trim(), textSexo.Text.Trim(), textEndereco.Text.Trim(), textNumero.Text.Trim(), textBairro.Text.Trim(), textCidade.Text.Trim(), textUf.Text.Trim(),
                   textCep.Text.Trim(), textTelefone.Text.Trim(), textEmail.Text.Trim(), textEscolaridade.Text.Trim(), textProfissao.Text.Trim(), textNasc.Text.Trim(), textNat.Text.Trim(), textRg.Text.Trim(),
                   textOrg.Text.Trim(), textCpf.Text.Trim(), textDtCasamento.Text.Trim(), textConj.Text.Trim(), textTelConj.Text.Trim(), textFilho.Text.Trim(), textFilho2.Text.Trim(), textFilho3.Text.Trim(),
                   textFilho4.Text.Trim(), textFilho5.Text.Trim(), textDtFilho.Text.Trim(), textDtFilho2.Text.Trim(), textDtFilho3.Text.Trim(), textDtFilho4.Text.Trim(), textDtFilho5.Text.Trim(),
                   textSexFilho.Text.Trim(), textSexFilho2.Text.Trim(), textSexFilho3.Text.Trim(), textSexFilho4.Text.Trim(), textSexFilho5.Text.Trim(), textPai.Text.Trim(), textMae.Text.Trim(),
                   textDtBat.Text.Trim(), textIgrBat.Text.Trim(), textIgrAnt.Text.Trim(), textPasBat.Text.Trim(), textCargExer.Text.Trim(), textCargIgr.Text.Trim(), textTalen.Text.Trim(), textTipo.Text.Trim(), textAcei.Text.Trim());

                DbMembro.EditarMembro(membro, ID);
                DesativarTextBoxes(false);
                Editavel = false;
            }
            this.Display();
            ContabilizarMembro();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            if (dataGridView1.CurrentCell.Selected = true == true)
            {
                Adicionavel = false;
            }

            DesativarTextBoxes(false);

            if (e.RowIndex >= 0)
            {
                // obter o ID da pessoa selecionada
                ID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value);

                // criar a conexão com o banco de dados
                DbMembro dbMembro = new DbMembro();
                using (SqlConnection connection = new SqlConnection(ConfiguracoesDb.stringConexao))
                {
                    connection.Open();

                    // criar a query para selecionar os dados da pessoa
                    string query = "SELECT ID, NOME, SEXO, ENDERECO, NÚMERO, BAIRRO, CIDADE, UF, CEP, TELEFONE_CELULAR, EMAIL, ESCOLARIDADE, PROFISSAO, DATA_NASCIMENTO, NATURALIDADE, RG, ORG, CPF, DATA_CASAMENTO, CONJUGUE, CEL_CONJUGUE, NOME_FILHO1, NOME_FILHO2, NOME_FILHO3, NOME_FILHO4, NOME_FILHO5, DATA_NASCIMENTO_FILHO1, DATA_NASCIMENTO_FILHO2, DATA_NASCIMENTO_FILHO3, DATA_NASCIMENTO_FILHO4, DATA_NASCIMENTO_FILHO5, SEXO_FILHO1, SEXO_FILHO2, SEXO_FILHO3, SEXO_FILHO4, SEXO_FILHO5, NOME_PAI, NOME_MAE, DATA_BATISMO, NOME_IGREJA_BATISMO, NOME_IGREJA_ANTERIOR, NOME_PASTOR_BATIZOU, CARGOS_EXERCIDOS, REQUISICAO_CARGO, TALENTOS, TIPO, ACEITO_POR FROM membros WHERE ID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                try
                                {
                                    // atribuir os valores do banco de dados para as textboxes
                                    textNome.Text = (string)reader["NOME"];
                                    textSexo.Text = (string)reader["SEXO"];
                                    textEndereco.Text = (string)reader["ENDERECO"];
                                    textNumero.Text = (string)reader["NÚMERO"];
                                    textBairro.Text = (string)reader["BAIRRO"];
                                    textCidade.Text = (string)reader["CIDADE"];
                                    textUf.Text = (string)reader["UF"];
                                    textCep.Text = (string)reader["CEP"];
                                    textTelefone.Text = (string)reader["TELEFONE_CELULAR"];
                                    textEmail.Text = (string)reader["EMAIL"];
                                    textEscolaridade.Text = (string)reader["ESCOLARIDADE"];
                                    textProfissao.Text = (string)reader["PROFISSAO"];
                                    textNasc.Text = (string)reader["DATA_NASCIMENTO"];
                                    textNat.Text = (string)reader["NATURALIDADE"];
                                    textRg.Text = (string)reader["RG"];
                                    textOrg.Text = (string)reader["ORG"];
                                    textCpf.Text = (string)reader["CPF"];
                                    textDtCasamento.Text = (string)reader["DATA_CASAMENTO"];
                                    textConj.Text = (string)reader["CONJUGUE"];
                                    textTelConj.Text = (string)reader["CEL_CONJUGUE"];
                                    textFilho.Text = (string)reader["NOME_FILHO1"];
                                    textFilho2.Text = (string)reader["NOME_FILHO2"];
                                    textFilho3.Text = (string)reader["NOME_FILHO3"];
                                    textFilho4.Text = (string)reader["NOME_FILHO4"];
                                    textFilho5.Text = (string)reader["NOME_FILHO5"];
                                    textDtFilho.Text = (string)reader["DATA_NASCIMENTO_FILHO1"];
                                    textDtFilho2.Text = (string)reader["DATA_NASCIMENTO_FILHO2"];
                                    textDtFilho3.Text = (string)reader["DATA_NASCIMENTO_FILHO3"];
                                    textDtFilho4.Text = (string)reader["DATA_NASCIMENTO_FILHO4"];
                                    textDtFilho5.Text = (string)reader["DATA_NASCIMENTO_FILHO5"];
                                    textSexFilho.Text = (string)reader["SEXO_FILHO1"];
                                    textSexFilho2.Text = (string)reader["SEXO_FILHO2"];
                                    textSexFilho3.Text = (string)reader["SEXO_FILHO3"];
                                    textSexFilho4.Text = (string)reader["SEXO_FILHO4"];
                                    textSexFilho5.Text = (string)reader["SEXO_FILHO5"];
                                    textPai.Text = (string)reader["NOME_PAI"];
                                    textMae.Text = (string)reader["NOME_MAE"];
                                    textDtBat.Text = (string)reader["DATA_BATISMO"];
                                    textIgrBat.Text = (string)reader["NOME_IGREJA_BATISMO"];
                                    textIgrAnt.Text = (string)reader["NOME_IGREJA_ANTERIOR"];
                                    textPasBat.Text = (string)reader["NOME_PASTOR_BATIZOU"];
                                    textCargExer.Text = (string)reader["CARGOS_EXERCIDOS"];
                                    textCargIgr.Text = (string)reader["REQUISICAO_CARGO"];
                                    textTalen.Text = (string)reader["TALENTOS"];
                                    textTipo.Text = (string)reader["TIPO"];
                                    textAcei.Text = (string)reader["ACEITO_POR"];
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro ao exibir dados no relatório! ", $"Error{ex}\nSe o problema persistir, entre em contado com o Lucas Woibau! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }

                            if (e.ColumnIndex == 0)
                            {
                                //Deletando
                                if (MessageBox.Show("Você realmente deseja deletar esse membro?", "Informação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    DbMembro.DeletarMembro(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                                    Limpar();
                                    Display();
                                    ContabilizarMembro();
                                    Adicionavel = true;
                                    DesativarTextBoxes(true);
                                }
                                return;
                            }
                        }
                    }
                }
            }
        }
        private void textBoxPesqMem_TextChanged(object sender, EventArgs e)
        {
            DbMembro.PesquisarMembro($"select ID, NOME, TIPO, TELEFONE_CELULAR, CIDADE from membros where NOME LIKE'%{textBoxPesqMem.Text}%'", dataGridView1);
        }

        public void VersiculosDiarios()
        {
            String[] versiculos = new String[]
            {
                "Romanos 10:9 - A saber: Se, com a tua boca, confessares ao\n" +
                "Senhor Jesus e, em teu coração, creres que Deus o ressuscitou\n" +
                "dos mortos, serás salvo.",

                "João 3:16 - Porque Deus amou o mundo de tal maneira que\n" +
                "deu o seu Filho unigênito, para que todo aquele que nele\n" +
                "crê não pereça, mas tenha a vida eterna.",

                "Filipenses 4:13 - Tudo posso naquele que me fortalece.",

                "Mateus 6:33 - Buscai, pois, em primeiro lugar, o seu reino\n " +
                "e a sua justiça, e todas essas coisas vos serão acrescentadas.",

                "1 Pedro 3:15 - Antes, santificai a Cristo, como Senhor, em vosso \n" +
                "coração; e estai sempre preparados para responder com mansidão e \n" +
                "temor a qualquer que vos pedir a razão da esperança que há em vós.",

                "2 Coríntios 5:21 - Àquele que não conheceu pecado, o fez pecado\n" +
                "por nós; para que, nele, fôssemos feitos justiça de Deus.",

                "2 Coríntios 5:17 - Assim que, se alguém está em Cristo, nova \n" +
                "criatura é: as coisas velhas já passaram; eis que tudo se fez novo.",

                "Mateus 5:16 - Assim resplandeça a vossa luz diante dos homens,para que\n" +
                "vejam as vossas boas obras e glorifiquem o vosso Pai, que está nos céus.",

                "Tiago 1:12 - Bem-aventurado o varão que sofre a tentação; porque,\n" +
                "quando for provado, receberá a coroa da vida, a qual o Senhor tem\n" +
                "prometido aos que o amam.",

                "Hebreus 4:16 - Cheguemos, pois, com confiança ao trono da graça,\n " +
                "para que possamos alcançar misericórdia e achar graça, a fim de\n" +
                "sermos ajudados em tempo oportuno.",

                "Salmos 133:3 - Como o orvalho do Hermom, que desce sobre os montes\n" +
                "de Sião; porque ali o Senhor ordena a bênção e a vida para sempre.",

                "Tiago 5:16 - Confessai as vossas culpas uns aos outros e orai\n" +
                "nuns pelos outros, para que sareis; a oração feita por um\n" +
                "justo pode muito em seus efeitos.",

                "Provérbios 3:5 - Confia no Senhor de todo o teu coração e\n" +
                "não te estribes no teu próprio entendimento.",

                "1 João 3:16 - Conhecemos o amor nisto: que ele deu a sua vida\n" +
                "por nós, e nós devemos dar a vida pelos irmãos.",

                "Romanos 10:17 - De sorte que a fé é pelo ouvir,\n" +
                "e o ouvir pela palavra de Deus.",

                "João 14:27 - Deixo-vos a paz, a minha paz vos dou; não vo-la dou\n" +
                "como o mundo a dá. Não se turbe o vosso coração, nem se atemorize.",

                "Salmos 37:4 - Deleita-te também no Senhor, e ele te\n" +
                "concederá o que deseja o teu coração.",

                "Salmos 46:10 - Desiste, desiste, e sabe que eu sou Deus.",

                "Salmos 27:1 - O Senhor é a minha luz e a minha salvação.",

                "1 João 4:8 - Quem não ama não conheceu a Deus, porque Deus é amor.",

                "Lucas 11:28 - Bendito seja o Pai que deu aos homens a\n" +
                "vida eterna, e ela está em seu Filho.",

                "Filipenses 4:6-7 - Não se inquietem com coisa alguma; antes,\n" +
                "em tudo, apresentem as suas petições a Deus em oração \n" +
                "e súplica, com ação de graças.\nE a paz de Deus, que excede\n" +
                "todo o entendimento, guardará o vosso coração e a\n" +
                "vossa mente em Cristo Jesus.",

                "Mateus 7:7 - Peça, e dar-se-vos-á; busque, e encontrarás;\n" +
                "bata, e abrir-se-lhe-á.",

                "Salmos 121:1-2 - Levantarei os meus olhos para os montes,\n" +
                "de onde vem o meu socorro. O meu socorro vem do Senhor,\n" +
                "que fez os céus e a terra.",

                "1 João 1:9 - Se confessarmos os nossos pecados, ele é fiel e justo\n" +
                "para perdoar-nos os pecados e nos purificar de toda injustiça.",

                "Romanos 8:38-39 - Porque estou certo de que, nem a morte, nem a\n" +
                "vida, nem os anjos, nem os principados, nem as coisas presentes,\n" +
                "nem as futuras, nem os poderes, nem a altura, nem a profundidade,\n" +
                "nem qualquer outra criatura poderá separar-nos do amor de Deus,\n" +
                "que está em Cristo Jesus, nosso Senhor.",

                "1 Tessalonicenses 5:18 - Em tudo dai graças, porque esta é a\n" +
                "vontade de Deus em Cristo Jesus para convosco.",

                "Salmos 91:16 - Com as minhas asas te cobrirei, e debaixo das\n" +
                "minhas penas te confortarás; a minha verdade é o escudo e a proteção.",

                "Salmos 56:3 - Quando eu estiver sob o pavor, confiarei em ti.",

                "Lucas 12:32 - Não temas, pequenino rebanho, porque a vosso\n" +
                "Pai agradou dar-vos o reino.",

                "1 Coríntios 13:4-8 - O amor é sofredor, é benigno; o amor não\n" +
                "é invejoso; o amor não se vangloria, não se inflama de\n" +
                "orgulho, não se conduz inconvenientemente, não procura\n" +
                "os seus interesses, não se irrita, não guarda rancor; não se\n" +
                "alegra com a injustiça, mas se regozija com a verdade;\n" +
                "tudo sofre, tudo crê, tudo espera, tudo suporta.",

                "Romanos 8:28 - Sabemos que todas as coisas concorrem para\n" +
                "o bem daqueles que amam a Deus, daqueles que são chamados\n" +
                "segundo o seu propósito.",

                "Salmos 27:14 - Espera no Senhor; seja forte, e ele\n" +
                "fortalecerá o teu coração; espera, sim, no Senhor.",

                "Efésios 2:8-9 - Porque pela graça sois salvos, por meio\n" +
                "da fé; e isto não vem de vós, é dom de Deus; não de obras,\n" +
                "para que ninguém se glorie.",

                "1 Pedro 5:7 - Lançando sobre ele toda a vossa ansiedade,\n" +
                "porque ele tem cuidado de vós.",

                "João 14:6 - Disse-lhe Jesus: Eu sou o caminho, e a verdade,\n" +
                "e a vida; ninguém vem ao Pai, senão por mim.",

                "1 João 5:4 - Porque tudo o que é nascido de Deus vence o\n" +
                "mundo; e esta é a vitória que venceu o mundo: a nossa fé.",

                "Salmos 31:24 - Sejam fortalecidos na retidão, ó meu coração,\n" +
                "pois ao Senhor confiei.",

                "1 Tessalonicenses 5:24 - O qual preserva todos quantos o\n" +
                "amam, mas a todos os ímpios destruirá.",

                "João 8:32 - E conhecereis a verdade, e a verdade vos libertará.",

                "Salmos 37:23-24 - Os passos do homem bom são confirmados pelo\n" +
                "Senhor, e ele se agrada do seu caminho. Ainda que caia,\n" +
                "não ficará prostrado, pois o Senhor o sustenta com a sua mão.",

                "Lucas 12:34 - Porque onde estiver o teu tesouro, aí estará\n" +
                "também o teu coração.",

                "Tiago 1:2-4 - Considerai-vos felizes, meus irmãos, quando\n" +
                "encontrais várias provações, sabendo que a prova da vossa fé\n" +
                "produz perseverança. E a perseverança deve ter obra completa, a fim\n" +
                "de que sejais perfeitos e completos, sem faltar em coisa alguma.",

                "Colossenses 3:23-24 - E tudo o que fizerdes, fazei-o de coração,\n" +
                "como para o Senhor e não para os homens, sabendo que do Senhor\n" +
                "recebereis a recompensa da herança, porque a Cristo, o Senhor, servis.",

                "1 João 4:18 - Nós amamos, porque ele nos amou primeiro.",

                "Salmos 103:1-5 - Bendize, ó minha alma, ao Senhor, e tudo o que\n" +
                "há em mim bendiga o seu santo nome. Bendize, ó minha alma, ao Senhor,\n" +
                "e não esqueças nenhum de seus benefícios. Ele é o que perdoa todas\n" +
                "as tuas iniquidades, que sara todas as tuas doenças; que resgata a\n" +
                "tua vida da sepultura, que te cor."

            };

            Random rand = new Random();
            int randomVersiculo = rand.Next(versiculos.Length);

            labelVers.Text = versiculos[randomVersiculo];
        }
    }
}