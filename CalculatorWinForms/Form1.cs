using System;
using System.Linq;
using System.Windows.Forms;


namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = Logic.EnterNomber((sender as Button).Text);
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            if (Logic.DSCount(textBoxCulc.Text)) textBoxCulc.Text = Logic.EnterNomber((sender as Button).Text); ;
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = "0";
            Logic.Clear();
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Enabled = true;
            }
        }


        private void butttonOperation_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = Logic.EnterOper((sender as Button).Text);
            if (textBoxCulc.Text == "Error")
                Error();
        }


        private void Equals_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = Logic.ResultString();
            if (textBoxCulc.Text == "Error")
                Error();
        }

        /// <summary>
        /// Блокировка ввода символов в случае ошибки. 
        /// </summary>
        private void Error()
        {
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Enabled = false;
                }
                buttonClear.Enabled = true;
            }

        }

        private void textBoxCulc_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 21) Error();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = Logic.Backspace();
        }
    }



}
