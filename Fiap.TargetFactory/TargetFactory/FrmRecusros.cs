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
    public partial class FrmRecursos : Form
    {
        #region variaveis

        Recurso recurso;

        #endregion

        #region contrutores

        public FrmRecursos()
        {
            InitializeComponent();
            recurso = new Recurso();
        }

        #endregion

        #region eventos

        private void frmCadastroRecursos_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarDataGridRecursos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista de recursos!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dgRecursos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int id = (int)((DataGridView)sender).CurrentRow.Cells["Registro"].Value;
                Recurso recurso = new Logic().BuscarRecurso(Convert.ToInt32(id));

                txtId.Text = recurso.Id.ToString();
                txtDesc.Text = recurso.Descricao;

                DesabilitaBusca();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar recurso!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    recurso.Id = Convert.ToInt32(id);
                else
                    recurso.Id = 0;

                recurso.Descricao = txtDesc.Text.Trim();

                int status = new Logic().CadatrarAtualizarRecurso(recurso);

                if (status == 1)
                {
                    MessageBox.Show("Recurso alterado com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridRecursos();
                }
                else if (status == 2)
                {
                    MessageBox.Show("Recurso incluído com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridRecursos();
                }
                else
                {
                    MessageBox.Show("Nenhuma ação realizada, selecione um recurso!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                HabilitaBusca();
                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar ou alterar recurso!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtId.Text.Trim();

                if (!string.IsNullOrEmpty(id))
                    recurso.Id = Convert.ToInt32(id);
                else
                    recurso.Id = 0;

                int status = new Logic().ExcluirRecurso(recurso.Id);

                if (status == 1)
                {
                    MessageBox.Show("Recurso Excluido com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridRecursos();
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
                MessageBox.Show("Erro ao cadastrar ou alterar recurso!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    MessageBox.Show("Informe o código do Recurso!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Recurso recurso = new Logic().BuscarRecurso(Convert.ToInt32(txtId.Text.Trim()));

                if (recurso == null)
                {
                    MessageBox.Show("Recurso não encontrado!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtId.Text = recurso.Id.ToString();
                txtDesc.Text = recurso.Descricao;

                DesabilitaBusca();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar recurso!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void CarregarDataGridRecursos()
        {
            try
            {
                var dt = new Logic().ListarTodosRecursos();

                if (dt != null)
                {
                    dgRecursos.DataSource = dt;
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
