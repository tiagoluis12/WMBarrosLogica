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
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Ganhos
            if(txtGanhosJan.Text.Trim() == string.Empty)
            {
                txtGanhosJan.Clear();
                txtGanhosJan.Focus();
                MessageBox.Show("Preencher os Ganhos de (Jan)");
            }
            else if(txtGanhosFev.Text.Trim() == string.Empty)
            {
                txtGanhosFev.Clear();
                txtGanhosFev.Focus();
                MessageBox.Show("Preencher os Ganhos de (Fev)");
            }
            else if (txtGanhosMar.Text.Trim() == string.Empty)
            {
                txtGanhosMar.Clear();
                txtGanhosMar.Focus();
                MessageBox.Show("Preencher os Ganhos de (Mar)");
            }
            else if (txtGanhosAbr.Text.Trim() == string.Empty)
            {
                txtGanhosAbr.Clear();
                txtGanhosAbr.Focus();
                MessageBox.Show("Preencher os Ganhos de (Abr)");
            }
            else if (txtGanhosMai.Text.Trim() == string.Empty)
            {
                txtGanhosMai.Clear();
                txtGanhosMai.Focus();
                MessageBox.Show("Preencher os Ganhos de (Mai)");
            }
            else if (txtGanhosJun.Text.Trim() == string.Empty)
            {
                txtGanhosJun.Clear();
                txtGanhosJun.Focus();
                MessageBox.Show("Preencher os Ganhos de (Jun)");
            }
            else if (txtGanhosJul.Text.Trim() == string.Empty)
            {
                txtGanhosJul.Clear();
                txtGanhosJul.Focus();
                MessageBox.Show("Preencher os Ganhos de (Jul)");
            }
            else if (txtGanhosAgo.Text.Trim() == string.Empty)
            {
                txtGanhosAgo.Clear();
                txtGanhosAgo.Focus();
                MessageBox.Show("Preencher os Ganhos de (Ago)");
            }
            else if (txtGanhosSet.Text.Trim() == string.Empty)
            {
                txtGanhosSet.Clear();
                txtGanhosSet.Focus();
                MessageBox.Show("Preencher os Ganhos de (Set)");
            }
            else if (txtGanhosOut.Text.Trim() == string.Empty)
            {
                txtGanhosOut.Clear();
                txtGanhosOut.Focus();
                MessageBox.Show("Preencher os Ganhos de (Out)");
            }
            else if (txtGanhosNov.Text.Trim() == string.Empty)
            {
                txtGanhosNov.Clear();
                txtGanhosNov.Focus();
                MessageBox.Show("Preencher os Ganhos de (Nov)");
            }
            else if (txtGanhosDez.Text.Trim() == string.Empty)
            {
                txtGanhosDez.Clear();
                txtGanhosDez.Focus();
                MessageBox.Show("Preencher os Ganhos de (Dez)");
            }

            //Gastos
            if (txtGastosJan.Text.Trim() == string.Empty)
            {
                txtGastosJan.Clear();
                txtGastosJan.Focus();
                MessageBox.Show("Preencher os Gastos de (Jan)");
            }
            else if (txtGastosFev.Text.Trim() == string.Empty)
            {
                txtGastosFev.Clear();
                txtGastosFev.Focus();
                MessageBox.Show("Preencher os Gastos de (Fev)");
            }
            else if (txtGastosMar.Text.Trim() == string.Empty)
            {
                txtGastosMar.Clear();
                txtGastosMar.Focus();
                MessageBox.Show("Preencher os Gastos de (Mar)");
            }
            else if (txtGastosAbr.Text.Trim() == string.Empty)
            {
                txtGastosAbr.Clear();
                txtGastosAbr.Focus();
                MessageBox.Show("Preencher os Gastos de (Abr)");
            }
            else if (txtGastosMai.Text.Trim() == string.Empty)
            {
                txtGastosMai.Clear();
                txtGastosMai.Focus();
                MessageBox.Show("Preencher os Gastos de (Mai)");
            }
            else if (txtGastosJun.Text.Trim() == string.Empty)
            {
                txtGastosJun.Clear();
                txtGastosJun.Focus();
                MessageBox.Show("Preencher os Gastos de (Jun)");
            }
            else if (txtGastosJul.Text.Trim() == string.Empty)
            {
                txtGastosJul.Clear();
                txtGastosJul.Focus();
                MessageBox.Show("Preencher os Gastos de (Jul)");
            }
            else if (txtGastosAgo.Text.Trim() == string.Empty)
            {
                txtGastosAgo.Clear();
                txtGastosAgo.Focus();
                MessageBox.Show("Preencher os Gastos de (Ago)");
            }
            else if (txtGastosSet.Text.Trim() == string.Empty)
            {
                txtGastosSet.Clear();
                txtGastosSet.Focus();
                MessageBox.Show("Preencher os Gastos de (Set)");
            }
            else if (txtGastosOut.Text.Trim() == string.Empty)
            {
                txtGastosOut.Clear();
                txtGastosOut.Focus();
                MessageBox.Show("Preencher os Gastos de (Out)");
            }
            else if (txtGastosNov.Text.Trim() == string.Empty)
            {
                txtGastosNov.Clear();
                txtGastosNov.Focus();
                MessageBox.Show("Preencher os Gastos de (Nov)");
            }
            else if (txtGastosDez.Text.Trim() == string.Empty)
            {
                txtGastosDez.Clear();
                txtGastosDez.Focus();
                MessageBox.Show("Preencher os Gastos de (Dez)");
            }

            else
            {
                double ganhosJan, ganhosFev, ganhosMar, ganhosAbr, ganhosMai, ganhosJun,
                    ganhosJul, ganhosAgo, ganhosSet, ganhosOut, ganhosNov, ganhosDez, gastosJan,
                    gastosFev, gastosMar, gastosAbr, gastosMai, gastosJun, gastosJul, gastosAgo,
                    gastosSet, gastosOut, gastosNov, gastosDez, lucroJan, lucroFev, lucroMar, lucroAbr,
                    lucroMai, lucroJun, lucroJul, lucroAgo, lucroSet, lucroOut, lucroNov, lucroDez, totalLucroAno,
                    TotalGanhosAno, TotalGastosAno;
                try
                {
                    // Ganhos
                    ganhosJan = Convert.ToDouble(txtGanhosJan.Text);
                    ganhosFev = Convert.ToDouble(txtGanhosFev.Text);
                    ganhosMar = Convert.ToDouble(txtGanhosMar.Text);
                    ganhosAbr = Convert.ToDouble(txtGanhosAbr.Text);
                    ganhosMai = Convert.ToDouble(txtGanhosMai.Text);
                    ganhosJun = Convert.ToDouble(txtGanhosJun.Text);
                    ganhosJul = Convert.ToDouble(txtGanhosJul.Text);
                    ganhosAgo = Convert.ToDouble(txtGanhosAgo.Text);
                    ganhosSet = Convert.ToDouble(txtGanhosSet.Text);
                    ganhosOut = Convert.ToDouble(txtGanhosOut.Text);
                    ganhosNov = Convert.ToDouble(txtGanhosNov.Text);
                    ganhosDez = Convert.ToDouble(txtGanhosDez.Text);

                    // Gastos
                    gastosJan = Convert.ToDouble(txtGastosJan.Text);
                    gastosFev = Convert.ToDouble(txtGastosFev.Text);
                    gastosMar = Convert.ToDouble(txtGastosMar.Text);
                    gastosAbr = Convert.ToDouble(txtGastosAbr.Text);
                    gastosMai = Convert.ToDouble(txtGastosMai.Text);
                    gastosJun = Convert.ToDouble(txtGastosJun.Text);
                    gastosJul = Convert.ToDouble(txtGastosJul.Text);
                    gastosAgo = Convert.ToDouble(txtGastosAgo.Text);
                    gastosSet = Convert.ToDouble(txtGastosSet.Text);
                    gastosOut = Convert.ToDouble(txtGastosOut.Text);
                    gastosNov = Convert.ToDouble(txtGastosNov.Text);
                    gastosDez = Convert.ToDouble(txtGastosDez.Text);

                    TotalGanhosAno = ganhosJan + ganhosFev + ganhosMar + ganhosAbr + ganhosMai + ganhosJun + ganhosJul
                                    + ganhosAgo + ganhosSet + ganhosOut + ganhosNov + ganhosDez;
                    TotalGastosAno = gastosJan + gastosFev + gastosMar + gastosAbr + gastosMai + gastosJun + gastosJul
                                    + gastosAgo + gastosSet + gastosOut + gastosNov + gastosDez;

                    // lucros
                    lucroJan = ganhosJan - gastosJan;
                    lucroFev = ganhosFev - gastosFev;
                    lucroMar = ganhosMar - gastosMar;
                    lucroAbr = ganhosAbr - gastosAbr;
                    lucroMai = ganhosMai - gastosMai;
                    lucroJun = ganhosJun - gastosJun;
                    lucroJul = ganhosJul - gastosJul;
                    lucroAgo = ganhosAgo - gastosAgo;
                    lucroSet = ganhosSet - gastosSet;
                    lucroOut = ganhosOut - gastosOut;
                    lucroNov = ganhosNov - gastosNov;
                    lucroDez = ganhosDez - gastosDez;

                    totalLucroAno = lucroJan + lucroFev + lucroMar + lucroAbr + lucroMai + lucroJun + lucroJul
                                    + lucroAgo + lucroSet + lucroOut + lucroNov + lucroDez;


                    // 
                    txtLucroJan.Text = Convert.ToString(lucroJan);
                    txtLucroFev.Text = Convert.ToString(lucroFev);
                    txtLucroMar.Text = Convert.ToString(lucroMar);
                    txtLucroAbr.Text = Convert.ToString(lucroAbr);
                    txtLucroMai.Text = Convert.ToString(lucroMai);
                    txtLucroJun.Text = Convert.ToString(lucroJun);
                    txtLucroJul.Text = Convert.ToString(lucroJul);
                    txtLucroAgo.Text = Convert.ToString(lucroAgo);
                    txtLucroSet.Text = Convert.ToString(lucroSet);
                    txtLucroOut.Text = Convert.ToString(lucroOut);
                    txtLucroNov.Text = Convert.ToString(lucroNov);
                    txtLucroDez.Text = Convert.ToString(lucroDez);

                    txtTotalGanhosAno.Text = Convert.ToString(TotalGanhosAno);
                    txtTotalGastosAno.Text = Convert.ToString(TotalGastosAno);
                    txtTotalLucroAno.Text = Convert.ToString(totalLucroAno);
                }
                catch
                {
                    MessageBox.Show("Preencher os numeros corretamentes!");
                }
            }
        }
    }
}
