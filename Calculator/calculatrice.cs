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
    public partial class calculatrice : Form

    {

        private decimal term1 = 0.0m;
        private decimal term2 = 0.0m;
        private decimal result = 0.0m;


        private string Operation = "+";

        public calculatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chifre7_Click(object sender, EventArgs e)
        {
            text.Text += "7";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            text.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text.Text += "9";
        }
   
        

        private void button5_Click(object sender, EventArgs e)
        {
            text.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text.Text += "2";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            text.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {

            text.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(text.Text);
            text.Clear();
            Operation = "+";

            
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(text.Text);
            text.Clear();
            Operation = "-";
        }

        private void buttonFois_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(text.Text);
            text.Clear();
            Operation = "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(text.Text);
            text.Clear();
            Operation = "/";
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            text.Clear();
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    term2 = decimal.Parse(text.Text);
                    result = term1 + term2;
                    text.Text = result.ToString();
                    break;

                case "-":
                    term2 = decimal.Parse(text.Text);
                    result = term1 - term2;
                    text.Text = result.ToString();
                    break;

                case "*":
                    term2 = decimal.Parse(text.Text);
                    result = term1 * term2;
                    text.Text = result.ToString();
                    break;

                case "/":
                    term2 = decimal.Parse(text.Text);
                    result = term1 / term2;
                    text.Text = result.ToString();
                    break;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       
    }
}
