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
            //    || !(Logic.DS_Count(textBoxCulc.Text) < 1))
            //{
            //    e.Handled = true;
            //}
            var text = textBoxCulc.Text;

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar.Equals(',')) && (!text.Contains(',')) && e.KeyChar.Equals(8)))
            {
                e.Handled = true;
            }
        }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            var text = textBoxCulc.Text;
            if (text == "0") text = "";
            textBoxCulc.Text += (sender as Button).Text.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCulc.Text = "0";
        }
    }



}
