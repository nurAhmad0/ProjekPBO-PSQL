namespace ProjekPBO_PSQL.Views
{
    partial class FormTambahPelanggan
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
            txtNama = new TextBox();
            txtNoTelp = new TextBox();
            btnTambah = new Button();
            panel1 = new Panel();
            txtAlamat = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBatal = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(384, 108);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(310, 27);
            txtNama.TabIndex = 15;
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(384, 182);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(310, 27);
            txtNoTelp.TabIndex = 14;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(839, 463);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(txtNoTelp);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 4;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(384, 334);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(310, 27);
            txtAlamat.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 337);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 17;
            label3.Text = "Alamat";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(384, 260);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 27);
            txtEmail.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 263);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 189);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "No. Telp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 111);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Pelanggan";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(3, 3);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // FormTambahPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormTambahPelanggan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button btnBatal;
        private Label label3;
        public TextBox txtNama;
        public TextBox txtNoTelp;
        public TextBox txtAlamat;
        public TextBox txtEmail;
    }
}