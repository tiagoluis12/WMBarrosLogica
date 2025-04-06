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
    public partial class frmOperador3 : Form
    {
        public frmOperador3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSalario.Text.Trim() == string.Empty || txtPorcentagem.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Preencher todos os campos!");
                }

                else if (Convert.ToDecimal(txtSalario.Text) <= 0 || Convert.ToDecimal(txtPorcentagem.Text) <= 0)
                {
                    MessageBox.Show("Os valores apresentado nao pode ser negativo ou 0!");
                    txtSalario.Clear();
                    txtSalario.Focus();
                    txtPorcentagem.Clear();
                }
                else
                {
                    decimal salario, porcentagem, aumentoDoSalario, salarioFinal;

                    salario = Convert.ToDecimal(txtSalario.Text);
                    porcentagem = Convert.ToDecimal(txtPorcentagem.Text);

                    aumentoDoSalario = (salario * porcentagem) / 100;
                    salarioFinal = salario + porcentagem;

                    txtNovoSalario.Text = Convert.ToString(salarioFinal);

                    if (aumentoDoSalario >= 0 && aumentoDoSalario < 101)
                    {
                        txtClassificacao.Text = "Aumento Nivel 1";
                    }
                    else if (aumentoDoSalario >= 101 && aumentoDoSalario < 201)
                    {
                        txtClassificacao.Text = "Aumento Nivel 2";
                    }
                    else if (aumentoDoSalario >= 201 && aumentoDoSalario < 301)
                    {
                        txtClassificacao.Text = "Aumento Nivel 3";
                    }
                    else if (aumentoDoSalario >= 301 && aumentoDoSalario < 401)
                    {
                        txtClassificacao.Text = "Aumento Nivel 4";
                    }
                    else if (aumentoDoSalario > 401)
                    {
                        txtClassificacao.Text = "Aumento Nivel 5";
                    }
                }
            }




            catch
            {
                txtSalario.Clear();
                txtSalario.Focus();
                txtPorcentagem.Clear();
                MessageBox.Show("Preencher os campos corretamente!");
            }

            }
        }
    }

