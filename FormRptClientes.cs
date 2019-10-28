using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Vendas
{
    public partial class FormRptClientes : Form
    {
        public FormRptClientes()
        {
            InitializeComponent();
        }

        private void FormRptClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSVendas.pc_clientes' table. You can move, or remove it, as needed.
            this.pc_clientesTableAdapter.Fill(this.DSVendas.pc_clientes);

            this.reportViewer1.RefreshReport();
 
            this.reportViewer1.RefreshReport();
        }
    }
}
