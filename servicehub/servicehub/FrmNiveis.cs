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
            CarregaGrid();
        }
        private void CarregaGrid(string busca = " ")
        {
            List<Nivel> lista = Nivel.ObterLista(busca);
            dgvNiveis.DataSource = null;
            dgvNiveis.DataSource = lista;
        }
       

        private void dgvNiveis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvNiveis.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvNiveis.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSigla.Text = dgvNiveis.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNome.Text, txtSigla.Text);
            nivel.Inserir();

            if (nivel.Id > 0)
            {
                MessageBox.Show($"Nivel {nivel.Id} inserido com sucesso!");
                CarregaGrid();
                txtNome.Clear();
                txtSigla.Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Nivel cat = new Nivel(int.Parse(txtId.Text), txtNome.Text, txtSigla.Text);
            if (cat.Update())
            {
                txtId.Clear();
                txtNome.Clear();
                txtSigla.Clear();

                MessageBox.Show($"Nivel {cat.Id} Alterado com sucesso!\nLista atualizada");
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar Nível!");
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
                    Nivel cat = new Nivel(int.Parse(txtId.Text));
                    cat.Excluir();

                    txtId.Clear();
                    txtNome.Clear();
                    txtSigla.Clear();

                    MessageBox.Show("Nível excluído com sucesso!");
                    CarregaGrid(); 
                }
            }
        }
    }
}