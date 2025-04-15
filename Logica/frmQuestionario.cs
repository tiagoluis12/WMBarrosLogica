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
    public partial class frmQuestionario : Form
    {
        public frmQuestionario()
        {
            InitializeComponent();
        }

        # region VARIAVEIS GLOBAIS
        int contarAcertos = 0;
        int contarErros = 0;
        # endregion

        # region ENUM
        private enum Classificacao
        {
            Excelente = 3,
            Bom = 2,
            Ruim = 1,
            Pessimo = 0
        }

        private enum Resposta
        {
            Acerto,
            Erro
        }

        private enum Questionario
        {
            Pergunta1,
            Pergunta2,
            Pergunta3,
            Pergunta4
        }
        # endregion

        # region METODOS PRIVADOS

        private void Pontuar(Resposta resposta)
        {
            switch (resposta)
            {
                case Resposta.Acerto:
                    ContarAcertos();
                    break;
                case Resposta.Erro:
                    ContarErros();
                    break;
            }
        }

        private void MostrarResultadoFinal(int pontuacaoFinal, string classificacao)
        {
            MessageBox.Show("Sua pontuacao foi: " + pontuacaoFinal + "/n Sua Classificacao foi: " + classificacao);
        }

        private string VerificarClassificacao(int pontuacaoFinal)
        {
            string classificacao = "";

            switch (pontuacaoFinal)
            {
                case (int)Classificacao.Excelente:
                    classificacao = "EXCELENTE";
                    break;
                case (int)Classificacao.Bom:
                    classificacao = "BOM";
                    break;
                case (int)Classificacao.Ruim: 
                    classificacao = "RUIM";
                    break;
                default:
                    classificacao = "PESSIMO";
                    break;
            }

            return classificacao;
        }

        private int ContabilizarResultados()
        {
            int resultado;

            resultado = contarAcertos - contarErros;

            return resultado;
        }

        private bool VerificarMarcacoes(Questionario pergunta)
        {
            bool flag = true;

            switch (pergunta)
            {
                case Questionario.Pergunta1:
                    if(!rb1_1.Checked && !rb1_2.Checked && !rb1_3.Checked)
                    {
                        flag = false;
                    }
                    break;

                case Questionario.Pergunta2:
                    if (!rb2_1.Checked && !rb2_2.Checked && !rb2_3.Checked)
                    {
                        flag = false;
                    }
                    break;

                case Questionario.Pergunta3:
                    if (!rb3_3.Checked && !rb3_2.Checked && !rb3_1.Checked)
                    {
                        flag = false;
                    }
                    break;

                case Questionario.Pergunta4:
                    if (!rb4_3.Checked && !rb4_2.Checked && !rb4_1.Checked)
                    {
                        flag = false;
                    }
                    break;
            }

            if (!flag)
            {
                MessageBox.Show("E necessario selecionar uma resposta");
            }

            return flag;
        }
        private void VerificarQuestao(Questionario perguntar)
        {
            switch (perguntar)
            {
                case Questionario.Pergunta1:
                    if (rb1_1.Checked)
                    {
                        Pontuar(Resposta.Acerto);
                        IrParaPergunta(Questionario.Pergunta2);
                    }
                    else
                    {
                        Pontuar(Resposta.Erro);
                    }
                        break;
                case Questionario.Pergunta2:
                    if (rb2_1.Checked)
                    {
                        Pontuar(Resposta.Acerto);
                        IrParaPergunta(Questionario.Pergunta3);
                    }
                    else
                    {
                        Pontuar(Resposta.Erro);
                    }
                        break;
                case Questionario.Pergunta3:
                    if (rb3_3.Checked)
                    {
                        Pontuar(Resposta.Acerto);
                        IrParaPergunta(Questionario.Pergunta4);
                    }
                    else
                    {
                        Pontuar(Resposta.Erro);
                    }
                        break;
                case Questionario.Pergunta4:
                    if (rb4_3.Checked)
                    {
                        int pontuacaoFinal;
                        string classificacao;

                        Pontuar(Resposta.Acerto);
                        pontuacaoFinal = ContabilizarResultados();
                        classificacao = VerificarClassificacao(pontuacaoFinal);
                        MostrarResultadoFinal(pontuacaoFinal, classificacao);
                    }
                    else
                    {
                        Pontuar(Resposta.Erro);
                    }
                        break;

            }
        }
        private void ContarAcertos()
        {
            contarAcertos++;
            lblAcertos.Text = contarAcertos.ToString();
        }

        private void ContarErros()
        {
            contarErros++;
            lblErros.Text = contarErros.ToString();
        }
        private void IrParaPergunta(Questionario pergunta)
        {
            switch (pergunta)
            {
                case Questionario.Pergunta1:
                    gbBox1.Visible = true;
                    gbBox2.Visible = false;
                    gbBox3.Visible = false;
                    gbBox4.Visible = false;
                    break;
                case Questionario.Pergunta2:
                    gbBox1.Visible = false;
                    gbBox2.Visible = true;
                    gbBox3.Visible = false;
                    gbBox4.Visible = false;
                    break;
                case Questionario.Pergunta3:
                    gbBox1.Visible = false;
                    gbBox2.Visible = false;
                    gbBox3.Visible = true;
                    gbBox4.Visible = false;
                    break;
                case Questionario.Pergunta4:
                    gbBox1.Visible = false;
                    gbBox2.Visible = false;
                    gbBox3.Visible = false;
                    gbBox4.Visible = true;
                    break;
            }
        }
        # endregion

        # region EVENTOS
        private void frmQuestionario_Load(object sender, EventArgs e)
        {
            IrParaPergunta(Questionario.Pergunta1);
        }

        private void btnResponder1_Click(object sender, EventArgs e)
        {
            if (VerificarMarcacoes(Questionario.Pergunta1))
            {
                VerificarQuestao(Questionario.Pergunta1);
            }
        }

        private void btnResponder2_Click(object sender, EventArgs e)
        {
            if (VerificarMarcacoes(Questionario.Pergunta2))
            {
                VerificarQuestao(Questionario.Pergunta2);
            }
        }

        private void btnResponder3_Click(object sender, EventArgs e)
        {
            if (VerificarMarcacoes(Questionario.Pergunta3))
            {
                VerificarQuestao(Questionario.Pergunta3);
            }
        }

        private void btnResponder4_Click(object sender, EventArgs e)
        {
            if (VerificarMarcacoes(Questionario.Pergunta4))
            {
                VerificarQuestao(Questionario.Pergunta4);
            }
        }
        # endregion
    }
}
