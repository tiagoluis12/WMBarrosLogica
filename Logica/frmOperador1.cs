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
    public partial class frmOperador1 : Form
    {
        public frmOperador1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == string.Empty || txtN2.Text.Trim() == string.Empty ||
                txtN3.Text.Trim() == string.Empty || txtN4.Text.Trim() == string.Empty ||
                txtN5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos!");
            }
            else
            {
                decimal  n1, n2, n3, n4, n5, resultado;
                try
                {
                    n1 = Convert.ToDecimal(txtN1.Text);
                    n2 = Convert.ToDecimal(txtN2.Text);
                    n3 = Convert.ToDecimal(txtN3.Text);
                    n4 = Convert.ToDecimal(txtN4.Text);
                    n5 = Convert.ToDecimal(txtN5.Text);

                    resultado = (n1 * n2) + (n3 * n4 * n5);

                    lblResultado.Text = Convert.ToString(resultado);

                    if(resultado > 100)
                    {
                        MessageBox.Show("Acima de 100");
                    }
                    else if (resultado > 100)
                    {
                        MessageBox.Show("Abaixo de 100");
                    }
                    else if (resultado == 100)
                    {
                        MessageBox.Show("Igual a 100");
                    }
                }
                catch
                {
                    MessageBox.Show("Preencher os numeros corretamentes!");
                }
            }
        }
    }
}
