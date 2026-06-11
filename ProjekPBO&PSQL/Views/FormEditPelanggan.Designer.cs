namespace ProjekPBO_PSQL.Views
{
    partial class FormEditPelanggan
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
            panel1 = new Panel();
            txtAlamat = new TextBox();
            btnHapus = new Button();
            label3 = new Label();
            txtIdPelanggan = new TextBox();
            txtEmail = new TextBox();
            label10 = new Label();
            txtNama = new TextBox();
            btnUpdate = new Button();
            txtNoTelp = new TextBox();
            label5 = new Label();
            btnBatal = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtIdPelanggan);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtNoTelp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnBatal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 5;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(395, 350);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(310, 27);
            txtAlamat.TabIndex = 26;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 128, 128);
            btnHapus.Location = new Point(812, 469);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(126, 29);
            btnHapus.TabIndex = 34;
            btnHapus.Text = "HAPUS BARIS";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 353);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 25;
            label3.Text = "Alamat";
            // 
            // txtIdPelanggan
            // 
            txtIdPelanggan.Location = new Point(194, 467);
            txtIdPelanggan.Name = "txtIdPelanggan";
            txtIdPelanggan.ReadOnly = true;
            txtIdPelanggan.Size = new Size(310, 27);
            txtIdPelanggan.TabIndex = 33;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(395, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 27);
            txtEmail.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(59, 474);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 32;
            label10.Text = "ID";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(395, 124);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(310, 27);
            txtNama.TabIndex = 23;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdate.Location = new Point(690, 469);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(395, 198);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(310, 27);
            txtNoTelp.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 279);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(3, 3);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 205);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 20;
            label2.Text = "No. Telp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 127);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 19;
            label1.Text = "Nama Pelanggan";
            // 
            // FormEditPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormEditPelanggan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnBatal;
        private Button btnHapus;
        private TextBox textBox7;
        private Label label10;
        private Button btnUpdate;
        public TextBox txtIdPelanggan;
        public TextBox txtAlamat;
        private Label label3;
        public TextBox txtEmail;
        public TextBox txtNama;
        public TextBox txtNoTelp;
        private Label label5;
        private Label label2;
        private Label label1;
    }
}