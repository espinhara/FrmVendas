namespace WFA_Vendas
{
    partial class FrmFornecedor
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
            System.Windows.Forms.Label cod_forLabel;
            System.Windows.Forms.Label razaoLabel;
            System.Windows.Forms.Label fantasiaLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label ieLabel;
            System.Windows.Forms.Label dataCadLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dSVendas = new WFA_Vendas.DSVendas();
            this.pc_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_fornecedorTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_fornecedorTableAdapter();
            this.tableAdapterManager = new WFA_Vendas.DSVendasTableAdapters.TableAdapterManager();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.txtCod_for = new System.Windows.Forms.TextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mksCep = new System.Windows.Forms.MaskedTextBox();
            this.mksTel = new System.Windows.Forms.MaskedTextBox();
            this.mksFax = new System.Windows.Forms.MaskedTextBox();
            this.mksCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtDataCad = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.mksUf = new System.Windows.Forms.MaskedTextBox();
            this.mskIe = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_forLabel = new System.Windows.Forms.Label();
            razaoLabel = new System.Windows.Forms.Label();
            fantasiaLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ieLabel = new System.Windows.Forms.Label();
            dataCadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_forLabel
            // 
            cod_forLabel.AutoSize = true;
            cod_forLabel.Location = new System.Drawing.Point(126, 42);
            cod_forLabel.Name = "cod_forLabel";
            cod_forLabel.Size = new System.Drawing.Size(64, 13);
            cod_forLabel.TabIndex = 1;
            cod_forLabel.Text = "Fornecedor:";
            // 
            // razaoLabel
            // 
            razaoLabel.AutoSize = true;
            razaoLabel.Location = new System.Drawing.Point(126, 69);
            razaoLabel.Name = "razaoLabel";
            razaoLabel.Size = new System.Drawing.Size(41, 13);
            razaoLabel.TabIndex = 3;
            razaoLabel.Text = "Razão:";
            // 
            // fantasiaLabel
            // 
            fantasiaLabel.AutoSize = true;
            fantasiaLabel.Location = new System.Drawing.Point(126, 95);
            fantasiaLabel.Name = "fantasiaLabel";
            fantasiaLabel.Size = new System.Drawing.Size(50, 13);
            fantasiaLabel.TabIndex = 5;
            fantasiaLabel.Text = "Fantasia:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(126, 121);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(126, 147);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(583, 43);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 11;
            bairroLabel.Text = "Bairro:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(583, 69);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(24, 13);
            ufLabel.TabIndex = 13;
            ufLabel.Text = "UF:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(583, 95);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 15;
            cepLabel.Text = "CEP:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(583, 121);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 17;
            telefoneLabel.Text = "Telefone:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(583, 147);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 19;
            faxLabel.Text = "Fax:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(583, 173);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(37, 13);
            cnpjLabel.TabIndex = 21;
            cnpjLabel.Text = "CNPJ:";
            // 
            // ieLabel
            // 
            ieLabel.AutoSize = true;
            ieLabel.Location = new System.Drawing.Point(126, 176);
            ieLabel.Name = "ieLabel";
            ieLabel.Size = new System.Drawing.Size(20, 13);
            ieLabel.TabIndex = 23;
            ieLabel.Text = "IE:";
            // 
            // dataCadLabel
            // 
            dataCadLabel.AutoSize = true;
            dataCadLabel.Location = new System.Drawing.Point(126, 203);
            dataCadLabel.Name = "dataCadLabel";
            dataCadLabel.Size = new System.Drawing.Size(78, 13);
            dataCadLabel.TabIndex = 25;
            dataCadLabel.Text = "Data Cadastro:";
            // 
            // dSVendas
            // 
            this.dSVendas.DataSetName = "DSVendas";
            this.dSVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_fornecedorBindingSource
            // 
            this.pc_fornecedorBindingSource.DataMember = "pc_fornecedor";
            this.pc_fornecedorBindingSource.DataSource = this.dSVendas;
            // 
            // pc_fornecedorTableAdapter
            // 
            this.pc_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_fornecedorTableAdapter = this.pc_fornecedorTableAdapter;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFA_Vendas.DSVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AutoGenerateColumns = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dgvFornecedor.DataSource = this.pc_fornecedorBindingSource;
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 261);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(1104, 171);
            this.dgvFornecedor.TabIndex = 21;
            this.dgvFornecedor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFornecedor_CellFormatting);
            // 
            // txtCod_for
            // 
            this.txtCod_for.Enabled = false;
            this.txtCod_for.Location = new System.Drawing.Point(198, 39);
            this.txtCod_for.Name = "txtCod_for";
            this.txtCod_for.Size = new System.Drawing.Size(200, 20);
            this.txtCod_for.TabIndex = 1;
            // 
            // txtRazao
            // 
            this.txtRazao.Enabled = false;
            this.txtRazao.Location = new System.Drawing.Point(198, 65);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(200, 20);
            this.txtRazao.TabIndex = 2;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Enabled = false;
            this.txtFantasia.Location = new System.Drawing.Point(198, 91);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(200, 20);
            this.txtFantasia.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(198, 117);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(198, 143);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(644, 40);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 8;
            // 
            // mksCep
            // 
            this.mksCep.Enabled = false;
            this.mksCep.Location = new System.Drawing.Point(644, 92);
            this.mksCep.Mask = "00000-000";
            this.mksCep.Name = "mksCep";
            this.mksCep.Size = new System.Drawing.Size(90, 20);
            this.mksCep.TabIndex = 10;
            // 
            // mksTel
            // 
            this.mksTel.Enabled = false;
            this.mksTel.Location = new System.Drawing.Point(644, 118);
            this.mksTel.Mask = "(00) 00000-0000";
            this.mksTel.Name = "mksTel";
            this.mksTel.Size = new System.Drawing.Size(90, 20);
            this.mksTel.TabIndex = 11;
            // 
            // mksFax
            // 
            this.mksFax.Enabled = false;
            this.mksFax.Location = new System.Drawing.Point(644, 144);
            this.mksFax.Mask = "(00) 00000-0000";
            this.mksFax.Name = "mksFax";
            this.mksFax.Size = new System.Drawing.Size(90, 20);
            this.mksFax.TabIndex = 12;
            // 
            // mksCnpj
            // 
            this.mksCnpj.Enabled = false;
            this.mksCnpj.Location = new System.Drawing.Point(644, 170);
            this.mksCnpj.Mask = "00.000.000/0000-00";
            this.mksCnpj.Name = "mksCnpj";
            this.mksCnpj.Size = new System.Drawing.Size(104, 20);
            this.mksCnpj.TabIndex = 13;
            // 
            // txtDataCad
            // 
            this.txtDataCad.CustomFormat = "dd/MM/yyyy";
            this.txtDataCad.Enabled = false;
            this.txtDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataCad.Location = new System.Drawing.Point(210, 197);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(90, 20);
            this.txtDataCad.TabIndex = 7;
            this.txtDataCad.Value = new System.DateTime(2019, 8, 12, 0, 0, 0, 0);
            this.txtDataCad.ValueChanged += new System.EventHandler(this.txtDataCad_ValueChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(994, 210);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(994, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(994, 152);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(994, 123);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(994, 92);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(994, 61);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(994, 32);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 14;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // mksUf
            // 
            this.mksUf.Enabled = false;
            this.mksUf.Location = new System.Drawing.Point(644, 69);
            this.mksUf.Mask = ">LL";
            this.mksUf.Name = "mksUf";
            this.mksUf.Size = new System.Drawing.Size(22, 20);
            this.mksUf.TabIndex = 9;
            // 
            // mskIe
            // 
            this.mskIe.Enabled = false;
            this.mskIe.Location = new System.Drawing.Point(198, 169);
            this.mskIe.Mask = "000.000.000.000";
            this.mskIe.Name = "mskIe";
            this.mskIe.Size = new System.Drawing.Size(90, 20);
            this.mskIe.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_for";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "razao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Razão";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fantasia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fantasia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "uf";
            dataGridViewCellStyle1.Format = ">LL";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.HeaderText = "UF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cep";
            dataGridViewCellStyle2.Format = "#####-###";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn8.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "telefone";
            dataGridViewCellStyle3.Format = "(##)*####-####";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fax";
            dataGridViewCellStyle4.Format = "(##)#####-####";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn10.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cnpj";
            dataGridViewCellStyle5.Format = "##.###.###/####-##";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn11.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ie";
            dataGridViewCellStyle6.Format = "###.###.###.###";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn12.HeaderText = "IE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "dataCad";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn13.HeaderText = "Data Cadastro";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 70;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 444);
            this.Controls.Add(this.mskIe);
            this.Controls.Add(this.mksUf);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(cod_forLabel);
            this.Controls.Add(this.txtCod_for);
            this.Controls.Add(razaoLabel);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(fantasiaLabel);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(ufLabel);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.mksCep);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.mksTel);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.mksFax);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.mksCnpj);
            this.Controls.Add(ieLabel);
            this.Controls.Add(dataCadLabel);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.dgvFornecedor);
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSVendas dSVendas;
        private System.Windows.Forms.BindingSource pc_fornecedorBindingSource;
        private DSVendasTableAdapters.pc_fornecedorTableAdapter pc_fornecedorTableAdapter;
        private DSVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TextBox txtCod_for;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mksCep;
        private System.Windows.Forms.MaskedTextBox mksTel;
        private System.Windows.Forms.MaskedTextBox mksFax;
        private System.Windows.Forms.MaskedTextBox mksCnpj;
        private System.Windows.Forms.DateTimePicker txtDataCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.MaskedTextBox mksUf;
        private System.Windows.Forms.MaskedTextBox mskIe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}