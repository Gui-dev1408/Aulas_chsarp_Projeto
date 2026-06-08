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
using static Mysqlx.Notice.Warning.Types;

namespace Servicehub
{
    public partial class FrmNiveis : Form
    {
        public FrmNiveis()
        {
            InitializeComponent();
        }

        private void FrmNiveis_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;

            dgvNiveis.AutoGenerateColumns = false;
            dgvNiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNiveis.MultiSelect = false;
            dgvNiveis.RowHeadersVisible = false;

            CarregaGrid();
        }
        private void CarregaGrid(string busca = "")
        {
            List<Nivel> lista = Nivel.ObterLista(busca);

            dgvNiveis.Rows.Clear();

            foreach (Nivel nivel in lista)
            {
                dgvNiveis.Rows.Add(
                    nivel.Id,
                    nivel.Nome,
                    nivel.Sigla
                );
            }
        }
        private void dgvNiveis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Text = dgvNiveis.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtNome.Text = dgvNiveis.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtSigla.Text = dgvNiveis.Rows[e.RowIndex].Cells[2].Value?.ToString();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome do nível.");
                txtNome.Focus();
                return;
            }

            Nivel nivel = new Nivel(txtNome.Text, txtSigla.Text);
            nivel.Inserir();

            if (nivel.Id > 0)
            {
                MessageBox.Show($"Nível {nivel.Id} inserido com sucesso!");

                txtId.Clear();
                txtNome.Clear();
                txtSigla.Clear();

                CarregaGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um registro para editar.");
                return;
            }

            Nivel nivel = new Nivel(
                int.Parse(txtId.Text),
                txtNome.Text,
                txtSigla.Text
            );

            if (nivel.Update())
            {
                txtId.Clear();
                txtNome.Clear();
                txtSigla.Clear();

                MessageBox.Show($"Nível {nivel.Id} alterado com sucesso!");
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar nível!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim().Length > 1)
            {
                CarregaGrid(txtBuscar.Text.Trim());
            }
            else
            {
                CarregaGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                var resposta = MessageBox.Show($"Deseja excluir o nível {txtId.Text} - {txtNome.Text}?",
                    "Exclusão de Nível", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                    );

                if (resposta == DialogResult.Yes)
                { 
                    Nivel nivel = new Nivel(int.Parse(txtId.Text));
                    nivel.Excluir();

                    txtId.Clear();
                    txtNome.Clear();
                    txtSigla.Clear();

                    MessageBox.Show("Nível excluído com sucesso!");
                    CarregaGrid(); 
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtSigla.Clear();
            txtBuscar.Clear();

            txtNome.Focus();

            CarregaGrid();
        }
    }
}