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
        }

        private void botaomais_Click(object sender, EventArgs e)
        {
            string num1 = textnum1.Text;
            string num2 = textnum2.Text;

            if (!num1.All(char.IsNumber) || !num2.All(char.IsNumber))
            {
                textCabecario.Text = "Os valores devem ser n�meros";
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
            operador.Text = result;
            if (result.Contains("03/07/2000"))
            {
                premio.Text = "Parab�ns :D";
                premio.ForeColor = Color.Green;
            }
            else 
            {
                premio.Text = "Esse n�o � meu anivers�rio :c";
                premio.ForeColor = Color.Red;
            }
        }
    }
}

