using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiap.CustomControls
{
    public class MyTextBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ',' || e.KeyChar == ' ';
        }
    }
}
