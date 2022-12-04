
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace calcul



{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count;
        float num1;
        float num2;
       
       
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0+0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            compute(count);
        }
        private void Form1_Keypress(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                button20.PerformClick();
                compute(count);
            }
            if (e.Control && e.KeyCode == Keys.Add)
            {
                button13.PerformClick();
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }

            if (e.Control && e.KeyCode == Keys.Subtract)
            {
                if (textBox1.Text != "")
                {

                    button17.PerformClick();
                    num1 = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count = 1;
                }
            }
            if (e.Control && e.KeyCode == Keys.Divide)
            {
                button5.PerformClick();
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;

            }

            if (e.Control && e.KeyCode == Keys.Multiply)
            {

            button9.PerformClick();
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            }




        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    num2 = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 2:
                    num2 = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 3:
                    num2 = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 4:
                    num2 = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            count = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
          
        }
       
    }
}