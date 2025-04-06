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
    public partial class frmMetodo : Form
    {
        public frmMetodo()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            if(!ValidarCampos())
            {
                MessageBox.Show("Preencher TODOS OS CAMPOS");
            }
            else
            {
                double numero1, numero2, resultado;

                numero1 = Convert.ToDouble(txtNumero1.Text);
                numero2 = Convert.ToDouble(txtNumero2.Text);

                resultado = CalcularSoma(numero1, numero2);
                txtResultadoSoma.Text = Convert.ToString(resultado);
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtNumero1.Text.Trim() == string.Empty || txtNumero2.Text.Trim() == string.Empty)
            {
                flag = false;
            }

            return flag;
        }

        private double CalcularSoma(double n1, double n2)
        {
            double resultado;
            resultado = n1 + n2;
            return resultado;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultadoSoma.Clear();
        }
    }
}
