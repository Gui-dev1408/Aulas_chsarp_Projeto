namespace servicehub
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
            dgvUsuarios = new DataGridView();
            txtBuscar = new TextBox();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            button1 = new Button();
            buttonExcluir = new Button();
            txtSenha = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbNivel = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(85, 313);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(599, 166);
            dgvUsuarios.TabIndex = 58;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(85, 209);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Usuario";
            txtBuscar.Size = new Size(412, 23);
            txtBuscar.TabIndex = 57;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial Narrow", 11.25F);
            btnExcluir.ForeColor = Color.Firebrick;
            btnExcluir.Location = new Point(389, 250);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 57);
            btnExcluir.TabIndex = 50;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial Narrow", 11.25F);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(553, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 57);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial Narrow", 11.25F);
            btnPesquisar.ForeColor = Color.FromArgb(0, 192, 192);
            btnPesquisar.Image = Servicehub.Properties.Resources.Search;
            btnPesquisar.Location = new Point(517, 199);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(111, 38);
            btnPesquisar.TabIndex = 48;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Arial Narrow", 11.25F);
            btnEditar.ForeColor = Color.Goldenrod;
            btnEditar.Image = Servicehub.Properties.Resources.Edit;
            btnEditar.Location = new Point(241, 250);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 57);
            btnEditar.TabIndex = 49;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Narrow", 11.25F);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Image = Servicehub.Properties.Resources.Add;
            btnAdd.Location = new Point(85, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 57);
            btnAdd.TabIndex = 47;
            btnAdd.Text = "&Adicionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 127);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 54;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 53;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 65);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 52;
            label1.Text = "ID";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(219, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(245, 23);
            txtNome.TabIndex = 45;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(85, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 46;
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 83);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(79, 23);
            txtId.TabIndex = 55;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F);
            button1.ForeColor = Color.Red;
            button1.Image = Servicehub.Properties.Resources.Cancel;
            button1.Location = new Point(553, 250);
            button1.Name = "button1";
            button1.Size = new Size(75, 57);
            button1.TabIndex = 51;
            button1.Text = "&Cancelar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.FlatAppearance.BorderSize = 0;
            buttonExcluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            buttonExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Arial Narrow", 11.25F);
            buttonExcluir.ForeColor = Color.Firebrick;
            buttonExcluir.Image = Servicehub.Properties.Resources.Delete;
            buttonExcluir.Location = new Point(397, 250);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 57);
            buttonExcluir.TabIndex = 50;
            buttonExcluir.Text = "E&xcluir";
            buttonExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(389, 145);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(239, 23);
            txtSenha.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 127);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 62;
            label5.Text = "Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(508, 65);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 64;
            label6.Text = "Nivel";
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(508, 83);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(260, 9);
            label4.Name = "label4";
            label4.Size = new Size(212, 32);
            label4.TabIndex = 66;
            label4.Text = "Tabela de Usuarios";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(label4);
            Controls.Add(cmbNivel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSenha);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtBuscar);
            Controls.Add(buttonExcluir);
            Controls.Add(btnExcluir);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private TextBox txtBuscar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtId;
        private Button button1;
        private Button buttonExcluir;
        private TextBox txtSenha;
        private Label label5;
        private Label label6;
        private ComboBox cmbNivel;
        private Label label4;
    }
}