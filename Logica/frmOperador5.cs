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
    public partial class frmOperador5 : Form
    {
        public frmOperador5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAnterior.Text.Trim() == string.Empty || txtAtual.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Preencher os campos corretamente!");
                }
                else
                {
                    decimal slAnterior, slAtual, aumentoAnterior, aumentoAtual;

                    slAnterior = Convert.ToDecimal(txtAnterior.Text);
                    slAtual = Convert.ToDecimal(txtAtual.Text);

                    aumentoAnterior = (slAnterior * 15) / 100;
                    aumentoAtual = (slAtual * 18) / 100;

                    lblAumentoAnterior.Text = Convert.ToString(aumentoAnterior);
                    lblAumentoAtual.Text = Convert.ToString(aumentoAtual);

                    if(aumentoAnterior >= 0 && aumentoAnterior < 101)
                    {
                        txtClassificacao.Text = "Aumento RUIM";
                    }
                    else if (aumentoAnterior >= 101 && aumentoAnterior < 201)
                    {
                        txtClassificacao.Text = "Aumento RAZOAVEL";
                    }
                    else if (aumentoAnterior >= 201 && aumentoAnterior < 301)
                    {
                        txtClassificacao.Text = "Aumento BOM";
                    }
                    else if (aumentoAnterior >= 301 && aumentoAnterior < 401)
                    {
                        txtClassificacao.Text = "Aumento OTIMO";
                    }
                    else if (aumentoAnterior > 401)
                    {
                        txtClassificacao.Text = "Aumento EXCELENTE";
                    }

                }
            }
            catch
            {
                txtAnterior.Clear();
                txtAnterior.Focus();
                txtAtual.Focus();
                MessageBox.Show("Preencher os campos Corretamente!");
            }
        }
    }
}
