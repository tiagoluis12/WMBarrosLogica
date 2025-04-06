using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public partial class frmOperador6 : Form
    {
        public frmOperador6()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtVelocidade.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informar a velocidade do carro!");
                }
                else
                {
                    decimal velocidadeCarro, velocidadePermitida, totalVelocidade;

                    velocidadeCarro = Convert.ToDecimal(txtVelocidade.Text);

                    velocidadePermitida = (velocidadeCarro * 2) / 100;
                    totalVelocidade = velocidadeCarro - velocidadePermitida;


                    if(totalVelocidade < 51)
                    {
                        txtClassificacao.Text = "Sem Multa";
                    }
                    else if (totalVelocidade >= 51 && totalVelocidade < 60)
                    {
                        txtClassificacao.Text = "Multa 3 pontos";
                    }
                    else if (totalVelocidade >= 61 && totalVelocidade < 70)
                    {
                        txtClassificacao.Text = "Multa 5 pontos";
                    }
                    else if (totalVelocidade >= 71 && totalVelocidade < 80)
                    {
                        txtClassificacao.Text = "Multa 10 pontos";
                    }
                    else if (totalVelocidade >= 81 && totalVelocidade < 90)
                    {
                        txtClassificacao.Text = "Multa 15 pontos";
                    }
                    else if (totalVelocidade >= 91 && totalVelocidade < 100)
                    {
                        txtClassificacao.Text = "Multa 18 pontos";
                    }
                    else if (totalVelocidade > 100)
                    {
                        txtClassificacao.Text = "Multa 20 pontos e suspensao da carteira";
                    }
                }
            }
            catch
            {
                txtVelocidade.Clear();
                txtVelocidade.Focus();
                MessageBox.Show("Preencher os campos corretamente!");
            }
        }
    }
}
