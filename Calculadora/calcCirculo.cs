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

        private bool RadioNaoSelecionado(List<RadioButton> radios)
        {
            return radios.All(radio => !radio.Checked);
        }
        private bool ValorInvalido(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) || !valor.All(char.IsNumber);
        }

        private bool ValidarCirc()
        {
            List<RadioButton> radios = new List<RadioButton> { perimetro, diametro, area, volume };
            if (RadioNaoSelecionado(radios))
            {
                erro.Text = "Selecione uma opção";
                erro.ForeColor = Color.Red;
                return false;
            }
            if (ValorInvalido(textRaio.Text))
            {
                erro.Text = "Inserir um valor valido";
                return false;
            }
            return true;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (!ValidarCirc())
            {
                return;
            }

            double raionum = Convert.ToDouble(textRaio.Text);
            double resultado;

            erro.Text = "";
            textRaio.Clear();


            if (perimetro.Checked)
            {
                resultado = 2 * 3.14 * raionum;
                textResult.Text = resultado.ToString("F");
            }
            else if (diametro.Checked)
            {
                resultado = 2 * raionum;
                textResult.Text = resultado.ToString("F");
            }
            else if (area.Checked)
            {
                resultado = 3.14 * Math.Pow(raionum, 2);
                textResult.Text = resultado.ToString("F");
            }
            else if (volume.Checked)
            {
                resultado = (4 * 3.14 * Math.Pow(raionum, 3)) / 3;
                textResult.Text = resultado.ToString("F");
            }

            //Pi = 3.14 = Math.Pi

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
