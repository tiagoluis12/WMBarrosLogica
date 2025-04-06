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
    public partial class frmMetodo1 : Form
    {
        public frmMetodo1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Preencher todos os Campos!");
            }
            else
            {
                double n1, n2, n3, n4, n5, MultiplicarConta, somaTresPrimeiros;

                n1 = Convert.ToDouble(txtN1.Text);
                n2 = Convert.ToDouble(txtN2.Text);
                n3 = Convert.ToDouble(txtN3.Text);
                n4 = Convert.ToDouble(txtN4.Text);
                n5 = Convert.ToDouble(txtN5.Text);

                somaTresPrimeiros = CalcularNumeros(n1, n2, n3);
                MultiplicarConta = MultiplicarParametros(somaTresPrimeiros, n4, n5);

                txtResultado.Text = Convert.ToString(MultiplicarConta);
            }

        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtN1.Text.Trim() == string.Empty || txtN2.Text.Trim() == string.Empty ||
                txtN3.Text.Trim() == string.Empty || txtN4.Text.Trim() == string.Empty) ;
            {
                flag = false;
            }

            return flag;
        }

        private double CalcularNumeros(double n1, double n2, double n3)
        {
            double somaTresPrimeiros;
            somaTresPrimeiros = (n1 + n2 + n3);
            return somaTresPrimeiros;
        }

        private double MultiplicarParametros(double somaTresPrimeiros, double n4, double n5)
        {
            double MultiplicarConta;
            MultiplicarConta = somaTresPrimeiros * n4 * n5;
            return MultiplicarConta;
            ;
        }


    }
}
