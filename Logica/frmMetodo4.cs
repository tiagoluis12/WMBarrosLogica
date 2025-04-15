using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public partial class frmMetodo4 : Form
    {
        public frmMetodo4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Preencher todos os Campos!");
            }
            try
            {

                string nome = txtNome.Text;
                double valorCompra = Convert.ToDouble(txtValorCompra.Text);
                int numeroParcelas = Convert.ToInt32(txtParcelas.Text);
                double taxaJuros = Convert.ToDouble(txtJuros.Text);

                double valorParcela = CalcularParcelaComJuros(valorCompra, taxaJuros, numeroParcelas);
                double valorTotalComJuros = CalcularTotalComJuros(valorParcela, numeroParcelas);

                ExibirResultado(valorTotalComJuros);
            }
            catch
            {

            }
        }
        private double CalcularParcelaComJuros(double valor, double juros, int parcelas)
        {
            double taxa;
            taxa = juros / 100;
            return valor * (1 + taxa) / parcelas;
        }

        private double CalcularTotalComJuros(double valorParcela, int parcelas)
        {
            double TotalComJuros;
            TotalComJuros = valorParcela * parcelas;
            return TotalComJuros;
        }

        private void ExibirResultado(double valorTotal)
        {
            lblResultado.Text = "Valor total com juros: " + valorTotal.ToString("C", new CultureInfo("pt-BR"));

            if (valorTotal < 2000)
            {
                lblFaixa.Text = "TOTAL DE COMPRAS: Abaixo de R$ 2000,00";
            }
            else if (valorTotal <= 3000)
            {
                lblFaixa.Text = "TOTAL DE COMPRAS: Entre R$ 2001 - 3000";
            }
            else
            {
                lblFaixa.Text = "TOTAL DE COMPRAS: Acima de R$ 3000";
            }
        }
        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtNome.Text.Trim() == string.Empty || txtParcelas.Text.Trim() == string.Empty ||
                txtValorCompra.Text.Trim() == string.Empty || txtJuros.Text.Trim() == string.Empty)
            {
                flag = false;
            }

            return flag;
        }
    }
}
