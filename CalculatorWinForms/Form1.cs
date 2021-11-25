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
            checkError(textBoxCulc.Text);
        }


        private void Equals_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = Logic.ResultString();
            checkError(textBoxCulc.Text);
        }

        /// <summary>
        /// Блокировка ввода символов в случае ошибки. 
        /// </summary>
        /// <param name="s"></param>
        private void checkError(string s)
        {
            if (s == "Error")
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Enabled = false;
                }
                buttonClear.Enabled = true;
            }

        }
    }



}
