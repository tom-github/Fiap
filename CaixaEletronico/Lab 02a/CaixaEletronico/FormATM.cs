using CaixaEletronicoBLL;
using Fiap.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class FormATM : Form
    {
        int? amountCashValue50;
        int? amountCashValue20;
        int? amountCashValue10;
        int? amountCashValue5;

        public FormATM()
        {
            InitializeComponent();
        }


        private void txtValueDrawee_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int.Parse(txtValueDrawee.Text.Trim());

                txtAmountCashValue50.Enabled = true;
                txtAmountCashValue20.Enabled = true;
                txtAmountCashValue10.Enabled = true;
                txtAmountCashValue5.Enabled = true;
                btnCalculate.Enabled = true;
            }
            catch
            {
                txtAmountCashValue50.Enabled = false;
                txtAmountCashValue20.Enabled = false;
                txtAmountCashValue10.Enabled = false;
                txtAmountCashValue5.Enabled = false;
                btnCalculate.Enabled = false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Withdrawal calc = new Withdrawal();
                int valueDrawee = Convert.ToInt32(txtValueDrawee.Text);
                Tuple<int, int> tupleRemainder;

                tupleRemainder = calc.Calculate(valueDrawee, Withdrawal.enumMoneyValue.fifty, amountCashValue50);

                txtAmountCashValue50.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Twenty, amountCashValue20);
                txtAmountCashValue20.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Ten, amountCashValue10);
                txtAmountCashValue10.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.fife, amountCashValue5);
                txtAmountCashValue5.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Two, 0);
                txtAmountCashValue2.Text = tupleRemainder.Item1.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtAmountCashValue50_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
                amountCashValue50 = Convert.ToInt32(txtAmountCashValue50.Text);

        }
        private void txtAmountCashValue20_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
                amountCashValue20 = Convert.ToInt32(txtAmountCashValue20.Text);
        }

        private void txtAmountCashValue10_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
                amountCashValue10 = Convert.ToInt32(txtAmountCashValue10.Text);
        }

        private void txtAmountCashValue5_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
                amountCashValue5 = Convert.ToInt32(txtAmountCashValue5.Text);
        }
    }
}
