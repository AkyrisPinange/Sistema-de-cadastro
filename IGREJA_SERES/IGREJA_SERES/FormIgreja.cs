using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using IGREJA_SERES.Model;
using System.Runtime.InteropServices;
using IGREJA_SERES.BLL;

namespace IGREJA_SERES.Frm_Usuario
{
    public partial class FormIgreja : Form
    {
        public FormIgreja()
        {
            InitializeComponent();
            CarregaComboUP();
            listar();
        }
        private void CarregaComboUP()
        {
            IgrejaBLL igrejaBLL = new IgrejaBLL();
            cmbPresidio.DataSource = igrejaBLL.CarregaComboUP();
            cmbPresidio.ValueMember = "ID";
            cmbPresidio.DisplayMember = "nome_UP";

        }
        private void listar()
        {
            IgrejaBLL igrejaBLL = new IgrejaBLL();
            dgvIgreja.DataSource = igrejaBLL.listar();

        }
        private void Editar(igreja igreja)
        {
            IgrejaBLL igrejaBLL = new IgrejaBLL();

            igreja.Id = Convert.ToInt32(txtID.Text);
            igreja.Descricao = txtIgreja.Text;
            igreja.NomePastor = txtPastorRep.Text;
            igreja.Numero = txtNumero.Text;
            igreja.Idpresidio = Convert.ToInt32(cmbPresidio.SelectedValue);




            if (txtIgreja.Text == "")
            {
                MessageBox.Show("O Campo Igreja é OBRIGATÓRIO", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    igrejaBLL.Editar(igreja);
                    MessageBox.Show("Ígreja alterada com Suceeso", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {

                    throw erro;
                }

                listar();
                limparCampos();
            }

        }


        public FormIgreja(int _Idpresidio)
        {
            cmbPresidio.SelectedValue = _Idpresidio;

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
        private void limparCampos()
        {
            txtID.Clear();
            txtIgreja.Clear();
            txtPastorRep.Clear();
            txtNumero.Clear();
            bntSalvar.Text = "Adicionar";


        }
        public void Excluir(igreja igreja)
        {
            IgrejaBLL igrejaBLL = new IgrejaBLL();
            igreja.Id = Convert.ToInt32(txtID.Text);
            igrejaBLL.Excluir(igreja);

            MessageBox.Show("Ígreja excluida com sucesso", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limparCampos();

        }
        private void salvar(igreja igreja)
        {
            IgrejaBLL igrejaBLL = new IgrejaBLL();

            igreja.Descricao = txtIgreja.Text;
            igreja.NomePastor = txtPastorRep.Text;
            igreja.Numero = txtNumero.Text;
            igreja.Idpresidio = Convert.ToInt32(cmbPresidio.SelectedValue);



            try
            {
                igrejaBLL.salvar(igreja);

                MessageBox.Show("Igreja salva com Sucesso");
            }
            catch (Exception erro)
            {

                throw erro;
            }

            listar();
            limparCampos();


        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //btn Salvar
        //private void bntEditar_Click(object sender, EventArgs e)
        //{
        //    igreja Igreja = new igreja();
        //    salvar(Igreja);
        //}

        private void pnlTOP_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pnlTOP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cmbPresidio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPastor_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPastorRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIgreja_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbigreja_Click(object sender, EventArgs e)
        {

        }

        private void FormIgreja_Load(object sender, EventArgs e)
        {
            dgvIgreja.Columns[1].HeaderText = "Nome do Ígrejas";
            dgvIgreja.Columns[4].HeaderText = "ID da Unidade";
            dgvIgreja.Columns[2].HeaderText = "Nome do pastor";
            dgvIgreja.Columns[3].HeaderText = "Numero do pastor";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            if ((txtIgreja.Text == ""))
            {

                MessageBox.Show("O Campo Igreja é OBRIGATÓRIO", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtID.Text.Any())
                {
                    igreja igreja = new igreja();
                    Editar(igreja);

                }
                else
                {
                    igreja igreja = new igreja();
                    salvar(igreja);
                }

                bntSalvar.Text = "Adicionar";
            }
        }
        private void dgvUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIgreja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvIgreja.CurrentRow.Cells[0].Value.ToString();
            txtIgreja.Text = dgvIgreja.CurrentRow.Cells[1].Value.ToString();
            cmbPresidio.SelectedValue = dgvIgreja.CurrentRow.Cells[4].Value.ToString();
            txtPastorRep.Text = dgvIgreja.CurrentRow.Cells[2].Value.ToString();
            txtNumero.Text = dgvIgreja.CurrentRow.Cells[3].Value.ToString();

            bntSalvar.Text = "Alterar";

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if ((txtIgreja.Text == "") || (txtPastorRep.Text == "") || (txtNumero.Text == ""))
            {

                MessageBox.Show("CERTIFIXE QUE TODOS OS CAMPOS ESTÃO PREENCHIDOS");
            }
            else
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    igreja igreja = new igreja();
                    Excluir(igreja);

                }
                limparCampos();
                listar();
            }
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número ");
            }
        }

        private void cmbPresidio_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPresidio.SelectedIndex != 0)
            {
                IgrejaBLL igrejaBLL = new IgrejaBLL();
                dgvIgreja.DataSource = igrejaBLL.listarPorUP(Convert.ToInt32(cmbPresidio.SelectedValue));
            }
        }
    }
}
