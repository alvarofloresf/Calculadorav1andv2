using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_1
{
    public partial class Form1 : Form
    {
        float num1, num2, res;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void num1_txt_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void num2_txt_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(num1_txt.Text);
            num2 = float.Parse(num2_txt.Text);
            
            if (num1 == 0 && num2 == 0)
            {
                label4.Text = "∞";
            }
            else
            {
                res = num1 / num2;
                label4.Text = res.ToString();
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(num1_txt.Text);
            num2 = float.Parse(num2_txt.Text);
            res = num1 - num2;
            label4.Text = res.ToString();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(num1_txt.Text);
            num2 = float.Parse(num2_txt.Text);
            res = num1 * num2;
            label4.Text = res.ToString();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(num1_txt.Text);
            num2 = float.Parse(num2_txt.Text);
            res = num1 + num2;
            label4.Text = res.ToString();
            
        }

    }
}
