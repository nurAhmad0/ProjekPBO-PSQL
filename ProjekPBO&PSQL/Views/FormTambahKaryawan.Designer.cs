namespace ProjekPBO_PSQL.Views
{
    partial class FormTambahKaryawan
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
            txtIdRole = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            dtpTanggalLahir = new DateTimePicker();
            cbStatusKerja = new ComboBox();
            txtNama = new TextBox();
            txtNoTelp = new TextBox();
            txtEmail = new TextBox();
            txtSaldo = new TextBox();
            btnTambah = new Button();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnBatal = new Button();
            panel1 = new Panel();
            label8 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdRole
            // 
            txtIdRole.FormattingEnabled = true;
            txtIdRole.Items.AddRange(new object[] { "Farmer", "Pengantar" });
            txtIdRole.Location = new Point(623, 195);
            txtIdRole.Name = "txtIdRole";
            txtIdRole.Size = new Size(310, 28);
            txtIdRole.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(623, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 27);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(623, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 27);
            txtUsername.TabIndex = 18;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.CustomFormat = "yyyy-MM-dd";
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.Location = new Point(192, 195);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(310, 27);
            dtpTanggalLahir.TabIndex = 17;
            // 
            // cbStatusKerja
            // 
            cbStatusKerja.FormattingEnabled = true;
            cbStatusKerja.Items.AddRange(new object[] { "Belum Dikerjakan", "Dalam Pengerjaan", "Sudah Dikerjakan", "Gagal", "Kendala" });
            cbStatusKerja.Location = new Point(192, 306);
            cbStatusKerja.Name = "cbStatusKerja";
            cbStatusKerja.Size = new Size(310, 28);
            cbStatusKerja.TabIndex = 16;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(192, 88);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(310, 27);
            txtNama.TabIndex = 15;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(192, 142);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(310, 27);
            txtNoTelp.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(192, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(192, 364);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(310, 27);
            txtSaldo.TabIndex = 12;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(542, 149);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 9;
            label9.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(542, 198);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 7;
            label7.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(82, 371);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 6;
            label6.Text = "Saldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(82, 309);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 5;
            label5.Text = "Status Kerja";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(82, 248);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(82, 200);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 3;
            label3.Text = "Tanggal Lahir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(83, 91);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtIdRole);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(dtpTanggalLahir);
            panel1.Controls.Add(cbStatusKerja);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(txtNoTelp);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSaldo);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(542, 91);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 8;
            label8.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(82, 149);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "No. Telp";
            // 
            // FormTambahKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormTambahKaryawan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnBatal;
        private Panel panel1;
        private Label label8;
        private Label label2;
        public ComboBox txtIdRole;
        public TextBox txtPassword;
        public TextBox txtUsername;
        public DateTimePicker dtpTanggalLahir;
        public ComboBox cbStatusKerja;
        public TextBox txtNama;
        public TextBox txtNoTelp;
        public TextBox txtEmail;
        public TextBox txtSaldo;
    }
}