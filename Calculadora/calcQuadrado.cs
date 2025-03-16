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

        private bool RadioNaoSelecionado(List<RadioButton> radios)
        {
            return radios.All(radio => !radio.Checked);
        }
        private bool ValorInvalido(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) || !valor.All(char.IsNumber);
        }
        private bool ValidarRetangulo()
        {
            List<RadioButton> radios = new List<RadioButton> { perimetroBut, areaBut, volumeBut };
            if (RadioNaoSelecionado(radios))
            {
                erro.Text = "Selecione uma operação.";
                return false;
            }

            if (ValorInvalido(baseRet.Text))
            {
                erro.Text = "Insira um valor de base válido";
                return false;
            }

            if (ValorInvalido(altRet.Text))
            {
                erro.Text = "Insira um valor de altura válido";
                return false;
            }
            return true;
        }
        private bool ValidarQuadrado()
        {
            List<RadioButton> radios = new List<RadioButton> { perimetroBut, areaBut, volumeBut };
            if (RadioNaoSelecionado(radios))
            {
                erro.Text = "Selecione uma operação.";
                return false;
            }

            if (ValorInvalido(baseRet.Text))
            {
                erro.Text = "Insira um valor de base válido";
                return false;
            }
            return true;
        }
        private bool ValidarParalelepipedo()
        {
            List<RadioButton> radios = new List<RadioButton> { perimetroBut, areaBut, volumeBut };
            if (RadioNaoSelecionado(radios))
            {
                erro.Text = "Selecione uma operação.";
                return false;
            }

            if (ValorInvalido(baseRet.Text))
            {
                erro.Text = "Insira um valor de base válido";
                return false;
            }

            if (ValorInvalido(altRet.Text))
            {
                erro.Text = "Insira um valor de altura válido";
                return false;
            }

            if (ValorInvalido(volRet.Text))
            {
                erro.Text = "Insira um valor de comprimento válido";
                return false;
            }

            return true;
        }
        private bool ValidarCubo()
        {
            List<RadioButton> radios = new List<RadioButton> { perimetroBut, areaBut, volumeBut };
            if (RadioNaoSelecionado(radios))
            {
                erro.Text = "Selecione uma operação.";
                return false;
            }

            if (ValorInvalido(baseRet.Text))
            {
                erro.Text = "Insira um valor de base válido";
                return false;
            }
            return true;
        }


        private bool ValidarForm()
        {
            erro.Text = "";

            if (opcoesForma.SelectedItem == null)
            {
                erro.Text = "Selecione uma forma";
                return false;
            }

            if (opcoesForma.SelectedItem.ToString() == "Quadrado")
            {
                return ValidarQuadrado();
            }

            if (opcoesForma.SelectedItem.ToString() == "Retângulo")
            {
                return ValidarRetangulo();
            }

            if (opcoesForma.SelectedItem.ToString() == "Paralelepípedo")
            {
                return ValidarParalelepipedo();
            }
            if (opcoesForma.SelectedItem.ToString() == "Cubo")
            {
                return ValidarCubo();
            }

            return false;
        }
        private void calcBotao_Click(object sender, EventArgs e)
        {
            if (!ValidarForm())
            {
                return;
            }

            string baseforma = baseRet.Text;
            string altura = altRet.Text;
            string comprimento = volRet.Text;

            baseRet.Clear();
            altRet.Clear();
            volRet.Clear();

            if (opcoesForma.Text == "Retângulo")
            {
                volumeBut.Enabled = false;
                if (perimetroBut.Checked)
                {
                    double resultado = 2 * (Convert.ToDouble(baseforma) + Convert.ToDouble(altura));
                    result.Text = Convert.ToString(resultado);
                    return;
                }
                if (areaBut.Checked)
                {
                    double resultado = Convert.ToDouble(baseforma) * Convert.ToDouble(altura);
                    result.Text = Convert.ToString(resultado);
                    return;
                }

            }

            if (opcoesForma.Text == "Quadrado")
            {
                volumeBut.Enabled = false;
                if (perimetroBut.Checked)
                {
                    double resultado = 4 * Convert.ToDouble(baseforma);
                    result.Text = Convert.ToString(resultado);
                    return;
                }
                if (areaBut.Checked)
                {
                    double resultado = Math.Pow(Convert.ToDouble(baseforma), 2);
                    result.Text = Convert.ToString(resultado);
                    return;
                }
            }
            if (opcoesForma.Text == "Paralelepípedo")
            {
                if (perimetroBut.Checked)
                {
                    double resultado = (4 * Convert.ToDouble(baseforma)) + (4 * Convert.ToDouble(altura)) + (4 * Convert.ToDouble(comprimento));
                    result.Text = Convert.ToString(resultado);
                    return;
                }
                else if (areaBut.Checked)
                {
                    double resultado = 2 * (Convert.ToDouble(baseforma) * Convert.ToDouble(altura) + Convert.ToDouble(altura) * Convert.ToDouble(comprimento)
                        + Convert.ToDouble(comprimento) * Convert.ToDouble(baseforma));
                    result.Text = Convert.ToString(resultado);
                    return;
                }
                else if (volumeBut.Checked)
                {
                    double resultado = Convert.ToDouble(baseforma) * Convert.ToDouble(altura) * Convert.ToDouble(comprimento);
                    result.Text = Convert.ToString(resultado);
                    return;
                }

            }
            if (opcoesForma.Text == "Cubo")
            {

                if (perimetroBut.Checked)
                {
                    double resultado = 12 * Convert.ToDouble(baseforma);
                    result.Text = Convert.ToString(resultado);
                    return;
                }
                if (areaBut.Checked)
                {
                    double resultado = 6 * Math.Pow(Convert.ToDouble(baseforma), 2);
                    result.Text = Convert.ToString(resultado);
                    return;
                }
                if (volumeBut.Checked)
                {
                    double resultado = Math.Pow(Convert.ToDouble(baseforma), 3);
                    result.Text = Convert.ToString(resultado);
                    return;
                }
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

            if (opcoesForma.Text == "Paralelepípedo")
            {
                volRet.Enabled = true;
            }
            else
            {
                volRet.Enabled = false;
            }
            if (opcoesForma.Text == "Quadrado" || opcoesForma.Text == "Retângulo")
            {
                volumeBut.Enabled = false;
            }
            else
            {
                volumeBut.Enabled = true;
            }
        }
    }
}
