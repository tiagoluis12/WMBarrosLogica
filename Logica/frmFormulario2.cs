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
    public partial class frmFormulario2 : Form
    {
        public frmFormulario2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtJogador1.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo ( nome do Jogador 1)");
                txtJogador1.Clear();
                txtJogador1.Focus();
            }
            else if (txtJogador2.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo (nome do Jogador 2)");
                txtJogador2.Clear();
                txtJogador2.Focus();
            }
            else if (txtJogador3.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo (nome do Jogador 3)");
                txtJogador3.Clear();
                txtJogador3.Focus();
            }
            else if (txtTecnico.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo (nome do Tecnico)");
                txtTecnico.Clear();
                txtTecnico.Focus();
            }
            else if (txtCapitao.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo (nome do Capitao)");
                txtCapitao.Clear();
                txtCapitao.Focus();
            }
            else
            {
                //OPCAO 1 \
                //string jogador1, jogador2, jogador3, tecnico, capitao;

                //jogador1 = txtJogador1.Text;
                //jogador2 = txtJogador3.Text;
                //jogador3 = txtJogador3.Text;
                //tecnico = txtTecnico.Text;
                //capitao = txtCapitao.Text;

                //MessageBox.Show("Jogador 1: " + jogador1 +
                //    "\nJogador 2: " + jogador2 +
                //    "\nJogador 3: " + jogador3 +
                //    "\nTecnico: " + tecnico + "\nCapitao: " + capitao);

                //OPCAO 2

                MessageBox.Show
                    ("Jogador 1: " + txtJogador1.Text + "\nJogador 2: " + txtJogador2.Text +
                    "\nJogador 3: " + txtJogador3.Text + "\nTecnico: " + txtTecnico.Text + "\nCapitao: " + txtCapitao.Text);
            }
        }
    }
}
