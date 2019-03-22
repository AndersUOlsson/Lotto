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
            values[0] = textBox1.Text;
            values[1] = textBox2.Text;
            values[2] = textBox3.Text;
            values[3] = textBox4.Text;
            values[4] = textBox5.Text;
            values[5] = textBox6.Text;
            values[6] = textBox7.Text;

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
            _checkControler.ControlNumberInterval(textBox1);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBox1, panel1, StartBtn);
        }

        private void textBoxValue2_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBox2);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBox2, panel1, StartBtn);
        }

        private void textBoxValue3_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBox3);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBox3,panel1, StartBtn);
        }

        private void textBoxValue4_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBox4);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBox4, panel1, StartBtn);
        }

        private void textBoxValue5_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBox5);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBox5, panel1, StartBtn);
        }

        private void textBoxValue6_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBox6);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBox6, panel1, StartBtn);
        }

        private void textBoxValue7_TextChanged(object sender, EventArgs e)
        {
            _checkControler.ControlNumberInterval(textBox7);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
            _checkControler.CheckForDuplicate(textBox7,panel1, StartBtn);
        }

        private void textBoxHowManyTries_TextChanged(object sender, EventArgs e)
        {
            _checkControler.CheckForHowManyTimes(textBoxHowManyTries);
            _checkControler.CheckForEmpty(panel1, textBoxHowManyTries, StartBtn);
        }
    }
}
