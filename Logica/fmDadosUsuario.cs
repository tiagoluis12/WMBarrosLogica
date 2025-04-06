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
    public partial class fmDadosUsuario : Form
    {
        public fmDadosUsuario()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o Nome");
                txtNome.Clear();
                txtNome.Focus();
            }
            else if(txtRua.Text.Trim() == "")
            {
                MessageBox.Show("Preencher Nome da Rua");
                txtRua.Clear();
                txtRua.Focus();
            }
            else
            {
                //OPCAO 1

                //string nome, rua;

                //nome = txtNome.Text;
                //rua = txtRua.Text;

                //MessageBox.Show("Nome: " + nome + @"Rua" + rua);

                //Opcao 2

                MessageBox.Show("Nome: " + txtNome.Text + "/nRua " + txtRua.Text);
            }
        }
    }
}
