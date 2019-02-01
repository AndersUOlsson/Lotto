using System;
using System.Linq;
using System.Windows.Forms;


namespace Lotto
{
    public partial class Form1 : Form
    {
        private readonly TicketCalculator _ticketCalculator = new TicketCalculator();
        private  readonly CheckControler _checkControler    = new CheckControler();

        public Form1()
        {
            InitializeComponent();
        }

        //Start button. 
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Scorelbl.Visible = false;
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);

            var values = new string[7];
            values[0] = textBoxValue1.Text;
            values[1] = textBoxValue2.Text;
            values[2] = textBoxValue3.Text;
            values[3] = textBoxValue4.Text;
            values[4] = textBoxValue5.Text;
            values[5] = textBoxValue6.Text;
            values[6] = textBoxValue7.Text;

            var howManyTimes = int.Parse(textBoxHowManyTries.Text);

            var result = _ticketCalculator.SetTheNumberOfTheTicket(values, howManyTimes);
            Scorelbl.Visible = true;
            StartBtn.Enabled = false;

            textBoxHowManyFives.Text   = result[0].ToString();
            textBoxHowManySixth.Text   = result[1].ToString();
            textBoxHowManySeventh.Text = result[2].ToString();

            StartBtn.Enabled = true;
        }

        //From here and downward are the textboxes from the GUI. This textboxes have some controllers from the CheckControler class.
        //More info about the controls check "CheckControler" class.
        private void textBoxValue1_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBoxValue1);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBoxValue1, panel1, StartBtn);
        }

        private void textBoxValue2_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBoxValue2);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBoxValue2, panel1, StartBtn);
        }

        private void textBoxValue3_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBoxValue3);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBoxValue3,panel1, StartBtn);
        }

        private void textBoxValue4_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBoxValue4);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBoxValue4, panel1, StartBtn);
        }

        private void textBoxValue5_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBoxValue5);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBoxValue5, panel1, StartBtn);
        }

        private void textBoxValue6_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBoxValue6);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBoxValue6, panel1, StartBtn);
        }

        private void textBoxValue7_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBoxValue7);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBoxValue7,panel1, StartBtn);
        }

        private void textBoxHowManyTries_TextChanged(object sender, EventArgs e)
        {
            _checkControler.CheckForHowManyTimes(textBoxHowManyTries);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
        }
    }
}
