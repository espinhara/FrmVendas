namespace WFA_Vendas
{
    partial class FormRptClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DSVendas = new WFA_Vendas.DSVendas();
            this.pc_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_clientesTableAdapter = new WFA_Vendas.DSVendasTableAdapters.pc_clientesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DSVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DSVendas
            // 
            this.DSVendas.DataSetName = "DSVendas";
            this.DSVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_clientesBindingSource
            // 
            this.pc_clientesBindingSource.DataMember = "pc_clientes";
            this.pc_clientesBindingSource.DataSource = this.DSVendas;
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pc_clientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFA_Vendas.RptClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(701, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormRptClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 414);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRptClientes";
            this.Text = "FormRptClientes";
            this.Load += new System.EventHandler(this.FormRptClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pc_clientesBindingSource;
        private DSVendas DSVendas;
        private DSVendasTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}