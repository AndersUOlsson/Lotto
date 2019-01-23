using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    class CheckControler
    {
        //Control if the numbers of the ticket input is in the valid interval.
        public void ControlNumberInterval(Control textBox)
        {
            var res = int.TryParse(textBox.Text, out var val);
            if (res && (val > 35 || val < 1) && textBox.Text != string.Empty)
            {
                MessageBox.Show("Please input 1 to 35 only.");
                textBox.Text = string.Empty;
            }
        }

        //Control if the numbers of the ticket input is duplicate or not.
        public void CheckForDuplicate(Control textBox, Control panel, Button StartBtn)
        {
            if (!panel.Controls.OfType<TextBox>().Any(tb => textBox.Text.Equals(tb.Text) && tb != textBox)) return;
            MessageBox.Show("Duplicate text");
            StartBtn.Enabled = false;
        }

        //Control if the numbers of how many times input is valid or not.
        public void CheckForHowManyTimes(Control textBoxHowManyTries)
        {
            var res = int.TryParse(textBoxHowManyTries.Text, out var val);
            if ((!res || val <= 1000000) && val >= 0) return;
            MessageBox.Show(@"Please input 1 to 1 000 000 and integer only.");
            textBoxHowManyTries.Text = "";
        }

        //Control if the textboxes is empty or not. 
        internal void CheckForEmpty( Panel panel, TextBox textBoxHowManyTries, Button StartBtn)
        {
            //This will loop the whole panel text boxes and the how many tries text box. 
            foreach (var tb in panel.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text.Trim()) || textBoxHowManyTries.Text == string.Empty)
                {
                    StartBtn.Enabled = false;
                    break;
                }
                StartBtn.Enabled = true;
            }
        }
    }
}
