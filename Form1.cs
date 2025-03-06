using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int var_a;
        private int var_b;
        private int var_c;
        private int var_d;
        private int var_e;
        private int var_f;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += '+';
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            String[] data = textBox1.Text.Split('+');
            var_a = Int32.Parse(data[0]);
            var_b = Int32.Parse(data[1]);
            int result = var_a + var_b;
            
            if (data.Length >2)
            {
                var_c = Int32.Parse(data[2]);

                result += var_c;

            }
            textBox1.Text = result.ToString();
            //var_d = Int32.Parse(textBox1.Text.Split('+')[3]);
           
        }
    }
}
