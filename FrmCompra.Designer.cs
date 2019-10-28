namespace WFA_Vendas
{
    partial class FrmCompra
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
            System.Windows.Forms.Label numCompraLabel;
            System.Windows.Forms.Label cod_forLabel;
            System.Windows.Forms.Label dataCompraLabel;
            System.Windows.Forms.Label dataEntregaLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precounitLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label codProLabel;
            this.dSVendas = new WFA_Vendas.DSVendas();
            this.pc_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_compraTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_compraTableAdapter();
            this.tableAdapterManager = new WFA_Vendas.DSVendasTableAdapters.TableAdapterManager();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.grpItemVenda = new System.Windows.Forms.GroupBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.pcProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrecounit = new System.Windows.Forms.TextBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.btnItemCancelar = new System.Windows.Forms.Button();
            this.btnItemIncluir = new System.Windows.Forms.Button();
            this.btnItemExcluir = new System.Windows.Forms.Button();
            this.btnItemAlterar = new System.Windows.Forms.Button();
            this.btnItemPesquisar = new System.Windows.Forms.Button();
            this.btnItemGravar = new System.Windows.Forms.Button();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.pcfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvItemCompra = new System.Windows.Forms.DataGridView();
            this.pcitemCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_fornecedorTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_fornecedorTableAdapter();
            this.pc_ProdutoTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_ProdutoTableAdapter();
            this.pc_itemCompraTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_itemCompraTableAdapter();
            this.codProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precounitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numCompraLabel = new System.Windows.Forms.Label();
            cod_forLabel = new System.Windows.Forms.Label();
            dataCompraLabel = new System.Windows.Forms.Label();
            dataEntregaLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            codProLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.grpItemVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcfornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcitemCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numCompraLabel
            // 
            numCompraLabel.AutoSize = true;
            numCompraLabel.Location = new System.Drawing.Point(114, 67);
            numCompraLabel.Name = "numCompraLabel";
            numCompraLabel.Size = new System.Drawing.Size(46, 13);
            numCompraLabel.TabIndex = 1;
            numCompraLabel.Text = "Compra:";
            // 
            // cod_forLabel
            // 
            cod_forLabel.AutoSize = true;
            cod_forLabel.Location = new System.Drawing.Point(361, 67);
            cod_forLabel.Name = "cod_forLabel";
            cod_forLabel.Size = new System.Drawing.Size(64, 13);
            cod_forLabel.TabIndex = 3;
            cod_forLabel.Text = "Fornecedor:";
            // 
            // dataCompraLabel
            // 
            dataCompraLabel.AutoSize = true;
            dataCompraLabel.Location = new System.Drawing.Point(114, 107);
            dataCompraLabel.Name = "dataCompraLabel";
            dataCompraLabel.Size = new System.Drawing.Size(70, 13);
            dataCompraLabel.TabIndex = 5;
            dataCompraLabel.Text = "data Compra:";
            // 
            // dataEntregaLabel
            // 
            dataEntregaLabel.AutoSize = true;
            dataEntregaLabel.Location = new System.Drawing.Point(359, 104);
            dataEntregaLabel.Name = "dataEntregaLabel";
            dataEntregaLabel.Size = new System.Drawing.Size(71, 13);
            dataEntregaLabel.TabIndex = 7;
            dataEntregaLabel.Text = "data Entrega:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(153, 155);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(29, 13);
            obsLabel.TabIndex = 9;
            obsLabel.Text = "Obs:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(186, 66);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 40;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(317, 68);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(77, 13);
            precounitLabel.TabIndex = 42;
            precounitLabel.Text = "Preço Unitário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(684, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 42;
            label1.Text = "Total:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(510, 68);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 44;
            subTotalLabel.Text = "Sub Total:";
            // 
            // codProLabel
            // 
            codProLabel.AutoSize = true;
            codProLabel.Location = new System.Drawing.Point(6, 64);
            codProLabel.Name = "codProLabel";
            codProLabel.Size = new System.Drawing.Size(47, 13);
            codProLabel.TabIndex = 45;
            codProLabel.Text = "Produto:";
            // 
            // dSVendas
            // 
            this.dSVendas.DataSetName = "DSVendas";
            this.dSVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_compraBindingSource
            // 
            this.pc_compraBindingSource.DataMember = "pc_compra";
            this.pc_compraBindingSource.DataSource = this.dSVendas;
            // 
            // pc_compraTableAdapter
            // 
            this.pc_compraTableAdapter.ClearBeforeFill = true;
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
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AutoGenerateColumns = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvCompra.DataSource = this.pc_compraBindingSource;
            this.dgvCompra.Location = new System.Drawing.Point(191, 224);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(635, 122);
            this.dgvCompra.TabIndex = 14;
            this.dgvCompra.SelectionChanged += new System.EventHandler(this.DgvCompra_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numCompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Compra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cod_for";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataCompra";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data da Compra";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn5.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // txtCompra
            // 
            this.txtCompra.Enabled = false;
            this.txtCompra.Location = new System.Drawing.Point(191, 64);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(105, 20);
            this.txtCompra.TabIndex = 8;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCompra.Enabled = false;
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCompra.Location = new System.Drawing.Point(191, 103);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(105, 20);
            this.dtpDataCompra.TabIndex = 9;
            this.dtpDataCompra.Value = new System.DateTime(2019, 8, 26, 0, 0, 0, 0);
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntrega.Enabled = false;
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntrega.Location = new System.Drawing.Point(436, 100);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(102, 20);
            this.dtpDataEntrega.TabIndex = 11;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(191, 152);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(448, 48);
            this.txtObs.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(719, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(628, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(537, 11);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(436, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(341, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(245, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(146, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(751, 177);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 13;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // grpItemVenda
            // 
            this.grpItemVenda.Controls.Add(codProLabel);
            this.grpItemVenda.Controls.Add(this.cmbProduto);
            this.grpItemVenda.Controls.Add(subTotalLabel);
            this.grpItemVenda.Controls.Add(this.txtSubTotal);
            this.grpItemVenda.Controls.Add(label1);
            this.grpItemVenda.Controls.Add(precounitLabel);
            this.grpItemVenda.Controls.Add(quantidadeLabel);
            this.grpItemVenda.Controls.Add(this.txtTotal);
            this.grpItemVenda.Controls.Add(this.txtPrecounit);
            this.grpItemVenda.Controls.Add(this.nudQtd);
            this.grpItemVenda.Controls.Add(this.btnItemCancelar);
            this.grpItemVenda.Controls.Add(this.btnItemIncluir);
            this.grpItemVenda.Controls.Add(this.btnItemExcluir);
            this.grpItemVenda.Controls.Add(this.btnItemAlterar);
            this.grpItemVenda.Controls.Add(this.btnItemPesquisar);
            this.grpItemVenda.Controls.Add(this.btnItemGravar);
            this.grpItemVenda.Location = new System.Drawing.Point(84, 403);
            this.grpItemVenda.Name = "grpItemVenda";
            this.grpItemVenda.Size = new System.Drawing.Size(833, 115);
            this.grpItemVenda.TabIndex = 36;
            this.grpItemVenda.TabStop = false;
            this.grpItemVenda.Text = "Itens da Compra";
            // 
            // cmbProduto
            // 
            this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduto.DataSource = this.pcProdutoBindingSource;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(59, 64);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 21;
            this.cmbProduto.ValueMember = "codPro";
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // pcProdutoBindingSource
            // 
            this.pcProdutoBindingSource.DataMember = "pc_Produto";
            this.pcProdutoBindingSource.DataSource = this.dSVendas;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(572, 65);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 24;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(724, 66);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // txtPrecounit
            // 
            this.txtPrecounit.Enabled = false;
            this.txtPrecounit.Location = new System.Drawing.Point(400, 65);
            this.txtPrecounit.Name = "txtPrecounit";
            this.txtPrecounit.Size = new System.Drawing.Size(89, 20);
            this.txtPrecounit.TabIndex = 23;
            // 
            // nudQtd
            // 
            this.nudQtd.Enabled = false;
            this.nudQtd.Location = new System.Drawing.Point(257, 64);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(53, 20);
            this.nudQtd.TabIndex = 22;
            // 
            // btnItemCancelar
            // 
            this.btnItemCancelar.Enabled = false;
            this.btnItemCancelar.Location = new System.Drawing.Point(618, 19);
            this.btnItemCancelar.Name = "btnItemCancelar";
            this.btnItemCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnItemCancelar.TabIndex = 20;
            this.btnItemCancelar.Text = "Cancelar";
            this.btnItemCancelar.UseVisualStyleBackColor = true;
            this.btnItemCancelar.Click += new System.EventHandler(this.BtnItemCancelar_Click);
            // 
            // btnItemIncluir
            // 
            this.btnItemIncluir.Location = new System.Drawing.Point(136, 19);
            this.btnItemIncluir.Name = "btnItemIncluir";
            this.btnItemIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnItemIncluir.TabIndex = 15;
            this.btnItemIncluir.Text = "Incluir";
            this.btnItemIncluir.UseVisualStyleBackColor = true;
            this.btnItemIncluir.Click += new System.EventHandler(this.BtnItemIncluir_Click);
            // 
            // btnItemExcluir
            // 
            this.btnItemExcluir.Location = new System.Drawing.Point(235, 19);
            this.btnItemExcluir.Name = "btnItemExcluir";
            this.btnItemExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnItemExcluir.TabIndex = 16;
            this.btnItemExcluir.Text = "Excluir";
            this.btnItemExcluir.UseVisualStyleBackColor = true;
            this.btnItemExcluir.Click += new System.EventHandler(this.BtnItemExcluir_Click);
            // 
            // btnItemAlterar
            // 
            this.btnItemAlterar.Location = new System.Drawing.Point(331, 19);
            this.btnItemAlterar.Name = "btnItemAlterar";
            this.btnItemAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnItemAlterar.TabIndex = 17;
            this.btnItemAlterar.Text = "Alterar";
            this.btnItemAlterar.UseVisualStyleBackColor = true;
            this.btnItemAlterar.Click += new System.EventHandler(this.BtnItemAlterar_Click);
            // 
            // btnItemPesquisar
            // 
            this.btnItemPesquisar.Location = new System.Drawing.Point(426, 19);
            this.btnItemPesquisar.Name = "btnItemPesquisar";
            this.btnItemPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnItemPesquisar.TabIndex = 18;
            this.btnItemPesquisar.Text = "Pesquisar";
            this.btnItemPesquisar.UseVisualStyleBackColor = true;
            this.btnItemPesquisar.Click += new System.EventHandler(this.BtnItemPesquisar_Click);
            // 
            // btnItemGravar
            // 
            this.btnItemGravar.Enabled = false;
            this.btnItemGravar.Location = new System.Drawing.Point(527, 18);
            this.btnItemGravar.Name = "btnItemGravar";
            this.btnItemGravar.Size = new System.Drawing.Size(75, 23);
            this.btnItemGravar.TabIndex = 19;
            this.btnItemGravar.Text = "Gravar";
            this.btnItemGravar.UseVisualStyleBackColor = true;
            this.btnItemGravar.Click += new System.EventHandler(this.BtnItemGravar_Click);
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFornecedor.DataSource = this.pcfornecedorBindingSource;
            this.cmbFornecedor.DisplayMember = "fantasia";
            this.cmbFornecedor.Enabled = false;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(436, 63);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(250, 21);
            this.cmbFornecedor.TabIndex = 10;
            this.cmbFornecedor.ValueMember = "cod_for";
            // 
            // pcfornecedorBindingSource
            // 
            this.pcfornecedorBindingSource.DataMember = "pc_fornecedor";
            this.pcfornecedorBindingSource.DataSource = this.dSVendas;
            // 
            // dgvItemCompra
            // 
            this.dgvItemCompra.AllowUserToAddRows = false;
            this.dgvItemCompra.AllowUserToDeleteRows = false;
            this.dgvItemCompra.AllowUserToOrderColumns = true;
            this.dgvItemCompra.AutoGenerateColumns = false;
            this.dgvItemCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precounitDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.dgvItemCompra.DataSource = this.pcitemCompraBindingSource;
            this.dgvItemCompra.Location = new System.Drawing.Point(191, 537);
            this.dgvItemCompra.Name = "dgvItemCompra";
            this.dgvItemCompra.ReadOnly = true;
            this.dgvItemCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemCompra.Size = new System.Drawing.Size(646, 208);
            this.dgvItemCompra.TabIndex = 26;
            // 
            // pcitemCompraBindingSource
            // 
            this.pcitemCompraBindingSource.DataMember = "pc_itemCompra";
            this.pcitemCompraBindingSource.DataSource = this.dSVendas;
            // 
            // pc_fornecedorTableAdapter
            // 
            this.pc_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // pc_ProdutoTableAdapter
            // 
            this.pc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // pc_itemCompraTableAdapter
            // 
            this.pc_itemCompraTableAdapter.ClearBeforeFill = true;
            // 
            // codProDataGridViewTextBoxColumn
            // 
            this.codProDataGridViewTextBoxColumn.DataPropertyName = "codPro";
            this.codProDataGridViewTextBoxColumn.HeaderText = "codPro";
            this.codProDataGridViewTextBoxColumn.Name = "codProDataGridViewTextBoxColumn";
            this.codProDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precounitDataGridViewTextBoxColumn
            // 
            this.precounitDataGridViewTextBoxColumn.DataPropertyName = "precounit";
            this.precounitDataGridViewTextBoxColumn.HeaderText = "precounit";
            this.precounitDataGridViewTextBoxColumn.Name = "precounitDataGridViewTextBoxColumn";
            this.precounitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(998, 749);
            this.Controls.Add(this.dgvItemCompra);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.grpItemVenda);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(numCompraLabel);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(cod_forLabel);
            this.Controls.Add(dataCompraLabel);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(dataEntregaLabel);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.dgvCompra);
            this.Name = "FrmCompra";
            this.Text = "Cadastro de Compra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.grpItemVenda.ResumeLayout(false);
            this.grpItemVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcfornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcitemCompraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSVendas dSVendas;
        private System.Windows.Forms.BindingSource pc_compraBindingSource;
        private DSVendasTableAdapters.pc_compraTableAdapter pc_compraTableAdapter;
        private DSVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.GroupBox grpItemVenda;
        private System.Windows.Forms.TextBox txtPrecounit;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Button btnItemCancelar;
        private System.Windows.Forms.Button btnItemIncluir;
        private System.Windows.Forms.Button btnItemExcluir;
        private System.Windows.Forms.Button btnItemAlterar;
        private System.Windows.Forms.Button btnItemPesquisar;
        private System.Windows.Forms.Button btnItemGravar;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dgvItemCompra;
        private System.Windows.Forms.BindingSource pcfornecedorBindingSource;
        private DSVendasTableAdapters.pc_fornecedorTableAdapter pc_fornecedorTableAdapter;
        private System.Windows.Forms.BindingSource pcProdutoBindingSource;
        private DSVendasTableAdapters.pc_ProdutoTableAdapter pc_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource pcitemCompraBindingSource;
        private DSVendasTableAdapters.pc_itemCompraTableAdapter pc_itemCompraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precounitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
    }
}