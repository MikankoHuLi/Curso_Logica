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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            //procurar alternativa caso todos unchecked

            if (perimetro.Checked)
            {
                resultado = ((2 * 3.14) * raionum);
            }
            else if (diametro.Checked)
            {
                resultado = 2 * raionum;
            }
            else if (area.Checked)
            {
                resultado = 3.14 * Math.Pow(raionum, 2);
            }
            else if (volume.Checked)
            {
                resultado = (4 * 3.14 * Math.Pow(raionum, 3)) / 3;
            }
            else
            {
                erro.Text = "Selecione uma opção";
                return;
            }


            textResult.Text = resultado.ToString("F");
            erro.Text = "";
            textRaio.Clear();
        }

        private void carinha_Click(object sender, EventArgs e)
        {
            carinha.Text = ">:3";
            carinha.Font = new Font("Segoe UI", 64);
            carinha.ForeColor = Color.Red;
            Random rng = new Random();
            int rng1 = rng.Next(-10,700);
            int rng2 = rng.Next(-10, 400);

            carinha.Location = new Point(rng1, rng2);
        }
    }
}
