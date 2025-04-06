using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Properties;

namespace Logica
{
    public partial class frmOperador4 : Form
    {
        public frmOperador4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                 pctBox.Image = null;

                if (txtPeso.Text.Trim() == string.Empty || txtAltura.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Preencher os campos corretamente!");
                }

                else
                {
                    decimal peso, altura, imc, imcFinal;

                    peso = Convert.ToDecimal(txtPeso.Text);
                    altura = Convert.ToDecimal(txtAltura.Text);

                    imc = peso / (altura * altura);
                    imcFinal = peso / altura * altura;

                    txtIMC.Text = Convert.ToString(imc);

                    if (imc >= 0 && imc < 21)
                    {
                        txtClassificacao.Text = "Magro";
                        pctBox.Image = Resources.magro;
                    }
                    else if (imc >= 21 && imc < 26)
                    {
                        txtClassificacao.Text = "Peso ideal";
                        pctBox.Image = Resources.peso_ideal;
                    }
                    else if (imc >= 26 && imc <= 31)
                    {
                        txtClassificacao.Text = "Obeso";
                        pctBox.Image = Resources.obeso;
                    }
                    else if (imc > 30)
                    {
                        txtClassificacao.Text = "Muito obeso";
                        pctBox.Image = Resources.muito_obeso;
                    }
                }
            }
            catch
            {
                txtPeso.Clear();
                txtPeso.Focus();
                txtAltura.Clear();
                MessageBox.Show("Preencher os campos corretamente!");
            }
        }
    }
}
