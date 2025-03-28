using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Mejorada
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private double controlOperacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            valor2 = double.Parse(textBox1.Text);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text +="9";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            valor2 = double.Parse(textBox1.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            valor2 = double.Parse(textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox1.Text);
            switch (controlOperacion)

            {
                case 1:
                    
                    
                    resultado = valor1 + valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 2:
                    
                    resultado = valor1 - valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 3:
                    
                    resultado = valor1 * valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 4:
                    
                    if (valor2 != 0)
                    {
                      resultado = valor1 / valor2;
                      textBox1.Text=resultado.ToString();
                    }
                    else {
                        MessageBox.Show("Error operacion no valida","Error operacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    break;

                default:
                    MessageBox.Show("Error");
                    break;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            controlOperacion = 1;
            valor1=double.Parse(textBox1.Text);
            textBox1.Text = "";
           
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            controlOperacion = 2;
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            controlOperacion = 3;
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            controlOperacion = 4;
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            
        }
    }
}
