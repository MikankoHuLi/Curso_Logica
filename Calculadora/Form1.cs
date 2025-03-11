namespace CalHard
{
    public partial class Form1 : Form
    {
        List<double> numeros = new List<double>();
        List<string> operadores = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoMais_Click(object sender, EventArgs e)
        {
            string num1 = textNum.Text;


            if (!num1.All(char.IsNumber))
            {
                textCab.Text = "Os valores devem ser números";
                return;
            }

            double dnum1 = Convert.ToDouble(num1);
            numeros.Add(dnum1);
            operadores.Add("+");
            textNum.Clear();
        }

       

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            {
                string num1 = textNum.Text;


                if (!num1.All(char.IsNumber))
                {
                    textCab.Text = "Os valores devem ser números";
                    return;
                }

                double dnum1 = Convert.ToDouble(num1);
                numeros.Add(dnum1);
                operadores.Add("-");
                textNum.Clear();
            }
        }

        private void botaoMult_Click(object sender, EventArgs e)
        {
            {
                string num1 = textNum.Text;


                if (!num1.All(char.IsNumber))
                {
                    textCab.Text = "Os valores devem ser números";
                    return;
                }

                double dnum1 = Convert.ToDouble(num1);
                numeros.Add(dnum1);
                operadores.Add("x");
                textNum.Clear();
            }
        }

        private void botaoDiv_Click(object sender, EventArgs e)
        {
            {
                string num1 = textNum.Text;


                if (!num1.All(char.IsNumber))
                {
                    textCab.Text = "Os valores devem ser números";
                    return;
                }

                double dnum1 = Convert.ToDouble(num1);
                numeros.Add(dnum1);
                operadores.Add("/");
                textNum.Clear();
            }

        }
        private void botaoResult_Click(object sender, EventArgs e)
        {
            string num2 = textNum.Text;

            if (!num2.All(char.IsNumber))
            {
                textCab.Text = "Os valores devem ser números";
                return;
            }

            double dnum2 = Convert.ToDouble(num2);
            numeros.Add(dnum2);



            if (operadores.Contains("-"))
            {
                textNum.Text = Convert.ToString(numeros[0] - numeros[1]);
            }
            if (operadores.Contains("+"))
            {
                textNum.Text = Convert.ToString(numeros[0] + numeros[1]);
            }
            if (operadores.Contains("x"))
            {
                textNum.Text = Convert.ToString(numeros[0] * numeros[1]); 
            }
            if (operadores.Contains("/"))
            {
                textNum.Text = Convert.ToString(numeros[0] / numeros[1]);
            }
            operadores.Clear();
            numeros.Clear();
        }
    }
}

