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
        }
        
    
    }
}

