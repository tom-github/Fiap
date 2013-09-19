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
    public partial class FrmMeta : Form
    {
        #region variaveis

        Meta meta;

        #endregion

        #region contrutor
        
        public FrmMeta()
        {
            InitializeComponent();
            meta = new Meta();
        }

        #endregion

        #region eventos

        private void FrmMeta_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarListaRecursos();
                CarregarListaItens();
                CarregarDataGridMetas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar tela de metas!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtItemHora.Text.Trim()))
                {
                    MessageBox.Show("Digite a quantidade de peças que deverão ser produzidas por hora!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                meta.Id_Recurso = Convert.ToInt32(((System.Data.DataRowView)(lstRecurso.SelectedItem)).Row.ItemArray[0]);
                meta.Id_Item = Convert.ToInt32(((System.Data.DataRowView)(lstItem.SelectedItem)).Row.ItemArray[0]);
                meta.ItemHora = Convert.ToInt32(txtItemHora.Text.Trim());

                int status = new Logic().CadatrarMeta(meta);

                if (status == 1)
                {
                    MessageBox.Show("Meta incluída com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridMetas();
                }
                else
                {
                    MessageBox.Show("Nenhuma ação realizada!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                txtItemHora.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar meta!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgMetas.SelectedCells[0].Value);

                int status = new Logic().ExcluirMeta(id);

                if (status == 1)
                {
                    MessageBox.Show("Meta Excluída com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridMetas();
                }
                else
                {
                    MessageBox.Show("Nenhuma ação realizada!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                txtItemHora.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar ou alterar item!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region metodos

        private void CarregarListaItens()
        {
            try
            {
                var dt = new Logic().ListarTodosRecursos();

                if (dt != null)
                {
                    lstRecurso.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregarListaRecursos()
        {
            try
            {
                var dt = new Logic().ListarTodosItens();

                if (dt != null)
                {
                    lstItem.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregarDataGridMetas()
        {
            try
            {
                var dt = new Logic().ListarTodasMetas();

                if (dt != null)
                {
                    dgMetas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void txtItemHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
      
    }
}
