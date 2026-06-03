namespace Servicehub
{
    partial class FrmNiveis
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            btnadicionar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtBuscar = new TextBox();
            dgvNiveis = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 45);
            label1.TabIndex = 0;
            label1.Text = "Categoria Nivies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 62);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 62);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(635, 62);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Sigla";
            // 
            // txtId
            // 
            txtId.Location = new Point(61, 80);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(200, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 5;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(608, 80);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(91, 23);
            txtSigla.TabIndex = 6;
            // 
            // btnadicionar
            // 
            btnadicionar.FlatAppearance.BorderSize = 0;
            btnadicionar.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnadicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnadicionar.Image = Properties.Resources.Add;
            btnadicionar.Location = new Point(34, 150);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(131, 70);
            btnadicionar.TabIndex = 7;
            btnadicionar.Text = "&Adicionar";
            btnadicionar.TextAlign = ContentAlignment.BottomCenter;
            btnadicionar.UseVisualStyleBackColor = false;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.White;
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(183, 150);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 70);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "&Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPesquisar.Image = Properties.Resources.Search1;
            btnPesquisar.Location = new Point(329, 150);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(131, 70);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.BottomCenter;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(483, 150);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(131, 70);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "&Excluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(638, 150);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 70);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(51, 238);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Categoria";
            txtBuscar.Size = new Size(696, 23);
            txtBuscar.TabIndex = 12;
            txtBuscar.Tag = "";
            // 
            // dgvNiveis
            // 
            dgvNiveis.AllowUserToAddRows = false;
            dgvNiveis.AllowUserToDeleteRows = false;
            dgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNiveis.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvNiveis.Location = new Point(51, 279);
            dgvNiveis.Name = "dgvNiveis";
            dgvNiveis.ReadOnly = true;
            dgvNiveis.Size = new Size(696, 150);
            dgvNiveis.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Sigla";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // FrmNiveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNiveis);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnadicionar);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNiveis";
            Text = "FrmNiveis";
            Load += FrmNiveis_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSigla;
        private Button btnadicionar;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtBuscar;
        private DataGridView dgvNiveis;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}