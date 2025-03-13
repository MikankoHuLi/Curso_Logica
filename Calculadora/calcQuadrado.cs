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

            if (string.IsNullOrWhiteSpace(num1))
            {
                erro.Text = "Insira um valor";
                erro.ForeColor = Color.Red;
                return;
            }
            if (!num1.All(char.IsNumber) || !num2.All(char.IsNumber) || !num3.All(char.IsNumber))
            {
                erro.Text = "Os valores devem ser números";
                erro.ForeColor = Color.Red;
                return;
            }

            double dnum1 = Convert.ToDouble(num1);
            double dnum2 = Convert.ToDouble(num2);
            

            if (opcoesForma.Text == "Retângulo")
            {
                if (opcoes.Text == "Perímetro")
                {

                    erro.Text = "Paralelepido não possu perímetro";
                }
                else if (opcoes.Text == "Área")
                {

                    result.Text = Convert.ToString(dnum1 * dnum2);
                    erro.Text = "";
                }
                else
                {
                    erro.Text = "Selecione uma opção válida";
                }

            }

            if (opcoesForma.Text == "Quadrado")
            {
                if (opcoes.Text == "Perímetro")
                {

                    result.Text = Convert.ToString(4 * dnum1);
                    erro.Text = "";
                }
                else if (opcoes.Text == "Área")
                {

                    result.Text = Convert.ToString(dnum1 * dnum1);
                    erro.Text = "";
                }
                else
                {
                    erro.Text = "Selecione uma opção válida";
                }
            }
            if (opcoesForma.Text == "Paralelepípedo")
            {
                double dnum3 = Convert.ToDouble(num3);
                if (opcoes.Text == "Perímetro")
                {
                    result.Text = Convert.ToString((4 * dnum1) + (4 * dnum2) + (4 * dnum3));
                    erro.Text = "";
                }
                else if (opcoes.Text == "Área")
                {
                    result.Text = Convert.ToString(2 * ((dnum1*dnum2) + (dnum2*dnum3) + (dnum3*dnum1)));
                    erro.Text = "";
                }
                else if (opcoes.Text == "Volume")
                {

                    result.Text = Convert.ToString(dnum1 * dnum2 * dnum3);
                    erro.Text = "";
                }
                else
                {
                    erro.Text = "Selecione uma opção válida";
                }
            }
            if (opcoesForma.Text == "Cubo")
            {

                if (opcoes.Text == "Perímetro")
                {
                    result.Text = Convert.ToString(12 * dnum1);
                    erro.Text = "";
                }
                else if (opcoes.Text == "Área")
                {
                    result.Text = Convert.ToString(6 * (dnum1 * dnum1));
                    erro.Text = "";
                }
                else if (opcoes.Text == "Volume")
                {

                    result.Text = Convert.ToString(dnum1 * dnum1 * dnum1);
                    erro.Text = "";
                }
                else
                {
                    erro.Text = "Selecione uma opção válida";
                }
            }


            baseRet.Clear();
            altRet.Clear();
            volRet.Clear();

        }

        private void opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcoesForma.Text == "Paralelepípedo")
            {
                volRet.Enabled = true;
            }
            else
            {
                volRet.Enabled = false;
            }

        }

        private void opcoesForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcoesForma.Text == "Quadrado" || opcoesForma.Text == "Cubo")
            {
                altRet.Enabled = false;
            }
            else 
            {
                altRet.Enabled = true;  
            }
        }
    }
}
