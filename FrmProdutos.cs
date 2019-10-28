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
    public partial class FrmProdutos : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmProdutos()
        {
            InitializeComponent();
        }
        private void habilitaCampos(bool hab)
        {
            txtDescricao.Enabled = hab;
            txtCodPro.Enabled = hab;
            nudQuantidade.Enabled = hab;
            txtPreco.Enabled = hab;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSVendas.pc_Produto' table. You can move, or remove it, as needed.
            this.pc_ProdutoTableAdapter.Fill(this.dSVendas.pc_Produto);
            habilitaCampos(false);
            habilitaBotoes(true);

        }

        private void habilitaBotoes(bool hab)
        {
            btnAlterar.Enabled = hab;
            btnIncluir.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;

        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtCodPro.Hide();
            incluir = true;
            limpaCampos();
            habilitaBotoes(false);
            habilitaCampos(true);
            txtDescricao.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvProduto.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir a venda selecionada", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_ProdutoTableAdapter.Delete(Convert.ToInt32(
                            dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString()));
                        pc_ProdutoTableAdapter.Delete(Convert.ToInt32(
                            dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString()));
                        FrmProdutos_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um item primeiro!",
                        "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                    "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (dgvProduto.SelectedRows.Count > 0)
            {

                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtCodPro.Enabled = false;
                txtDescricao.Focus();
                txtCodPro.Text = dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString();
                txtDescricao.Text = dgvProduto[1, dgvProduto.CurrentRow.Index].Value.ToString();
                nudQuantidade.Text = dgvProduto[2, dgvProduto.CurrentRow.Index].Value.ToString();
                txtPreco.Text = dgvProduto[3, dgvProduto.CurrentRow.Index].Value.ToString();
               

            }
            else
            {
                MessageBox.Show(null, "Selecione um PRODUTO primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Enabled == false)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnCancelar.Enabled = false;
                btnGravar.Enabled = false;
                MessageBox.Show(null, "Digite a descrição do produto desejado ou " +
                    "\nparte dele.", "Pesquisa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                this.pc_ProdutoTableAdapter.FillBy(this.dSVendas.pc_Produto,
                    "%" + txtDescricao.Text + "%");
                btnCancelar_Click(null, null);
            }
        }
        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox))
                {
                    ((TextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                    if (((MaskedTextBox)item).Name == "txtPreco")
                    {
                        ((MaskedTextBox)item).Text = "0,00";

                    }
                }
                if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            incluir = false;
            alterar = false;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (incluir)
                {
                    pc_ProdutoTableAdapter.Insert(txtDescricao.Text,Convert.ToInt32(nudQuantidade.Text)
                        ,Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtCodPro.Text));
                    MessageBox.Show("Incluindo com sucesso!", "Incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_ProdutoTableAdapter.Update(txtDescricao.Text
                        , Convert.ToInt32(nudQuantidade.Text), Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtCodPro.Text));

                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmProdutos_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
