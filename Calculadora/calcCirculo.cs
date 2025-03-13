using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    public partial class calcCirculo : Form
    {
        public calcCirculo()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            string raio = textRaio.Text;

            if (string.IsNullOrWhiteSpace(raio))
            {
                erro.Text = "Insira um valor";
                erro.ForeColor = Color.Red;
                return;
            }
            if (!raio.All(char.IsNumber))
            {
                erro.Text = "Os valores devem ser números";
                erro.ForeColor = Color.Red;
                return;
            }

            double raionum = Convert.ToDouble(raio);
            double resultado = 0;

            if (perimetro.Checked)
            {
                resultado = ((2 * 3.14) * raionum);
            }
            if (diametro.Checked)
            {
                resultado = 2 * raionum;
            }
            if (area.Checked)
            {
                resultado = 3.14 * Math.Pow(raionum,2);
            }
            if (volume.Checked)
            {
                resultado = (4 * 3.14 * Math.Pow(raionum,3)) / 3;
            }

            textResult.Text = Convert.ToString(resultado);
            erro.Text = "";
            textRaio.Clear();
        }
    }
}
