using System;
using System.Windows.Forms;

namespace ConversorDeTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-------------- inicio da verificação das siglas------------------

        // verifica qual tipo de temperatura de entrada foi escolhido e adiciona sua sigla.

        private void rbTCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblTemperatura.Text = "C°";
        }

        private void rbTKelvins_CheckedChanged(object sender, EventArgs e)
        {
            lblTemperatura.Text = "K°";
        }

        private void rbTFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lblTemperatura.Text = "F°";
        }
        // Verifica qual tipo de temperatura de saida foi escolhido e adiciona sua sigla.

        private void rbRCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "C°";
        }

        private void rbRKelvins_CheckedChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "K°";
        }

        private void rbRFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "F°";
        }
        //----------------- Fim da verificação das siglas --------------

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // identifica se foi digitado algum valor.

            if (txtTemperatura.Text.Length == 0)
            {
                MessageBox.Show("Digite uma temperatura para conversão !!!", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                //Cria as variaveis e converte o texto para numeros.

                double ValorEntrada = Convert.ToDouble(txtTemperatura.Text);
                double soma;

                // Verifica se Celsius foi selecionado se verdadeiro verifica a temperatura de saida e faz a conversão.
                if (rbTCelsius.Checked == true)
                {
                    if (rbRKelvins.Checked == true)
                    {
                        soma = ValorEntrada + 273.15;
                        txtResultado.Text = Convert.ToString(soma);

                    }
                    else if (rbRFahrenheit.Checked == true)
                    {
                        soma = (ValorEntrada * 9 / 5) + 32;
                        txtResultado.Text = Convert.ToString(soma);
                    }

                    else if (rbRCelsius.Checked == true)
                    {
                        MessageBox.Show("Não pode ser convertido pela mesma temperatura de entrada!!!", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Escolha um tipo de temperatura para conversão", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                // Verifica se Kelvins foi selecionado se verdadeiro verifica a temperatura de saida e faz a conversão.
                if (rbTKelvins.Checked == true)
                {
                    if (rbRCelsius.Checked == true)
                    {
                        soma = ValorEntrada - 273.15;
                        txtResultado.Text = Convert.ToString(soma);

                    }
                    else if (rbRFahrenheit.Checked == true)
                    {
                        soma = (ValorEntrada - 273.15) * 9 / 5 + 32;
                        txtResultado.Text = Convert.ToString(soma);
                    }

                    else if (rbRKelvins.Checked == true)
                    {
                        MessageBox.Show("Não pode ser convertido pela mesma temperatura de entrada!!!", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // se nunhuma opção for escolhida.

                        MessageBox.Show("Escolha uma temperatura para conversão", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Verifica se Fahrenheit foi selecionado se verdadeiro verifica a temperatura de saida e faz a conversão.
                if (rbTFahrenheit.Checked == true)
                {
                    if (rbRKelvins.Checked == true)
                    {
                        soma = (ValorEntrada - 32) * 5 / 9 + 273.15;
                        txtResultado.Text = Convert.ToString(soma);

                    }
                    else if (rbRCelsius.Checked == true)
                    {
                        soma = (ValorEntrada - 32) * 5 / 9;
                        txtResultado.Text = Convert.ToString(soma);
                    }

                    else if (rbRFahrenheit.Checked == true)
                    {
                        MessageBox.Show("Não pode ser convertido pela mesma temperatura de entrada!!!", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // se nunhuma opção for escolhida.

                        MessageBox.Show("Escolha uma temperatura para conversão", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }// ----------- Fim do botão de converter -------------------

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Faz a limpeza do fomulario.

            txtTemperatura.Text = null;
            txtResultado.Text = null;
            rbTCelsius.Checked = false;
            rbTKelvins.Checked = false;
            rbTFahrenheit.Checked = false;
            rbRCelsius.Checked = false;
            rbRKelvins.Checked = false;
            rbRFahrenheit.Checked = false;

        } // ---------- Fim do botão de limpar ------------

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
