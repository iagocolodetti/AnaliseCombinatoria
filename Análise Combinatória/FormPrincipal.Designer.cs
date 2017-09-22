namespace Análise_Combinatória
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.TbP = new System.Windows.Forms.TextBox();
            this.BtCalcular = new System.Windows.Forms.Button();
            this.LbP = new System.Windows.Forms.Label();
            this.LbN = new System.Windows.Forms.Label();
            this.TbN = new System.Windows.Forms.TextBox();
            this.RtbResultados = new System.Windows.Forms.RichTextBox();
            this.BtLimpar = new System.Windows.Forms.Button();
            this.LbInfo = new System.Windows.Forms.Label();
            this.PanelPermutacaoRepeticao = new System.Windows.Forms.Panel();
            this.RbPermutacaoRepeticao = new System.Windows.Forms.RadioButton();
            this.PanelCombinacaoRepeticao = new System.Windows.Forms.Panel();
            this.RbCombinacaoRepeticao = new System.Windows.Forms.RadioButton();
            this.PanelArranjoRepeticao = new System.Windows.Forms.Panel();
            this.RbArranjoRepeticao = new System.Windows.Forms.RadioButton();
            this.PanelCombinacaoSimples = new System.Windows.Forms.Panel();
            this.RbCombinacaoSimples = new System.Windows.Forms.RadioButton();
            this.PanelArranjoSimples = new System.Windows.Forms.Panel();
            this.RbArranjoSimples = new System.Windows.Forms.RadioButton();
            this.PanelPermutacaoSimples = new System.Windows.Forms.Panel();
            this.RbPermutacaoSimples = new System.Windows.Forms.RadioButton();
            this.PanelPermutacaoRepeticao.SuspendLayout();
            this.PanelCombinacaoRepeticao.SuspendLayout();
            this.PanelArranjoRepeticao.SuspendLayout();
            this.PanelCombinacaoSimples.SuspendLayout();
            this.PanelArranjoSimples.SuspendLayout();
            this.PanelPermutacaoSimples.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbP
            // 
            this.TbP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbP.Location = new System.Drawing.Point(78, 440);
            this.TbP.Name = "TbP";
            this.TbP.Size = new System.Drawing.Size(137, 26);
            this.TbP.TabIndex = 12;
            // 
            // BtCalcular
            // 
            this.BtCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCalcular.Location = new System.Drawing.Point(56, 519);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(159, 29);
            this.BtCalcular.TabIndex = 15;
            this.BtCalcular.Text = "Calcular";
            this.BtCalcular.UseVisualStyleBackColor = true;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // LbP
            // 
            this.LbP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbP.AutoSize = true;
            this.LbP.Location = new System.Drawing.Point(52, 443);
            this.LbP.Name = "LbP";
            this.LbP.Size = new System.Drawing.Size(22, 20);
            this.LbP.TabIndex = 11;
            this.LbP.Text = "p:";
            // 
            // LbN
            // 
            this.LbN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbN.AutoSize = true;
            this.LbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbN.Location = new System.Drawing.Point(52, 483);
            this.LbN.Name = "LbN";
            this.LbN.Size = new System.Drawing.Size(22, 20);
            this.LbN.TabIndex = 13;
            this.LbN.Text = "n:";
            // 
            // TbN
            // 
            this.TbN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbN.Location = new System.Drawing.Point(78, 480);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(137, 26);
            this.TbN.TabIndex = 14;
            // 
            // RtbResultados
            // 
            this.RtbResultados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RtbResultados.BackColor = System.Drawing.SystemColors.Control;
            this.RtbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RtbResultados.Location = new System.Drawing.Point(290, 436);
            this.RtbResultados.Name = "RtbResultados";
            this.RtbResultados.ReadOnly = true;
            this.RtbResultados.Size = new System.Drawing.Size(563, 173);
            this.RtbResultados.TabIndex = 16;
            this.RtbResultados.Text = "";
            this.RtbResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtbResultados_KeyDown);
            // 
            // BtLimpar
            // 
            this.BtLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLimpar.Location = new System.Drawing.Point(49, 580);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.Size = new System.Drawing.Size(173, 29);
            this.BtLimpar.TabIndex = 17;
            this.BtLimpar.Text = "Limpar Resultados";
            this.BtLimpar.UseVisualStyleBackColor = true;
            this.BtLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // LbInfo
            // 
            this.LbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbInfo.AutoSize = true;
            this.LbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInfo.Location = new System.Drawing.Point(67, 9);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(727, 18);
            this.LbInfo.TabIndex = 0;
            this.LbInfo.Text = "* p = número de elementos escolhidos   /   p,p,... = número de repetições   /   n" +
    " = número total de elementos *";
            // 
            // PanelPermutacaoRepeticao
            // 
            this.PanelPermutacaoRepeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelPermutacaoRepeticao.BackgroundImage = global::Análise_Combinatória.Properties.Resources.permutacaocomrepeticao;
            this.PanelPermutacaoRepeticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPermutacaoRepeticao.Controls.Add(this.RbPermutacaoRepeticao);
            this.PanelPermutacaoRepeticao.Location = new System.Drawing.Point(292, 46);
            this.PanelPermutacaoRepeticao.Name = "PanelPermutacaoRepeticao";
            this.PanelPermutacaoRepeticao.Size = new System.Drawing.Size(280, 190);
            this.PanelPermutacaoRepeticao.TabIndex = 18;
            this.PanelPermutacaoRepeticao.Click += new System.EventHandler(this.PanelPermutacaoRepeticao_Click);
            // 
            // RbPermutacaoRepeticao
            // 
            this.RbPermutacaoRepeticao.AutoSize = true;
            this.RbPermutacaoRepeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPermutacaoRepeticao.Location = new System.Drawing.Point(9, 145);
            this.RbPermutacaoRepeticao.Name = "RbPermutacaoRepeticao";
            this.RbPermutacaoRepeticao.Size = new System.Drawing.Size(261, 28);
            this.RbPermutacaoRepeticao.TabIndex = 0;
            this.RbPermutacaoRepeticao.TabStop = true;
            this.RbPermutacaoRepeticao.Text = "Permutação com Repetição";
            this.RbPermutacaoRepeticao.UseVisualStyleBackColor = true;
            this.RbPermutacaoRepeticao.Click += new System.EventHandler(this.RbPermutacaoRepeticao_Click);
            // 
            // PanelCombinacaoRepeticao
            // 
            this.PanelCombinacaoRepeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelCombinacaoRepeticao.BackgroundImage = global::Análise_Combinatória.Properties.Resources.combinacaocomrepeticao;
            this.PanelCombinacaoRepeticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCombinacaoRepeticao.Controls.Add(this.RbCombinacaoRepeticao);
            this.PanelCombinacaoRepeticao.Location = new System.Drawing.Point(571, 235);
            this.PanelCombinacaoRepeticao.Name = "PanelCombinacaoRepeticao";
            this.PanelCombinacaoRepeticao.Size = new System.Drawing.Size(280, 190);
            this.PanelCombinacaoRepeticao.TabIndex = 9;
            this.PanelCombinacaoRepeticao.Click += new System.EventHandler(this.PanelCombinacaoRepeticao_Click);
            // 
            // RbCombinacaoRepeticao
            // 
            this.RbCombinacaoRepeticao.AutoSize = true;
            this.RbCombinacaoRepeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCombinacaoRepeticao.Location = new System.Drawing.Point(6, 145);
            this.RbCombinacaoRepeticao.Name = "RbCombinacaoRepeticao";
            this.RbCombinacaoRepeticao.Size = new System.Drawing.Size(267, 28);
            this.RbCombinacaoRepeticao.TabIndex = 10;
            this.RbCombinacaoRepeticao.TabStop = true;
            this.RbCombinacaoRepeticao.Text = "Combinação com Repetição";
            this.RbCombinacaoRepeticao.UseVisualStyleBackColor = true;
            this.RbCombinacaoRepeticao.Click += new System.EventHandler(this.RbCombinacaoRepeticao_Click);
            // 
            // PanelArranjoRepeticao
            // 
            this.PanelArranjoRepeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelArranjoRepeticao.BackgroundImage = global::Análise_Combinatória.Properties.Resources.arranjocomrepeticao;
            this.PanelArranjoRepeticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelArranjoRepeticao.Controls.Add(this.RbArranjoRepeticao);
            this.PanelArranjoRepeticao.Location = new System.Drawing.Point(13, 235);
            this.PanelArranjoRepeticao.Name = "PanelArranjoRepeticao";
            this.PanelArranjoRepeticao.Size = new System.Drawing.Size(280, 190);
            this.PanelArranjoRepeticao.TabIndex = 5;
            this.PanelArranjoRepeticao.Click += new System.EventHandler(this.PanelArranjoRepeticao_Click);
            // 
            // RbArranjoRepeticao
            // 
            this.RbArranjoRepeticao.AutoSize = true;
            this.RbArranjoRepeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbArranjoRepeticao.Location = new System.Drawing.Point(30, 145);
            this.RbArranjoRepeticao.Name = "RbArranjoRepeticao";
            this.RbArranjoRepeticao.Size = new System.Drawing.Size(221, 28);
            this.RbArranjoRepeticao.TabIndex = 6;
            this.RbArranjoRepeticao.TabStop = true;
            this.RbArranjoRepeticao.Text = "Arranjo com Repetição";
            this.RbArranjoRepeticao.UseVisualStyleBackColor = true;
            this.RbArranjoRepeticao.Click += new System.EventHandler(this.RbArranjoRepeticao_Click);
            // 
            // PanelCombinacaoSimples
            // 
            this.PanelCombinacaoSimples.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelCombinacaoSimples.BackgroundImage = global::Análise_Combinatória.Properties.Resources.combinacaosimples;
            this.PanelCombinacaoSimples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCombinacaoSimples.Controls.Add(this.RbCombinacaoSimples);
            this.PanelCombinacaoSimples.Location = new System.Drawing.Point(292, 235);
            this.PanelCombinacaoSimples.Name = "PanelCombinacaoSimples";
            this.PanelCombinacaoSimples.Size = new System.Drawing.Size(280, 190);
            this.PanelCombinacaoSimples.TabIndex = 7;
            this.PanelCombinacaoSimples.Click += new System.EventHandler(this.PanelCombinacaoSimples_Click);
            // 
            // RbCombinacaoSimples
            // 
            this.RbCombinacaoSimples.AutoSize = true;
            this.RbCombinacaoSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCombinacaoSimples.Location = new System.Drawing.Point(37, 145);
            this.RbCombinacaoSimples.Name = "RbCombinacaoSimples";
            this.RbCombinacaoSimples.Size = new System.Drawing.Size(207, 28);
            this.RbCombinacaoSimples.TabIndex = 8;
            this.RbCombinacaoSimples.TabStop = true;
            this.RbCombinacaoSimples.Text = "Combinação Simples";
            this.RbCombinacaoSimples.UseVisualStyleBackColor = true;
            this.RbCombinacaoSimples.Click += new System.EventHandler(this.RbCombinacaoSimples_Click);
            // 
            // PanelArranjoSimples
            // 
            this.PanelArranjoSimples.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelArranjoSimples.BackgroundImage = global::Análise_Combinatória.Properties.Resources.arranjosimples;
            this.PanelArranjoSimples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelArranjoSimples.Controls.Add(this.RbArranjoSimples);
            this.PanelArranjoSimples.Location = new System.Drawing.Point(571, 46);
            this.PanelArranjoSimples.Name = "PanelArranjoSimples";
            this.PanelArranjoSimples.Size = new System.Drawing.Size(280, 190);
            this.PanelArranjoSimples.TabIndex = 3;
            this.PanelArranjoSimples.Click += new System.EventHandler(this.PanelArranjoSimples_Click);
            // 
            // RbArranjoSimples
            // 
            this.RbArranjoSimples.AutoSize = true;
            this.RbArranjoSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbArranjoSimples.Location = new System.Drawing.Point(58, 145);
            this.RbArranjoSimples.Name = "RbArranjoSimples";
            this.RbArranjoSimples.Size = new System.Drawing.Size(161, 28);
            this.RbArranjoSimples.TabIndex = 4;
            this.RbArranjoSimples.TabStop = true;
            this.RbArranjoSimples.Text = "Arranjo Simples";
            this.RbArranjoSimples.UseVisualStyleBackColor = true;
            this.RbArranjoSimples.Click += new System.EventHandler(this.RbArranjoSimples_Click);
            // 
            // PanelPermutacaoSimples
            // 
            this.PanelPermutacaoSimples.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelPermutacaoSimples.BackColor = System.Drawing.SystemColors.Control;
            this.PanelPermutacaoSimples.BackgroundImage = global::Análise_Combinatória.Properties.Resources.permutacaosimples;
            this.PanelPermutacaoSimples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPermutacaoSimples.Controls.Add(this.RbPermutacaoSimples);
            this.PanelPermutacaoSimples.Location = new System.Drawing.Point(13, 46);
            this.PanelPermutacaoSimples.Name = "PanelPermutacaoSimples";
            this.PanelPermutacaoSimples.Size = new System.Drawing.Size(280, 190);
            this.PanelPermutacaoSimples.TabIndex = 1;
            this.PanelPermutacaoSimples.Click += new System.EventHandler(this.PanelPermutacaoSimples_Click);
            // 
            // RbPermutacaoSimples
            // 
            this.RbPermutacaoSimples.AutoSize = true;
            this.RbPermutacaoSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPermutacaoSimples.Location = new System.Drawing.Point(37, 145);
            this.RbPermutacaoSimples.Name = "RbPermutacaoSimples";
            this.RbPermutacaoSimples.Size = new System.Drawing.Size(201, 28);
            this.RbPermutacaoSimples.TabIndex = 2;
            this.RbPermutacaoSimples.TabStop = true;
            this.RbPermutacaoSimples.Text = "Permutação Simples";
            this.RbPermutacaoSimples.UseVisualStyleBackColor = true;
            this.RbPermutacaoSimples.Click += new System.EventHandler(this.RbPermutacaoSimples_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(864, 621);
            this.Controls.Add(this.PanelPermutacaoRepeticao);
            this.Controls.Add(this.PanelCombinacaoRepeticao);
            this.Controls.Add(this.PanelArranjoRepeticao);
            this.Controls.Add(this.LbInfo);
            this.Controls.Add(this.BtLimpar);
            this.Controls.Add(this.RtbResultados);
            this.Controls.Add(this.LbN);
            this.Controls.Add(this.LbP);
            this.Controls.Add(this.PanelCombinacaoSimples);
            this.Controls.Add(this.PanelArranjoSimples);
            this.Controls.Add(this.PanelPermutacaoSimples);
            this.Controls.Add(this.BtCalcular);
            this.Controls.Add(this.TbN);
            this.Controls.Add(this.TbP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 660);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise Combinatória";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelPermutacaoRepeticao.ResumeLayout(false);
            this.PanelPermutacaoRepeticao.PerformLayout();
            this.PanelCombinacaoRepeticao.ResumeLayout(false);
            this.PanelCombinacaoRepeticao.PerformLayout();
            this.PanelArranjoRepeticao.ResumeLayout(false);
            this.PanelArranjoRepeticao.PerformLayout();
            this.PanelCombinacaoSimples.ResumeLayout(false);
            this.PanelCombinacaoSimples.PerformLayout();
            this.PanelArranjoSimples.ResumeLayout(false);
            this.PanelArranjoSimples.PerformLayout();
            this.PanelPermutacaoSimples.ResumeLayout(false);
            this.PanelPermutacaoSimples.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbP;
        private System.Windows.Forms.Button BtCalcular;
        private System.Windows.Forms.Panel PanelPermutacaoSimples;
        private System.Windows.Forms.Panel PanelArranjoSimples;
        private System.Windows.Forms.Panel PanelCombinacaoSimples;
        private System.Windows.Forms.RadioButton RbCombinacaoSimples;
        private System.Windows.Forms.RadioButton RbArranjoSimples;
        private System.Windows.Forms.RadioButton RbPermutacaoSimples;
        private System.Windows.Forms.Label LbP;
        private System.Windows.Forms.Label LbN;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.RichTextBox RtbResultados;
        private System.Windows.Forms.Button BtLimpar;
        private System.Windows.Forms.Label LbInfo;
        private System.Windows.Forms.Panel PanelArranjoRepeticao;
        private System.Windows.Forms.RadioButton RbArranjoRepeticao;
        private System.Windows.Forms.Panel PanelCombinacaoRepeticao;
        private System.Windows.Forms.RadioButton RbCombinacaoRepeticao;
        private System.Windows.Forms.Panel PanelPermutacaoRepeticao;
        private System.Windows.Forms.RadioButton RbPermutacaoRepeticao;
    }
}

