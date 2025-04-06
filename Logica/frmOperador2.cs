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
    public partial class frmOperador2 : Form
    {
        public frmOperador2()
        {
            InitializeComponent();
        }

        private void btnVerificar(object sender, EventArgs e)
        {
           if(txtN1.Text.Trim() == string.Empty || txtN2.Text.Trim() == string.Empty || txtN3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos");
            }
           else
            {
                decimal n1, n2, n3, resultadoN2;
                try
                {
                    n1 = Convert.ToDecimal(txtN1.Text);
                    n2 = Convert.ToDecimal(txtN2.Text);
                    n3 = Convert.ToDecimal(txtN3.Text);

                    resultadoN2 = n2 / 2;

                    if(n1 <= resultadoN2 && resultadoN2 <= n3)
                    {
                        MessageBox.Show(" O numero " + resultadoN2 + " esta entre o numero " + n1 + " e " + n3);
                    }
                    else if(n1 >= resultadoN2 && resultadoN2 >= n3)
                    {
                        txtN1.Text = Convert.ToString(n3);
                        txtN3.Text = Convert.ToString(n1);
                        MessageBox.Show(" O numero " + resultadoN2 + " esta entre o numero " + n3 + " e " + n1);
                    }
                    else
                    {
                        MessageBox.Show(" O numero " + resultadoN2 + " nao esta entre o numero " + n1 + " e " + n3);
                    }
                }
                catch
                {
                    MessageBox.Show("Preencher corretamente os numeros");
                }
            }
        }
    }
}
