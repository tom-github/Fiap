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
    public partial class FrmSimuladorProducao : Form
    {
        #region variaveis

        int qtdPecasProduzidas;
        DateTime tempoInicial;
        FrmMeta frmMeta;

        #endregion

        #region Construtor

        public FrmSimuladorProducao()
        {
            InitializeComponent();
        }

        #endregion

        #region metodos

        private void FrmSimuladorProducao_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarListaRecursos();
                CarregarListaItens();
                CarregarListaOperadores();
                BuscarMeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar tela de metas!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                qtdPecasProduzidas = Convert.ToInt32(lblQtdProduzida.Text);

                lblInicio.Text = DateTime.Now.ToString();

                double minutos = TimeSpan.FromTicks(DateTime.Now.Ticks - tempoInicial.Ticks).TotalHours;

                lblPecaPorHora.Text = (qtdPecasProduzidas / minutos).ToString("0000");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar simulação!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAcionar_Click(object sender, EventArgs e)
        {
            try
            {
                int result;

                if (!Int32.TryParse(lblMeta.Text, out result))
                {
                    MessageBox.Show("Cadastre primeiro uma meta para o Recurso e item selecionados e retorne ao simulador.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();

                    if (frmMeta == null || frmMeta.IsDisposed)
                    {
                        frmMeta = new FrmMeta();
                        frmMeta.Show();
                    }
                    return;
                }

                if (!timer.Enabled)
                {
                    timer.Start();
                    tempoInicial = DateTime.Now;
                }
                lblQtdProduzida.Text = (Convert.ToInt32(lblQtdProduzida.Text) + 1).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acionar máquina!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnPara_Click(object sender, EventArgs e)
        {
            try
            {

                timer.Enabled = false;

                StringBuilder sb = new StringBuilder();
                sb.Clear();

                sb.AppendLine("Relatório de produção");
                sb.AppendLine("");
                sb.AppendLine("Inicio: " + tempoInicial);
                sb.AppendLine("Fim: " + DateTime.Now);
                sb.AppendLine("");
                sb.AppendLine("Operador: " + ((System.Data.DataRowView)(lstOperador.SelectedItem)).Row.ItemArray[1]);
                sb.AppendLine("Recurso: " + ((System.Data.DataRowView)(lstRecurso.SelectedItem)).Row.ItemArray[1]);
                sb.AppendLine("Item: " + ((System.Data.DataRowView)(lstItem.SelectedItem)).Row.ItemArray[1]);
                sb.AppendLine("");
                sb.AppendLine("Quantidade de peças produzidas: " + lblQtdProduzida.Text);
                sb.AppendLine("Velocidade de produção: " + lblPecaPorHora.Text + " peças/hora");
                sb.AppendLine("Meta: " + lblMeta.Text + " peças/hora");
                sb.AppendLine("");
                sb.AppendLine("");

                var qtdProduzidaHora = Convert.ToInt32(lblPecaPorHora.Text);

                var meta = Convert.ToInt32(lblMeta.Text);

                if (qtdProduzidaHora < meta)
                {
                    sb.AppendLine("OPERADOR NÃO ATINGIU A META!");
                }
                else
                {
                    sb.AppendLine("OPERADOR ATINGIU A META!");
                }

                lblInicio.Text = "00:00";
                lblPecaPorHora.Text = "0";
                lblQtdProduzida.Text = "0";

                MessageBox.Show(sb.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao parar máquina!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lstRecurso_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                BuscarMeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar meta!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void lstItem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                BuscarMeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar meta!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void lstOperador_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                BuscarMeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar meta!\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region metodos

        private void CarregarListaOperadores()
        {
            try
            {
                var dt = new Logic().ListarTodosOperadores();

                if (dt != null)
                {
                    lstOperador.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregarListaItens()
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
        private void CarregarListaRecursos()
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
        private void BuscarMeta()
        {
            try
            {
                var id_recurso = Convert.ToInt32(((System.Data.DataRowView)(lstRecurso.SelectedItem)).Row.ItemArray[0]);
                var id_item = Convert.ToInt32(((System.Data.DataRowView)(lstItem.SelectedItem)).Row.ItemArray[0]);

                var meta = new Logic().BuscarMeta(id_recurso, id_item);

                if (meta != null)
                {
                    lblMeta.Text = meta.ItemHora.ToString();
                }
                else
                {
                    lblMeta.Text = "Meta não cadastrada!";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
