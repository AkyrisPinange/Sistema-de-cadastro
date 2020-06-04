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
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using IGREJA_SERES.Model;
using System.Data;
using IGREJA_SERES.Frm_Usuario;

namespace IGREJA_SERES
{
    public partial class FormLogin : Form
    {






        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string ID;
            string con = "SERVER=localhost; DATABASE=capelania; UID=root; PWD=1234";
            var conexao = new MySqlConnection(con);
            var comando = conexao.CreateCommand();
            MySqlCommand query = new MySqlCommand("SELECT count(*) from usuario where Login  ='" + txtLogin.Text + "' and Senha ='" + txtSenha.Text + "'", conexao);
            conexao.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);


            foreach (DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    MySqlCommand verificaPerfil = new MySqlCommand("SELECT idperfil from usuario where Login  ='" + txtLogin.Text + "' and Senha ='" + txtSenha.Text + "'", conexao);
                  
                    DataTable DataTable = new DataTable();
                    MySqlDataAdapter Da = new MySqlDataAdapter(query);
                    da.Fill(DataTable);

                    foreach (DataRow Lista in DataTable.Rows)
                    {
                        if (Convert.ToInt32(Lista.ItemArray[0]) == 2) { 

                        MessageBox.Show("Usuario Validado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                            Form f = new FormMenu();
                            f.Closed += (s, args) => this.Close();
                            f.Show();

                        }
                        else
                        {
                            MessageBox.Show("Usuario Validado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form f = new FormMenu();
                            f.Closed += (s, args) => this.Close();
                            f.Show();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuário Invalido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }


            conexao.Close();


        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LinkEsquece_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new FormIgreja();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEntrar;
        }
    }
}
