namespace SistemaIgreja
{
    partial class FormMembro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMembro));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxPesqMem = new System.Windows.Forms.TextBox();
            this.labelPesqMem = new System.Windows.Forms.Label();
            this.membrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaIgrejaDataSet = new SistemaIgreja.SistemaIgrejaDataSet();
            this.membrosTableAdapter = new SistemaIgreja.SistemaIgrejaDataSetTableAdapters.membrosTableAdapter();
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.labelUf = new System.Windows.Forms.Label();
            this.textUf = new System.Windows.Forms.TextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.textCep = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEscolaridade = new System.Windows.Forms.Label();
            this.textEscolaridade = new System.Windows.Forms.TextBox();
            this.labelProfissao = new System.Windows.Forms.Label();
            this.textProfissao = new System.Windows.Forms.TextBox();
            this.labelNasc = new System.Windows.Forms.Label();
            this.labelNat = new System.Windows.Forms.Label();
            this.textNat = new System.Windows.Forms.TextBox();
            this.labelRg = new System.Windows.Forms.Label();
            this.textRg = new System.Windows.Forms.TextBox();
            this.labelOrg = new System.Windows.Forms.Label();
            this.textOrg = new System.Windows.Forms.TextBox();
            this.labelDtCasamento = new System.Windows.Forms.Label();
            this.textDtCasamento = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelConj = new System.Windows.Forms.Label();
            this.textConj = new System.Windows.Forms.TextBox();
            this.labelTelConj = new System.Windows.Forms.Label();
            this.textTelConj = new System.Windows.Forms.TextBox();
            this.nomeFilho = new System.Windows.Forms.Label();
            this.textFilho = new System.Windows.Forms.TextBox();
            this.DtFilho = new System.Windows.Forms.Label();
            this.sexFilho = new System.Windows.Forms.Label();
            this.textFilho2 = new System.Windows.Forms.TextBox();
            this.textFilho3 = new System.Windows.Forms.TextBox();
            this.textFilho4 = new System.Windows.Forms.TextBox();
            this.textFilho5 = new System.Windows.Forms.TextBox();
            this.labelPai = new System.Windows.Forms.Label();
            this.textPai = new System.Windows.Forms.TextBox();
            this.labelMae = new System.Windows.Forms.Label();
            this.textMae = new System.Windows.Forms.TextBox();
            this.labelBatismo = new System.Windows.Forms.Label();
            this.labelIgrBatismo = new System.Windows.Forms.Label();
            this.textIgrBat = new System.Windows.Forms.TextBox();
            this.labelIgrAnt = new System.Windows.Forms.Label();
            this.textIgrAnt = new System.Windows.Forms.TextBox();
            this.labelPasBat = new System.Windows.Forms.Label();
            this.textPasBat = new System.Windows.Forms.TextBox();
            this.labelCargExe = new System.Windows.Forms.Label();
            this.textCargExer = new System.Windows.Forms.TextBox();
            this.labelCargIgr = new System.Windows.Forms.Label();
            this.textCargIgr = new System.Windows.Forms.TextBox();
            this.labelTalen = new System.Windows.Forms.Label();
            this.textTalen = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelAceito = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textSexo = new System.Windows.Forms.ComboBox();
            this.textTipo = new System.Windows.Forms.ComboBox();
            this.textAcei = new System.Windows.Forms.ComboBox();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textNasc = new System.Windows.Forms.MaskedTextBox();
            this.textDtBat = new System.Windows.Forms.MaskedTextBox();
            this.textDtFilho = new System.Windows.Forms.MaskedTextBox();
            this.textDtFilho2 = new System.Windows.Forms.MaskedTextBox();
            this.textDtFilho3 = new System.Windows.Forms.MaskedTextBox();
            this.textDtFilho4 = new System.Windows.Forms.MaskedTextBox();
            this.textDtFilho5 = new System.Windows.Forms.MaskedTextBox();
            this.textSexFilho2 = new System.Windows.Forms.ComboBox();
            this.textSexFilho = new System.Windows.Forms.ComboBox();
            this.textSexFilho4 = new System.Windows.Forms.ComboBox();
            this.textSexFilho3 = new System.Windows.Forms.ComboBox();
            this.textSexFilho5 = new System.Windows.Forms.ComboBox();
            this.formMembroInfo = new System.Windows.Forms.Panel();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIgrejaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.formMembroInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            resources.ApplyResources(this.panelInfo, "panelInfo");
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.dataGridView1);
            this.panelInfo.Controls.Add(this.textBoxPesqMem);
            this.panelInfo.Controls.Add(this.labelPesqMem);
            this.panelInfo.Name = "panelInfo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNOME,
            this.ColumnTIPO,
            this.ColumnCONTATO,
            this.ColumnCIDADE,
            this.Column6});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            resources.ApplyResources(this.ColumnID, "ColumnID");
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnNOME
            // 
            this.ColumnNOME.DataPropertyName = "NOME";
            resources.ApplyResources(this.ColumnNOME, "ColumnNOME");
            this.ColumnNOME.Name = "ColumnNOME";
            this.ColumnNOME.ReadOnly = true;
            this.ColumnNOME.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTIPO
            // 
            this.ColumnTIPO.DataPropertyName = "TIPO";
            resources.ApplyResources(this.ColumnTIPO, "ColumnTIPO");
            this.ColumnTIPO.Name = "ColumnTIPO";
            this.ColumnTIPO.ReadOnly = true;
            this.ColumnTIPO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnCONTATO
            // 
            this.ColumnCONTATO.DataPropertyName = "TELEFONE_CELULAR";
            resources.ApplyResources(this.ColumnCONTATO, "ColumnCONTATO");
            this.ColumnCONTATO.Name = "ColumnCONTATO";
            this.ColumnCONTATO.ReadOnly = true;
            this.ColumnCONTATO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnCIDADE
            // 
            this.ColumnCIDADE.DataPropertyName = "CIDADE";
            resources.ApplyResources(this.ColumnCIDADE, "ColumnCIDADE");
            this.ColumnCIDADE.Name = "ColumnCIDADE";
            this.ColumnCIDADE.ReadOnly = true;
            this.ColumnCIDADE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Text = "EXCLUIR";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // textBoxPesqMem
            // 
            resources.ApplyResources(this.textBoxPesqMem, "textBoxPesqMem");
            this.textBoxPesqMem.Name = "textBoxPesqMem";
            this.textBoxPesqMem.TextChanged += new System.EventHandler(this.textBoxPesqMem_TextChanged);
            // 
            // labelPesqMem
            // 
            resources.ApplyResources(this.labelPesqMem, "labelPesqMem");
            this.labelPesqMem.Name = "labelPesqMem";
            // 
            // membrosBindingSource
            // 
            this.membrosBindingSource.DataMember = "membros";
            this.membrosBindingSource.DataSource = this.sistemaIgrejaDataSet;
            // 
            // sistemaIgrejaDataSet
            // 
            this.sistemaIgrejaDataSet.DataSetName = "SistemaIgrejaDataSet";
            this.sistemaIgrejaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membrosTableAdapter
            // 
            this.membrosTableAdapter.ClearBeforeFill = true;
            // 
            // labelNome
            // 
            resources.ApplyResources(this.labelNome, "labelNome");
            this.labelNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNome.Name = "labelNome";
            // 
            // textNome
            // 
            this.textNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membrosBindingSource, "NOME", true));
            resources.ApplyResources(this.textNome, "textNome");
            this.textNome.Name = "textNome";
            // 
            // labelSexo
            // 
            resources.ApplyResources(this.labelSexo, "labelSexo");
            this.labelSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSexo.Name = "labelSexo";
            // 
            // labelEndereco
            // 
            resources.ApplyResources(this.labelEndereco, "labelEndereco");
            this.labelEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndereco.Name = "labelEndereco";
            // 
            // textEndereco
            // 
            resources.ApplyResources(this.textEndereco, "textEndereco");
            this.textEndereco.Name = "textEndereco";
            // 
            // labelNumero
            // 
            resources.ApplyResources(this.labelNumero, "labelNumero");
            this.labelNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNumero.Name = "labelNumero";
            // 
            // textNumero
            // 
            resources.ApplyResources(this.textNumero, "textNumero");
            this.textNumero.Name = "textNumero";
            // 
            // labelBairro
            // 
            resources.ApplyResources(this.labelBairro, "labelBairro");
            this.labelBairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBairro.Name = "labelBairro";
            // 
            // textBairro
            // 
            resources.ApplyResources(this.textBairro, "textBairro");
            this.textBairro.Name = "textBairro";
            // 
            // labelCidade
            // 
            resources.ApplyResources(this.labelCidade, "labelCidade");
            this.labelCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCidade.Name = "labelCidade";
            // 
            // textCidade
            // 
            resources.ApplyResources(this.textCidade, "textCidade");
            this.textCidade.Name = "textCidade";
            // 
            // labelUf
            // 
            resources.ApplyResources(this.labelUf, "labelUf");
            this.labelUf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUf.Name = "labelUf";
            // 
            // textUf
            // 
            resources.ApplyResources(this.textUf, "textUf");
            this.textUf.Name = "textUf";
            // 
            // labelCep
            // 
            resources.ApplyResources(this.labelCep, "labelCep");
            this.labelCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCep.Name = "labelCep";
            // 
            // textCep
            // 
            resources.ApplyResources(this.textCep, "textCep");
            this.textCep.Name = "textCep";
            // 
            // labelTelefone
            // 
            resources.ApplyResources(this.labelTelefone, "labelTelefone");
            this.labelTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTelefone.Name = "labelTelefone";
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmail.Name = "labelEmail";
            // 
            // textEmail
            // 
            resources.ApplyResources(this.textEmail, "textEmail");
            this.textEmail.Name = "textEmail";
            // 
            // labelEscolaridade
            // 
            resources.ApplyResources(this.labelEscolaridade, "labelEscolaridade");
            this.labelEscolaridade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEscolaridade.Name = "labelEscolaridade";
            // 
            // textEscolaridade
            // 
            resources.ApplyResources(this.textEscolaridade, "textEscolaridade");
            this.textEscolaridade.Name = "textEscolaridade";
            this.textEscolaridade.Tag = "";
            // 
            // labelProfissao
            // 
            resources.ApplyResources(this.labelProfissao, "labelProfissao");
            this.labelProfissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProfissao.Name = "labelProfissao";
            // 
            // textProfissao
            // 
            resources.ApplyResources(this.textProfissao, "textProfissao");
            this.textProfissao.Name = "textProfissao";
            // 
            // labelNasc
            // 
            resources.ApplyResources(this.labelNasc, "labelNasc");
            this.labelNasc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNasc.Name = "labelNasc";
            // 
            // labelNat
            // 
            resources.ApplyResources(this.labelNat, "labelNat");
            this.labelNat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNat.Name = "labelNat";
            // 
            // textNat
            // 
            resources.ApplyResources(this.textNat, "textNat");
            this.textNat.Name = "textNat";
            // 
            // labelRg
            // 
            resources.ApplyResources(this.labelRg, "labelRg");
            this.labelRg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRg.Name = "labelRg";
            // 
            // textRg
            // 
            resources.ApplyResources(this.textRg, "textRg");
            this.textRg.Name = "textRg";
            // 
            // labelOrg
            // 
            resources.ApplyResources(this.labelOrg, "labelOrg");
            this.labelOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOrg.Name = "labelOrg";
            // 
            // textOrg
            // 
            resources.ApplyResources(this.textOrg, "textOrg");
            this.textOrg.Name = "textOrg";
            // 
            // labelDtCasamento
            // 
            resources.ApplyResources(this.labelDtCasamento, "labelDtCasamento");
            this.labelDtCasamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDtCasamento.Name = "labelDtCasamento";
            // 
            // textDtCasamento
            // 
            resources.ApplyResources(this.textDtCasamento, "textDtCasamento");
            this.textDtCasamento.Name = "textDtCasamento";
            // 
            // labelCpf
            // 
            resources.ApplyResources(this.labelCpf, "labelCpf");
            this.labelCpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCpf.Name = "labelCpf";
            // 
            // labelConj
            // 
            resources.ApplyResources(this.labelConj, "labelConj");
            this.labelConj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelConj.Name = "labelConj";
            // 
            // textConj
            // 
            resources.ApplyResources(this.textConj, "textConj");
            this.textConj.Name = "textConj";
            // 
            // labelTelConj
            // 
            resources.ApplyResources(this.labelTelConj, "labelTelConj");
            this.labelTelConj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTelConj.Name = "labelTelConj";
            // 
            // textTelConj
            // 
            resources.ApplyResources(this.textTelConj, "textTelConj");
            this.textTelConj.Name = "textTelConj";
            // 
            // nomeFilho
            // 
            resources.ApplyResources(this.nomeFilho, "nomeFilho");
            this.nomeFilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nomeFilho.Name = "nomeFilho";
            // 
            // textFilho
            // 
            resources.ApplyResources(this.textFilho, "textFilho");
            this.textFilho.Name = "textFilho";
            // 
            // DtFilho
            // 
            resources.ApplyResources(this.DtFilho, "DtFilho");
            this.DtFilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DtFilho.Name = "DtFilho";
            // 
            // sexFilho
            // 
            resources.ApplyResources(this.sexFilho, "sexFilho");
            this.sexFilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexFilho.Name = "sexFilho";
            // 
            // textFilho2
            // 
            resources.ApplyResources(this.textFilho2, "textFilho2");
            this.textFilho2.Name = "textFilho2";
            // 
            // textFilho3
            // 
            resources.ApplyResources(this.textFilho3, "textFilho3");
            this.textFilho3.Name = "textFilho3";
            // 
            // textFilho4
            // 
            resources.ApplyResources(this.textFilho4, "textFilho4");
            this.textFilho4.Name = "textFilho4";
            // 
            // textFilho5
            // 
            resources.ApplyResources(this.textFilho5, "textFilho5");
            this.textFilho5.Name = "textFilho5";
            // 
            // labelPai
            // 
            resources.ApplyResources(this.labelPai, "labelPai");
            this.labelPai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPai.Name = "labelPai";
            // 
            // textPai
            // 
            resources.ApplyResources(this.textPai, "textPai");
            this.textPai.Name = "textPai";
            // 
            // labelMae
            // 
            resources.ApplyResources(this.labelMae, "labelMae");
            this.labelMae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMae.Name = "labelMae";
            // 
            // textMae
            // 
            resources.ApplyResources(this.textMae, "textMae");
            this.textMae.Name = "textMae";
            // 
            // labelBatismo
            // 
            resources.ApplyResources(this.labelBatismo, "labelBatismo");
            this.labelBatismo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBatismo.Name = "labelBatismo";
            // 
            // labelIgrBatismo
            // 
            resources.ApplyResources(this.labelIgrBatismo, "labelIgrBatismo");
            this.labelIgrBatismo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIgrBatismo.Name = "labelIgrBatismo";
            // 
            // textIgrBat
            // 
            resources.ApplyResources(this.textIgrBat, "textIgrBat");
            this.textIgrBat.Name = "textIgrBat";
            // 
            // labelIgrAnt
            // 
            resources.ApplyResources(this.labelIgrAnt, "labelIgrAnt");
            this.labelIgrAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIgrAnt.Name = "labelIgrAnt";
            // 
            // textIgrAnt
            // 
            resources.ApplyResources(this.textIgrAnt, "textIgrAnt");
            this.textIgrAnt.Name = "textIgrAnt";
            // 
            // labelPasBat
            // 
            resources.ApplyResources(this.labelPasBat, "labelPasBat");
            this.labelPasBat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPasBat.Name = "labelPasBat";
            // 
            // textPasBat
            // 
            resources.ApplyResources(this.textPasBat, "textPasBat");
            this.textPasBat.Name = "textPasBat";
            // 
            // labelCargExe
            // 
            resources.ApplyResources(this.labelCargExe, "labelCargExe");
            this.labelCargExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCargExe.Name = "labelCargExe";
            // 
            // textCargExer
            // 
            resources.ApplyResources(this.textCargExer, "textCargExer");
            this.textCargExer.Name = "textCargExer";
            // 
            // labelCargIgr
            // 
            resources.ApplyResources(this.labelCargIgr, "labelCargIgr");
            this.labelCargIgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCargIgr.Name = "labelCargIgr";
            // 
            // textCargIgr
            // 
            resources.ApplyResources(this.textCargIgr, "textCargIgr");
            this.textCargIgr.Name = "textCargIgr";
            // 
            // labelTalen
            // 
            resources.ApplyResources(this.labelTalen, "labelTalen");
            this.labelTalen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTalen.Name = "labelTalen";
            // 
            // textTalen
            // 
            resources.ApplyResources(this.textTalen, "textTalen");
            this.textTalen.Name = "textTalen";
            // 
            // labelTipo
            // 
            resources.ApplyResources(this.labelTipo, "labelTipo");
            this.labelTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTipo.Name = "labelTipo";
            // 
            // labelAceito
            // 
            resources.ApplyResources(this.labelAceito, "labelAceito");
            this.labelAceito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAceito.Name = "labelAceito";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnNovo, "btnNovo");
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label3);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label4);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textSexo
            // 
            this.textSexo.FormattingEnabled = true;
            this.textSexo.Items.AddRange(new object[] {
            resources.GetString("textSexo.Items"),
            resources.GetString("textSexo.Items1")});
            resources.ApplyResources(this.textSexo, "textSexo");
            this.textSexo.Name = "textSexo";
            // 
            // textTipo
            // 
            this.textTipo.FormattingEnabled = true;
            this.textTipo.Items.AddRange(new object[] {
            resources.GetString("textTipo.Items"),
            resources.GetString("textTipo.Items1")});
            resources.ApplyResources(this.textTipo, "textTipo");
            this.textTipo.Name = "textTipo";
            // 
            // textAcei
            // 
            this.textAcei.BackColor = System.Drawing.Color.White;
            this.textAcei.FormattingEnabled = true;
            this.textAcei.Items.AddRange(new object[] {
            resources.GetString("textAcei.Items"),
            resources.GetString("textAcei.Items1"),
            resources.GetString("textAcei.Items2")});
            resources.ApplyResources(this.textAcei, "textAcei");
            this.textAcei.Name = "textAcei";
            // 
            // textTelefone
            // 
            resources.ApplyResources(this.textTelefone, "textTelefone");
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // textCpf
            // 
            resources.ApplyResources(this.textCpf, "textCpf");
            this.textCpf.Name = "textCpf";
            // 
            // textNasc
            // 
            resources.ApplyResources(this.textNasc, "textNasc");
            this.textNasc.Name = "textNasc";
            this.textNasc.ValidatingType = typeof(System.DateTime);
            // 
            // textDtBat
            // 
            resources.ApplyResources(this.textDtBat, "textDtBat");
            this.textDtBat.Name = "textDtBat";
            this.textDtBat.ValidatingType = typeof(System.DateTime);
            // 
            // textDtFilho
            // 
            resources.ApplyResources(this.textDtFilho, "textDtFilho");
            this.textDtFilho.Name = "textDtFilho";
            this.textDtFilho.ValidatingType = typeof(System.DateTime);
            // 
            // textDtFilho2
            // 
            resources.ApplyResources(this.textDtFilho2, "textDtFilho2");
            this.textDtFilho2.Name = "textDtFilho2";
            this.textDtFilho2.ValidatingType = typeof(System.DateTime);
            // 
            // textDtFilho3
            // 
            resources.ApplyResources(this.textDtFilho3, "textDtFilho3");
            this.textDtFilho3.Name = "textDtFilho3";
            this.textDtFilho3.ValidatingType = typeof(System.DateTime);
            // 
            // textDtFilho4
            // 
            resources.ApplyResources(this.textDtFilho4, "textDtFilho4");
            this.textDtFilho4.Name = "textDtFilho4";
            this.textDtFilho4.ValidatingType = typeof(System.DateTime);
            // 
            // textDtFilho5
            // 
            resources.ApplyResources(this.textDtFilho5, "textDtFilho5");
            this.textDtFilho5.Name = "textDtFilho5";
            this.textDtFilho5.ValidatingType = typeof(System.DateTime);
            // 
            // textSexFilho2
            // 
            this.textSexFilho2.FormattingEnabled = true;
            this.textSexFilho2.Items.AddRange(new object[] {
            resources.GetString("textSexFilho2.Items"),
            resources.GetString("textSexFilho2.Items1")});
            resources.ApplyResources(this.textSexFilho2, "textSexFilho2");
            this.textSexFilho2.Name = "textSexFilho2";
            // 
            // textSexFilho
            // 
            this.textSexFilho.FormattingEnabled = true;
            this.textSexFilho.Items.AddRange(new object[] {
            resources.GetString("textSexFilho.Items"),
            resources.GetString("textSexFilho.Items1")});
            resources.ApplyResources(this.textSexFilho, "textSexFilho");
            this.textSexFilho.Name = "textSexFilho";
            // 
            // textSexFilho4
            // 
            this.textSexFilho4.FormattingEnabled = true;
            this.textSexFilho4.Items.AddRange(new object[] {
            resources.GetString("textSexFilho4.Items"),
            resources.GetString("textSexFilho4.Items1")});
            resources.ApplyResources(this.textSexFilho4, "textSexFilho4");
            this.textSexFilho4.Name = "textSexFilho4";
            // 
            // textSexFilho3
            // 
            this.textSexFilho3.FormattingEnabled = true;
            this.textSexFilho3.Items.AddRange(new object[] {
            resources.GetString("textSexFilho3.Items"),
            resources.GetString("textSexFilho3.Items1")});
            resources.ApplyResources(this.textSexFilho3, "textSexFilho3");
            this.textSexFilho3.Name = "textSexFilho3";
            // 
            // textSexFilho5
            // 
            this.textSexFilho5.FormattingEnabled = true;
            this.textSexFilho5.Items.AddRange(new object[] {
            resources.GetString("textSexFilho5.Items"),
            resources.GetString("textSexFilho5.Items1")});
            resources.ApplyResources(this.textSexFilho5, "textSexFilho5");
            this.textSexFilho5.Name = "textSexFilho5";
            // 
            // formMembroInfo
            // 
            this.formMembroInfo.BackColor = System.Drawing.Color.DarkGray;
            this.formMembroInfo.Controls.Add(this.textSexFilho5);
            this.formMembroInfo.Controls.Add(this.textSexFilho3);
            this.formMembroInfo.Controls.Add(this.textSexFilho4);
            this.formMembroInfo.Controls.Add(this.textSexFilho);
            this.formMembroInfo.Controls.Add(this.textSexFilho2);
            this.formMembroInfo.Controls.Add(this.textDtFilho5);
            this.formMembroInfo.Controls.Add(this.textDtFilho4);
            this.formMembroInfo.Controls.Add(this.textDtFilho3);
            this.formMembroInfo.Controls.Add(this.textDtFilho2);
            this.formMembroInfo.Controls.Add(this.textDtFilho);
            this.formMembroInfo.Controls.Add(this.textDtBat);
            this.formMembroInfo.Controls.Add(this.textNasc);
            this.formMembroInfo.Controls.Add(this.textCpf);
            this.formMembroInfo.Controls.Add(this.textTelefone);
            this.formMembroInfo.Controls.Add(this.textAcei);
            this.formMembroInfo.Controls.Add(this.textTipo);
            this.formMembroInfo.Controls.Add(this.textSexo);
            this.formMembroInfo.Controls.Add(this.panel4);
            this.formMembroInfo.Controls.Add(this.panel3);
            this.formMembroInfo.Controls.Add(this.panel2);
            this.formMembroInfo.Controls.Add(this.panel1);
            this.formMembroInfo.Controls.Add(this.btnNovo);
            this.formMembroInfo.Controls.Add(this.btnSalvar);
            this.formMembroInfo.Controls.Add(this.btnEditar);
            this.formMembroInfo.Controls.Add(this.labelAceito);
            this.formMembroInfo.Controls.Add(this.labelTipo);
            this.formMembroInfo.Controls.Add(this.textTalen);
            this.formMembroInfo.Controls.Add(this.labelTalen);
            this.formMembroInfo.Controls.Add(this.textCargIgr);
            this.formMembroInfo.Controls.Add(this.labelCargIgr);
            this.formMembroInfo.Controls.Add(this.textCargExer);
            this.formMembroInfo.Controls.Add(this.labelCargExe);
            this.formMembroInfo.Controls.Add(this.textPasBat);
            this.formMembroInfo.Controls.Add(this.labelPasBat);
            this.formMembroInfo.Controls.Add(this.textIgrAnt);
            this.formMembroInfo.Controls.Add(this.labelIgrAnt);
            this.formMembroInfo.Controls.Add(this.textIgrBat);
            this.formMembroInfo.Controls.Add(this.labelIgrBatismo);
            this.formMembroInfo.Controls.Add(this.labelBatismo);
            this.formMembroInfo.Controls.Add(this.textMae);
            this.formMembroInfo.Controls.Add(this.labelMae);
            this.formMembroInfo.Controls.Add(this.textPai);
            this.formMembroInfo.Controls.Add(this.labelPai);
            this.formMembroInfo.Controls.Add(this.textFilho5);
            this.formMembroInfo.Controls.Add(this.textFilho4);
            this.formMembroInfo.Controls.Add(this.textFilho3);
            this.formMembroInfo.Controls.Add(this.textFilho2);
            this.formMembroInfo.Controls.Add(this.sexFilho);
            this.formMembroInfo.Controls.Add(this.DtFilho);
            this.formMembroInfo.Controls.Add(this.textFilho);
            this.formMembroInfo.Controls.Add(this.nomeFilho);
            this.formMembroInfo.Controls.Add(this.textTelConj);
            this.formMembroInfo.Controls.Add(this.labelTelConj);
            this.formMembroInfo.Controls.Add(this.textConj);
            this.formMembroInfo.Controls.Add(this.labelConj);
            this.formMembroInfo.Controls.Add(this.labelCpf);
            this.formMembroInfo.Controls.Add(this.textDtCasamento);
            this.formMembroInfo.Controls.Add(this.labelDtCasamento);
            this.formMembroInfo.Controls.Add(this.textOrg);
            this.formMembroInfo.Controls.Add(this.labelOrg);
            this.formMembroInfo.Controls.Add(this.textRg);
            this.formMembroInfo.Controls.Add(this.labelRg);
            this.formMembroInfo.Controls.Add(this.textNat);
            this.formMembroInfo.Controls.Add(this.labelNat);
            this.formMembroInfo.Controls.Add(this.labelNasc);
            this.formMembroInfo.Controls.Add(this.textProfissao);
            this.formMembroInfo.Controls.Add(this.labelProfissao);
            this.formMembroInfo.Controls.Add(this.textEscolaridade);
            this.formMembroInfo.Controls.Add(this.labelEscolaridade);
            this.formMembroInfo.Controls.Add(this.textEmail);
            this.formMembroInfo.Controls.Add(this.labelEmail);
            this.formMembroInfo.Controls.Add(this.labelTelefone);
            this.formMembroInfo.Controls.Add(this.textCep);
            this.formMembroInfo.Controls.Add(this.labelCep);
            this.formMembroInfo.Controls.Add(this.textUf);
            this.formMembroInfo.Controls.Add(this.labelUf);
            this.formMembroInfo.Controls.Add(this.textCidade);
            this.formMembroInfo.Controls.Add(this.labelCidade);
            this.formMembroInfo.Controls.Add(this.textBairro);
            this.formMembroInfo.Controls.Add(this.labelBairro);
            this.formMembroInfo.Controls.Add(this.textNumero);
            this.formMembroInfo.Controls.Add(this.labelNumero);
            this.formMembroInfo.Controls.Add(this.textEndereco);
            this.formMembroInfo.Controls.Add(this.labelEndereco);
            this.formMembroInfo.Controls.Add(this.labelSexo);
            this.formMembroInfo.Controls.Add(this.textNome);
            this.formMembroInfo.Controls.Add(this.labelNome);
            resources.ApplyResources(this.formMembroInfo, "formMembroInfo");
            this.formMembroInfo.Name = "formMembroInfo";
            // 
            // FormMembro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.formMembroInfo);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMembro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMembro_FormClosing);
            this.Load += new System.EventHandler(this.FormMembro_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIgrejaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.formMembroInfo.ResumeLayout(false);
            this.formMembroInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxPesqMem;
        private System.Windows.Forms.Label labelPesqMem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SistemaIgrejaDataSet sistemaIgrejaDataSet;
        private System.Windows.Forms.BindingSource membrosBindingSource;
        private SistemaIgrejaDataSetTableAdapters.membrosTableAdapter membrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCIDADE;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label labelUf;
        private System.Windows.Forms.TextBox textUf;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.TextBox textCep;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEscolaridade;
        private System.Windows.Forms.TextBox textEscolaridade;
        private System.Windows.Forms.Label labelProfissao;
        private System.Windows.Forms.TextBox textProfissao;
        private System.Windows.Forms.Label labelNasc;
        private System.Windows.Forms.Label labelNat;
        private System.Windows.Forms.TextBox textNat;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.TextBox textRg;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.TextBox textOrg;
        private System.Windows.Forms.Label labelDtCasamento;
        private System.Windows.Forms.TextBox textDtCasamento;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelConj;
        private System.Windows.Forms.TextBox textConj;
        private System.Windows.Forms.Label labelTelConj;
        private System.Windows.Forms.TextBox textTelConj;
        private System.Windows.Forms.Label nomeFilho;
        private System.Windows.Forms.TextBox textFilho;
        private System.Windows.Forms.Label DtFilho;
        private System.Windows.Forms.Label sexFilho;
        private System.Windows.Forms.TextBox textFilho2;
        private System.Windows.Forms.TextBox textFilho3;
        private System.Windows.Forms.TextBox textFilho4;
        private System.Windows.Forms.TextBox textFilho5;
        private System.Windows.Forms.Label labelPai;
        private System.Windows.Forms.TextBox textPai;
        private System.Windows.Forms.Label labelMae;
        private System.Windows.Forms.TextBox textMae;
        private System.Windows.Forms.Label labelBatismo;
        private System.Windows.Forms.Label labelIgrBatismo;
        private System.Windows.Forms.TextBox textIgrBat;
        private System.Windows.Forms.Label labelIgrAnt;
        private System.Windows.Forms.TextBox textIgrAnt;
        private System.Windows.Forms.Label labelPasBat;
        private System.Windows.Forms.TextBox textPasBat;
        private System.Windows.Forms.Label labelCargExe;
        private System.Windows.Forms.TextBox textCargExer;
        private System.Windows.Forms.Label labelCargIgr;
        private System.Windows.Forms.TextBox textCargIgr;
        private System.Windows.Forms.Label labelTalen;
        private System.Windows.Forms.TextBox textTalen;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelAceito;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox textSexo;
        private System.Windows.Forms.ComboBox textTipo;
        private System.Windows.Forms.ComboBox textAcei;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textNasc;
        private System.Windows.Forms.MaskedTextBox textDtBat;
        private System.Windows.Forms.MaskedTextBox textDtFilho;
        private System.Windows.Forms.MaskedTextBox textDtFilho2;
        private System.Windows.Forms.MaskedTextBox textDtFilho3;
        private System.Windows.Forms.MaskedTextBox textDtFilho4;
        private System.Windows.Forms.MaskedTextBox textDtFilho5;
        private System.Windows.Forms.ComboBox textSexFilho2;
        private System.Windows.Forms.ComboBox textSexFilho;
        private System.Windows.Forms.ComboBox textSexFilho4;
        private System.Windows.Forms.ComboBox textSexFilho3;
        private System.Windows.Forms.ComboBox textSexFilho5;
        private System.Windows.Forms.Panel formMembroInfo;
    }
}

