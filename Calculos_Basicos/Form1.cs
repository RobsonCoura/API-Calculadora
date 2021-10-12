using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_Basicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis do tipo double, Num1, Num2, Resultado.
            Double Num1, Num2, Resultado;
            /* Num1 e Num2 recebe conteudo de textbox (txtNum1.text e txtNum2.text)
            Convert.Todouble é necessario para que seja convertido o conteudo do textbox para número. */
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            //  Variavel resultado = recebe conteudo de Num1 + Num2 e realiza o calculo.
            Resultado = Num1 + Num2;
            // txtResultado.Text = recebe conteudo da variavel resultado e converte para numero.
            txtResultado.Text = Resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis do tipo double, Num1, Num2, Resultado.
            Double Num1, Num2, Resultado;
            /* Num1 e Num2 recebe conteudo de textbox (txtNum1.text e txtNum2.text)
            Convert.Todouble é necessario para que seja convertido o conteudo do textbox para número. */
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            //  Variavel resultado = recebe conteudo de Num1 + Num2 e realiza o calculo.
            Resultado = Num1 - Num2;
            // txtResultado.Text = recebe conteudo da variavel resultado e converte para numero.
            txtResultado.Text = Resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis do tipo double, Num1, Num2, Resultado.
            Double Num1, Num2, Resultado;
            /* Num1 e Num2 recebe conteudo de textbox (txtNum1.text e txtNum2.text)
            Convert.Todouble é necessario para que seja convertido o conteudo do textbox para número. */
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            //  Variavel resultado = recebe conteudo de Num1 + Num2 e realiza o calculo.
            Resultado = Num1 * Num2;
            // txtResultado.Text = recebe conteudo da variavel resultado e converte para numero.
            txtResultado.Text = Resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis do tipo double, Num1, Num2, Resultado.
            Double Num1, Num2, Resultado;
            /* Num1 e Num2 recebe conteudo de textbox (txtNum1.text e txtNum2.text)
            Convert.Todouble é necessario para que seja convertido o conteudo do textbox para número. */
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            //  Variavel resultado = recebe conteudo de Num1 + Num2 e realiza o calculo.
            Resultado = Num1 / Num2;
            // txtResultado.Text = recebe conteudo da variavel resultado e converte para numero.
            txtResultado.Text = Resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
