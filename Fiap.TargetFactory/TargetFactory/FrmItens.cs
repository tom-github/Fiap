using Fiap.TargetFactory.BLL;
using Fiap.TargetFactory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiap.TargetFactory.PL
{
    public partial class FrmItens : Form
    {
        #region variaveis

        Item item;

        #endregion

        #region contrutores

        public FrmItens()
        {
            InitializeComponent();
            item = new Item();
        }

        #endregion

        #region eventos

        private void frmCadastroItens_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarDataGridItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista de Itens!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dgItens_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int id = (int)((DataGridView)sender).CurrentRow.Cells["Registro"].Value;
                Item item = new Logic().BuscarItem(Convert.ToInt32(id));

                txtId.Text = item.Id.ToString();
                txtDesc.Text = item.Descricao;

                DesabilitaBusca();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar item!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnNovoCancelar_Click(object sender, EventArgs e)
        {
            if (btnNovoCancelar.Text == "Novo")
            {
                DesabilitaBusca();
            }
            else if (btnNovoCancelar.Text == "Cancelar")
            {
                HabilitaBusca();
            }

            Limpar();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtId.Text.Trim();

                if (!string.IsNullOrEmpty(id))
                    item.Id = Convert.ToInt32(id);
                else
                    item.Id = 0;

                item.Descricao = txtDesc.Text.Trim();

                int status = new Logic().CadatrarAtualizarItem(item);

                if (status == 1)
                {
                    MessageBox.Show("Item alterado com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridItens();
                }
                else if (status == 2)
                {
                    MessageBox.Show("Item incluído com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridItens();
                }
                else
                {
                    MessageBox.Show("Nenhuma ação realizada, selecione um item!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                HabilitaBusca();
                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar ou alterar item!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtId.Text.Trim();

                if (!string.IsNullOrEmpty(id))
                    item.Id = Convert.ToInt32(id);
                else
                    item.Id = 0;

                int status = new Logic().ExcluirItem(item.Id);

                if (status == 1)
                {
                    MessageBox.Show("Item Excluido com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridItens();
                }
                else
                {
                    MessageBox.Show("Nenhuma ação realizada!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                HabilitaBusca();
                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar ou alterar item!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Logic().BuscarItem(Convert.ToInt32(txtId.Text.Trim()));

                if (item == null)
                {
                    MessageBox.Show("Item não encontrado!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtId.Text = item.Id.ToString();
                txtDesc.Text = item.Descricao;

                DesabilitaBusca();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar item!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region metodos

        private void CarregarDataGridItens()
        {
            try
            {
                var dt = new Logic().ListarTodosItens();

                if (dt != null)
                {
                    dgItens.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void HabilitaBusca()
        {
            txtId.Enabled = true;
            txtId.Focus();
            txtDesc.Enabled = false;
            btnNovoCancelar.Text = "Novo";
            btnBuscar.Enabled = true;
            btnSalvar.Enabled = false;
        }
        private void DesabilitaBusca()
        {
            txtId.Enabled = false;
            txtDesc.Enabled = true;
            txtDesc.Focus();
            btnNovoCancelar.Text = "Cancelar";
            btnExcluir.Enabled = true;
            btnBuscar.Enabled = false;
            btnSalvar.Enabled = true;
        }
        private void Limpar()
        {
            txtId.Clear();
            txtDesc.Clear();
        }

        #endregion
    }
}
