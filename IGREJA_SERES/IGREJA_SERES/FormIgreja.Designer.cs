namespace IGREJA_SERES.Frm_Usuario
{
    partial class FormIgreja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIgreja));
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.txtIgreja = new System.Windows.Forms.TextBox();
            this.lbigreja = new System.Windows.Forms.Label();
            this.txtPastorRep = new System.Windows.Forms.TextBox();
            this.lbPastor = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTOP = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbPresidio = new System.Windows.Forms.ComboBox();
            this.dgvIgreja = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bntEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            this.pnlTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgreja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1188, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(53, 37);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 6;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1126, 6);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(53, 37);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmin.TabIndex = 7;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // txtIgreja
            // 
            this.txtIgreja.Location = new System.Drawing.Point(382, 164);
            this.txtIgreja.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtIgreja.MaxLength = 20;
            this.txtIgreja.Multiline = true;
            this.txtIgreja.Name = "txtIgreja";
            this.txtIgreja.Size = new System.Drawing.Size(376, 30);
            this.txtIgreja.TabIndex = 22;
            this.txtIgreja.TextChanged += new System.EventHandler(this.txtIgreja_TextChanged);
            // 
            // lbigreja
            // 
            this.lbigreja.AutoSize = true;
            this.lbigreja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbigreja.ForeColor = System.Drawing.Color.White;
            this.lbigreja.Location = new System.Drawing.Point(281, 164);
            this.lbigreja.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbigreja.Name = "lbigreja";
            this.lbigreja.Size = new System.Drawing.Size(93, 16);
            this.lbigreja.TabIndex = 23;
            this.lbigreja.Text = "Nome Igreja";
            this.lbigreja.Click += new System.EventHandler(this.lbigreja_Click);
            // 
            // txtPastorRep
            // 
            this.txtPastorRep.Location = new System.Drawing.Point(381, 203);
            this.txtPastorRep.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtPastorRep.MaxLength = 20;
            this.txtPastorRep.Multiline = true;
            this.txtPastorRep.Name = "txtPastorRep";
            this.txtPastorRep.Size = new System.Drawing.Size(376, 30);
            this.txtPastorRep.TabIndex = 24;
            this.txtPastorRep.TextChanged += new System.EventHandler(this.txtPastorRep_TextChanged);
            // 
            // lbPastor
            // 
            this.lbPastor.AutoSize = true;
            this.lbPastor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPastor.ForeColor = System.Drawing.Color.White;
            this.lbPastor.Location = new System.Drawing.Point(223, 209);
            this.lbPastor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbPastor.Name = "lbPastor";
            this.lbPastor.Size = new System.Drawing.Size(149, 16);
            this.lbPastor.TabIndex = 25;
            this.lbPastor.Text = "Pastor Responsável";
            this.lbPastor.Click += new System.EventHandler(this.lbPastor_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(381, 246);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(376, 30);
            this.txtNumero.TabIndex = 29;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(242, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Número do pastor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(487, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cadastro de Ìgrejas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlTOP
            // 
            this.pnlTOP.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlTOP.Controls.Add(this.label1);
            this.pnlTOP.Controls.Add(this.pictureBox1);
            this.pnlTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTOP.Location = new System.Drawing.Point(0, 0);
            this.pnlTOP.Name = "pnlTOP";
            this.pnlTOP.Size = new System.Drawing.Size(1250, 62);
            this.pnlTOP.TabIndex = 33;
            this.pnlTOP.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTOP_Paint);
            this.pnlTOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTOP_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1179, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbPresidio
            // 
            this.cmbPresidio.FormattingEnabled = true;
            this.cmbPresidio.Location = new System.Drawing.Point(384, 123);
            this.cmbPresidio.Name = "cmbPresidio";
            this.cmbPresidio.Size = new System.Drawing.Size(212, 24);
            this.cmbPresidio.TabIndex = 36;
            this.cmbPresidio.SelectedIndexChanged += new System.EventHandler(this.cmbPresidio_SelectedIndexChanged);
            this.cmbPresidio.SelectedValueChanged += new System.EventHandler(this.cmbPresidio_SelectedValueChanged);
            // 
            // dgvIgreja
            // 
            this.dgvIgreja.AllowUserToAddRows = false;
            this.dgvIgreja.AllowUserToDeleteRows = false;
            this.dgvIgreja.AllowUserToOrderColumns = true;
            this.dgvIgreja.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvIgreja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgreja.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvIgreja.Location = new System.Drawing.Point(303, 286);
            this.dgvIgreja.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dgvIgreja.MultiSelect = false;
            this.dgvIgreja.Name = "dgvIgreja";
            this.dgvIgreja.ReadOnly = true;
            this.dgvIgreja.RowHeadersVisible = false;
            this.dgvIgreja.Size = new System.Drawing.Size(497, 221);
            this.dgvIgreja.TabIndex = 37;
            this.dgvIgreja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIgreja_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Presídios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntSalvar.FlatAppearance.BorderSize = 0;
            this.bntSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.bntSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvar.ForeColor = System.Drawing.Color.White;
            this.bntSalvar.Image = ((System.Drawing.Image)(resources.GetObject("bntSalvar.Image")));
            this.bntSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSalvar.Location = new System.Drawing.Point(814, 464);
            this.bntSalvar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(174, 34);
            this.bntSalvar.TabIndex = 39;
            this.bntSalvar.Text = "Adicionar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(708, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(52, 22);
            this.txtID.TabIndex = 40;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(682, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(814, 420);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(174, 34);
            this.btnDeletar.TabIndex = 42;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(369, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntEditar.FlatAppearance.BorderSize = 0;
            this.bntEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.bntEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.bntEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEditar.ForeColor = System.Drawing.Color.White;
            this.bntEditar.Image = ((System.Drawing.Image)(resources.GetObject("bntEditar.Image")));
            this.bntEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntEditar.Location = new System.Drawing.Point(814, 375);
            this.bntEditar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(169, 34);
            this.bntEditar.TabIndex = 44;
            this.bntEditar.Text = "Limpar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // FormIgreja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1250, 597);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIgreja);
            this.Controls.Add(this.cmbPresidio);
            this.Controls.Add(this.pnlTOP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbPastor);
            this.Controls.Add(this.txtPastorRep);
            this.Controls.Add(this.lbigreja);
            this.Controls.Add(this.txtIgreja);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIgreja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecupera";
            this.Load += new System.EventHandler(this.FormIgreja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            this.pnlTOP.ResumeLayout(false);
            this.pnlTOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgreja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.TextBox txtIgreja;
        private System.Windows.Forms.Label lbigreja;
        private System.Windows.Forms.TextBox txtPastorRep;
        private System.Windows.Forms.Label lbPastor;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTOP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbPresidio;
        private System.Windows.Forms.DataGridView dgvIgreja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntEditar;
    }
}