namespace WFA_Vendas
{
    partial class FrmVendas
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
            System.Windows.Forms.Label codCliLabel;
            System.Windows.Forms.Label numVendaLabel;
            System.Windows.Forms.Label dataVendaLabel;
            System.Windows.Forms.Label dataEntregaLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label codProLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precounitLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVendas = new WFA_Vendas.DSVendas();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.pcclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntregaVenda = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.pc_itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnItemIncluir = new System.Windows.Forms.Button();
            this.btnItemExcluir = new System.Windows.Forms.Button();
            this.btnItemAlterar = new System.Windows.Forms.Button();
            this.btnItemPesquisar = new System.Windows.Forms.Button();
            this.btnItemGravar = new System.Windows.Forms.Button();
            this.btnItemCancelar = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtPrecounit = new System.Windows.Forms.TextBox();
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpItemVenda = new System.Windows.Forms.GroupBox();
            this.pc_vendasTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_vendasTableAdapter();
            this.pc_clientesTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_clientesTableAdapter();
            this.pc_ProdutoTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_ProdutoTableAdapter();
            this.tableAdapterManager = new WFA_Vendas.DSVendasTableAdapters.TableAdapterManager();
            this.pc_itemVendaTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_itemVendaTableAdapter();
            this.pcProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codCliLabel = new System.Windows.Forms.Label();
            numVendaLabel = new System.Windows.Forms.Label();
            dataVendaLabel = new System.Windows.Forms.Label();
            dataEntregaLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            codProLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            this.grpItemVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codCliLabel
            // 
            codCliLabel.AutoSize = true;
            codCliLabel.Location = new System.Drawing.Point(392, 57);
            codCliLabel.Name = "codCliLabel";
            codCliLabel.Size = new System.Drawing.Size(42, 13);
            codCliLabel.TabIndex = 1;
            codCliLabel.Text = "Cliente:";
            // 
            // numVendaLabel
            // 
            numVendaLabel.AutoSize = true;
            numVendaLabel.Location = new System.Drawing.Point(106, 57);
            numVendaLabel.Name = "numVendaLabel";
            numVendaLabel.Size = new System.Drawing.Size(41, 13);
            numVendaLabel.TabIndex = 3;
            numVendaLabel.Text = "Venda:";
            // 
            // dataVendaLabel
            // 
            dataVendaLabel.AutoSize = true;
            dataVendaLabel.Location = new System.Drawing.Point(67, 93);
            dataVendaLabel.Name = "dataVendaLabel";
            dataVendaLabel.Size = new System.Drawing.Size(82, 13);
            dataVendaLabel.TabIndex = 5;
            dataVendaLabel.Text = "Data da Venda:";
            // 
            // dataEntregaLabel
            // 
            dataEntregaLabel.AutoSize = true;
            dataEntregaLabel.Location = new System.Drawing.Point(346, 93);
            dataEntregaLabel.Name = "dataEntregaLabel";
            dataEntregaLabel.Size = new System.Drawing.Size(88, 13);
            dataEntregaLabel.TabIndex = 7;
            dataEntregaLabel.Text = "Data da Entrega:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(118, 134);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(29, 13);
            obsLabel.TabIndex = 9;
            obsLabel.Text = "Obs:";
            // 
            // codProLabel
            // 
            codProLabel.AutoSize = true;
            codProLabel.Location = new System.Drawing.Point(6, 50);
            codProLabel.Name = "codProLabel";
            codProLabel.Size = new System.Drawing.Size(47, 13);
            codProLabel.TabIndex = 26;
            codProLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(217, 50);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 28;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(313, 50);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(77, 13);
            precounitLabel.TabIndex = 30;
            precounitLabel.Text = "Preço Unitário:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(436, 50);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 33;
            subTotalLabel.Text = "Sub Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(560, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 33;
            label2.Text = "Total:";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvVendas.DataSource = this.pc_vendasBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(37, 189);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(695, 122);
            this.dgvVendas.TabIndex = 14;
            this.dgvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pc_vendasDataGridView_CellContentClick);
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numVenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "Venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codCli";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataVenda";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data da Venda";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataEntrega";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data da Entrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // pc_vendasBindingSource
            // 
            this.pc_vendasBindingSource.DataMember = "pc_vendas";
            this.pc_vendasBindingSource.DataSource = this.dSVendas;
            // 
            // dSVendas
            // 
            this.dSVendas.DataSetName = "DSVendas";
            this.dSVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataSource = this.pcclientesBindingSource;
            this.cmbCliente.DisplayMember = "nome";
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(440, 54);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(233, 21);
            this.cmbCliente.TabIndex = 10;
            this.cmbCliente.ValueMember = "codCli";
            // 
            // pcclientesBindingSource
            // 
            this.pcclientesBindingSource.DataMember = "pc_clientes";
            this.pcclientesBindingSource.DataSource = this.dSVendas;
            // 
            // txtVenda
            // 
            this.txtVenda.Enabled = false;
            this.txtVenda.Location = new System.Drawing.Point(155, 54);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(100, 20);
            this.txtVenda.TabIndex = 8;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Enabled = false;
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(157, 86);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(98, 20);
            this.dtpDataVenda.TabIndex = 9;
            // 
            // dtpDataEntregaVenda
            // 
            this.dtpDataEntregaVenda.Enabled = false;
            this.dtpDataEntregaVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntregaVenda.Location = new System.Drawing.Point(440, 87);
            this.dtpDataEntregaVenda.Name = "dtpDataEntregaVenda";
            this.dtpDataEntregaVenda.Size = new System.Drawing.Size(100, 20);
            this.dtpDataEntregaVenda.TabIndex = 11;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(153, 134);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(520, 49);
            this.txtObs.TabIndex = 12;
            // 
            // pc_itemVendaBindingSource
            // 
            this.pc_itemVendaBindingSource.DataMember = "FK_pc_itemVenda_pc_vendas";
            this.pc_itemVendaBindingSource.DataSource = this.pc_vendasBindingSource;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(79, 13);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(178, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(274, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(369, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(470, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(561, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(642, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(699, 134);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 13;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnItemIncluir
            // 
            this.btnItemIncluir.Location = new System.Drawing.Point(73, 19);
            this.btnItemIncluir.Name = "btnItemIncluir";
            this.btnItemIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnItemIncluir.TabIndex = 15;
            this.btnItemIncluir.Text = "Incluir";
            this.btnItemIncluir.UseVisualStyleBackColor = true;
            this.btnItemIncluir.Click += new System.EventHandler(this.btnItemIncluir_Click);
            // 
            // btnItemExcluir
            // 
            this.btnItemExcluir.Location = new System.Drawing.Point(172, 19);
            this.btnItemExcluir.Name = "btnItemExcluir";
            this.btnItemExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnItemExcluir.TabIndex = 16;
            this.btnItemExcluir.Text = "Excluir";
            this.btnItemExcluir.UseVisualStyleBackColor = true;
            this.btnItemExcluir.Click += new System.EventHandler(this.btnItemExcluir_Click);
            // 
            // btnItemAlterar
            // 
            this.btnItemAlterar.Location = new System.Drawing.Point(268, 19);
            this.btnItemAlterar.Name = "btnItemAlterar";
            this.btnItemAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnItemAlterar.TabIndex = 17;
            this.btnItemAlterar.Text = "Alterar";
            this.btnItemAlterar.UseVisualStyleBackColor = true;
            this.btnItemAlterar.Click += new System.EventHandler(this.btnItemAlterar_Click);
            // 
            // btnItemPesquisar
            // 
            this.btnItemPesquisar.Location = new System.Drawing.Point(363, 19);
            this.btnItemPesquisar.Name = "btnItemPesquisar";
            this.btnItemPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnItemPesquisar.TabIndex = 18;
            this.btnItemPesquisar.Text = "Pesquisar";
            this.btnItemPesquisar.UseVisualStyleBackColor = true;
            this.btnItemPesquisar.Click += new System.EventHandler(this.btnItemPesquisar_Click);
            // 
            // btnItemGravar
            // 
            this.btnItemGravar.Enabled = false;
            this.btnItemGravar.Location = new System.Drawing.Point(464, 18);
            this.btnItemGravar.Name = "btnItemGravar";
            this.btnItemGravar.Size = new System.Drawing.Size(75, 23);
            this.btnItemGravar.TabIndex = 19;
            this.btnItemGravar.Text = "Gravar";
            this.btnItemGravar.UseVisualStyleBackColor = true;
            this.btnItemGravar.Click += new System.EventHandler(this.btnItemGravar_Click);
            // 
            // btnItemCancelar
            // 
            this.btnItemCancelar.Enabled = false;
            this.btnItemCancelar.Location = new System.Drawing.Point(555, 19);
            this.btnItemCancelar.Name = "btnItemCancelar";
            this.btnItemCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnItemCancelar.TabIndex = 20;
            this.btnItemCancelar.Text = "Cancelar";
            this.btnItemCancelar.UseVisualStyleBackColor = true;
            this.btnItemCancelar.Click += new System.EventHandler(this.btnItemCancelar_Click);
            // 
            // cmbProduto
            // 
            this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduto.DataSource = this.pcProdutoBindingSource;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(20, 72);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(196, 21);
            this.cmbProduto.TabIndex = 21;
            this.cmbProduto.ValueMember = "codPro";
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Enabled = false;
            this.nudQuantidade.Location = new System.Drawing.Point(228, 73);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(54, 20);
            this.nudQuantidade.TabIndex = 22;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // txtPrecounit
            // 
            this.txtPrecounit.Enabled = false;
            this.txtPrecounit.Location = new System.Drawing.Point(316, 73);
            this.txtPrecounit.Name = "txtPrecounit";
            this.txtPrecounit.Size = new System.Drawing.Size(100, 20);
            this.txtPrecounit.TabIndex = 23;
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.AllowUserToAddRows = false;
            this.dgvItemVenda.AllowUserToDeleteRows = false;
            this.dgvItemVenda.AutoGenerateColumns = false;
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.dgvItemVenda.DataSource = this.pc_itemVendaBindingSource;
            this.dgvItemVenda.Location = new System.Drawing.Point(37, 456);
            this.dgvItemVenda.Name = "dgvItemVenda";
            this.dgvItemVenda.ReadOnly = true;
            this.dgvItemVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemVenda.Size = new System.Drawing.Size(695, 105);
            this.dgvItemVenda.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codPro";
            this.dataGridViewTextBoxColumn8.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "precounit";
            dataGridViewCellStyle1.Format = "R$ #,###,###,##0.00";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn10.HeaderText = "Preço Unitário";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SubTotal";
            dataGridViewCellStyle2.Format = "R$ #,###,###,##0.00";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn12.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(439, 73);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 24;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(563, 74);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // grpItemVenda
            // 
            this.grpItemVenda.Controls.Add(this.btnItemCancelar);
            this.grpItemVenda.Controls.Add(label2);
            this.grpItemVenda.Controls.Add(this.btnItemIncluir);
            this.grpItemVenda.Controls.Add(subTotalLabel);
            this.grpItemVenda.Controls.Add(this.btnItemExcluir);
            this.grpItemVenda.Controls.Add(this.txtTotal);
            this.grpItemVenda.Controls.Add(this.txtSubTotal);
            this.grpItemVenda.Controls.Add(this.btnItemAlterar);
            this.grpItemVenda.Controls.Add(this.btnItemPesquisar);
            this.grpItemVenda.Controls.Add(precounitLabel);
            this.grpItemVenda.Controls.Add(this.btnItemGravar);
            this.grpItemVenda.Controls.Add(this.txtPrecounit);
            this.grpItemVenda.Controls.Add(this.cmbProduto);
            this.grpItemVenda.Controls.Add(quantidadeLabel);
            this.grpItemVenda.Controls.Add(codProLabel);
            this.grpItemVenda.Controls.Add(this.nudQuantidade);
            this.grpItemVenda.Location = new System.Drawing.Point(37, 317);
            this.grpItemVenda.Name = "grpItemVenda";
            this.grpItemVenda.Size = new System.Drawing.Size(695, 115);
            this.grpItemVenda.TabIndex = 35;
            this.grpItemVenda.TabStop = false;
            this.grpItemVenda.Text = "Itens da Venda";
            // 
            // pc_vendasTableAdapter
            // 
            this.pc_vendasTableAdapter.ClearBeforeFill = true;
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // pc_ProdutoTableAdapter
            // 
            this.pc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_fornecedorTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFA_Vendas.DSVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_itemVendaTableAdapter
            // 
            this.pc_itemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // pcProdutoBindingSource
            // 
            this.pcProdutoBindingSource.DataMember = "pc_Produto";
            this.pcProdutoBindingSource.DataSource = this.dSVendas;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.grpItemVenda);
            this.Controls.Add(this.dgvItemVenda);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(dataEntregaLabel);
            this.Controls.Add(this.dtpDataEntregaVenda);
            this.Controls.Add(dataVendaLabel);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(numVendaLabel);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(codCliLabel);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgvVendas);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            this.grpItemVenda.ResumeLayout(false);
            this.grpItemVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSVendas dSVendas;
        private System.Windows.Forms.BindingSource pc_vendasBindingSource;
        private DSVendasTableAdapters.pc_vendasTableAdapter pc_vendasTableAdapter;
        private DSVendasTableAdapters.pc_itemVendaTableAdapter pc_itemVendaTableAdapter;
        private DSVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.BindingSource pcclientesBindingSource;
        private DSVendasTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataEntregaVenda;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.BindingSource pc_itemVendaBindingSource;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnItemIncluir;
        private System.Windows.Forms.Button btnItemExcluir;
        private System.Windows.Forms.Button btnItemAlterar;
        private System.Windows.Forms.Button btnItemPesquisar;
        private System.Windows.Forms.Button btnItemGravar;
        private System.Windows.Forms.Button btnItemCancelar;
        private System.Windows.Forms.ComboBox cmbProduto;
        private DSVendasTableAdapters.pc_ProdutoTableAdapter pc_ProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtPrecounit;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grpItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource pcProdutoBindingSource;
        // private DSVendasTableAdapters.pc_itemVendaTableAdapter pc_itemVendaTableAdapter;
    }
}