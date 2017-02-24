using System;
using System.Windows.Forms;
using System.Drawing;
using System.Numerics;
using System.Linq;

namespace Análise_Combinatória
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private int MaxNumber = 100;
        private int TipoSelecionado = 0;

        #region Funções
        public BigInteger Fatorial(int n)
        {
            if (n < 0) return 0;
            else if (n == 0) return 1;
            else if (n == 1) return n;
            else return (n * Fatorial(n - 1));
        }

        public BigInteger PermutacaoSimples(int n)
        {
            return Fatorial(n);
        }

        public BigInteger PermutacaoRepeticao(int n, int[] p)
        {
            if (n < p.Sum()) return 0;
            BigInteger resultado, pp = 1;
            for (int i = 0; i < p.Length; i++) pp *= Fatorial(p[i]);
            resultado = (Fatorial(n) / pp);
            if (resultado < 0) resultado = 0;
            return resultado;
        }

        public BigInteger ArranjoSimples(int n, int p)
        {
            if (n < p) return 0;
            BigInteger resultado = (Fatorial(n) / Fatorial(n - p));
            if (resultado < 0) resultado = 0;
            return resultado;
        }
        
        public BigInteger ArranjoRepeticao(int n, int p)
        {
            if (p < 0) return 0;
            else if (p == 0) return 1;
            else if (p == 1) return n;
            else return (n * ArranjoRepeticao(n, p - 1));
        }

        public BigInteger CombinacaoSimples(int n, int p)
        {
            if (n < p) return 0;
            BigInteger resultado = (Fatorial(n) / (Fatorial(n - p) * Fatorial(p)));
            if (resultado < 0) resultado = 0;
            return resultado;
        }

        public BigInteger CombinacaoRepeticao(int n, int p)
        {
            BigInteger resultado = (Fatorial(n + p - 1) / (Fatorial(n - 1) * Fatorial(p)));
            if (resultado < 0) resultado = 0;
            return resultado;
        }

        public void RtbAddColorText(RichTextBox r, Color c, string s)
        {
            r.SelectionStart = r.Text.Length;
            r.SelectionColor = c;
            r.AppendText(s);
        }

        private void RtbAddTextComResultado(RichTextBox r, string s, BigInteger resultado)
        {
            RtbAddColorText(r, Color.Red, ">  ");
            RtbAddColorText(r, Color.Black, s);
            RtbAddColorText(r, Color.Red, "    >    ");
            RtbAddColorText(r, Color.Blue, "R: " + resultado.ToString() + "\n");
        }
        #endregion

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            rb_trocar(0);
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0, p = 0;

                #region Tratamento de Erro
                if (TipoSelecionado == 0)
                {
                    if (string.IsNullOrEmpty(tb_n.Text) == true) { MessageBox.Show("O campo 'n' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (int.TryParse(tb_n.Text, out n) == false) { MessageBox.Show("O valor do campo 'n' não é um inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (n < 1 || n > MaxNumber) { MessageBox.Show("O valor do campo 'n' deve ser um número inteiro positivo de 1 a " + MaxNumber.ToString() + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
                else if (TipoSelecionado == 1)
                {
                    if (string.IsNullOrEmpty(tb_p.Text) == true) { MessageBox.Show("O campo 'p' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (string.IsNullOrEmpty(tb_n.Text) == true) { MessageBox.Show("O campo 'n' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (int.TryParse(tb_n.Text, out n) == false) { MessageBox.Show("O valor do campo 'n' não é um inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (n < 1 || n > MaxNumber) { MessageBox.Show("O valor do campo 'n' deve ser um número inteiro positivo de 1 a "  + MaxNumber.ToString() + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
                else
                {
                    if (string.IsNullOrEmpty(tb_p.Text) == true) { MessageBox.Show("O campo 'p' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (string.IsNullOrEmpty(tb_n.Text) == true) { MessageBox.Show("O campo 'n' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (int.TryParse(tb_p.Text, out p) == false) { MessageBox.Show("O valor do campo 'p' não é um inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (p < 1 || p > MaxNumber) { MessageBox.Show("O valor do campo 'p' deve ser um número inteiro positivo de 1 a " + MaxNumber.ToString() + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (int.TryParse(tb_n.Text, out n) == false) { MessageBox.Show("O valor do campo 'n' não é um inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (n < 1 || n > MaxNumber) { MessageBox.Show("O valor do campo 'n' deve ser um número inteiro positivo de 1 a " + MaxNumber.ToString() + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if ((TipoSelecionado != 3 && TipoSelecionado != 5) && n < p) { MessageBox.Show("O valor do campo 'p' deve ser menor ou igual ao valor do campo 'n'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
                #endregion

                switch (TipoSelecionado)
                {
                    case 0:
                        RtbAddTextComResultado(rtb_resultados, "P(n) => P(" + n.ToString() + ")", PermutacaoSimples(n));
                        break;

                    case 1:
                        string exibir = "P(n,(p,p,...)) => P(" + n.ToString() + ",(";
                        string[] s = tb_p.Text.Split(',');
                        int[] pp = new int[s.Length];
                        for (int i = 0; i < s.Length; i++)
                        {
                            #region Tratamento de Erro (p por p)
                            if (int.TryParse(s[i], out p) == false) { MessageBox.Show("Um valor do campo 'p' não é um inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (p < 1 || p > MaxNumber) { MessageBox.Show("Os valores do campo 'p' devem ser números inteiros positivos de 1 a " + MaxNumber.ToString() + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            #endregion
                            if (i == 0) exibir += p.ToString();
                            else exibir += "," + p.ToString();
                            pp[i] = p;
                        }
                        #region Tratamento de Erro
                        if(n < pp.Sum()) { MessageBox.Show("O valor total do campo 'p' deve ser menor ou igual ao valor do campo 'n'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        #endregion
                        RtbAddTextComResultado(rtb_resultados, exibir + "))", PermutacaoRepeticao(n, pp));
                        break;

                    case 2:
                        RtbAddTextComResultado(rtb_resultados, "A(n,p) => A(" + n.ToString() + "," + p.ToString() + ")", ArranjoSimples(n, p));
                        break;

                    case 3:
                        RtbAddTextComResultado(rtb_resultados, "AR(n,p) => A(" + n.ToString() + "," + p.ToString() + ")", ArranjoRepeticao(n, p));
                        break;

                    case 4:
                        RtbAddTextComResultado(rtb_resultados, "C(n,p) => C(" + n.ToString() + "," + p.ToString() + ")", CombinacaoSimples(n, p));
                        break;

                    case 5:
                        RtbAddTextComResultado(rtb_resultados, "CR(n,p) => CR(" + n.ToString() + "," + p.ToString() + ")", CombinacaoRepeticao(n, p));
                        break;

                    default:
                        MessageBox.Show("Não foi possível calcular.\nO tipo não foi selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                rtb_resultados.ScrollToCaret();
            }
            catch
            {
                MessageBox.Show("Não foi possível calcular.\nErro interno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            rtb_resultados.Clear();
        }

        private void rtb_resultados_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (e.KeyCode == Keys.Oemplus) rtb_resultados.ZoomFactor += 0.1f;
                    else if (e.KeyCode == Keys.OemMinus) rtb_resultados.ZoomFactor -= 0.1f;
                    else if (e.KeyCode == Keys.D0) rtb_resultados.ZoomFactor = 1.0f;
                }
            }
            catch { }
        }

        #region Troca de tipos
        private void rb_trocar(int tipo)
        {
            if (tipo < 0 || tipo > 5) tipo = 0;

            if (tipo == 0) { lb_p.Enabled = false; tb_p.Enabled = false; }
            else { lb_p.Enabled = true; tb_p.Enabled = true; }

            RadioButton[] rb_array = { rb_permutacao_simples, rb_permutacao_repeticao, rb_arranjo_simples, rb_arranjo_repeticao, rb_combinacao_simples, rb_combinacao_repeticao };
            rb_array[tipo].Checked = true;
            for (int i = 0; i < rb_array.Length; i++) if (i != tipo) rb_array[i].Checked = false;

            TipoSelecionado = tipo;
        }

        private void rb_permutacao_simples_Click(object sender, EventArgs e)
        {
            rb_trocar(0);
        }

        private void rb_permutacao_repeticao_Click(object sender, EventArgs e)
        {
            rb_trocar(1);
        }

        private void rb_arranjo_simples_Click(object sender, EventArgs e)
        {
            rb_trocar(2);
        }

        private void rb_arranjo_repeticao_Click(object sender, EventArgs e)
        {
            rb_trocar(3);
        }

        private void rb_combinacao_simples_Click(object sender, EventArgs e)
        {
            rb_trocar(4);
        }

        private void rb_combinacao_repeticao_Click(object sender, EventArgs e)
        {
            rb_trocar(5);
        }

        private void panel_permutacao_simples_Click(object sender, EventArgs e)
        {
            rb_trocar(0);
        }

        private void panel_permutacao_repeticao_Click(object sender, EventArgs e)
        {
            rb_trocar(1);
        }

        private void panel_arranjo_simples_Click(object sender, EventArgs e)
        {
            rb_trocar(2);
        }

        private void panel_arranjo_repeticao_Click(object sender, EventArgs e)
        {
            rb_trocar(3);
        }

        private void panel_combinacao_simples_Click(object sender, EventArgs e)
        {
            rb_trocar(4);
        }

        private void panel_combinacao_repeticao_Click(object sender, EventArgs e)
        {
            rb_trocar(5);
        }
        #endregion
    }
}
