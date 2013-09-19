using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiap.TargetFactory.BLL;
using Fiap.TargetFactory.Model;

namespace Fiap.TargetFactory.PL
{
    public partial class FrmOrperadores : Form
    {
        #region variaveis

        Operador operador;

        #endregion

        #region contrutores

        public FrmOrperadores()
        {
            InitializeComponent();
            operador = new Operador();
        }

        #endregion

        #region eventos

        private void frmCadastroOperadores_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarDataGridOperadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista de operadores!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dgOperadores_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int id = (int)((DataGridView)sender).CurrentRow.Cells["Registro"].Value;
                Operador operador = new Logic().BuscarOperador(Convert.ToInt32(id));

                txtId.Text = operador.Id.ToString();
                txtNome.Text = operador.Nome;

                DesabilitaBusca();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar operador!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    operador.Id = Convert.ToInt32(id);
                else
                    operador.Id = 0;

                operador.Nome = txtNome.Text.Trim();

                int status = new Logic().CadatrarAtualizarOperador(operador);

                if (status == 1)
                {
                    MessageBox.Show("Operador alterado com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridOperadores();
                }
                else if (status == 2)
                {
                    MessageBox.Show("Operador incluído com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridOperadores();
                }
                else
                {
                    MessageBox.Show("Nenhuma ação realizada, selecione um operador!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                HabilitaBusca();
                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar ou alterar operador!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtId.Text.Trim();

                if (!string.IsNullOrEmpty(id))
                    operador.Id = Convert.ToInt32(id);
                else
                    operador.Id = 0;

                int status = new Logic().ExcluirOperador(operador.Id);

                if (status == 1)
                {
                    MessageBox.Show("Operador Excluido com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridOperadores();
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
                MessageBox.Show("Erro ao cadastrar ou alterar operador!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    MessageBox.Show("Informe o código do Operador!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Operador operador = new Logic().BuscarOperador(Convert.ToInt32(txtId.Text.Trim()));

                if (operador == null)
                {
                    MessageBox.Show("Operador não encontrado!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtId.Text = operador.Id.ToString();
                txtNome.Text = operador.Nome;

                DesabilitaBusca();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar operador!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void CarregarDataGridOperadores()
        {
            try
            {
                var dt = new Logic().ListarTodosOperadores();

                if (dt != null)
                {
                    dgOperadores.DataSource = dt;
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
            txtNome.Enabled = false;
            btnNovoCancelar.Text = "Novo";
            btnBuscar.Enabled = true;
            btnSalvar.Enabled = false;
        }
        private void DesabilitaBusca()
        {
            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtNome.Focus();
            btnNovoCancelar.Text = "Cancelar";
            btnExcluir.Enabled = true;
            btnBuscar.Enabled = false;
            btnSalvar.Enabled = true;
        }
        private void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
        }

        #endregion
    }
}
