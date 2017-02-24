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
            this.tb_p = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.lb_p = new System.Windows.Forms.Label();
            this.lb_n = new System.Windows.Forms.Label();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.rtb_resultados = new System.Windows.Forms.RichTextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.lb_info = new System.Windows.Forms.Label();
            this.panel_permutacao_repeticao = new System.Windows.Forms.Panel();
            this.rb_permutacao_repeticao = new System.Windows.Forms.RadioButton();
            this.panel_combinacao_repeticao = new System.Windows.Forms.Panel();
            this.rb_combinacao_repeticao = new System.Windows.Forms.RadioButton();
            this.panel_arranjo_repeticao = new System.Windows.Forms.Panel();
            this.rb_arranjo_repeticao = new System.Windows.Forms.RadioButton();
            this.panel_combinacao_simples = new System.Windows.Forms.Panel();
            this.rb_combinacao_simples = new System.Windows.Forms.RadioButton();
            this.panel_arranjo_simples = new System.Windows.Forms.Panel();
            this.rb_arranjo_simples = new System.Windows.Forms.RadioButton();
            this.panel_permutacao_simples = new System.Windows.Forms.Panel();
            this.rb_permutacao_simples = new System.Windows.Forms.RadioButton();
            this.panel_permutacao_repeticao.SuspendLayout();
            this.panel_combinacao_repeticao.SuspendLayout();
            this.panel_arranjo_repeticao.SuspendLayout();
            this.panel_combinacao_simples.SuspendLayout();
            this.panel_arranjo_simples.SuspendLayout();
            this.panel_permutacao_simples.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_p
            // 
            this.tb_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_p.Location = new System.Drawing.Point(78, 440);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(137, 26);
            this.tb_p.TabIndex = 12;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular.Location = new System.Drawing.Point(56, 519);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(159, 29);
            this.bt_calcular.TabIndex = 15;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // lb_p
            // 
            this.lb_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_p.AutoSize = true;
            this.lb_p.Location = new System.Drawing.Point(52, 443);
            this.lb_p.Name = "lb_p";
            this.lb_p.Size = new System.Drawing.Size(22, 20);
            this.lb_p.TabIndex = 11;
            this.lb_p.Text = "p:";
            // 
            // lb_n
            // 
            this.lb_n.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_n.AutoSize = true;
            this.lb_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_n.Location = new System.Drawing.Point(52, 483);
            this.lb_n.Name = "lb_n";
            this.lb_n.Size = new System.Drawing.Size(22, 20);
            this.lb_n.TabIndex = 13;
            this.lb_n.Text = "n:";
            // 
            // tb_n
            // 
            this.tb_n.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_n.Location = new System.Drawing.Point(78, 480);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(137, 26);
            this.tb_n.TabIndex = 14;
            // 
            // rtb_resultados
            // 
            this.rtb_resultados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_resultados.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtb_resultados.Location = new System.Drawing.Point(290, 436);
            this.rtb_resultados.Name = "rtb_resultados";
            this.rtb_resultados.ReadOnly = true;
            this.rtb_resultados.Size = new System.Drawing.Size(563, 173);
            this.rtb_resultados.TabIndex = 16;
            this.rtb_resultados.Text = "";
            this.rtb_resultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_resultados_KeyDown);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(49, 580);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(173, 29);
            this.bt_limpar.TabIndex = 17;
            this.bt_limpar.Text = "Limpar Resultados";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // lb_info
            // 
            this.lb_info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info.Location = new System.Drawing.Point(67, 9);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(727, 18);
            this.lb_info.TabIndex = 0;
            this.lb_info.Text = "* p = número de elementos escolhidos   /   p,p,... = número de repetições   /   n" +
    " = número total de elementos *";
            // 
            // panel_permutacao_repeticao
            // 
            this.panel_permutacao_repeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_permutacao_repeticao.BackgroundImage = global::Análise_Combinatória.Properties.Resources.permutacaocomrepeticao;
            this.panel_permutacao_repeticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_permutacao_repeticao.Controls.Add(this.rb_permutacao_repeticao);
            this.panel_permutacao_repeticao.Location = new System.Drawing.Point(292, 46);
            this.panel_permutacao_repeticao.Name = "panel_permutacao_repeticao";
            this.panel_permutacao_repeticao.Size = new System.Drawing.Size(280, 190);
            this.panel_permutacao_repeticao.TabIndex = 18;
            this.panel_permutacao_repeticao.Click += new System.EventHandler(this.panel_permutacao_repeticao_Click);
            // 
            // rb_permutacao_repeticao
            // 
            this.rb_permutacao_repeticao.AutoSize = true;
            this.rb_permutacao_repeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_permutacao_repeticao.Location = new System.Drawing.Point(9, 145);
            this.rb_permutacao_repeticao.Name = "rb_permutacao_repeticao";
            this.rb_permutacao_repeticao.Size = new System.Drawing.Size(261, 28);
            this.rb_permutacao_repeticao.TabIndex = 0;
            this.rb_permutacao_repeticao.TabStop = true;
            this.rb_permutacao_repeticao.Text = "Permutação com Repetição";
            this.rb_permutacao_repeticao.UseVisualStyleBackColor = true;
            this.rb_permutacao_repeticao.Click += new System.EventHandler(this.rb_permutacao_repeticao_Click);
            // 
            // panel_combinacao_repeticao
            // 
            this.panel_combinacao_repeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_combinacao_repeticao.BackgroundImage = global::Análise_Combinatória.Properties.Resources.combinacaocomrepeticao;
            this.panel_combinacao_repeticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_combinacao_repeticao.Controls.Add(this.rb_combinacao_repeticao);
            this.panel_combinacao_repeticao.Location = new System.Drawing.Point(571, 235);
            this.panel_combinacao_repeticao.Name = "panel_combinacao_repeticao";
            this.panel_combinacao_repeticao.Size = new System.Drawing.Size(280, 190);
            this.panel_combinacao_repeticao.TabIndex = 9;
            this.panel_combinacao_repeticao.Click += new System.EventHandler(this.panel_combinacao_repeticao_Click);
            // 
            // rb_combinacao_repeticao
            // 
            this.rb_combinacao_repeticao.AutoSize = true;
            this.rb_combinacao_repeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_combinacao_repeticao.Location = new System.Drawing.Point(6, 145);
            this.rb_combinacao_repeticao.Name = "rb_combinacao_repeticao";
            this.rb_combinacao_repeticao.Size = new System.Drawing.Size(267, 28);
            this.rb_combinacao_repeticao.TabIndex = 10;
            this.rb_combinacao_repeticao.TabStop = true;
            this.rb_combinacao_repeticao.Text = "Combinação com Repetição";
            this.rb_combinacao_repeticao.UseVisualStyleBackColor = true;
            this.rb_combinacao_repeticao.Click += new System.EventHandler(this.rb_combinacao_repeticao_Click);
            // 
            // panel_arranjo_repeticao
            // 
            this.panel_arranjo_repeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_arranjo_repeticao.BackgroundImage = global::Análise_Combinatória.Properties.Resources.arranjocomrepeticao;
            this.panel_arranjo_repeticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_arranjo_repeticao.Controls.Add(this.rb_arranjo_repeticao);
            this.panel_arranjo_repeticao.Location = new System.Drawing.Point(13, 235);
            this.panel_arranjo_repeticao.Name = "panel_arranjo_repeticao";
            this.panel_arranjo_repeticao.Size = new System.Drawing.Size(280, 190);
            this.panel_arranjo_repeticao.TabIndex = 5;
            this.panel_arranjo_repeticao.Click += new System.EventHandler(this.panel_arranjo_repeticao_Click);
            // 
            // rb_arranjo_repeticao
            // 
            this.rb_arranjo_repeticao.AutoSize = true;
            this.rb_arranjo_repeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_arranjo_repeticao.Location = new System.Drawing.Point(30, 145);
            this.rb_arranjo_repeticao.Name = "rb_arranjo_repeticao";
            this.rb_arranjo_repeticao.Size = new System.Drawing.Size(221, 28);
            this.rb_arranjo_repeticao.TabIndex = 6;
            this.rb_arranjo_repeticao.TabStop = true;
            this.rb_arranjo_repeticao.Text = "Arranjo com Repetição";
            this.rb_arranjo_repeticao.UseVisualStyleBackColor = true;
            this.rb_arranjo_repeticao.Click += new System.EventHandler(this.rb_arranjo_repeticao_Click);
            // 
            // panel_combinacao_simples
            // 
            this.panel_combinacao_simples.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_combinacao_simples.BackgroundImage = global::Análise_Combinatória.Properties.Resources.combinacaosimples;
            this.panel_combinacao_simples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_combinacao_simples.Controls.Add(this.rb_combinacao_simples);
            this.panel_combinacao_simples.Location = new System.Drawing.Point(292, 235);
            this.panel_combinacao_simples.Name = "panel_combinacao_simples";
            this.panel_combinacao_simples.Size = new System.Drawing.Size(280, 190);
            this.panel_combinacao_simples.TabIndex = 7;
            this.panel_combinacao_simples.Click += new System.EventHandler(this.panel_combinacao_simples_Click);
            // 
            // rb_combinacao_simples
            // 
            this.rb_combinacao_simples.AutoSize = true;
            this.rb_combinacao_simples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_combinacao_simples.Location = new System.Drawing.Point(37, 145);
            this.rb_combinacao_simples.Name = "rb_combinacao_simples";
            this.rb_combinacao_simples.Size = new System.Drawing.Size(207, 28);
            this.rb_combinacao_simples.TabIndex = 8;
            this.rb_combinacao_simples.TabStop = true;
            this.rb_combinacao_simples.Text = "Combinação Simples";
            this.rb_combinacao_simples.UseVisualStyleBackColor = true;
            this.rb_combinacao_simples.Click += new System.EventHandler(this.rb_combinacao_simples_Click);
            // 
            // panel_arranjo_simples
            // 
            this.panel_arranjo_simples.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_arranjo_simples.BackgroundImage = global::Análise_Combinatória.Properties.Resources.arranjosimples;
            this.panel_arranjo_simples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_arranjo_simples.Controls.Add(this.rb_arranjo_simples);
            this.panel_arranjo_simples.Location = new System.Drawing.Point(571, 46);
            this.panel_arranjo_simples.Name = "panel_arranjo_simples";
            this.panel_arranjo_simples.Size = new System.Drawing.Size(280, 190);
            this.panel_arranjo_simples.TabIndex = 3;
            this.panel_arranjo_simples.Click += new System.EventHandler(this.panel_arranjo_simples_Click);
            // 
            // rb_arranjo_simples
            // 
            this.rb_arranjo_simples.AutoSize = true;
            this.rb_arranjo_simples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_arranjo_simples.Location = new System.Drawing.Point(58, 145);
            this.rb_arranjo_simples.Name = "rb_arranjo_simples";
            this.rb_arranjo_simples.Size = new System.Drawing.Size(161, 28);
            this.rb_arranjo_simples.TabIndex = 4;
            this.rb_arranjo_simples.TabStop = true;
            this.rb_arranjo_simples.Text = "Arranjo Simples";
            this.rb_arranjo_simples.UseVisualStyleBackColor = true;
            this.rb_arranjo_simples.Click += new System.EventHandler(this.rb_arranjo_simples_Click);
            // 
            // panel_permutacao_simples
            // 
            this.panel_permutacao_simples.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_permutacao_simples.BackColor = System.Drawing.SystemColors.Control;
            this.panel_permutacao_simples.BackgroundImage = global::Análise_Combinatória.Properties.Resources.permutacaosimples;
            this.panel_permutacao_simples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_permutacao_simples.Controls.Add(this.rb_permutacao_simples);
            this.panel_permutacao_simples.Location = new System.Drawing.Point(13, 46);
            this.panel_permutacao_simples.Name = "panel_permutacao_simples";
            this.panel_permutacao_simples.Size = new System.Drawing.Size(280, 190);
            this.panel_permutacao_simples.TabIndex = 1;
            this.panel_permutacao_simples.Click += new System.EventHandler(this.panel_permutacao_simples_Click);
            // 
            // rb_permutacao_simples
            // 
            this.rb_permutacao_simples.AutoSize = true;
            this.rb_permutacao_simples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_permutacao_simples.Location = new System.Drawing.Point(37, 145);
            this.rb_permutacao_simples.Name = "rb_permutacao_simples";
            this.rb_permutacao_simples.Size = new System.Drawing.Size(201, 28);
            this.rb_permutacao_simples.TabIndex = 2;
            this.rb_permutacao_simples.TabStop = true;
            this.rb_permutacao_simples.Text = "Permutação Simples";
            this.rb_permutacao_simples.UseVisualStyleBackColor = true;
            this.rb_permutacao_simples.Click += new System.EventHandler(this.rb_permutacao_simples_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(864, 621);
            this.Controls.Add(this.panel_permutacao_repeticao);
            this.Controls.Add(this.panel_combinacao_repeticao);
            this.Controls.Add(this.panel_arranjo_repeticao);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.rtb_resultados);
            this.Controls.Add(this.lb_n);
            this.Controls.Add(this.lb_p);
            this.Controls.Add(this.panel_combinacao_simples);
            this.Controls.Add(this.panel_arranjo_simples);
            this.Controls.Add(this.panel_permutacao_simples);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tb_n);
            this.Controls.Add(this.tb_p);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 660);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise Combinatória";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel_permutacao_repeticao.ResumeLayout(false);
            this.panel_permutacao_repeticao.PerformLayout();
            this.panel_combinacao_repeticao.ResumeLayout(false);
            this.panel_combinacao_repeticao.PerformLayout();
            this.panel_arranjo_repeticao.ResumeLayout(false);
            this.panel_arranjo_repeticao.PerformLayout();
            this.panel_combinacao_simples.ResumeLayout(false);
            this.panel_combinacao_simples.PerformLayout();
            this.panel_arranjo_simples.ResumeLayout(false);
            this.panel_arranjo_simples.PerformLayout();
            this.panel_permutacao_simples.ResumeLayout(false);
            this.panel_permutacao_simples.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Panel panel_permutacao_simples;
        private System.Windows.Forms.Panel panel_arranjo_simples;
        private System.Windows.Forms.Panel panel_combinacao_simples;
        private System.Windows.Forms.RadioButton rb_combinacao_simples;
        private System.Windows.Forms.RadioButton rb_arranjo_simples;
        private System.Windows.Forms.RadioButton rb_permutacao_simples;
        private System.Windows.Forms.Label lb_p;
        private System.Windows.Forms.Label lb_n;
        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.RichTextBox rtb_resultados;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Panel panel_arranjo_repeticao;
        private System.Windows.Forms.RadioButton rb_arranjo_repeticao;
        private System.Windows.Forms.Panel panel_combinacao_repeticao;
        private System.Windows.Forms.RadioButton rb_combinacao_repeticao;
        private System.Windows.Forms.Panel panel_permutacao_repeticao;
        private System.Windows.Forms.RadioButton rb_permutacao_repeticao;
    }
}

