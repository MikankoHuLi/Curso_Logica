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

            if (string.IsNullOrWhiteSpace(textRaio.Text))
            {
                erro.Text = "Insira um valor";
                erro.ForeColor = Color.Red;
                return;
            }
            if (!textRaio.Text.All(char.IsNumber))
            {
                erro.Text = "Os valores devem ser números";
                erro.ForeColor = Color.Red;
                return;
            }

            double raionum = Convert.ToDouble(textRaio.Text);
            double resultado;

            //procurar alternativa caso todos unchecked

            if (perimetro.Checked)
            {
                resultado = 2 * 3.14 * raionum;
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
            //Pi = 3.14 = Math.Pi


            textResult.Text = resultado.ToString("F");
            erro.Text = "";
            textRaio.Clear();
        }

        private void carinha_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int x = rng.Next(-10, 700);
            int y = rng.Next(-10, 400);
            int size = rng.Next(4, 300);

            carinha.Text = ">:3";
            carinha.Font = new Font("Segoe UI", size);
            carinha.ForeColor = Color.Red;
            carinha.Location = new Point(x, y);

            carinha.Text = ">:3";
            carinha.Font = new Font("Segoe UI", size);
            carinha.ForeColor = Color.Red;
            carinha.Location = new Point(x, y);

            progresso.Minimum = 0;
            progresso.Maximum = 10;
            progresso.Step = 1;
            progresso.PerformStep();

            if (progresso.Value == 10)
            {
                carinha.Text = ">:3";
                carinha.Font = new Font("Segoe UI", 300);
                carinha.ForeColor = Color.Red;
                carinha.Location = new Point(25, 100); 
                secret.Text = "Boo!";
                secret.Font = new Font("MS UI Gothic", 150);
                secret.ForeColor = Color.Red;
                secret.Location = new Point(159, 0); 
            }



        }
    }
}
