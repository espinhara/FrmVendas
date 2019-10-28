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
    public partial class FrmFornecedor : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void pc_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSVendas);

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSVendas.pc_fornecedor' table. You can move, or remove it, as needed.
            this.pc_fornecedorTableAdapter.Fill(this.dSVendas.pc_fornecedor);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            incluir = true;
            limpaCampos();
            txtRazao.Focus();
            txtCod_for.Hide();
        }
        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnCancelar.Enabled = !hab;
            btnExcluir.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
        }
        private void habilitaCampos(bool hab)
        {
            txtCod_for.Enabled = hab;
            txtFantasia.Enabled = hab;
            txtRazao.Enabled = hab;
            txtEndereco.Enabled = hab;
            txtCidade.Enabled = hab;
            txtBairro.Enabled = hab;
            mksCep.Enabled = hab;
            mksUf.Enabled = hab;
            mksTel.Enabled = hab;
            mksFax.Enabled = hab;
            mksCnpj.Enabled = hab;
            mskIe.Enabled = hab;
            txtDataCad.Enabled = hab;

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
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void txtDataCad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedor.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o fornecedor selecionado?", 
                        "Atenção:" , MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button2)== System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_fornecedorTableAdapter.Delete(Convert.ToInt32(
                            dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value.ToString()));
                        FrmFornecedor_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um fornecedor primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {

                mksCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskIe.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksFax.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtCod_for.Enabled = false;
                txtRazao.Focus();
                txtCod_for.Text = dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtRazao.Text = dgvFornecedor[1, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtFantasia.Text = dgvFornecedor[2, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvFornecedor[3, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvFornecedor[4, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvFornecedor[5, dgvFornecedor.CurrentRow.Index].Value.ToString();

                mksUf.Text = dgvFornecedor[6, dgvFornecedor.CurrentRow.Index].Value.ToString();
                mksCep.Text = dgvFornecedor[7, dgvFornecedor.CurrentRow.Index].Value.ToString();

                mksTel.Text =
                   dgvFornecedor[8, dgvFornecedor.CurrentRow.Index].Value.ToString();

                mksFax.Text = dgvFornecedor[9, dgvFornecedor.CurrentRow.Index].Value.ToString();
                mksCnpj.Text = dgvFornecedor[10, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtDataCad.Value =
                   Convert.ToDateTime(dgvFornecedor[12, dgvFornecedor.CurrentRow.Index].Value.ToString());

                mskIe.Text = dgvFornecedor[11, dgvFornecedor.CurrentRow.Index].Value.ToString();



            }
            else
            {
                MessageBox.Show(null, "Selecione um fornecedor primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtRazao.Enabled == false)
            {
                txtRazao.Enabled = true;
                txtRazao.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnCancelar.Enabled = false;
                btnGravar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou " +
                    "\nparte dele.", "Pesquisa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                this.pc_fornecedorTableAdapter.FillByRazao(this.dSVendas.pc_fornecedor,
                    "%" + txtRazao.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                mksCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksFax.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskIe.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (incluir)
                {
                    pc_fornecedorTableAdapter.Insert(
                        txtRazao.Text,txtFantasia.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text,
                        mksUf.Text,mksCep.Text, mksTel.Text, mksFax.Text, mksCnpj.Text, mskIe.Text, txtDataCad.Value.Date);
                    MessageBox.Show("Incluindo com sucesso!", "Incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_fornecedorTableAdapter.Update(txtRazao.Text, txtFantasia.Text,
                        txtEndereco.Text, txtCidade.Text, txtBairro.Text,
                        mksUf.Text, mksCep.Text, mksTel.Text, mksFax.Text, 
                        mksCnpj.Text, mskIe.Text, txtDataCad.Value.Date, Convert.ToInt32(txtCod_for.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmFornecedor_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvFornecedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvFornecedor.Columns[e.ColumnIndex].DataPropertyName == "telefone"||
                this.dgvFornecedor.Columns[e.ColumnIndex].DataPropertyName == "fax")
            {
                if (e.Value != null)    
                {
                    string strvalue = (string)e.Value;
                    if (strvalue != "")
                    {
                        strvalue = "(" + strvalue.Substring(0, 2) + ")" + strvalue.Substring(2, 5)
                            + "-" + strvalue.Substring(7, 4);
                        e.Value = strvalue;
                    }
                }
            }
            else if (this.dgvFornecedor.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string strvalue = (string)e.Value;
                    if (strvalue != "")
                    {
                        strvalue = strvalue.Substring(0, 5) + "-"
                            + strvalue.Substring(5, 3);
                        e.Value = strvalue;
                    }
                }
            }
            //TODO IE CNPJ DATA 
            else if (this.dgvFornecedor.Columns[e.ColumnIndex].DataPropertyName == "ie")
            {
                if (e.Value != null)
                {
                    string strvalue = (string)e.Value;
                    if (strvalue != "")
                    {
                        strvalue = strvalue.Substring(0, 3) + "."
                            + strvalue.Substring(3, 3) + "."
                            + strvalue.Substring(6, 3) + "."
                            + strvalue.Substring(9, 3);
                        e.Value = strvalue;
                    }
                }
            }
            else if (this.dgvFornecedor.Columns[e.ColumnIndex].DataPropertyName == "cnpj")
            {
                if (e.Value != null)
                {
                    string strv = (string)e.Value;
                    if (strv != "")
                    {
                        strv = strv.Substring(0, 2) + "." +
                            strv.Substring(2, 3) + "." +
                            strv.Substring(5, 3) + "/" +
                            strv.Substring(8, 4) + "-" +
                            strv.Substring(12, 2);
                        e.Value = strv;
                    }
                }
            }
        }
    }
}
