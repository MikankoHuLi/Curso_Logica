using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calcQuadrado : Form
    {
        public calcQuadrado()
        {
            InitializeComponent();
        }

        private void calcBotao_Click(object sender, EventArgs e)
        {
            string num1 = baseRet.Text;
            string num2 = altRet.Text;
            string num3 = volRet.Text;

            if (!num1.All(char.IsNumber) || !num2.All(char.IsNumber) || !num3.All(char.IsNumber))
            {
                erro.Text = "Os valores devem ser números";
                erro.ForeColor = Color.Red;
                return;
            }

            double dnum1 = Convert.ToDouble(num1);
            double dnum2 = Convert.ToDouble(num2);
            double dnum3 = Convert.ToDouble(num3);

            if (opcoes.Text == "Perímetro")
            {
                
                    result.Text = Convert.ToString(2*(dnum1+dnum2));
                   
            }
            if (opcoes.Text == "Área")
            {

                result.Text = Convert.ToString(dnum1 * dnum2);

            }
            if (opcoes.Text == "Volume")
            {

                result.Text = Convert.ToString(dnum1 * dnum2 * dnum3);

            }
            baseRet.Clear();
            altRet.Clear();
            volRet.Clear();

        }
    }
}
