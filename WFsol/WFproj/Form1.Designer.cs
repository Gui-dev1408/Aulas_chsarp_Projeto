namespace WFproj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtnome = new TextBox();
            button1 = new Button();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            N1 = new Label();
            N2 = new Label();
            button2 = new Button();
            Resultado = new Label();
            txtAdicao = new TextBox();
            txtSubtracao = new TextBox();
            txtMenor = new TextBox();
            txtMultiplicacao = new TextBox();
            txtMaior = new TextBox();
            txtDivisao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(46, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(46, 76);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "Digite seu nome";
            txtnome.Size = new Size(235, 23);
            txtnome.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(300, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "E&nviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(46, 194);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(181, 194);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 4;
            // 
            // N1
            // 
            N1.AutoSize = true;
            N1.Location = new Point(46, 176);
            N1.Name = "N1";
            N1.Size = new Size(22, 15);
            N1.TabIndex = 5;
            N1.Text = "N1";
            // 
            // N2
            // 
            N2.AutoSize = true;
            N2.Location = new Point(181, 176);
            N2.Name = "N2";
            N2.Size = new Size(22, 15);
            N2.TabIndex = 6;
            N2.Text = "N2";
            // 
            // button2
            // 
            button2.Location = new Point(300, 193);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "&Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(27, 314);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(59, 15);
            Resultado.TabIndex = 8;
            Resultado.Text = "Resultado";
            // 
            // txtAdicao
            // 
            txtAdicao.Location = new Point(91, 314);
            txtAdicao.Name = "txtAdicao";
            txtAdicao.Size = new Size(45, 23);
            txtAdicao.TabIndex = 9;
            // 
            // txtSubtracao
            // 
            txtSubtracao.Location = new Point(143, 314);
            txtSubtracao.Name = "txtSubtracao";
            txtSubtracao.Size = new Size(60, 23);
            txtSubtracao.TabIndex = 9;
            // 
            // txtMenor
            // 
            txtMenor.Location = new Point(438, 314);
            txtMenor.Name = "txtMenor";
            txtMenor.Size = new Size(56, 23);
            txtMenor.TabIndex = 9;
            // 
            // txtMultiplicacao
            // 
            txtMultiplicacao.Location = new Point(209, 314);
            txtMultiplicacao.Name = "txtMultiplicacao";
            txtMultiplicacao.Size = new Size(84, 23);
            txtMultiplicacao.TabIndex = 9;
            // 
            // txtMaior
            // 
            txtMaior.Location = new Point(363, 314);
            txtMaior.Name = "txtMaior";
            txtMaior.Size = new Size(59, 23);
            txtMaior.TabIndex = 9;
            // 
            // txtDivisao
            // 
            txtDivisao.Location = new Point(300, 314);
            txtDivisao.Name = "txtDivisao";
            txtDivisao.Size = new Size(57, 23);
            txtDivisao.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 291);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Adição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 291);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Subtração";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 291);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 10;
            label3.Text = "Multiplicação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 291);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Divisão";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 291);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Maior";
            label5.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 291);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Menor";
            label6.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            CausesValidation = false;
            ClientSize = new Size(583, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDivisao);
            Controls.Add(txtMaior);
            Controls.Add(txtMultiplicacao);
            Controls.Add(txtMenor);
            Controls.Add(txtSubtracao);
            Controls.Add(txtAdicao);
            Controls.Add(Resultado);
            Controls.Add(button2);
            Controls.Add(N2);
            Controls.Add(N1);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(button1);
            Controls.Add(txtnome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtnome;
        private Button button1;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label N1;
        private Label N2;
        private Button button2;
        private Label Resultado;
        private TextBox txtAdicao;
        private TextBox txtSubtracao;
        private TextBox txtMenor;
        private TextBox txtMultiplicacao;
        private TextBox txtMaior;
        private TextBox txtDivisao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
