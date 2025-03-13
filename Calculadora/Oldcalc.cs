using CalHard;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    public partial class Oldcalc : Form
    {
        public Oldcalc()
        {
            InitializeComponent();
            monthCalendar1.SetDate(new DateTime(1990, 01, 01));

        }

        private void botaomais_Click(object sender, EventArgs e)
        {
            string num1 = textnum1.Text;
            string num2 = textnum2.Text;

            if (!num1.All(char.IsNumber) || !num2.All(char.IsNumber))
            {
                textCabecario.Text = "Os valores devem ser números";
                return;
            }

            double dnum1 = Convert.ToDouble(num1);
            double dnum2 = Convert.ToDouble(num2);

            textnum1.Text = Convert.ToString(dnum1 + dnum2);
            textnum2.Clear();

        }

        private void novaCalc_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            //this.Hide();
        }

        private void botaoResult_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(caixaNum1.Text);
            double num2 = Convert.ToDouble(caixaNum2.Text);

            switch (operador.Text)
            {
                case "+":
                    textResult.Text = Convert.ToString(num1 + num2);
                    break;

                case "-":
                    textResult.Text = Convert.ToString(num1 - num2);
                    break;

                case "*":
                    textResult.Text = Convert.ToString(num1 * num2);
                    break;

                case "/":
                    textResult.Text = Convert.ToString(num1 / num2);
                    break;

            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operador.Text = comboBox1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string result = Convert.ToString(monthCalendar1);

            if (result.Contains("03/07/2000"))
            {
                premio.Text = "Parabéns :D";
                premio.ForeColor = Color.Green;
            }
            else
            {
                premio.Text = "Esse não é meu aniversário :c";
                premio.ForeColor = Color.Red;
            }
        }

        private void radioSoma_CheckedChanged(object sender, EventArgs e)
        {
            operador.Text = "+";
        }

        private void radioSub_CheckedChanged(object sender, EventArgs e)
        {
            operador.Text = "-";
        }

        private void radioMult_CheckedChanged(object sender, EventArgs e)
        {
            operador.Text = "*";
        }

        private void radioDiv_CheckedChanged(object sender, EventArgs e)
        {
            operador.Text = "/";
        }

        private void dica1check_CheckedChanged(object sender, EventArgs e)
        {
            dica1.Text = "Eu irei fazer 25 anos";
        }

        private void dica2check_CheckedChanged(object sender, EventArgs e)
        {
            dica2.Text = "Sou do signo de câncer";
        }

        private void dica3check_CheckedChanged(object sender, EventArgs e)
        {
            dica3.Text = "Nasci na primeira semana do mês";
        }

        private void calcQuad_Click(object sender, EventArgs e)
        {
            calcQuadrado calcQuadrado = new calcQuadrado();
            calcQuadrado.Show();
        }

        private void calcCirc_Click(object sender, EventArgs e)
        {
            calcCirculo calcCirculo = new calcCirculo();
            calcCirculo.Show();
        }
    }
}

