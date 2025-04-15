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
    public partial class frmMetodo2 : Form
    {
        public frmMetodo2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Preencher Todos os Campos!");
            }
            else
            {
                decimal metro, ValorPorMetro, resultadoTotal;

                metro = Convert.ToDecimal(txtTamanho.Text);
                ValorPorMetro = Convert.ToDecimal(txtValor.Text);

                resultadoTotal = CalcularValorTotal(metro, ValorPorMetro);

                lblResultado.Text = resultadoTotal.ToString("C", new CultureInfo("pt-BR"));
            }
        }

        private decimal CalcularValorTotal(decimal metro, decimal valorPorMetro)
        {
            decimal resultadoTotal;
            resultadoTotal = metro * valorPorMetro;
            return resultadoTotal;
        }

        private bool ValidarCampos()

        {
            bool flag = true;

            if(txtTamanho.Text.Trim() == string.Empty || txtValor.Text.Trim() == string.Empty)
            {
                flag = false;
            }

            return flag;
        }
    }
}
