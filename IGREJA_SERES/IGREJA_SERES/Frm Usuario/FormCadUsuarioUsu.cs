using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IGREJA_SERES.Model;
using IGREJA_SERES.BLL;

namespace IGREJA_SERES
{
    public partial class FormCadUsuarioUsu : Form
    {
        
        public FormCadUsuarioUsu()
        {
            InitializeComponent();
            listar();
            CarregaCombo();
           
        }
        //metodos para limpar campos
        private void limparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            btnAdicionar.Text = "Adicionar";
        }
        //metodo para exibir
        private void listar()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            dgvUsuario.DataSource = usuarioBLL.listar();
        }
        private void CarregaCombo()
        {
            perfilBLL perfilBLL = new perfilBLL();
            comboBoxPerfil.DataSource = perfilBLL.CarregaCombo();
            comboBoxPerfil.ValueMember = "idperfil_usuario";
            comboBoxPerfil.DisplayMember = "descricao";
           
        }

       
        //metodo para editar usuario
        private void Editar(usuario usuario)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            usuario.IDusuario = Convert.ToInt32(txtID.Text);
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Idperfil = Convert.ToInt32(comboBoxPerfil.SelectedIndex);
            if (comboBoxPerfil.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor selecione um perfil");

            }
            else { 
            try
            {
                usuarioBLL.Editar(usuario);
                MessageBox.Show("Usuário alterado com Suceeso");
            }
            catch (Exception erro)
            {

                throw erro;
            }
          
            listar();
            limparCampos();
        }
        }
        //metodo para salvar usuario
        private void salvar(usuario usuario)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Idperfil = Convert.ToInt32(comboBoxPerfil.SelectedIndex);
           
            if(comboBoxPerfil.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor selecione um perfil");
            
            }
            else { 
            try
            {
                usuarioBLL.salvar(usuario);

                MessageBox.Show("Usuario Cadastrado com Sucesso");
            }
            catch (Exception erro)
            {

                throw erro;
            }
            comboBoxPerfil.SelectedIndex = 0;
            listar();
            limparCampos();
            }

        }
        //metodo para excluir
        public void Excluir(usuario usuario)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuario.IDusuario = Convert.ToInt32(txtID.Text);
            usuarioBLL.Excluir(usuario);

            MessageBox.Show(" usuario excluido com sucesso");
            listar();
            limparCampos();
            comboBoxPerfil.SelectedIndex = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if((txtNome.Text == "") ||(txtLogin.Text == "") || (txtSenha.Text == "")){

                MessageBox.Show("POR FAVOR PREENCHA TODOS OS CAMPOS");
            }
            else { 
            if (txtID.Text.Any())
            {
                usuario usuario = new usuario();
                Editar(usuario);

            }
            else
            {
                usuario usuario = new usuario();
                salvar(usuario);
            }
                comboBoxPerfil.SelectedIndex = 0;
                btnAdicionar.Text = "Adicionar";
        }
        }
        private void dgvUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            //usuario usuario = new usuario();
            //Editar(usuario);
            limparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "") || (txtLogin.Text == "") || (txtSenha.Text == ""))
            {

                MessageBox.Show("CERTIFIXE QUE TODOS OS CAMPOS ESTÃO PREENCHIDOS");
            }
            else
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuario usuario = new usuario();
                    Excluir(usuario);

                }
                limparCampos();
            }
        }

        private void FormCadUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuario.Columns[0].HeaderText = "ID";
            comboBoxPerfil.SelectedIndex = 0;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
            txtLogin.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
            comboBoxPerfil.SelectedValue = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[4].Value.ToString());
            
            btnAdicionar.Text = "Alterar";
        }
    }
}
