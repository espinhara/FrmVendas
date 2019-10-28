using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Vendas;

namespace WfaVendas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)
                ==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoALadoNaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ladoALadoNaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            mnuCadClientes_Click(null, null);
        }

        private void mnuCadVendas_Click(object sender, EventArgs e)
        {

        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }

        private void mnuCadProdutos_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmProdutos)
                {
                    item.Focus();
                    return;
                }
            }

            FrmProdutos frm = new FrmProdutos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnuRelClientes_Click(object sender, EventArgs e)
        {

        }

        private void mnuFornecedores_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is WFA_Vendas.FrmFornecedor)
                {
                    item.Focus();
                    return;
                }
            }


            FrmFornecedor frm  = new FrmFornecedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuCadClientes_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is WFA_Vendas.FrmCadClientes)
                {
                    item.Focus();
                    return;
                }
            }


            FrmCadClientes frmCadClientes = new FrmCadClientes();
            frmCadClientes.MdiParent = this;
            frmCadClientes.Show();
        }

        private void mnuCadCompra_Click(object sender, EventArgs e)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item is WFA_Vendas.FrmCompra)
                {
                    item.Focus();
                    return;
                }
            }
            FrmCompra frmCompra= new FrmCompra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if(item is FormRptClientes)
                {
                    item.Focus();
                    return;
                }
            }
            FormRptClientes rtpCli = new WFA_Vendas.FormRptClientes();
            rtpCli.MdiParent = this;
            rtpCli.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmVendas)
                {
                    item.Focus();
                    return;
                }
            }
            FrmVendas F = new WFA_Vendas.FrmVendas();
            F.MdiParent = this;
            F.Show();
        }
    }
}