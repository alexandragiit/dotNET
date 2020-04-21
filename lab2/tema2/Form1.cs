using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema2
{
    public partial class Form1 : Form
    {

        double FirstNumber;
        string Operation;
        
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.KeyPreview = true;
            System.Diagnostics.Debug.WriteLine("Test");


        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
               
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = e.KeyChar.ToString();
                }
                else
                {
                    textBox1.Text += e.KeyChar.ToString();
                }
            }
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void add_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.AppendText($"KeyPress keychar: {e.KeyCode}" + "\r\n");
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {   


        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "1";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // button 4
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // button 6
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // button 0
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // button 7
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // add
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // div
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";

        }

        private void sub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Console.Write(Result);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-" + textBox1.Text;
        }
    }
}
