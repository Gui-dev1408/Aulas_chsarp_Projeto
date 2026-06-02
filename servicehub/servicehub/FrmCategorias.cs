using Org.BouncyCastle.Bcpg.OpenPgp;
using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicehub
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {

            CarregaGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(txtNome.Text, txtSigla.Text);
            categoria.Inserir();
            if (categoria.Id > 0)
            {
                MessageBox.Show($"Categoria {categoria.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }
        private void CarregaGrid(string texto = " ")
        {
            dgvCategorias.Rows.Clear();

            List<Categoria> categorias = Categoria.ObterLista(texto);
            foreach (var categoria in categorias)
            {
                dgvCategorias.Rows.Add();
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[0].Value = categoria.Id;
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[1].Value = categoria.Nome;
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[2].Value = categoria.Sigla;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 1)
            {
                CarregaGrid(txtBuscar.Text);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSigla.Text = dgvCategorias.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria(int.Parse(txtId.Text), txtNome.Text, txtSigla.Text);
            if (cat.Atualizar())
            {
                txtId.Clear();
                txtNome.Clear();
                txtSigla.Clear();
                CarregaGrid();
                MessageBox.Show($"Categoria {cat.Id} alterada com sucesso!\nLista atualizada");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar categoria!");
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                var resposta = MessageBox.Show($"Deseja excluir a categoria {txtId.Text} - {txtNome.Text}",
                    "Exclusão de categoria",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,MessageBoxDefaultButton.Button2
                    );
                if (resposta == DialogResult.Yes)
                {
                    Categoria cat = new(int.Parse(txtId.Text));
                    cat.Excluir();
                    CarregaGrid();
                }
            }
        }
    }
}
