namespace Servicehub
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            dup = new DomainUpDown();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnadicionar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(123, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 28);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Nome";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(515, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dup
            // 
            dup.Location = new Point(515, 86);
            dup.Name = "dup";
            dup.Size = new Size(120, 23);
            dup.TabIndex = 9;
            dup.Text = "Nivel";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(636, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 70);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(481, 180);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(131, 70);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "&Excluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPesquisar.Image = Properties.Resources.Search1;
            btnPesquisar.Location = new Point(327, 180);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(131, 70);
            btnPesquisar.TabIndex = 14;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.BottomCenter;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.White;
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(181, 180);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 70);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "&Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnadicionar
            // 
            btnadicionar.FlatAppearance.BorderSize = 0;
            btnadicionar.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnadicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnadicionar.Image = Properties.Resources.Add;
            btnadicionar.Location = new Point(32, 180);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(131, 70);
            btnadicionar.TabIndex = 12;
            btnadicionar.Text = "&Adicionar";
            btnadicionar.TextAlign = ContentAlignment.BottomCenter;
            btnadicionar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 74);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 17;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 118);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 18;
            label2.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(123, 120);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(350, 23);
            txtSenha.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(766, 340);
            dataGridView1.TabIndex = 21;

            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Senha";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Ativo";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Nivel";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(dataGridView1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnadicionar);
            Controls.Add(dup);
            Controls.Add(checkBox1);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label3;
        private CheckBox checkBox1;
        private DomainUpDown dup;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnadicionar;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}