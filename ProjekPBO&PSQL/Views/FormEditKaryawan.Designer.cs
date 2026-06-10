namespace ProjekPBO_PSQL.Views
{
    partial class FormEditKaryawan
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
            txtIdRole = new ComboBox();
            btnHapus = new Button();
            txtPassword = new TextBox();
            txtIdAnggota = new TextBox();
            txtUsername = new TextBox();
            label10 = new Label();
            dtpTanggalLahir = new DateTimePicker();
            btnUpdate = new Button();
            cbStatusKerja = new ComboBox();
            btnBatal = new Button();
            txtNama = new TextBox();
            label1 = new Label();
            txtNoTelp = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSaldo = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtIdRole);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtIdAnggota);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dtpTanggalLahir);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(cbStatusKerja);
            panel1.Controls.Add(btnBatal);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNoTelp);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSaldo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 0;
            // 
            // txtIdRole
            // 
            txtIdRole.FormattingEnabled = true;
            txtIdRole.Items.AddRange(new object[] { "Farmer", "Pengantar" });
            txtIdRole.Location = new Point(598, 181);
            txtIdRole.Name = "txtIdRole";
            txtIdRole.Size = new Size(310, 28);
            txtIdRole.TabIndex = 38;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 128, 128);
            btnHapus.Location = new Point(807, 463);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(126, 29);
            btnHapus.TabIndex = 23;
            btnHapus.Text = "HAPUS BARIS";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(598, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 27);
            txtPassword.TabIndex = 37;
            // 
            // txtIdAnggota
            // 
            txtIdAnggota.Location = new Point(164, 463);
            txtIdAnggota.Name = "txtIdAnggota";
            txtIdAnggota.ReadOnly = true;
            txtIdAnggota.Size = new Size(310, 27);
            txtIdAnggota.TabIndex = 22;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(598, 74);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 27);
            txtUsername.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 469);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 21;
            label10.Text = "ID";
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.CustomFormat = "yyyy-MM-dd";
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.Location = new Point(167, 181);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(310, 27);
            dtpTanggalLahir.TabIndex = 35;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdate.Location = new Point(685, 463);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbStatusKerja
            // 
            cbStatusKerja.FormattingEnabled = true;
            cbStatusKerja.Items.AddRange(new object[] { "Aktif", "Tidak Aktif" });
            cbStatusKerja.Location = new Point(167, 292);
            cbStatusKerja.Name = "cbStatusKerja";
            cbStatusKerja.Size = new Size(310, 28);
            cbStatusKerja.TabIndex = 34;
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
            // txtNama
            // 
            txtNama.Location = new Point(167, 74);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(310, 27);
            txtNama.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(58, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 21;
            label1.Text = "Nama";
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(167, 128);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(310, 27);
            txtNoTelp.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(57, 135);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 22;
            label2.Text = "No. Telp";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 27);
            txtEmail.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(57, 186);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 23;
            label3.Text = "Tanggal Lahir";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(167, 350);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(310, 27);
            txtSaldo.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(57, 234);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 24;
            label4.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(517, 135);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 29;
            label9.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(57, 295);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 25;
            label5.Text = "Status Kerja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(517, 77);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 28;
            label8.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(57, 357);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 26;
            label6.Text = "Saldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(517, 184);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 27;
            label7.Text = "Role";
            // 
            // FormEditKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormEditKaryawan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBatal;
        private Button btnUpdate;
        private Button btnHapus;
        private Label label10;
        public ComboBox txtIdRole;
        public TextBox txtPassword;
        public TextBox txtUsername;
        public DateTimePicker dtpTanggalLahir;
        public ComboBox cbStatusKerja;
        public TextBox txtNama;
        private Label label1;
        public TextBox txtNoTelp;
        private Label label2;
        public TextBox txtEmail;
        private Label label3;
        public TextBox txtSaldo;
        private Label label4;
        private Label label9;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label7;
        public TextBox txtIdAnggota;
    }
}