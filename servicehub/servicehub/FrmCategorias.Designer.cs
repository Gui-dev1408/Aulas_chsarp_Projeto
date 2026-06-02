namespace Servicehub
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtSigla = new TextBox();
            lblDescricao = new Label();
            lblNome = new Label();
            lblId = new Label();
            txtNome = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            dgvCategorias = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = Properties.Resources.Delete;
            btnCancelar.Location = new Point(535, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 67);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(418, 125);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(93, 67);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.Black;
            btnPesquisar.Image = Properties.Resources.Search1;
            btnPesquisar.Location = new Point(205, 125);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(93, 67);
            btnPesquisar.TabIndex = 20;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(304, 125);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 67);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "&Editar";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.Location = new Point(106, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 67);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "&Adiocionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(546, 80);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(109, 23);
            txtSigla.TabIndex = 15;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(546, 62);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(32, 15);
            lblDescricao.TabIndex = 25;
            lblDescricao.Text = "Sigla";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(138, 62);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(75, 62);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 23;
            lblId.Text = "ID";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(381, 23);
            txtNome.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 80);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(50, 23);
            txtId.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(405, 50);
            label1.TabIndex = 28;
            label1.Text = "Cadastro de Categorias";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCategorias.Location = new Point(55, 243);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(622, 195);
            dgvCategorias.TabIndex = 29;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 330;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Sigla";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(55, 198);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Categoria";
            txtBuscar.Size = new Size(622, 23);
            txtBuscar.TabIndex = 30;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(txtBuscar);
            Controls.Add(dgvCategorias);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtSigla);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtSigla;
        private Label lblDescricao;
        private Label lblNome;
        private Label lblId;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label1;
        private DataGridView dgvCategorias;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}