namespace ProjekPBO_PSQL.Views
{
    partial class FormTambahJadwal
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
            dtpTanggal = new DateTimePicker();
            txtKeterangan = new TextBox();
            txtTotalUpah = new TextBox();
            btnTambah = new Button();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtIdPelanggan = new TextBox();
            txtIdLahan = new TextBox();
            txtJumlahAnggota = new TextBox();
            label6 = new Label();
            cbStatusGlobal = new ComboBox();
            cbTipeJadwal = new ComboBox();
            label1 = new Label();
            btnBatal = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "yyyy-MM-dd";
            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.Location = new Point(192, 91);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(310, 27);
            dtpTanggal.TabIndex = 17;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(192, 142);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(310, 27);
            txtKeterangan.TabIndex = 14;
            // 
            // txtTotalUpah
            // 
            txtTotalUpah.Location = new Point(192, 311);
            txtTotalUpah.Name = "txtTotalUpah";
            txtTotalUpah.Size = new Size(310, 27);
            txtTotalUpah.TabIndex = 13;
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
            label9.Location = new Point(542, 145);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 9;
            label9.Text = "Pelanggan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(542, 91);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 8;
            label8.Text = "Lahan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 366);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 5;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 314);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 4;
            label4.Text = "Total Upah";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 257);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Banyak Anggota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 149);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Keterangan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtIdPelanggan);
            panel1.Controls.Add(txtIdLahan);
            panel1.Controls.Add(txtJumlahAnggota);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbStatusGlobal);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(cbTipeJadwal);
            panel1.Controls.Add(txtKeterangan);
            panel1.Controls.Add(txtTotalUpah);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 2;
            // 
            // txtIdPelanggan
            // 
            txtIdPelanggan.Location = new Point(635, 142);
            txtIdPelanggan.Name = "txtIdPelanggan";
            txtIdPelanggan.Size = new Size(310, 27);
            txtIdPelanggan.TabIndex = 26;
            // 
            // txtIdLahan
            // 
            txtIdLahan.Location = new Point(635, 88);
            txtIdLahan.Name = "txtIdLahan";
            txtIdLahan.Size = new Size(310, 27);
            txtIdLahan.TabIndex = 25;
            // 
            // txtJumlahAnggota
            // 
            txtJumlahAnggota.Location = new Point(192, 254);
            txtJumlahAnggota.Name = "txtJumlahAnggota";
            txtJumlahAnggota.Size = new Size(310, 27);
            txtJumlahAnggota.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 200);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 23;
            label6.Text = "Tipe Jadwal";
            // 
            // cbStatusGlobal
            // 
            cbStatusGlobal.FormattingEnabled = true;
            cbStatusGlobal.Items.AddRange(new object[] { "Belum Dikerjakan", "Dalam Pengerjaan", "Sudah Dikerjakan", "Gagal", "Kendala" });
            cbStatusGlobal.Location = new Point(192, 363);
            cbStatusGlobal.Name = "cbStatusGlobal";
            cbStatusGlobal.Size = new Size(310, 28);
            cbStatusGlobal.TabIndex = 21;
            // 
            // cbTipeJadwal
            // 
            cbTipeJadwal.FormattingEnabled = true;
            cbTipeJadwal.Items.AddRange(new object[] { "Farmer", "Pengantar" });
            cbTipeJadwal.Location = new Point(192, 197);
            cbTipeJadwal.Name = "cbTipeJadwal";
            cbTipeJadwal.Size = new Size(310, 28);
            cbTipeJadwal.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 91);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Tanggal";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(3, 3);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click_1;
            // 
            // FormTambahJadwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormTambahJadwal";
            Text = "Form1";
            Load += FormTambahJadwal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btnBatal;
        private Label label6;
        public DateTimePicker dtpTanggal;
        public TextBox txtKeterangan;
        public TextBox txtTotalUpah;
        public ComboBox cbStatusGlobal;
        public TextBox txtJumlahAnggota;
        public ComboBox cbTipeJadwal;
        public TextBox txtIdPelanggan;
        public TextBox txtIdLahan;
    }
}