using System;
using System.Windows.Forms;

namespace WFA_Vendas
{
    partial class FrmCadClientes
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label dataNascLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mksTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.mksUf = new System.Windows.Forms.MaskedTextBox();
            this.mksCep = new System.Windows.Forms.MaskedTextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pc_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVendas = new WFA_Vendas.DSVendas();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.pc_clientesTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_clientesTableAdapter();
            this.tableAdapterManager = new WFA_Vendas.DSVendasTableAdapters.TableAdapterManager();
            this.pc_vendasTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_vendasTableAdapter();
            this.fKpcvendaspcclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codCliLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            dataNascLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpcvendaspcclientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codCliLabel
            // 
            codCliLabel.AutoSize = true;
            codCliLabel.Location = new System.Drawing.Point(200, 22);
            codCliLabel.Name = "codCliLabel";
            codCliLabel.Size = new System.Drawing.Size(43, 13);
            codCliLabel.TabIndex = 1;
            codCliLabel.Text = "Codigo:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(200, 48);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(200, 74);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(200, 100);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(200, 126);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 9;
            bairroLabel.Text = "Bairro:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(200, 152);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(24, 13);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "UF:";
            // 
            // dataNascLabel
            // 
            dataNascLabel.AutoSize = true;
            dataNascLabel.Location = new System.Drawing.Point(200, 179);
            dataNascLabel.Name = "dataNascLabel";
            dataNascLabel.Size = new System.Drawing.Size(107, 13);
            dataNascLabel.TabIndex = 13;
            dataNascLabel.Text = "Data de Nascimento:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(200, 204);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(52, 13);
            ufLabel.TabIndex = 15;
            ufLabel.Text = "Telefone:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(200, 230);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 17;
            cepLabel.Text = "CEP:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(313, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(313, 71);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(313, 97);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(313, 123);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 5;
            // 
            // mksTelefone
            // 
            this.mksTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mksTelefone.Enabled = false;
            this.mksTelefone.Location = new System.Drawing.Point(313, 201);
            this.mksTelefone.Mask = "(99) 00000-0000";
            this.mksTelefone.Name = "mksTelefone";
            this.mksTelefone.Size = new System.Drawing.Size(88, 20);
            this.mksTelefone.TabIndex = 8;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNasc.Enabled = false;
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasc.Location = new System.Drawing.Point(313, 175);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(102, 20);
            this.dtpDataNasc.TabIndex = 7;
            // 
            // mksUf
            // 
            this.mksUf.Enabled = false;
            this.mksUf.Location = new System.Drawing.Point(313, 149);
            this.mksUf.Mask = ">LL";
            this.mksUf.Name = "mksUf";
            this.mksUf.Size = new System.Drawing.Size(22, 20);
            this.mksUf.TabIndex = 6;
            // 
            // mksCep
            // 
            this.mksCep.Enabled = false;
            this.mksCep.Location = new System.Drawing.Point(313, 227);
            this.mksCep.Mask = "00000-999";
            this.mksCep.Name = "mksCep";
            this.mksCep.Size = new System.Drawing.Size(59, 20);
            this.mksCep.TabIndex = 9;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvClientes.DataSource = this.pc_clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 267);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(957, 143);
            this.dgvClientes.TabIndex = 18;
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // pc_clientesBindingSource
            // 
            this.pc_clientesBindingSource.DataMember = "pc_clientes";
            this.pc_clientesBindingSource.DataSource = this.dSVendas;
            // 
            // dSVendas
            // 
            this.dSVendas.DataSetName = "DSVendas";
            this.dSVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(745, 26);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(745, 55);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(745, 86);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(745, 117);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(745, 146);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(745, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(745, 204);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCodCli
            // 
            this.txtCodCli.Enabled = false;
            this.txtCodCli.Location = new System.Drawing.Point(313, 19);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(114, 20);
            this.txtCodCli.TabIndex = 1;
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = this.pc_clientesTableAdapter;
            this.tableAdapterManager.pc_fornecedorTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFA_Vendas.DSVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_vendasTableAdapter
            // 
            this.pc_vendasTableAdapter.ClearBeforeFill = true;
            // 
            // fKpcvendaspcclientesBindingSource
            // 
            this.fKpcvendaspcclientesBindingSource.DataMember = "FK_pc_vendas_pc_clientes";
            this.fKpcvendaspcclientesBindingSource.DataSource = this.pc_clientesBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codCli";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "telefone";
            dataGridViewCellStyle1.Format = "(##)#####-####";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dataNasc";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "Dt.Nascimento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "uf";
            dataGridViewCellStyle3.Format = ">LL";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "UF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cep";
            dataGridViewCellStyle4.Format = "#####-###";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn9.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // FrmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 414);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(codCliLabel);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.mksTelefone);
            this.Controls.Add(dataNascLabel);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.mksUf);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.mksCep);
            this.Controls.Add(this.btnIncluir);
            this.Name = "FrmCadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpcvendaspcclientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DSVendas dSVendas;
        private System.Windows.Forms.BindingSource pc_clientesBindingSource;
        private DSVendasTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private DSVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mksTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.MaskedTextBox mksUf;
        private System.Windows.Forms.MaskedTextBox mksCep;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private BindingSource fKpcvendaspcclientesBindingSource;
        private DSVendasTableAdapters.pc_vendasTableAdapter pc_vendasTableAdapter;
        private TextBox txtCodCli;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

