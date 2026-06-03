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

namespace servicehub
{
    public partial class FrmUsuario : Form
    {
        private int usuarioSelecionadoId = 0;
        private bool editando = false;
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void CarregarUsuarios(string busca = "")
        {
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.ObterLista(busca);
        }
        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            if (cmbNivel.Items.Count > 0)
            {
                cmbNivel.SelectedIndex = 0;
            }

            usuarioSelecionadoId = 0;
            editando = false;

            btnEditar.Text = "Editar";
            txtNome.Focus();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            cmbNivel.DataSource = Nivel.ObterLista();
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";

            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AutoGenerateColumns = true;

            CarregarUsuarios();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Usuario usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

            if (usuario == null)
            {
                return;
            }

            usuarioSelecionadoId = usuario.Id;
            txtId.Text = usuario.Id.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)
                )
            );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                MessageBox.Show($"Usuario {usuario.Id}- {usuario.Nome} inserido com sucesso!");
                CarregarUsuarios();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string busca = txtBuscar.Text;

            CarregarUsuarios(busca);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {

                Usuario usuario = Usuario.ObterPorId(usuarioSelecionadoId);

                txtId.Text = usuario.Id.ToString();
                txtNome.Text = usuario.Nome;
                txtEmail.Text = usuario.Email;
                txtSenha.Text = usuario.Senha;

                if (usuario.nivel != null)
                {
                    cmbNivel.SelectedValue = usuario.nivel.Id;
                }

                editando = true;
                btnEditar.Text = "Salvar";

                txtNome.Focus();
            }
            else
            {

                Usuario usuario = new Usuario(
                    Convert.ToInt32(txtId.Text),
                    txtNome.Text,
                    txtEmail.Text,
                    txtSenha.Text,
                    Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );

                if (usuario.Atualizar())
                {
                    MessageBox.Show("Usuário atualizado com sucesso!");

                    CarregarUsuarios();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Nenhum usuário foi atualizado.");
                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este usuário?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                if (Usuario.Excluir(usuarioSelecionadoId))
                {
                    MessageBox.Show("Usuário excluído com sucesso!");

                    CarregarUsuarios();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o usuário.");
                }
            }
        }

        //Cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtId.Clear();
            txtBuscar.Clear();
            CarregarUsuarios();
        }

        private void InitializeComponent()
        {

        }
    }
}
