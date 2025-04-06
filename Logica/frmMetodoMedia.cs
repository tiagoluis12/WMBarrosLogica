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
    public partial class frmMetodoMedia : Form
    {
        public frmMetodoMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                decimal nota1, nota2, nota3, nota4, media;
                string classificacao = "";

                try
                {
                    nota1 = Convert.ToDecimal(txtNota1.Text);
                    nota2 = Convert.ToDecimal(txtNota2.Text);
                    nota3 = Convert.ToDecimal(txtNota3.Text);
                    nota4 = Convert.ToDecimal(txtNota4.Text);

                    if(VerificarDigitosDasNotas(nota1, nota2, nota3, nota4))
                    {
                        media = CalcularMedia(nota1, nota2, nota3, nota4);
                        classificacao = VerificarClassificacao(media);
                        MostrarResultado(media, classificacao);
                    }
                }

                catch
                {
                    MessageBox.Show("Digitar corretamente as notas!");
                }
            }
        }

        private void MostrarResultado(decimal media, string classificacao)
        {
            lblClassificacao.Text = classificacao;
            lblMedia.Text = media.ToString();
        }

        private string VerificarClassificacao(decimal media)
        {
            string classificacao = "";

            if(media >= 0 && media < 40)
            {
                classificacao = "REPROVADO";
                lblClassificacao.ForeColor = Color.Red;
            }
            else if (media >= 40 && media < 60)
            {
                classificacao = "EXAME";
                lblClassificacao.ForeColor = Color.Orange;
            }
            if (media >= 60)
            {
                classificacao = "APROVADO";
                lblClassificacao.ForeColor = Color.Blue;
            }

            return classificacao;
        }

        private decimal CalcularMedia(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal media;

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            return media;
        }

        private bool VerificarDigitosDasNotas(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            bool flag = true;

            if(nota1 > 100 || nota1 < 0)
            {
                MessageBox.Show("Digitar a nota 1 corretamente!");
                    flag = false;
            }
            else if (nota2 > 100 || nota2 < 0)
            {
                MessageBox.Show("Digitar a nota 2 corretamente!");
                flag = false;
            }
            else if (nota3 > 100 || nota3 < 0)
            {
                MessageBox.Show("Digitar a nota 3 corretamente!");
                flag = false;
            }
            else if (nota4 > 100 || nota4 < 0)
            {
                MessageBox.Show("Digitar a nota 4 corretamente!");
                flag = false;
            }

            return flag;
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtNota1.Text.Trim() == string.Empty || txtNota2.Text.Trim() == string.Empty ||
                txtNota3.Text.Trim() == string.Empty || txtNota4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todas as notas!");
                flag = false;
            }

            return flag;
        }
    }
}
