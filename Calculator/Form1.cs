using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label2.Text += "5";
        }

        private void button_coma_Click(object sender, EventArgs e)
        {
            this.label2.Text += ",";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            this.label2.Text += " +";
            this.top_label.Text = this.label2.Text;
            this.label2.ResetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label2.Text += "9";
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            this.label2.Text += " *";
            this.top_label.Text = this.label2.Text;
            this.label2.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label2.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label2.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label2.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.label2.Text += "0";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            this.label2.Text += " -";
            this.top_label.Text = this.label2.Text;
            this.label2.ResetText();
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            int topLabelLength = this.top_label.Text.Length;
            int labelTextLength = this.label2.Text.Length;
            string topLabelText ="";
            string labelText = "";

            try
            {
                for(int i =0; i < topLabelLength - 2; i++)
                {
                    topLabelText += this.top_label.Text[i];
                }

                for (int i = 0; i < labelTextLength; i++)
                {
                    labelText += this.label2.Text[i];
                }

                long topLabelNums = Convert.ToInt64(topLabelText);
                long labelNums = Convert.ToInt64(labelText);

                char sign = this.top_label.Text[topLabelLength - 1];

                switch (sign)
                {
                    case '*':
                        this.label2.Text = (topLabelNums * labelNums).ToString();
                        break;

                    case '+':
                        this.label2.Text = (topLabelNums + labelNums).ToString();
                        break;

                    case '-':
                        this.label2.Text = (topLabelNums - labelNums).ToString();
                        break;

                    case '/':
                        this.label2.Text = (topLabelNums / labelNums).ToString();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.top_label.ResetText();
        }

        private void top_label_Click(object sender, EventArgs e)
        {

        }
    }
}
