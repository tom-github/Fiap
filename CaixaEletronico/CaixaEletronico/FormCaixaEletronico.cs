using Fiap.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtValueDrawee_TextChanged(object sender, EventArgs e)
        {
            ValidateEmptyFields(txtValueDrawee);
            ValidateNegativeNumber(txtValueDrawee);
        }

        private void ValidateEmptyFields(MyTextBox myTextBox)
        {
            try
            {
                int.Parse(((MyTextBox)myTextBox).Text);

                txtAmountCashValue50.Enabled = true;
                txtAmountCashValue20.Enabled = true;
                txtAmountCashValue10.Enabled = true;
                txtAmountCashValue5.Enabled = true;
            }
            catch
            {
                txtAmountCashValue50.Enabled = false;
                txtAmountCashValue20.Enabled = false;
                txtAmountCashValue10.Enabled = false;
                txtAmountCashValue5.Enabled = false;
            }
        }
        private bool ValidateNegativeNumber(MyTextBox myTextBox)
        {
            try
            {
                int value = Convert.ToInt32(((MyTextBox)myTextBox).Text);

                if (Convert.ToInt32(((MyTextBox)myTextBox).Text) <= 0)
                {
                    throw new Exception("O Valor sacado deve ser maior que zero");
                }

            }
            catch (Exception ex)
            {
                throw Ex;
            }
        }
    }
}
