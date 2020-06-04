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
    public partial class FormCadPresidioUsu : Form
    {
     
        public FormCadPresidioUsu()
        {
           
            InitializeComponent();
            listar();
        }
        private void limparCampos()
        {
            txtID.Clear();
            txtNomePresidio.Clear();
            txtTelefoneUp.Clear();
            txtEmailInstUp.Clear();
            txtCNPJ.Clear();
            txtdiretor.Clear();
            txtTelefoneDiretor.Clear();
            txtEmailChefe.Clear();
            txtChefeSeg.Clear();
            txtTelefoneSeg.Clear();
            txtEmailInstSeg.Clear();
            btnAdicionar.Text = "Adicionar";
        }
        private void listar()
        {
            PresidioBLL presidioBLL = new PresidioBLL();
            dgvPresidio.DataSource = presidioBLL.listar();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        public void Excluir(presidio presidio)
        {
            PresidioBLL presidioBLL = new PresidioBLL();
            presidio.Id = Convert.ToInt32(txtID.Text);
            presidioBLL.Excluir(presidio);

            MessageBox.Show(" usuario excluido com sucesso");
            listar();
            limparCampos();
        }
        private void salvar(presidio presidio)
        {
            PresidioBLL PresidioBLL = new PresidioBLL();

            presidio.Nome_up = txtNomePresidio.Text;
            presidio.Telefone_UP = txtTelefoneUp.Text;
            presidio.Email_UP = txtEmailInstUp.Text;
            presidio.Cnpj_UP = txtCNPJ.Text;
            presidio.Diretor = txtdiretor.Text;
            presidio.Telefone_diretor = txtTelefoneDiretor.Text;
            presidio.Email_diretor = txtEmailChefe.Text;
            presidio.Chefe_SEG = txtChefeSeg.Text;
            presidio.Telefone_chefe_SEG = txtTelefoneSeg.Text;
            presidio.Email_chefe_SEG = txtEmailInstSeg.Text;

            try
            {
                PresidioBLL.salvar(presidio);

                MessageBox.Show("Usuario Cadastrado com Sucesso");
            }
            catch (Exception erro)
            {

                throw erro;
            }

            listar();
            limparCampos();

        }
        private void Editar(presidio presidio)
        {
            PresidioBLL PresidioBLL = new PresidioBLL();

            presidio.Id = Convert.ToInt32(txtID.Text);
            presidio.Nome_up = txtNomePresidio.Text;
            presidio.Telefone_UP = txtTelefoneUp.Text;
            presidio.Email_UP = txtEmailInstUp.Text;
            presidio.Cnpj_UP = txtCNPJ.Text;
            presidio.Diretor = txtdiretor.Text;
            presidio.Telefone_diretor = txtTelefoneDiretor.Text;
            presidio.Email_diretor = txtEmailChefe .Text;
            presidio.Chefe_SEG = txtChefeSeg.Text;
            presidio.Telefone_chefe_SEG = txtTelefoneSeg.Text;
            presidio.Email_chefe_SEG = txtEmailInstSeg.Text;
            try
            {
                PresidioBLL.Editar(presidio);
                MessageBox.Show("Usuário alterado com Suceeso");
            }
            catch (Exception erro)
            {

                throw erro;
            }

            listar();
            limparCampos();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((txtNomePresidio.Text == "") || (txtTelefoneUp.Text == "") || (txtEmailInstUp.Text == "") || (txtCNPJ.Text == "") || (txtdiretor.Text == "") || (txtTelefoneDiretor.Text == "") || (txtEmailChefe.Text == "") || (txtChefeSeg.Text == "") || (txtTelefoneSeg.Text == "") || (txtEmailInstSeg.Text == ""))
            {

                MessageBox.Show("CERTIFIXE QUE TODOS OS CAMPOS ESTÃO PREENCHIDOS");
            }
            else
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    presidio presidio = new presidio();
                    Excluir(presidio);

                }
                limparCampos();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if ((txtNomePresidio.Text == "") || (txtTelefoneUp.Text == "") || (txtEmailInstUp.Text == "") || (txtCNPJ.Text == "") || (txtdiretor.Text == "") || (txtTelefoneDiretor.Text == "") || (txtEmailChefe.Text == "") || (txtChefeSeg.Text == "") || (txtTelefoneSeg.Text == "") || (txtEmailInstSeg.Text == ""))
            {

                MessageBox.Show("POR FAVOR PREENCHA TODOS OS CAMPOS");
            }
            else
            {
                if (txtID.Text.Any())
                {
                    presidio presidio = new presidio();
                    Editar(presidio);

                }
                else
                {
                    presidio presidio = new presidio();
                    salvar(presidio);
                }
                btnAdicionar.Text = "Adicionar";
            }
        }

        private void dgvPresidio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvPresidio.CurrentRow.Cells[0].Value.ToString();
            txtNomePresidio.Text = dgvPresidio.CurrentRow.Cells[1].Value.ToString();
            txtTelefoneUp .Text = dgvPresidio.CurrentRow.Cells[2].Value.ToString();
            txtEmailInstUp.Text = dgvPresidio.CurrentRow.Cells[3].Value.ToString();
            txtCNPJ.Text = dgvPresidio.CurrentRow.Cells[4].Value.ToString();
            txtdiretor.Text = dgvPresidio.CurrentRow.Cells[5].Value.ToString();
            txtTelefoneDiretor.Text = dgvPresidio.CurrentRow.Cells[6].Value.ToString();
            txtEmailChefe.Text = dgvPresidio.CurrentRow.Cells[7].Value.ToString();
            txtChefeSeg.Text = dgvPresidio.CurrentRow.Cells[8].Value.ToString();
            txtTelefoneSeg.Text = dgvPresidio.CurrentRow.Cells[9].Value.ToString();
            txtEmailInstSeg.Text = dgvPresidio.CurrentRow.Cells[10].Value.ToString();
            
            btnAdicionar.Text = "Alterar";
        }

        private void txtEmailChefe_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void FormCadPresidio_Load(object sender, EventArgs e)
        {
            this.dgvPresidio.DefaultCellStyle.Font = new Font("Tahoma", 15);

            dgvPresidio.Columns[1].HeaderText = "Nome do Presídio";
            dgvPresidio.Columns[2].HeaderText = "Tel. do Presídio";
            dgvPresidio.Columns[3].HeaderText = "Email do Preídio";
            dgvPresidio.Columns[4].HeaderText = "CNPJ";
            dgvPresidio.Columns[5].HeaderText = "Nome do Diretor";
            dgvPresidio.Columns[6].HeaderText = "Tel. do Diretor";
            dgvPresidio.Columns[7].HeaderText = "Email do Diretor";
            dgvPresidio.Columns[8].HeaderText = "Nome do Chefe de Seg.";
            dgvPresidio.Columns[9].HeaderText = "Tel. do Chefe de Seg.";
            dgvPresidio.Columns[10].HeaderText = "Email do Chefe de Seg.";
        }

        private void txtTelefoneUp_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtTelefoneUp_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número ");
            }
        }

        private void txtTelefoneDiretor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número ");
            }
        }

        private void txtTelefoneSeg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneSeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número ");
            }

        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número ");
            }
        }
    }
}
