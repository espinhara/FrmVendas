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
    public partial class FrmCompra : Form
    {
        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool incluirItem = false;
        double precoTemp = 0;

        public FrmCompra()
        {
            InitializeComponent();
        }
        private void pc_compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSVendas);

        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSVendas.pc_itemVenda' table. You can move, or remove it, as needed.
            this.pc_ProdutoTableAdapter.Fill(this.dSVendas.pc_Produto);
            // TODO: This line of code loads data into the 'dSVendas.pc_fornecedor' table. You can move, or remove it, as needed.
            this.pc_fornecedorTableAdapter.Fill(this.dSVendas.pc_fornecedor);
            // TODO: This line of code loads data into the 'dSVendas.pc_compra' table. You can move, or remove it, as needed.
            this.pc_compraTableAdapter.Fill(this.dSVendas.pc_compra);
            // TODO: This line of code loads data into the 'dSVendas.pc_itemCompra' table. You can move, or remove it, as needed.
            this.pc_itemCompraTableAdapter.Fill(this.dSVendas.pc_itemCompra);
        }

        private void habilitaCampos(bool hab)
        {
            txtCompra.Enabled = hab;
            cmbFornecedor.Enabled = hab;
            dtpDataCompra.Enabled = hab;
            dtpDataEntrega.Enabled = hab;
            txtObs.Enabled = hab;
        }
        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQtd.Enabled = hab;
            
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
        private void habilitaBotoesItem(bool hab)
        {
            btnItemAlterar.Enabled = hab;
            btnItemIncluir.Enabled = hab;
            btnItemExcluir.Enabled = hab;
            btnItemPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnItemGravar.Enabled = !hab;
            btnItemCancelar.Enabled = !hab;
        }
        private void limpaCampos(Control local)
        {
            foreach (Control item in local.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    if (((TextBox)item).Name == "txtPrecounit"
                        || ((TextBox)item).Name == "txtSubTotal"
                        || ((TextBox)item).Name == "txtTotal")
                    {
                        ((TextBox)item).Text = "R$ 0,00";
                    }
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
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

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaBotoes(false);
            habilitaCampos(true);
            txtCompra.Hide();
            cmbFornecedor.Focus();
        }

        private void BtnItemIncluir_Click(object sender, EventArgs e)
        {
            incluirItem = true;
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            //this.pc_ProdutoTableAdapter.Fill(this.dSVendas.pc_Produto);
            cmbProduto_SelectedIndexChanged(null, null);
            cmbProduto.Focus();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = pc_ProdutoTableAdapter.GetDataByDescricao(cmbProduto.Text);
            precoTemp = 0;
            foreach (DataRow row in produto.Rows)
            {
                precoTemp = Convert.ToDouble(row["precounit"].ToString());
            }
            nudQtd.Value = 1;
            txtPrecounit.Text = precoTemp.ToString("R$ #,###,##0.00");
            txtSubTotal.Text = precoTemp.ToString("R$ #,###,##0.00");
        }

        private void BtnItemExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemCompra.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o item selecionado?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button2) ==
                          System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemCompraTableAdapter.DeleteQuery(
                            Convert.ToInt32(dgvItemCompra[0, dgvItemCompra.CurrentRow.Index].Value.ToString()),
                            Convert.ToInt32(dgvItemCompra[0, dgvItemCompra.CurrentRow.Index].Value.ToString())
                            );
                        DgvCompra_SelectionChanged(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um item primeiro!",
                        "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                    "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DgvCompra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCompra.RowCount > 0)
                {
                    this.pc_itemCompraTableAdapter.FillByNumCompra(dSVendas.pc_itemCompra,
                        Convert.ToInt32(dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()));
                    if (dgvCompra.RowCount > 0)
                    {
                        double total = (double)pc_itemCompraTableAdapter.TotalCompra(
                            Convert.ToInt32(dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()));
                        txtTotal.Text = total.ToString("R$ #,###,##0.00");
                    }
                    else
                    {
                        txtTotal.Text = "R$ 0,00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                    "Erro ao acessar Itens da Compra:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCompra.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir a compra selecionada", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemCompraTableAdapter.DeleteTodos(Convert.ToInt32(
                            dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()));
                        pc_compraTableAdapter.DeleteQuery(Convert.ToInt32(
                            dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()));
                        FrmCompra_Load(null, null);
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                editar = true;
                habilitaBotoes(false);
                txtCompra.Enabled = false;
                txtCompra.Text =
                    dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString();
                cmbFornecedor.SelectedValue = Convert.ToUInt32(
                    dgvCompra[1, dgvCompra.CurrentRow.Index].Value.ToString());
                dtpDataCompra.Value = Convert.ToDateTime(
                    dgvCompra[3, dgvCompra.CurrentRow.Index].Value.ToString());
                dtpDataEntrega.Value = Convert.ToDateTime(
                    dgvCompra[4, dgvCompra.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvCompra[5, dgvCompra.CurrentRow.Index].Value.ToString();
                cmbFornecedor.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione uma compra primeiro!", "Erro;",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbFornecedor.Enabled == false)
            {
                cmbFornecedor.Enabled = true;
                cmbFornecedor.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do cliente desejado ou " +
                  "\n parte dele.", "Pesquisa", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            else
            {
                pc_compraTableAdapter.FillByRazao(this.dSVendas.pc_compra,
                    "%" + cmbFornecedor.Text + "%");
                BtnCancelar_Click(null, null);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(this);
            limpaCampos(grpItemVenda);
            habilitaCampos(false);
            habilitaBotoes(true);
            editar = false;
            incluir = false;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {

                if (incluir)
                {
                    pc_compraTableAdapter.InsertQuery(
                        (Int32)cmbFornecedor.SelectedValue, dtpDataCompra.Value,
                        dtpDataEntrega.Value, txtObs.Text);
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editar)
                {
                    pc_compraTableAdapter.UpdateQuery((Int32)cmbFornecedor.SelectedValue, dtpDataCompra.Value,
                        dtpDataEntrega.Value, txtObs.Text, Convert.ToInt32(txtCompra.Text));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                BtnCancelar_Click(null, null);
                FrmCompra_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: " + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnItemPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemCompra.RowCount > 0)
                {
                    if (cmbProduto.Enabled == false)
                    {
                        cmbProduto.Enabled = true;
                        cmbProduto.Focus();
                        habilitaBotoesItem(false);
                        btnItemPesquisar.Enabled = true;
                        btnItemGravar.Enabled = false;
                        btnItemCancelar.Enabled = false;
                        MessageBox.Show(null, "Digite o nome do item desejado ou" +
                            "\n parte dele.", "Pesquisa", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        pc_itemCompraTableAdapter.FillByDescricao(this.dSVendas.pc_itemCompra,                           
                                "%" + cmbProduto.Text + "%");
                        BtnItemCancelar_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Cadastre o item primeiro!",
                        "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                    "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnItemCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(grpItemVenda);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
            editarItem = false;
            incluirItem = false;
        }

        private void BtnItemGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluirItem)
                {
                    pc_itemCompraTableAdapter.InsertQuery(Convert.ToInt32(          
                         dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()),
                        (Int32)cmbProduto.SelectedValue, (Int32)nudQtd.Value, precoTemp
                        );
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editarItem)
                {
                    //TODO arrumar
                    pc_itemCompraTableAdapter.UpdateQuery(
                        (Int32)cmbProduto.SelectedValue,
                        (Int32)nudQtd.Value,
                        
                        Convert.ToInt32(
                            dgvItemCompra[0, dgvItemCompra.CurrentRow.Index].Value.ToString()),
                        Convert.ToInt32(
                           dgvItemCompra[0, dgvItemCompra.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DgvCompra_SelectionChanged(null, null);
                BtnItemCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                                   "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            FrmCompra_Load(null, null);
        }

        private void BtnItemAlterar_Click(object sender, EventArgs e)
        {
            if (dgvItemCompra.SelectedRows.Count > 0)
            {
                editarItem = true;
                habilitaBotoesItem(false);
                habilitaCamposItem(true);
                cmbProduto.Text =
                    dgvItemCompra[1, dgvItemCompra.CurrentRow.Index].Value.ToString();
                cmbProduto_SelectedIndexChanged(null, null);
                nudQtd.Value = Convert.ToInt32(
                    dgvItemCompra[2, dgvItemCompra.CurrentRow.Index].Value.ToString());
                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um item primeiro!",
                    "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
