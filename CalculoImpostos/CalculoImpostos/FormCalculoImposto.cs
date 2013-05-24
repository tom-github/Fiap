using System;
using System.Globalization;
using System.Windows.Forms;

namespace Fiap.CalculoImpostos.PL
{
    public partial class FormCalculoImposto : Form
    {
        public FormCalculoImposto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salary = Convert.ToDecimal(mskSalary.Text);

                txtIRPF.Text = new BLL.IRPF().EvaluateIRPF(salary).ToString();
                txtINSS.Text = new BLL.INSS().EvaluateINSS(salary).ToString();

                decimal IFPF = Convert.ToDecimal(txtIRPF.Text);
                decimal INSS = Convert.ToDecimal(txtINSS.Text);

                txtNetSalary.Text = (salary - IFPF - INSS).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(string.Format("Formato númerico inválido, utilize somente números!"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro no cálculode impostos!\r\n{0}", ex.Message));
            }
        }
    }
}
