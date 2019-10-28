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
    public partial class FrmCadClientes : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmCadClientes()
        {
            InitializeComponent();
        }

        /*private void pc_clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSVendas);

        }*/

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSVendas.pc_vendas' table. You can move, or remove it, as needed.
           // this.pc_vendasTableAdapter.Fill(this.dSVendas.pc_vendas);
            // TODO: This line of code loads data into the 'dSVendas.pc_clientes' table. You can move, or remove it, as needed.
            pc_clientesTableAdapter.Fill(this.dSVendas.pc_clientes);

        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            mksCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mksTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mksUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            habilitaBotoes(false);
            habilitaCampos(true);
            incluir = true;
            limpaCampos();
            txtNome.Focus();
            txtCodCli.Hide();
        }

        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox))
                {
                    ((TextBox)item).Clear();
                }
                if(item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if(item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void habilitaCampos(bool hab)
        {
            txtNome.Enabled = hab;
            txtCodCli.Enabled = hab;
            txtEndereco.Enabled = hab;
            txtCidade.Enabled = hab;
            txtBairro.Enabled = hab;
            mksCep.Enabled = hab;
            mksUf.Enabled = hab;
            mksTelefone.Enabled = hab;
            dtpDataNasc.Enabled = hab;

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {

                mksCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtCodCli.Enabled = false;
                txtNome.Focus();
                txtCodCli.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                 mksTelefone.Text =
                    dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                 dtpDataNasc.Value =
                    Convert.ToDateTime(dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString());
               
                mksUf.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                mksCep.Text = dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString();


            }
            else
            {
                MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                mksCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mksUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (incluir)
                {
                    pc_clientesTableAdapter.InsertQuery(
                        txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text,
                      mksTelefone.Text,  dtpDataNasc.Value, mksUf.Text, mksCep.Text);
                    MessageBox.Show("Incluindo com sucesso!", "Incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_clientesTableAdapter.Update(txtNome.Text, txtEndereco.Text,
                        txtCidade.Text, txtBairro.Text, mksUf.Text,dtpDataNasc.Value ,
                        mksTelefone.Text, mksCep.Text, Convert.ToInt32(txtCodCli.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmCadClientes_Load(null, null);
                btnCancelar_Click(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:",
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", 
                        "Atenção:" , MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button2)== System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_clientesTableAdapter.Delete(Convert.ToInt32(
                            dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString()));
                        FrmCadClientes_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = true;
                txtNome.Focus();
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
                this.pc_clientesTableAdapter.FillBy(this.dSVendas.pc_clientes,
                    "%" + txtNome.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "telefone")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                            + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + "-"
                            + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }
        }

        private void telefoneMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ufMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
