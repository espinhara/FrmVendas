namespace WfaVendas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.tbrVendas = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJanelas = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsVendas = new System.Windows.Forms.ToolStrip();
            this.btnCadClientes = new System.Windows.Forms.ToolStripButton();
            this.btnCadVendas = new System.Windows.Forms.ToolStripButton();
            this.btnCadProdutos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatorios = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnRelClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.stbVendas = new System.Windows.Forms.StatusStrip();
            this.lblTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imlIcones = new System.Windows.Forms.ImageList(this.components);
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.tbrVendas.SuspendLayout();
            this.tlsVendas.SuspendLayout();
            this.stbVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbrVendas
            // 
            this.tbrVendas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuRelatorios,
            this.mnuJanelas,
            this.mnuAjuda});
            this.tbrVendas.Location = new System.Drawing.Point(0, 0);
            this.tbrVendas.MdiWindowListItem = this.mnuJanelas;
            this.tbrVendas.Name = "tbrVendas";
            this.tbrVendas.Size = new System.Drawing.Size(985, 24);
            this.tbrVendas.TabIndex = 1;
            this.tbrVendas.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuFornecedores,
            this.toolStripMenuItem3,
            this.mnuCadCompras,
            this.mnuCadProdutos,
            this.toolStripSeparator1,
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "&Arquivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem1.Text = "Cadastro de &Clientes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.mnuCadClientes_Click);
            // 
            // mnuFornecedores
            // 
            this.mnuFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("mnuFornecedores.Image")));
            this.mnuFornecedores.Name = "mnuFornecedores";
            this.mnuFornecedores.Size = new System.Drawing.Size(211, 22);
            this.mnuFornecedores.Text = "Cadastro de &Fornecedores";
            this.mnuFornecedores.Click += new System.EventHandler(this.mnuFornecedores_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem3.Text = "Controle de &Vendas";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // mnuCadCompras
            // 
            this.mnuCadCompras.Name = "mnuCadCompras";
            this.mnuCadCompras.Size = new System.Drawing.Size(211, 22);
            this.mnuCadCompras.Text = "Cadastro de Compra";
            this.mnuCadCompras.Click += new System.EventHandler(this.mnuCadCompra_Click);
            // 
            // mnuCadProdutos
            // 
            this.mnuCadProdutos.Name = "mnuCadProdutos";
            this.mnuCadProdutos.Size = new System.Drawing.Size(211, 22);
            this.mnuCadProdutos.Text = "Cadastro de &Produtos";
            this.mnuCadProdutos.Click += new System.EventHandler(this.mnuCadProdutos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(211, 22);
            this.mnuSair.Text = "Sai&r";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.mnuRelFornecedores,
            this.mnuRelVendas,
            this.mnuRelProdutos});
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatorios.Text = "&Relatórios";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem2.Text = "Relatório de &Clientes";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mnuRelFornecedores
            // 
            this.mnuRelFornecedores.Name = "mnuRelFornecedores";
            this.mnuRelFornecedores.Size = new System.Drawing.Size(211, 22);
            this.mnuRelFornecedores.Text = "Relatório de &Fornecedores";
            this.mnuRelFornecedores.Click += new System.EventHandler(this.MnuRelClientes_Click);
            // 
            // mnuRelVendas
            // 
            this.mnuRelVendas.Name = "mnuRelVendas";
            this.mnuRelVendas.Size = new System.Drawing.Size(211, 22);
            this.mnuRelVendas.Text = "Relatório de &Vendas";
            // 
            // mnuRelProdutos
            // 
            this.mnuRelProdutos.Name = "mnuRelProdutos";
            this.mnuRelProdutos.Size = new System.Drawing.Size(211, 22);
            this.mnuRelProdutos.Text = "Relatório de &Produtos";
            // 
            // mnuJanelas
            // 
            this.mnuJanelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.ladoALadoNaHorizontalToolStripMenuItem,
            this.ladoALadoNaVerticalToolStripMenuItem,
            this.toolStripSeparator2});
            this.mnuJanelas.Name = "mnuJanelas";
            this.mnuJanelas.Size = new System.Drawing.Size(56, 20);
            this.mnuJanelas.Text = "&Janelas";
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.cascataToolStripMenuItem.Text = "&Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // ladoALadoNaHorizontalToolStripMenuItem
            // 
            this.ladoALadoNaHorizontalToolStripMenuItem.Name = "ladoALadoNaHorizontalToolStripMenuItem";
            this.ladoALadoNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ladoALadoNaHorizontalToolStripMenuItem.Text = "Lado a lado na &Horizontal";
            this.ladoALadoNaHorizontalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoNaHorizontalToolStripMenuItem_Click);
            // 
            // ladoALadoNaVerticalToolStripMenuItem
            // 
            this.ladoALadoNaVerticalToolStripMenuItem.Name = "ladoALadoNaVerticalToolStripMenuItem";
            this.ladoALadoNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ladoALadoNaVerticalToolStripMenuItem.Text = "Lado a lado na &Vertical";
            this.ladoALadoNaVerticalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoNaVerticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnuAjuda.Text = "Aj&uda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(104, 22);
            this.mnuSobre.Text = "&Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // tlsVendas
            // 
            this.tlsVendas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadClientes,
            this.btnCadVendas,
            this.btnCadProdutos,
            this.toolStripSeparator3,
            this.btnRelatorios,
            this.toolStripSeparator4,
            this.btnSair});
            this.tlsVendas.Location = new System.Drawing.Point(0, 24);
            this.tlsVendas.Name = "tlsVendas";
            this.tlsVendas.Size = new System.Drawing.Size(985, 25);
            this.tlsVendas.TabIndex = 2;
            this.tlsVendas.Text = "toolStrip1";
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadClientes.Image")));
            this.btnCadClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(23, 22);
            this.btnCadClientes.Text = "toolStripButton1";
            this.btnCadClientes.ToolTipText = "Cadastro de Clientes";
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // btnCadVendas
            // 
            this.btnCadVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnCadVendas.Image")));
            this.btnCadVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadVendas.Name = "btnCadVendas";
            this.btnCadVendas.Size = new System.Drawing.Size(23, 22);
            this.btnCadVendas.Text = "toolStripButton2";
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProdutos.Image")));
            this.btnCadProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(23, 22);
            this.btnCadProdutos.Text = "toolStripButton3";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelClientes,
            this.btnRelVendas,
            this.btnRelProdutos});
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(29, 22);
            this.btnRelatorios.Text = "toolStripDropDownButton1";
            // 
            // btnRelClientes
            // 
            this.btnRelClientes.Name = "btnRelClientes";
            this.btnRelClientes.Size = new System.Drawing.Size(188, 22);
            this.btnRelClientes.Text = "Relatório de &Clientes";
            // 
            // btnRelVendas
            // 
            this.btnRelVendas.Name = "btnRelVendas";
            this.btnRelVendas.Size = new System.Drawing.Size(188, 22);
            this.btnRelVendas.Text = "Relatório de &Vendas";
            // 
            // btnRelProdutos
            // 
            this.btnRelProdutos.Name = "btnRelProdutos";
            this.btnRelProdutos.Size = new System.Drawing.Size(188, 22);
            this.btnRelProdutos.Text = "Relatório de &Produtos";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "toolStripButton4";
            // 
            // stbVendas
            // 
            this.stbVendas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTexto,
            this.lblHora,
            this.toolStripStatusLabel1});
            this.stbVendas.Location = new System.Drawing.Point(0, 476);
            this.stbVendas.Name = "stbVendas";
            this.stbVendas.Size = new System.Drawing.Size(985, 22);
            this.stbVendas.TabIndex = 3;
            this.stbVendas.Text = "statusStrip1";
            // 
            // lblTexto
            // 
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(702, 17);
            this.lblTexto.Spring = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = false;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(150, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // imlIcones
            // 
            this.imlIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcones.ImageStream")));
            this.imlIcones.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcones.Images.SetKeyName(0, "cliente.png");
            this.imlIcones.Images.SetKeyName(1, "venda.png");
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 498);
            this.Controls.Add(this.stbVendas);
            this.Controls.Add(this.tlsVendas);
            this.Controls.Add(this.tbrVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.tbrVendas;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.tbrVendas.ResumeLayout(false);
            this.tbrVendas.PerformLayout();
            this.tlsVendas.ResumeLayout(false);
            this.tlsVendas.PerformLayout();
            this.stbVendas.ResumeLayout(false);
            this.stbVendas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tbrVendas;
        private System.Windows.Forms.ToolStrip tlsVendas;
        private System.Windows.Forms.StatusStrip stbVendas;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuJanelas;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnuCadCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuCadProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuRelFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRelVendas;
        private System.Windows.Forms.ToolStripMenuItem mnuRelProdutos;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCadClientes;
        private System.Windows.Forms.ToolStripButton btnCadVendas;
        private System.Windows.Forms.ToolStripButton btnCadProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton btnRelatorios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnRelClientes;
        private System.Windows.Forms.ToolStripMenuItem btnRelVendas;
        private System.Windows.Forms.ToolStripMenuItem btnRelProdutos;
        private System.Windows.Forms.ToolStripStatusLabel lblTexto;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        public System.Windows.Forms.ImageList imlIcones;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}