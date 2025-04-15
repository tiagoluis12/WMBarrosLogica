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
    public partial class frmEnumExemplo : Form
    {
        public frmEnumExemplo()
        {
            InitializeComponent();
        }

        private enum TipoCalculo
        {
            Aumento,
            Desconto
        }

        private double CalcularValor(double valor, double porcentagem, TipoCalculo tipoCalculo)
        {
            double resultado = 0;

            switch (tipoCalculo)
            {
                case TipoCalculo.Aumento:
                    resultado = valor + (valor * porcentagem) / 100;
                    break;

                case TipoCalculo.Desconto:
                    resultado = valor - (valor * porcentagem) / 100;
                    break;
            }

            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MostrarResultado();
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtValor.Text.Trim() == string.Empty || txtPorcentagem.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os Campos!");
                flag = false;
            }

            if(!rbtAumento.Checked && !rbtDesconto.Checked)
            {
                MessageBox.Show("Selecione uma opcao!");
                flag = false;
            }

            return flag;
        }

        private void MostrarResultado()
        {
            try
            {
                double valor, porcentagem, resultadoFinal = 0;

                valor = Convert.ToDouble(txtValor.Text);
                porcentagem = Convert.ToDouble(txtPorcentagem.Text);

                if (rbtAumento.Checked)
                {
                    resultadoFinal = CalcularValor(valor, porcentagem, TipoCalculo.Aumento);
                }
                else if (rbtDesconto.Checked)
                {
                    resultadoFinal = CalcularValor(valor, porcentagem, TipoCalculo.Desconto);
                }

                lblResultado.Text = resultadoFinal.ToString("C2");
            }
            catch
            {
                MessageBox.Show("Digitar somente Numeros!");
            }
            
        }
    }
}
