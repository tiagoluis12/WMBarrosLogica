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
    public partial class frmCalcular2 : Form
    {
        public frmCalcular2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                MessageBox.Show("Preencher TODOS OS CAMPOS");
            }
            else
            {
                double ganhosJan, ganhosFev, ganhosMar, ganhosAbr, ganhosMai, ganhosJun,
                    ganhosJul, ganhosAgo, ganhosSet, ganhosOut, ganhosNov, ganhosDez, gastosJan,
                    gastosFev, gastosMar, gastosAbr, gastosMai, gastosJun, gastosJul, gastosAgo,
                    gastosSet, gastosOut, gastosNov, gastosDez, lucroJan, lucroFev, lucroMar, lucroAbr,
                    lucroMai, lucroJun, lucroJul, lucroAgo, lucroSet, lucroOut, lucroNov, lucroDez, totalLucroAno,
                    TotalGanhosAno, TotalGastosAno;

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

                TotalGanhosAno = CalcularGanhos(ganhosJan, ganhosFev, ganhosMar, ganhosAbr, ganhosMai, ganhosJun,
                    ganhosJul, ganhosAgo, ganhosSet, ganhosOut, ganhosNov, ganhosDez);

                TotalGastosAno = CalcularGastos(gastosJan, gastosFev, gastosMar, gastosAbr, gastosMai, gastosJun, gastosJul, gastosAgo, gastosSet,
                     gastosOut, gastosNov, gastosDez);

                totalLucroAno = CalcularLucro(lucroJan, lucroFev, lucroMar, lucroAbr, lucroMai, lucroJun, lucroJul, lucroAgo, lucroSet, lucroOut,
                     lucroNov, lucroDez);

                txtTotalGanhosAno.Text = Convert.ToString(TotalGanhosAno);
                txtTotalGastosAno.Text = Convert.ToString(TotalGastosAno);
                txtTotalLucroAno.Text = Convert.ToString(totalLucroAno);
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtGanhosJan.Text.Trim() == string.Empty || txtGanhosFev.Text.Trim() == string.Empty ||
                txtGanhosMar.Text.Trim() == string.Empty || txtGanhosAbr.Text.Trim() == string.Empty ||
                txtGanhosMai.Text.Trim() == string.Empty || txtGanhosJun.Text.Trim() == string.Empty ||
                txtGanhosJul.Text.Trim() == string.Empty || txtGanhosAgo.Text.Trim() == string.Empty ||
                txtGanhosSet.Text.Trim() == string.Empty || txtGanhosOut.Text.Trim() == string.Empty ||
                txtGanhosNov.Text.Trim() == string.Empty || txtGanhosDez.Text.Trim() == string.Empty ||

                txtGastosJan.Text.Trim() == string.Empty || txtGastosFev.Text.Trim() == string.Empty ||
                txtGastosMar.Text.Trim() == string.Empty || txtGastosAbr.Text.Trim() == string.Empty ||
                txtGastosMai.Text.Trim() == string.Empty || txtGastosJun.Text.Trim() == string.Empty ||
                txtGastosJul.Text.Trim() == string.Empty || txtGastosAgo.Text.Trim() == string.Empty ||
                txtGastosSet.Text.Trim() == string.Empty || txtGastosOut.Text.Trim() == string.Empty ||
                txtGastosNov.Text.Trim() == string.Empty || txtGastosDez.Text.Trim() == string.Empty) ;
            {
                flag = false;
            }

            return flag;

        }

        private double CalcularGanhos(double ganhosJan, double ganhosFev, double ganhosMar, double ganhosAbr, double ganhosMai, double ganhosJun,
            double ganhosJul, double ganhosAgo, double ganhosSet, double ganhosOut, double ganhosNov, double ganhosDez)
        {
            double TotalGanhosAno;

            TotalGanhosAno = (ganhosJan + ganhosFev + ganhosMar + ganhosAbr + ganhosMai + ganhosJun + ganhosJul + ganhosAgo + ganhosSet + ganhosOut
                 + ganhosNov + ganhosDez);

            return TotalGanhosAno;
           
        }

        private double CalcularGastos(double gastosJan, double gastosFev, double gastosMar, double gastosAbr, double gastosMai, double gastosJun, 
            double gastosJul, double gastosAgo, double gastosSet, double gastosOut,double gastosNov, double gastosDez)
        {
            double TotalGastosAno;

            TotalGastosAno = (gastosJan + gastosFev + gastosMar + gastosAbr + gastosMai + gastosJun + gastosJul + gastosAgo + gastosSet + gastosOut
                 + gastosNov + gastosDez);

            return TotalGastosAno;
        }

        private double CalcularLucro(double lucroJan, double lucroFev, double lucroMar, double lucroAbr, double lucroMai, double lucroJun,
               double lucroJul, double lucroAgo, double lucroSet, double lucroOut, double lucroNov, double lucroDez)
        {
            double TotalLucroAno;

            TotalLucroAno = (lucroJan + lucroFev + lucroMar + lucroAbr + lucroMai + lucroJun + lucroJul + lucroAgo + lucroSet + lucroOut + lucroNov + lucroDez);

            return TotalLucroAno;
        }
    }
}
