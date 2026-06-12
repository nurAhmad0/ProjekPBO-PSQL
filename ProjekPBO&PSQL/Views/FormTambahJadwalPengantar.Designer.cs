namespace ProjekPBO_PSQL.Views
{
    partial class FormTambahJadwalPengantaran
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
            labe = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            cbPengantar = new ComboBox();
            label7 = new Label();
            cbPelanggan = new ComboBox();
            txtTipeJadwal = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnBatal = new Button();
            cbTanaman = new ComboBox();
            txtJumlahDibeli = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            btHapus = new Button();
            btBuatJadwal = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txtTotalUpah.Location = new Point(192, 256);
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
            btnTambah.Text = "Selanjutnya";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(539, 91);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 9;
            label9.Text = "Pelanggan";
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.Location = new Point(264, 24);
            labe.Name = "labe";
            labe.Size = new Size(68, 20);
            labe.TabIndex = 8;
            labe.Text = "Tanaman";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 263);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 4;
            label4.Text = "Total Upah";
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
            panel1.Controls.Add(cbPengantar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbPelanggan);
            panel1.Controls.Add(txtTipeJadwal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(txtKeterangan);
            panel1.Controls.Add(txtTotalUpah);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 2;
            // 
            // cbPengantar
            // 
            cbPengantar.FormattingEnabled = true;
            cbPengantar.Location = new Point(636, 142);
            cbPengantar.Name = "cbPengantar";
            cbPengantar.Size = new Size(297, 28);
            cbPengantar.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 149);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 32;
            label7.Text = "Pengantar";
            // 
            // cbPelanggan
            // 
            cbPelanggan.FormattingEnabled = true;
            cbPelanggan.Location = new Point(635, 93);
            cbPelanggan.Name = "cbPelanggan";
            cbPelanggan.Size = new Size(298, 28);
            cbPelanggan.TabIndex = 30;
            // 
            // txtTipeJadwal
            // 
            txtTipeJadwal.Location = new Point(192, 200);
            txtTipeJadwal.Multiline = true;
            txtTipeJadwal.Name = "txtTipeJadwal";
            txtTipeJadwal.Size = new Size(310, 27);
            txtTipeJadwal.TabIndex = 27;
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
            // cbTanaman
            // 
            cbTanaman.FormattingEnabled = true;
            cbTanaman.Location = new Point(153, 69);
            cbTanaman.Name = "cbTanaman";
            cbTanaman.Size = new Size(297, 28);
            cbTanaman.TabIndex = 31;
            // 
            // txtJumlahDibeli
            // 
            txtJumlahDibeli.Location = new Point(529, 69);
            txtJumlahDibeli.Name = "txtJumlahDibeli";
            txtJumlahDibeli.Size = new Size(310, 27);
            txtJumlahDibeli.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(624, 24);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 28;
            label5.Text = "Jumlah Dibeli";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(btHapus);
            panel2.Controls.Add(btBuatJadwal);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtJumlahDibeli);
            panel2.Controls.Add(labe);
            panel2.Controls.Add(cbTanaman);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 500);
            panel2.TabIndex = 3;
            // 
            // btHapus
            // 
            btHapus.Location = new Point(109, 399);
            btHapus.Name = "btHapus";
            btHapus.Size = new Size(146, 29);
            btHapus.TabIndex = 35;
            btHapus.Text = "Hapus Produk";
            btHapus.UseVisualStyleBackColor = true;
            // 
            // btBuatJadwal
            // 
            btBuatJadwal.Location = new Point(804, 468);
            btBuatJadwal.Name = "btBuatJadwal";
            btBuatJadwal.Size = new Size(142, 29);
            btBuatJadwal.TabIndex = 34;
            btBuatJadwal.Text = "Buat Jadwal";
            btBuatJadwal.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(114, 150);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 33;
            label8.Text = "Keranjang";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 209);
            dataGridView1.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(16, 15);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "BATAL";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormTambahJadwalPengantaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormTambahJadwalPengantaran";
            Text = "Form1";
            Load += FormTambahJadwal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private Label label9;
        private Label labe;
        private Label label4;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btnBatal;
        private Label label6;
        public DateTimePicker dtpTanggal;
        public TextBox txtKeterangan;
        public TextBox txtTotalUpah;
        public TextBox txtTipeJadwal;
        private ComboBox cbTanaman;
        private ComboBox cbPelanggan;
        private TextBox txtJumlahDibeli;
        private Label label5;
        private ComboBox cbPengantar;
        private Label label7;
        private Panel panel2;
        private Button btBuatJadwal;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btHapus;
    }
}