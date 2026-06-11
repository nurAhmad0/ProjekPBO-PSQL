namespace ProjekPBO_PSQL.Views
{
    partial class FormEditJadwal
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
            btnHapus = new Button();
            txtIdJadwal = new TextBox();
            txtJumlahAnggota = new TextBox();
            label10 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            cbStatusGlobal = new ComboBox();
            btnBatal = new Button();
            dtpTanggal = new DateTimePicker();
            label1 = new Label();
            cbTipeJadwal = new ComboBox();
            label2 = new Label();
            txtKeterangan = new TextBox();
            label3 = new Label();
            txtTotalUpah = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            cbPelanggan = new ComboBox();
            cbLahan = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(cbLahan);
            panel1.Controls.Add(cbPelanggan);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(txtIdJadwal);
            panel1.Controls.Add(txtJumlahAnggota);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(cbStatusGlobal);
            panel1.Controls.Add(btnBatal);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbTipeJadwal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtKeterangan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTotalUpah);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 3;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 128, 128);
            btnHapus.Location = new Point(810, 468);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(126, 29);
            btnHapus.TabIndex = 30;
            btnHapus.Text = "HAPUS BARIS";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // txtIdJadwal
            // 
            txtIdJadwal.Location = new Point(192, 466);
            txtIdJadwal.Name = "txtIdJadwal";
            txtIdJadwal.ReadOnly = true;
            txtIdJadwal.Size = new Size(310, 27);
            txtIdJadwal.TabIndex = 29;
            // 
            // txtJumlahAnggota
            // 
            txtJumlahAnggota.Location = new Point(191, 261);
            txtJumlahAnggota.Name = "txtJumlahAnggota";
            txtJumlahAnggota.Size = new Size(310, 27);
            txtJumlahAnggota.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(57, 473);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 28;
            label10.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 207);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 39;
            label6.Text = "Tipe Jadwal";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdate.Location = new Point(688, 468);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // cbStatusGlobal
            // 
            cbStatusGlobal.FormattingEnabled = true;
            cbStatusGlobal.Items.AddRange(new object[] { "Belum Dikerjakan", "Dalam Pengerjaan", "Sudah Dikerjakan", "Gagal", "Kendala" });
            cbStatusGlobal.Location = new Point(191, 370);
            cbStatusGlobal.Name = "cbStatusGlobal";
            cbStatusGlobal.Size = new Size(310, 28);
            cbStatusGlobal.TabIndex = 38;
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
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "yyyy-MM-dd";
            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.Location = new Point(191, 98);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(310, 27);
            dtpTanggal.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 98);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 27;
            label1.Text = "Tanggal";
            // 
            // cbTipeJadwal
            // 
            cbTipeJadwal.FormattingEnabled = true;
            cbTipeJadwal.Items.AddRange(new object[] { "Farmer", "Pengantar" });
            cbTipeJadwal.Location = new Point(191, 204);
            cbTipeJadwal.Name = "cbTipeJadwal";
            cbTipeJadwal.Size = new Size(310, 28);
            cbTipeJadwal.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 156);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 28;
            label2.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(191, 149);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(310, 27);
            txtKeterangan.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 264);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 29;
            label3.Text = "Banyak Anggota";
            // 
            // txtTotalUpah
            // 
            txtTotalUpah.Location = new Point(191, 318);
            txtTotalUpah.Name = "txtTotalUpah";
            txtTotalUpah.Size = new Size(310, 27);
            txtTotalUpah.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 321);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 30;
            label4.Text = "Total Upah";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(541, 152);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 33;
            label9.Text = "Pelanggan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 373);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 31;
            label5.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(541, 98);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 32;
            label8.Text = "Lahan";
            // 
            // cbPelanggan
            // 
            cbPelanggan.FormattingEnabled = true;
            cbPelanggan.Items.AddRange(new object[] { "Belum Dikerjakan", "Dalam Pengerjaan", "Sudah Dikerjakan", "Gagal", "Kendala" });
            cbPelanggan.Location = new Point(634, 152);
            cbPelanggan.Name = "cbPelanggan";
            cbPelanggan.Size = new Size(310, 28);
            cbPelanggan.TabIndex = 42;
            // 
            // cbLahan
            // 
            cbLahan.FormattingEnabled = true;
            cbLahan.Items.AddRange(new object[] { "Belum Dikerjakan", "Dalam Pengerjaan", "Sudah Dikerjakan", "Gagal", "Kendala" });
            cbLahan.Location = new Point(634, 95);
            cbLahan.Name = "cbLahan";
            cbLahan.Size = new Size(310, 28);
            cbLahan.TabIndex = 43;
            // 
            // FormEditJadwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormEditJadwal";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnBatal;
        private Button btnHapus;
        private Label label10;
        private Button btnUpdate;
        public TextBox txtJumlahAnggota;
        private Label label6;
        public ComboBox cbStatusGlobal;
        public DateTimePicker dtpTanggal;
        private Label label1;
        public ComboBox cbTipeJadwal;
        private Label label2;
        public TextBox txtKeterangan;
        private Label label3;
        public TextBox txtTotalUpah;
        private Label label4;
        private Label label9;
        private Label label5;
        private Label label8;
        public TextBox txtIdJadwal;
        public ComboBox cbLahan;
        public ComboBox cbPelanggan;
    }
}