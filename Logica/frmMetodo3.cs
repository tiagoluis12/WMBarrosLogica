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
    public partial class frmMetodo3 : Form
    {
        public frmMetodo3()
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
                decimal totalProduto1, totalProduto2, totalProduto3, totalProduto4, totalProduto5,
              quantidade1, quantidade2, quantidade3, quantidade4, quantidade5,
              produto1, produto2, produto3, produto4, produto5,
              ValorDosProdutos;

                produto1 = Convert.ToInt32(txtValorDoProduto1.Text);
                produto2 = Convert.ToInt32(txtValorDoProduto2.Text);
                produto3 = Convert.ToInt32(txtValorDoProduto3.Text);
                produto4 = Convert.ToInt32(txtValorDoProduto4.Text);
                produto5 = Convert.ToInt32(txtValorDoProduto5.Text);

                quantidade1 = Convert.ToInt32(txtQuantidade1.Text);
                quantidade2 = Convert.ToInt32(txtQuantidade2.Text);
                quantidade3 = Convert.ToInt32(txtQuantidade3.Text);
                quantidade4 = Convert.ToInt32(txtQuantidade4.Text);
                quantidade5 = Convert.ToInt32(txtQuantidade5.Text);

                totalProduto1 = CalcularValorDosProdutos(produto1, quantidade1);
                totalProduto2 = CalcularValorDosProdutos(produto2, quantidade2);
                totalProduto3 = CalcularValorDosProdutos(produto3, quantidade3);
                totalProduto4 = CalcularValorDosProdutos(produto4, quantidade4);
                totalProduto5 = CalcularValorDosProdutos(produto5, quantidade5);


                ValorDosProdutos = CalcularValorTotal(totalProduto1, totalProduto2, totalProduto3, totalProduto4, totalProduto5);

                MostrarResultados(totalProduto1, totalProduto2, totalProduto3, totalProduto4, totalProduto5, ValorDosProdutos);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private decimal CalcularValorDosProdutos(decimal produto, decimal quantidade)
        {
            decimal ValorDosProdutos;
            ValorDosProdutos = produto * quantidade;
            return ValorDosProdutos;
        }

        private decimal CalcularValorTotal(decimal totalDosProdutos1, decimal totalDosProdutos2, decimal totalDosProdutos3, decimal totalDosProdutos4, decimal totalDosProdutos5)
        {
            decimal ValorTotalDosProdutos;
            ValorTotalDosProdutos = totalDosProdutos1 + totalDosProdutos2 + totalDosProdutos3 + totalDosProdutos3 + totalDosProdutos5;
            return ValorTotalDosProdutos;
        }

        private void MostrarResultados(decimal MostrarResultado1, decimal MostrarResultado2, decimal MostrarResultado3, decimal MostrarResultado4, decimal MostrarResultado5, decimal ValorDosProdutos)
        {
            txtValorTotalProduto1.Text = MostrarResultado1.ToString("C", new CultureInfo("pt-BR"));
            txtValorTotalProduto2.Text = MostrarResultado2.ToString("C", new CultureInfo("pt-BR"));
            txtValorTotalProduto3.Text = MostrarResultado3.ToString("C", new CultureInfo("pt-BR"));
            txtValorTotalProduto4.Text = MostrarResultado4.ToString("C", new CultureInfo("pt-BR"));
            txtValorTotalProduto5.Text = MostrarResultado5.ToString("C", new CultureInfo("pt-BR"));

            txtValorTotalFinal.Text = ValorDosProdutos.ToString("C", new CultureInfo("pt-BR"));
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtProduto1.Text.Trim() == string.Empty || txtProduto2.Text.Trim() == string.Empty || txtProduto3.Text.Trim() == string.Empty ||
                txtProduto4.Text.Trim() == string.Empty || txtProduto5.Text.Trim() == string.Empty || txtQuantidade1.Text.Trim() == string.Empty ||
                txtQuantidade2.Text.Trim() == string.Empty || txtQuantidade3.Text.Trim() == string.Empty || txtQuantidade4.Text.Trim() == string.Empty ||
                txtQuantidade5.Text.Trim() == string.Empty || txtValorDoProduto1.Text.Trim() == string.Empty || txtValorDoProduto2.Text.Trim() == string.Empty ||
                txtValorDoProduto3.Text.Trim() == string.Empty || txtValorDoProduto4.Text.Trim() == string.Empty || txtValorDoProduto5.Text.Trim() == string.Empty)
            {
                flag = false;
            }

            return flag;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto1.Clear(); txtProduto2.Clear(); txtProduto3.Clear(); txtProduto4.Clear(); txtProduto5.Clear();
            txtQuantidade1.Clear(); txtQuantidade2.Clear(); txtQuantidade3.Clear(); txtQuantidade4.Clear(); txtQuantidade5.Clear();
            txtValorDoProduto1.Clear(); txtValorDoProduto2.Clear(); txtValorDoProduto3.Clear(); txtValorDoProduto4.Clear(); txtValorDoProduto5.Clear();

            txtValorTotalProduto1.Clear(); txtValorTotalProduto2.Clear(); txtValorTotalProduto3.Clear(); txtValorTotalProduto4.Clear(); txtValorTotalProduto5.Clear();
            txtValorTotalFinal.Clear();
        }
    }
}
