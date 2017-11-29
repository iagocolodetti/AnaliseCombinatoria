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

        private const int MIN_NUMBER = 1, MAX_NUMBER = 100;
        private int TipoSelecionado = 0;

        #region Métodos
        private void MsgBoxError(string text)
        {
            MessageBox.Show(text, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RtbAddColorText(RichTextBox r, Color color, string text)
        {
            r.SelectionStart = r.Text.Length;
            r.SelectionColor = color;
            r.AppendText(text);
        }

        private void RtbAddTextComResultado(RichTextBox r, string text, BigInteger resultado)
        {
            RtbAddColorText(r, Color.Red, ">  ");
            RtbAddColorText(r, Color.Black, text);
            RtbAddColorText(r, Color.Red, "    >    ");
            RtbAddColorText(r, Color.Blue, "R: " + resultado.ToString() + "\n");
        }
        #endregion

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            RbTrocar(0);
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                AnaliseCombinatoria AC = new AnaliseCombinatoria();

                int n = 0, p = 0;

                #region Tratamento de Erro
                if (TipoSelecionado == 0)
                {
                    if (string.IsNullOrEmpty(TbN.Text) == true) { MsgBoxError("O campo 'n' está vazio."); return; }
                    if (int.TryParse(TbN.Text, out n) == false) { MsgBoxError("O valor do campo 'n' não é um inteiro."); return; }
                    if (n < MIN_NUMBER || n > MAX_NUMBER) { MsgBoxError("O valor do campo 'n' deve ser um número inteiro positivo de " + MIN_NUMBER.ToString() + " a " + MAX_NUMBER.ToString() + "."); return; }
                }
                else if (TipoSelecionado == 1)
                {
                    if (string.IsNullOrEmpty(TbP.Text) == true) { MsgBoxError("O campo 'p' está vazio."); return; }
                    if (string.IsNullOrEmpty(TbN.Text) == true) { MsgBoxError("O campo 'n' está vazio."); return; }
                    if (int.TryParse(TbN.Text, out n) == false) { MsgBoxError("O valor do campo 'n' não é um inteiro."); return; }
                    if (n < MIN_NUMBER || n > MAX_NUMBER) { MsgBoxError("O valor do campo 'n' deve ser um número inteiro positivo de " + MIN_NUMBER.ToString() + " a "  + MAX_NUMBER.ToString() + "."); return; }
                }
                else
                {
                    if (string.IsNullOrEmpty(TbP.Text) == true) { MsgBoxError("O campo 'p' está vazio."); return; }
                    if (string.IsNullOrEmpty(TbN.Text) == true) { MsgBoxError("O campo 'n' está vazio."); return; }
                    if (int.TryParse(TbP.Text, out p) == false) { MsgBoxError("O valor do campo 'p' não é um inteiro."); return; }
                    if (p < MIN_NUMBER || p > MAX_NUMBER) { MsgBoxError("O valor do campo 'p' deve ser um número inteiro positivo de " + MIN_NUMBER.ToString() + " a " + MAX_NUMBER.ToString() + "."); return; }
                    if (int.TryParse(TbN.Text, out n) == false) { MsgBoxError("O valor do campo 'n' não é um inteiro."); return; }
                    if (n < MIN_NUMBER || n > MAX_NUMBER) { MsgBoxError("O valor do campo 'n' deve ser um número inteiro positivo de " + MIN_NUMBER.ToString() + " a " + MAX_NUMBER.ToString() + "."); return; }
                    if ((TipoSelecionado != 3 && TipoSelecionado != 5) && n < p) { MsgBoxError("O valor do campo 'p' deve ser menor ou igual ao valor do campo 'n'."); return; }
                }
                #endregion

                switch (TipoSelecionado)
                {
                    case 0:
                        RtbAddTextComResultado(RtbResultados, "P(n) => P(" + n.ToString() + ")", AC.PermutacaoSimples(n));
                        break;

                    case 1:
                        string exibir = "P(n,(p,p,...)) => P(" + n.ToString() + ",(";
                        string[] s = TbP.Text.Split(',');
                        int[] pp = new int[s.Length];
                        for (int i = 0; i < s.Length; i++)
                        {
                            #region Tratamento de Erro (p por p)
                            if (int.TryParse(s[i], out p) == false) { MessageBox.Show("Um valor do campo 'p' não é um inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (p < MIN_NUMBER || p > MAX_NUMBER) { MessageBox.Show("Os valores do campo 'p' devem ser números inteiros positivos de " + MIN_NUMBER.ToString() + " a " + MAX_NUMBER.ToString() + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            #endregion
                            if (i == 0) exibir += p.ToString();
                            else exibir += "," + p.ToString();
                            pp[i] = p;
                        }
                        #region Tratamento de Erro
                        if(n < pp.Sum()) { MessageBox.Show("O valor total do campo 'p' deve ser menor ou igual ao valor do campo 'n'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        #endregion
                        RtbAddTextComResultado(RtbResultados, exibir + "))", AC.PermutacaoRepeticao(n, pp));
                        break;

                    case 2:
                        RtbAddTextComResultado(RtbResultados, "A(n,p) => A(" + n.ToString() + "," + p.ToString() + ")", AC.ArranjoSimples(n, p));
                        break;

                    case 3:
                        RtbAddTextComResultado(RtbResultados, "AR(n,p) => A(" + n.ToString() + "," + p.ToString() + ")", AC.ArranjoRepeticao(n, p));
                        break;

                    case 4:
                        RtbAddTextComResultado(RtbResultados, "C(n,p) => C(" + n.ToString() + "," + p.ToString() + ")", AC.CombinacaoSimples(n, p));
                        break;

                    case 5:
                        RtbAddTextComResultado(RtbResultados, "CR(n,p) => CR(" + n.ToString() + "," + p.ToString() + ")", AC.CombinacaoRepeticao(n, p));
                        break;

                    default:
                        MessageBox.Show("Não foi possível calcular.\nO tipo não foi selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                RtbResultados.ScrollToCaret();
            }
            catch
            {
                MessageBox.Show("Não foi possível calcular.\nErro interno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            RtbResultados.Clear();
        }

        private void RtbResultados_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (e.KeyCode == Keys.Oemplus) RtbResultados.ZoomFactor += 0.1f;
                    else if (e.KeyCode == Keys.OemMinus) RtbResultados.ZoomFactor -= 0.1f;
                    else if (e.KeyCode == Keys.D0) RtbResultados.ZoomFactor = 1.0f;
                }
            }
            catch { }
        }

        #region Troca de tipos
        private void RbTrocar(int tipo)
        {
            if (tipo < 0 || tipo > 5) tipo = 0;

            if (tipo == 0) { LbP.Enabled = false; TbP.Enabled = false; }
            else { LbP.Enabled = true; TbP.Enabled = true; }

            RadioButton[] rb_array = { RbPermutacaoSimples, RbPermutacaoRepeticao, RbArranjoSimples, RbArranjoRepeticao, RbCombinacaoSimples, RbCombinacaoRepeticao };
            rb_array[tipo].Checked = true;
            for (int i = 0; i < rb_array.Length; i++) if (i != tipo) rb_array[i].Checked = false;

            TipoSelecionado = tipo;
        }

        private void RbPermutacaoSimples_Click(object sender, EventArgs e)
        {
            RbTrocar(0);
        }

        private void RbPermutacaoRepeticao_Click(object sender, EventArgs e)
        {
            RbTrocar(1);
        }

        private void RbArranjoSimples_Click(object sender, EventArgs e)
        {
            RbTrocar(2);
        }

        private void RbArranjoRepeticao_Click(object sender, EventArgs e)
        {
            RbTrocar(3);
        }

        private void RbCombinacaoSimples_Click(object sender, EventArgs e)
        {
            RbTrocar(4);
        }

        private void RbCombinacaoRepeticao_Click(object sender, EventArgs e)
        {
            RbTrocar(5);
        }

        private void PanelPermutacaoSimples_Click(object sender, EventArgs e)
        {
            RbTrocar(0);
        }

        private void PanelPermutacaoRepeticao_Click(object sender, EventArgs e)
        {
            RbTrocar(1);
        }

        private void PanelArranjoSimples_Click(object sender, EventArgs e)
        {
            RbTrocar(2);
        }

        private void PanelArranjoRepeticao_Click(object sender, EventArgs e)
        {
            RbTrocar(3);
        }

        private void PanelCombinacaoSimples_Click(object sender, EventArgs e)
        {
            RbTrocar(4);
        }

        private void PanelCombinacaoRepeticao_Click(object sender, EventArgs e)
        {
            RbTrocar(5);
        }
        #endregion
    }
}
