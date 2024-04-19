using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        double value1 = 0;
        double value2 = 0;
        string sign = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            Operacion.Text = "Sumando";
            if (!string.IsNullOrEmpty(numero.Text))
            {
                sign = "+";
                value1 = double.Parse(numero.Text);
                numero.Text = "";
            }
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            Operacion.Text = "Restando";
            if (!string.IsNullOrEmpty(numero.Text))
            {
                sign = "-";
                value1 = double.Parse(numero.Text);
                numero.Text = "";
            }
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            Operacion.Text = "Multiplicando";
            if (!string.IsNullOrEmpty(numero.Text))
            {
                sign = "*";
                value1 = double.Parse(numero.Text);
                numero.Text = "";
            }
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            Operacion.Text = "Dividiendo";
            if (!string.IsNullOrEmpty(numero.Text))
            {
                sign = "/";
                value1 = double.Parse(numero.Text);
                numero.Text = "";
            }
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            Operacion.Text = "El resultado es: ";
            if (!string.IsNullOrWhiteSpace(numero.Text))
            {
                value2 = double.Parse(numero.Text);
                double resultado = Calculo(value1, value2, sign);
                numero.Text = resultado.ToString();
            }
        }


    

        private double Calculo(double value1, double value2, string sign)
        {
            double resultado = 0;
            switch (sign)
            {
                case "+":
                    resultado = value1 + value2;
                    break;
                case "-":
                    resultado = value1 - value2;
                    break;
                case "*":
                    resultado = value1 * value2;
                    break;
                case "/":
                    if (value2 != 0)
                        resultado = value1 / value2;
                    else
                        MessageBox.Show("No se puede dividir por cero");
                    break;
            }
            return resultado;
        }


                    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "1";
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numero.Text = numero.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numero.Text = "0";
        }

    }
}
