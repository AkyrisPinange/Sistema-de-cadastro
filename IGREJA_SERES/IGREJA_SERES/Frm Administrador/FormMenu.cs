using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using IGREJA_SERES.Frm_Usuario;
namespace IGREJA_SERES
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        { 
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 236)
            {
                MenuVertical.Width = 00;
         
            }
            else
            {
                MenuVertical.Width = 236;
            }
        }
        //Botão Restauras
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Location = new Point(LX, LY);
            this.Size = new Size(1208, 610);
            btnRestaure.Visible = false;
            btnMax.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        int LX, LY;
        private void btnMax_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaure.Visible = true;
            btnMax.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTOP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0); 

        }

        private void AbrirFormMenu(object formFilho)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
           Form fh = formFilho as Form;
           fh.TopLevel = false;
           fh.Dock = DockStyle.Fill;
           this.PanelPrincipal.Controls.Add(fh);
           this.PanelPrincipal.Tag = fh;
           fh.Show();
            

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            AbrirFormMenu(new FormCadUsuario());

        }

        private void btnPresidio_Click(object sender, EventArgs e)
        {
            AbrirFormMenu(new FormCadPresidio());
        }

        private void pnlTOP_Paint(object sender, PaintEventArgs e)
        {

        }
        //Botão de igreja
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormMenu(new FormIgreja());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

     
        }
    
    
    }
}
