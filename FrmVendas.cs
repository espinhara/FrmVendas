using System;
using System.Data;
using System.Windows.Forms;
using WFA_Vendas.DSVendasTableAdapters;

namespace WFA_Vendas
{
    public partial class FrmVendas : Form
    {
        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool incluirItem = false;
        double precoTemp = 0;
       
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void pc_vendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSVendas);

        }

        private void pc_vendasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSVendas);

        }

        private void pc_vendasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSVendas.pc_Produto' table. You can move, or remove it, as needed.
            this.pc_vendasTableAdapter.Fill(dSVendas.pc_vendas);
            // TODO: This line of code loads data into the 'dSVendas.pc_itemVenda' table. You can move, or remove it, as needed.
            //this.pc_itemVendaTableAdapter.Fill(this.dSVendas.pc_itemVenda);
            // TODO: This line of code loads data into the 'dSVendas.pc_clientes' table. You can move, or remove it, as needed.
            this.pc_clientesTableAdapter.Fill(this.dSVendas.pc_clientes);
            this.pc_ProdutoTableAdapter.Fill(this.dSVendas.pc_Produto);
            if (dgvVendas.Rows.Count > 0)
            {
                dgvVendas.Rows[0].Selected = true;
            }
        }

        private void habilitaCampos(bool hab)
        {
            txtVenda.Enabled = hab;
            cmbCliente.Enabled = hab;
            dtpDataVenda.Enabled = hab;
            dtpDataEntregaVenda.Enabled = hab;
            txtObs.Enabled = hab;
        }
        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }
        private void habilitaBotoes(bool hab)
        {
            btnAlterar.Enabled = hab;
            btnIncluir.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled =!hab;
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
                    if (((TextBox)item).Name == "txtPrecoUnit"
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //focus cliente
            incluir = true;
            habilitaBotoes(false);
            habilitaCampos(true);
            txtVenda.Hide();
            cmbCliente.Focus();
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.RowCount > 0)
                {
                    this.pc_itemVendaTableAdapter.FillByNumVenda(dSVendas.pc_itemVenda,
                        Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                    if (dgvVendas.RowCount > 0)
                    {
                        double total = (double)pc_itemVendaTableAdapter.TotalVenda(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
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
                    "Erro ao acessar Itens da Venda:", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir a venda selecionada","Atenção",
                        MessageBoxButtons.YesNo,  MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2)== System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemVendaTableAdapter.DeleteTodos(Convert.ToInt32(
                            dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        pc_vendasTableAdapter.DeleteQuery(Convert.ToInt32(
                            dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        FrmVendas_Load(null, null);
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (incluir)
                {
                    pc_vendasTableAdapter.InsertQuery(
                        (Int32)cmbCliente.SelectedValue, dtpDataVenda.Value.Date,
                        dtpDataEntregaVenda.Value.Date, txtObs.Text);
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editar)
                {
                    pc_vendasTableAdapter.UpdateQuery((Int32)cmbCliente.SelectedValue, dtpDataVenda.Value.Date,
                        dtpDataEntregaVenda.Value.Date, txtObs.Text, Convert.ToInt32(txtVenda.Text));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnCancelar_Click(null, null);
                FrmVendas_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: " + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(this);
            limpaCampos(grpItemVenda);
            habilitaCampos(false);
            habilitaBotoes(true);
            editar = false;
            incluir = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.SelectedRows.Count >0 )
            {
                editar = true;
                habilitaBotoes(false);
                txtVenda.Enabled = false;
                txtVenda.Text =
                    dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToUInt32(
                    dgvVendas[1, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataVenda.Value = Convert.ToDateTime(
                    dgvVendas[3
                    , dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataEntregaVenda.Value = Convert.ToDateTime(
                    dgvVendas[4, dgvVendas.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvVendas[2, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione uma venda primeiro!", "Erro;",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.Enabled == false)
            {
                cmbCliente.Enabled = true;
                cmbCliente.Focus();
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
                pc_vendasTableAdapter.FillByNome(this.dSVendas.pc_vendas,
                    "%" + cmbCliente.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnItemIncluir_Click(object sender, EventArgs e)
        {
            incluirItem = true;
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            //this.pc_ProdutoTableAdapter.Fill(this.dSVendas.pc_Produto);
            cmbProduto_SelectedIndexChanged(null,null);
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
            nudQuantidade.Value = 1;
            txtPrecounit.Text = precoTemp.ToString("R$ #,###,##0.00");
            txtSubTotal.Text = precoTemp.ToString("R$ #,###,##0.00");
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (Int32)nudQuantidade.Value * precoTemp;
            txtSubTotal.Text = subTotal.ToString("R$ #,###,##0.00");
        }

        private void btnItemExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemVenda.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null,"Deseja mesmo excluir o item selecionado?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button2)==
                          System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemVendaTableAdapter.DeleteQuery(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                            Convert.ToInt32(dgvItemVenda[0, dgvItemVenda.CurrentRow.Index].Value.ToString())
                            );
                        dgvVendas_SelectionChanged(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um item primeiro!",
                        "Erro ao excluir:",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                    "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnItemAlterar_Click(object sender, EventArgs e)
        {
            if (dgvItemVenda.SelectedRows.Count > 0)
            {
                editarItem = true;
                habilitaBotoesItem(false);
                habilitaCamposItem(true);
                cmbProduto.Text =
                    dgvItemVenda[1, dgvItemVenda.CurrentRow.Index].Value.ToString();
                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(
                    dgvItemVenda[2, dgvItemVenda.CurrentRow.Index].Value.ToString());
                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um item primeiro!",
                    "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnItemPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemVenda.RowCount > 0)
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
                        pc_itemVendaTableAdapter.FillByDescricao(this.dSVendas.pc_itemVenda,
                            Convert.ToInt32(
                                dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                                "%" + cmbProduto.Text + "%");
                        btnItemCancelar_Click(null, null);
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

        private void btnItemCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(grpItemVenda);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
            editarItem = false;
            incluirItem = false;
        }

        private void btnItemGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluirItem)
                {
                    pc_itemVendaTableAdapter.InsertQuery(Convert.ToInt32(
                        dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                        (Int32)cmbProduto.SelectedValue, (Int32)nudQuantidade.Value,
                        precoTemp);
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editarItem)
                {
                    pc_itemVendaTableAdapter.UpdateQuery(
                        (Int32)cmbProduto.SelectedValue,
                        (Int32)nudQuantidade.Value,               
                        Convert.ToInt32(
                            dgvVendas[0, dgvItemVenda.CurrentRow.Index].Value.ToString()),
                        Convert.ToInt32(
                            dgvItemVenda[0, dgvItemVenda.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvVendas_SelectionChanged(null, null);
                btnItemCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                                   "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            FrmVendas_Load(null, null);
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pc_itemVendaTableAdapter.Fill(this.dSVendas.pc_itemVenda);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pc_ProdutoTableAdapter.Fill(this.dSVendas.pc_Produto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pc_itemVendaTableAdapter.Fill(this.dSVendas.pc_itemVenda);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
