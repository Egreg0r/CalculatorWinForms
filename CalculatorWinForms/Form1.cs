using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = "0";
            Logic.Clear();
        }

        private void butttonOperation_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCulc.Text = Logic.EnterOper((sender as Button).Text);
            }
            catch 
            {
                textBoxCulc.Text = "Error";
                foreach(var button in this.Controls.OfType<Button>())
                {
                    button.Enabled = false;
                }
                buttonClear.Enabled = true;
            }
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            if (Logic.DSCount(textBoxCulc.Text) < 1) textBoxCulc.Text += ",";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = Logic.ResultString((sender as Button).Text);
        }
    }



}
