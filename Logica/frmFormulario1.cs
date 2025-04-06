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
    public partial class frmFormulario1 : Form
    {
        public frmFormulario1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo ( nome do campo)");
                txtProduto.Clear();
                txtProduto.Focus();
            }
            else if (txtCompra.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo (Valor da compra)");
                txtCompra.Clear();
                txtCompra.Focus();
            }
            else if (txtVenda.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo (Valor da Venda)");
                txtVenda.Clear();
                txtVenda.Focus();
            }
            else if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo (Descricao)");
                txtDescricao.Clear();
                txtDescricao.Focus();
            }
            else
            {
                //OPCAO 1 \
                string produto, compra, venda, descricao;

                produto = txtProduto.Text;
                compra = txtCompra.Text;
                venda = txtVenda.Text;
                descricao = txtDescricao.Text;

                MessageBox.Show("Produto: " + produto +
                    "Compra: " + compra +
                    "Venda: " + venda +
                    "Descricao: " + descricao);

                //OPCAO 2

                //MessageBox.Show
                //    ("Produto: " + txtProduto.Text + "\nCompra: " + txtCompra.Text +
                //    "\nVenda: " + txtVenda.Text + "\nDescricao: " + txtDescricao.Text);
            }
        }
    }
}
