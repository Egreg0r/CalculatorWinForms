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


        private void textBoxCulc_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && e.KeyChar != 47 && e.KeyChar != 61)
            //    || !(Logic.DSCount(textBoxCulc.Text) < 1))
            //{
            //    e.Handled = true;
            //}
            var text = textBoxCulc.Text;

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar.Equals(",")) && (!text.Contains(",")) && e.KeyChar.Equals(8)))
            {
                e.Handled = true;
            }
        }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            var text = textBoxCulc.Text;

            text += (sender as Button).Text;
            if ((text.IndexOf("0") == 0) && (text.IndexOf(",") != 1) ) text = text.Remove(0, 1);

            textBoxCulc.Text = text.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = "0";
        }

        private void butttonOperation_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text=Logic.ResultString(textBoxCulc.Text, (sender as Button).Text);
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            if (Logic.DSCount(textBoxCulc.Text) < 1) textBoxCulc.Text += ",";
        }
    }



}
