using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaIgreja
{
    public partial class FormMembro : Form
    {
        public string ID, NOME, SEXO, ENDERECO, NUMERO, BAIRRO, CIDADE, UF, CEP, TELEFONE_CELULAR, EMAIL, ESCOLARIDADE, PROFISSAO, DATA_NASCIMENTO, NATURALIDADE, RG, ORG, CPF, DATA_CASAMENTO, CONJUGUE, CEL_CONJUGUE, NOME_FILHO1, NOME_FILHO2, NOME_FILHO3,
                      NOME_FILHO4, NOME_FILHO5, DATA_NASCIMENTO_FILHO1, DATA_NASCIMENTO_FILHO2, DATA_NASCIMENTO_FILHO3, DATA_NASCIMENTO_FILHO4, DATA_NASCIMENTO_FILHO5, SEXO_FILHO1, SEXO_FILHO2, SEXO_FILHO3, SEXO_FILHO4, SEXO_FILHO5,
                      NOME_PAI, NOME_MAE, DATA_BATISMO, NOME_IGREJA_BATISMO, NOME_IGREJA_ANTERIOR, NOME_PASTOR_BATIZOU, CARGOS_EXERCIDOS, REQUISICAO_CARGOS, TALENTOS, TIPO, ACEITO_POR;

        private void FormMembro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaIgrejaDataSet.membros' table. You can move, or remove it, as needed.
            this.membrosTableAdapter.Fill(this.sistemaIgrejaDataSet.membros);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public FormMembro()
        {
            InitializeComponent();
            Display();
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
        }

        public void Display()
        {
            DbMembro.PesquisarMembro("select ID, NOME, TIPO, TELEFONE_CELULAR, CIDADE from membros", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'NOME'");
                return;
            }

            if (textSexo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'SEXO'");
                return;
            }

            if (textCidade.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'CIDADE'");
                return;
            }

            if (textCep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'CEP'");
                return;
            }

            if (textNasc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'DATA NASCIMENTO'");
                return;
            }

            if (textRg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'RG'");
                return;
            }

            if (textCpf.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'CPF'");
                return;
            }

            if (textTipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor preencher o campo 'TIPO'");
                return;
            }

            if (btnSalvar.Text == "SALVAR")
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

            else if(btnEditar.Text == "EDITAR")
            {
                Membro membro = new Membro(textNome.Text.Trim(), textSexo.Text.Trim(), textEndereco.Text.Trim(), textNumero.Text.Trim(), textBairro.Text.Trim(), textCidade.Text.Trim(), textUf.Text.Trim(),
                   textCep.Text.Trim(), textTelefone.Text.Trim(), textEmail.Text.Trim(), textEscolaridade.Text.Trim(), textProfissao.Text.Trim(), textNasc.Text.Trim(), textNat.Text.Trim(), textRg.Text.Trim(),
                   textOrg.Text.Trim(), textCpf.Text.Trim(), textDtCasamento.Text.Trim(), textConj.Text.Trim(), textTelConj.Text.Trim(), textFilho.Text.Trim(), textFilho2.Text.Trim(), textFilho3.Text.Trim(),
                   textFilho4.Text.Trim(), textFilho5.Text.Trim(), textDtFilho.Text.Trim(), textDtFilho2.Text.Trim(), textDtFilho3.Text.Trim(), textDtFilho4.Text.Trim(), textDtFilho5.Text.Trim(),
                   textSexFilho.Text.Trim(), textSexFilho2.Text.Trim(), textSexFilho3.Text.Trim(), textSexFilho4.Text.Trim(), textSexFilho5.Text.Trim(), textPai.Text.Trim(), textMae.Text.Trim(),
                   textDtBat.Text.Trim(), textIgrBat.Text.Trim(), textIgrAnt.Text.Trim(), textPasBat.Text.Trim(), textCargExer.Text.Trim(), textCargIgr.Text.Trim(), textTalen.Text.Trim(), textTipo.Text.Trim(), textAcei.Text.Trim());

                DbMembro.EditarMembro(membro, ID);
            }

            this.Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pega o índice da linha selecionada
            int index = e.RowIndex;

            // Verifica se o índice é válido (se ele é maior ou igual a zero)
            if (index >= 0)
            {
                // Pega os valores das células da linha selecionada
                string nome = dataGridView1.Rows[index].Cells[2].Value.ToString();
                string tipo = dataGridView1.Rows[index].Cells[3].Value.ToString();
                string telefone = dataGridView1.Rows[index].Cells[4].Value.ToString();
                string cidade = dataGridView1.Rows[index].Cells[5].Value.ToString();

                // Preenche os campos do formulário com os valores
                textNome.Text = nome;
                textTipo.Text = tipo;
                textTelefone.Text = telefone;
                textCidade.Text = cidade;
            }

            if (e.ColumnIndex == 0)
            {
                //Deletando
                if(MessageBox.Show("Você realmente deseja deletar esse membro?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbMembro.DeletarMembro(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Limpar();
                    Display();
                }
                return;
            }

        }

        private void textBoxPesqMem_TextChanged(object sender, EventArgs e)
        {           
            DbMembro.PesquisarMembro($"select ID, NOME, TIPO, TELEFONE_CELULAR, CIDADE from membros where NOME LIKE'%{textBoxPesqMem.Text}%'", dataGridView1);
        }
    }
}
