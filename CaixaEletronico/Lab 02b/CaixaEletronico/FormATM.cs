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

        int tempAmountCashValue50;
        int tempAmountCashValue20;
        int tempAmountCashValue10;
        int tempAmountCashValue5;

        public FormATM()
        {
            InitializeComponent();
        }


        private void txtValueDrawee_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int.Parse(txtValueDrawee.Text.Trim());

                txtAmountCash50.Enabled = true;
                txtAmountCashValue20.Enabled = true;
                txtAmountCashValue10.Enabled = true;
                txtAmountCashValue5.Enabled = true;
                btnCalculate.Enabled = true;
            }
            catch
            {
                txtAmountCash50.Enabled = false;
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

                lblAmountCash50.Text = (50 * tupleRemainder.Item1).ToString("C");
                txtAmountCash50.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Twenty, amountCashValue20);
                lblAmountCash20.Text = (20 * tupleRemainder.Item1).ToString("C");
                txtAmountCashValue20.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Ten, amountCashValue10);
                lblAmountCash10.Text = (10 * tupleRemainder.Item1).ToString("C");
                txtAmountCashValue10.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.fife, amountCashValue5);
                lblAmountCash5.Text = (5 * tupleRemainder.Item1).ToString("C");
                txtAmountCashValue5.Text = tupleRemainder.Item1.ToString();

                tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Two, 0);
                lblAmountCash2.Text = (2 * tupleRemainder.Item1).ToString("C");
                txtAmountCashValue2.Text = tupleRemainder.Item1.ToString();
                
                CacheCashValues();

            }
            catch (Exception ex)
            {
                RetriaverCach();

                MessageBox.Show(ex.Message);
            }
        }

        private void RetriaverCach()
        {
            try
            {
                amountCashValue50 = null;
                amountCashValue20 = null;
                amountCashValue10 = null;
                amountCashValue5 = null;

                txtAmountCash50.Text = tempAmountCashValue50.ToString();
                txtAmountCashValue20.Text = tempAmountCashValue20.ToString();
                txtAmountCashValue10.Text = tempAmountCashValue10.ToString();
                txtAmountCashValue5.Text = tempAmountCashValue5.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CacheCashValues()
        {
            try
            {
                tempAmountCashValue50 = !string.IsNullOrEmpty(txtAmountCash50.Text) ? Convert.ToInt32(txtAmountCash50.Text) : 0;
                tempAmountCashValue20 = !string.IsNullOrEmpty(txtAmountCashValue20.Text) ? Convert.ToInt32(txtAmountCashValue20.Text) : 0;
                tempAmountCashValue10 = !string.IsNullOrEmpty(txtAmountCashValue10.Text) ? Convert.ToInt32(txtAmountCashValue10.Text) : 0;
                tempAmountCashValue5 = !string.IsNullOrEmpty(txtAmountCashValue5.Text) ? Convert.ToInt32(txtAmountCashValue5.Text) : 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtAmountCashValue50_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
                amountCashValue50 = Convert.ToInt32(txtAmountCash50.Text);

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
