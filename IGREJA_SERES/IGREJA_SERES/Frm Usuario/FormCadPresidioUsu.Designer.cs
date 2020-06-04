namespace IGREJA_SERES
{
    partial class FormCadPresidioUsu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadPresidioUsu));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePresidio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefoneUp = new System.Windows.Forms.TextBox();
            this.txtEmailInstUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiretor = new System.Windows.Forms.TextBox();
            this.txtTelefoneDiretor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailChefe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChefeSeg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefoneSeg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailInstSeg = new System.Windows.Forms.TextBox();
            this.dgvPresidio = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresidio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Presídio";
            // 
            // txtNomePresidio
            // 
            this.txtNomePresidio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNomePresidio.Enabled = false;
            this.txtNomePresidio.Location = new System.Drawing.Point(13, 63);
            this.txtNomePresidio.Name = "txtNomePresidio";
            this.txtNomePresidio.Size = new System.Drawing.Size(280, 20);
            this.txtNomePresidio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txtTelefoneUp
            // 
            this.txtTelefoneUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefoneUp.Enabled = false;
            this.txtTelefoneUp.Location = new System.Drawing.Point(312, 63);
            this.txtTelefoneUp.MaxLength = 13;
            this.txtTelefoneUp.Name = "txtTelefoneUp";
            this.txtTelefoneUp.Size = new System.Drawing.Size(133, 20);
            this.txtTelefoneUp.TabIndex = 3;
            this.txtTelefoneUp.TextChanged += new System.EventHandler(this.txtTelefoneUp_TextChanged);
            this.txtTelefoneUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneUp_KeyPress);
            // 
            // txtEmailInstUp
            // 
            this.txtEmailInstUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmailInstUp.Enabled = false;
            this.txtEmailInstUp.Location = new System.Drawing.Point(469, 63);
            this.txtEmailInstUp.Name = "txtEmailInstUp";
            this.txtEmailInstUp.Size = new System.Drawing.Size(280, 20);
            this.txtEmailInstUp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Inst.";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(768, 63);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(162, 20);
            this.txtCNPJ.TabIndex = 6;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(765, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNPJ.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chefe/Diretor";
            // 
            // txtdiretor
            // 
            this.txtdiretor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtdiretor.Enabled = false;
            this.txtdiretor.Location = new System.Drawing.Point(13, 114);
            this.txtdiretor.Name = "txtdiretor";
            this.txtdiretor.Size = new System.Drawing.Size(280, 20);
            this.txtdiretor.TabIndex = 9;
            // 
            // txtTelefoneDiretor
            // 
            this.txtTelefoneDiretor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefoneDiretor.Enabled = false;
            this.txtTelefoneDiretor.Location = new System.Drawing.Point(312, 114);
            this.txtTelefoneDiretor.MaxLength = 13;
            this.txtTelefoneDiretor.Name = "txtTelefoneDiretor";
            this.txtTelefoneDiretor.Size = new System.Drawing.Size(133, 20);
            this.txtTelefoneDiretor.TabIndex = 10;
            this.txtTelefoneDiretor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneDiretor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(309, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(466, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email Inst.";
            // 
            // txtEmailChefe
            // 
            this.txtEmailChefe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmailChefe.Enabled = false;
            this.txtEmailChefe.Location = new System.Drawing.Point(469, 114);
            this.txtEmailChefe.Name = "txtEmailChefe";
            this.txtEmailChefe.Size = new System.Drawing.Size(280, 20);
            this.txtEmailChefe.TabIndex = 13;
            this.txtEmailChefe.TextChanged += new System.EventHandler(this.txtEmailChefe_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Chefe de Segurança";
            // 
            // txtChefeSeg
            // 
            this.txtChefeSeg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtChefeSeg.Enabled = false;
            this.txtChefeSeg.Location = new System.Drawing.Point(11, 166);
            this.txtChefeSeg.Name = "txtChefeSeg";
            this.txtChefeSeg.Size = new System.Drawing.Size(280, 20);
            this.txtChefeSeg.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(309, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefone";
            // 
            // txtTelefoneSeg
            // 
            this.txtTelefoneSeg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefoneSeg.Enabled = false;
            this.txtTelefoneSeg.Location = new System.Drawing.Point(312, 166);
            this.txtTelefoneSeg.MaxLength = 13;
            this.txtTelefoneSeg.Name = "txtTelefoneSeg";
            this.txtTelefoneSeg.Size = new System.Drawing.Size(133, 20);
            this.txtTelefoneSeg.TabIndex = 17;
            this.txtTelefoneSeg.TextChanged += new System.EventHandler(this.txtTelefoneSeg_TextChanged);
            this.txtTelefoneSeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneSeg_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(466, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email Inst.";
            // 
            // txtEmailInstSeg
            // 
            this.txtEmailInstSeg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmailInstSeg.Enabled = false;
            this.txtEmailInstSeg.Location = new System.Drawing.Point(469, 166);
            this.txtEmailInstSeg.Name = "txtEmailInstSeg";
            this.txtEmailInstSeg.Size = new System.Drawing.Size(280, 20);
            this.txtEmailInstSeg.TabIndex = 19;
            // 
            // dgvPresidio
            // 
            this.dgvPresidio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPresidio.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresidio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPresidio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPresidio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPresidio.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvPresidio.Location = new System.Drawing.Point(11, 233);
            this.dgvPresidio.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPresidio.MultiSelect = false;
            this.dgvPresidio.Name = "dgvPresidio";
            this.dgvPresidio.ReadOnly = true;
            this.dgvPresidio.Size = new System.Drawing.Size(751, 365);
            this.dgvPresidio.TabIndex = 26;
            this.dgvPresidio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresidio_CellDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 29);
            this.label15.TabIndex = 29;
            this.label15.Text = "Presídios";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(793, 361);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 37);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(13, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 33;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(793, 298);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 37);
            this.btnAdicionar.TabIndex = 34;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Visible = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntEditar.FlatAppearance.BorderSize = 0;
            this.bntEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.bntEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.bntEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEditar.ForeColor = System.Drawing.Color.White;
            this.bntEditar.Image = ((System.Drawing.Image)(resources.GetObject("bntEditar.Image")));
            this.bntEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntEditar.Location = new System.Drawing.Point(793, 417);
            this.bntEditar.Margin = new System.Windows.Forms.Padding(4);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(120, 37);
            this.bntEditar.TabIndex = 35;
            this.bntEditar.Text = "Cancelar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Visible = false;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // FormCadPresidioUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(951, 656);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvPresidio);
            this.Controls.Add(this.txtEmailInstSeg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelefoneSeg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtChefeSeg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmailChefe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefoneDiretor);
            this.Controls.Add(this.txtdiretor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailInstUp);
            this.Controls.Add(this.txtTelefoneUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePresidio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadPresidioUsu";
            this.Text = "FormCadPresidio";
            this.Load += new System.EventHandler(this.FormCadPresidio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresidio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePresidio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefoneUp;
        private System.Windows.Forms.TextBox txtEmailInstUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiretor;
        private System.Windows.Forms.TextBox txtTelefoneDiretor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailChefe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChefeSeg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefoneSeg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailInstSeg;
        private System.Windows.Forms.DataGridView dgvPresidio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button bntEditar;
    }
}