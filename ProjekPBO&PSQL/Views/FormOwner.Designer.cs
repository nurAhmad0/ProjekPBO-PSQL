namespace ProjekPBO_PSQL.Views
{
    partial class FormOwner
    {
        string bagianAktif = "Karyawan";
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
        private void PindahPanel(Panel panelTujuan, string namaBagian)
        {
            if (bagianAktif == namaBagian)
            {
                MessageBox.Show("Anda sudah ada di bagian ini", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            panelKaryawan.Visible = false;
            panelLahan.Visible = false;
            panelTanaman.Visible = false;
            panelJadwal.Visible = false;
            panelPelanggan.Visible = false;
            panelLainnya.Visible = false;
            panelDetailKaryawan.Visible = false;

            panelTujuan.Visible = true;
            bagianAktif = namaBagian;
        }
        private void InitializeComponent()
        {
            panelTop = new Panel();
            label7 = new Label();
            lblSaldo = new Label();
            lblNama = new Label();
            pictureBox1 = new PictureBox();
            panelBottom = new Panel();
            btnLaporan = new Button();
            btnPelanggan = new Button();
            btnJadwal = new Button();
            btnTanaman = new Button();
            btnLahan = new Button();
            btnKaryawan = new Button();
            panelMiddle = new Panel();
            panelPilihanJadwalFarmer = new Panel();
            label10 = new Label();
            btJadwalFarmerLainnya = new Button();
            btPanen = new Button();
            btTanam = new Button();
            button2 = new Button();
            panelPilihanJadwal = new Panel();
            labelPilihanJadwal = new Label();
            btPengantar = new Button();
            btFarmer = new Button();
            lbBack = new Button();
            panelJadwal = new Panel();
            label4 = new Label();
            dgvJadwal = new DataGridView();
            btnTambahJadwal = new Button();
            btnEditJadwal = new Button();
            panelLainnya = new Panel();
            btPenarikan = new Button();
            btLaporan = new Button();
            label6 = new Label();
            dgvLainnya = new DataGridView();
            panelLahan = new Panel();
            label2 = new Label();
            btnTambahLahan = new Button();
            btnEditLahan = new Button();
            dgvLahan = new DataGridView();
            panelPelanggan = new Panel();
            label5 = new Label();
            btnTambahPelanggan = new Button();
            btnEditPelanggan = new Button();
            dgvPelanggan = new DataGridView();
            panelTanaman = new Panel();
            btTanmanaBelumLaku = new Button();
            bt10TanamanPalingBanyakDitanam = new Button();
            label3 = new Label();
            btnTambahTanaman = new Button();
            btnEditTanaman = new Button();
            dgvTanaman = new DataGridView();
            panelDetailKaryawan = new Panel();
            btEdit = new Button();
            btBack = new Button();
            lbPassword = new Label();
            lbUsername = new Label();
            lbSaldo = new Label();
            lbRole = new Label();
            label12 = new Label();
            lbTanggalLahir = new Label();
            label9 = new Label();
            label8 = new Label();
            lbStatusKerja = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            TanggalLahir = new Label();
            lbID = new Label();
            label11 = new Label();
            lbEmail = new Label();
            lbNOTELP = new Label();
            lbNama = new Label();
            panelKaryawan = new Panel();
            label1 = new Label();
            btnTambahKaryawan = new Button();
            btnEditKaryawan = new Button();
            dgvKaryawan = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelPilihanJadwalFarmer.SuspendLayout();
            panelPilihanJadwal.SuspendLayout();
            panelJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            panelLainnya.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLainnya).BeginInit();
            panelLahan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).BeginInit();
            panelPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).BeginInit();
            panelTanaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).BeginInit();
            panelDetailKaryawan.SuspendLayout();
            panelKaryawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.RosyBrown;
            panelTop.Controls.Add(label7);
            panelTop.Controls.Add(lblSaldo);
            panelTop.Controls.Add(lblNama);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1037, 107);
            panelTop.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(225, 63);
            label7.Name = "label7";
            label7.Size = new Size(75, 31);
            label7.TabIndex = 3;
            label7.Text = "Nama";
            label7.Click += label7_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(104, 63);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(115, 31);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "Saldo: Rp.";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.Transparent;
            lblNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(104, 12);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(75, 31);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Untitled_design;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.RosyBrown;
            panelBottom.Controls.Add(btnLaporan);
            panelBottom.Controls.Add(btnPelanggan);
            panelBottom.Controls.Add(btnJadwal);
            panelBottom.Controls.Add(btnTanaman);
            panelBottom.Controls.Add(btnLahan);
            panelBottom.Controls.Add(btnKaryawan);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 487);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1037, 66);
            panelBottom.TabIndex = 1;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(681, 16);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(117, 38);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "LAINNYA";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPelanggan
            // 
            btnPelanggan.Location = new Point(545, 16);
            btnPelanggan.Name = "btnPelanggan";
            btnPelanggan.Size = new Size(117, 38);
            btnPelanggan.TabIndex = 4;
            btnPelanggan.Text = "PELANGGAN";
            btnPelanggan.UseVisualStyleBackColor = true;
            btnPelanggan.Click += btnPelanggan_Click;
            // 
            // btnJadwal
            // 
            btnJadwal.Location = new Point(411, 16);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(117, 38);
            btnJadwal.TabIndex = 3;
            btnJadwal.Text = "JADWAL";
            btnJadwal.UseVisualStyleBackColor = true;
            btnJadwal.Click += btnJadwal_Click;
            // 
            // btnTanaman
            // 
            btnTanaman.Location = new Point(278, 16);
            btnTanaman.Name = "btnTanaman";
            btnTanaman.Size = new Size(117, 38);
            btnTanaman.TabIndex = 2;
            btnTanaman.Text = "TANAMAN";
            btnTanaman.UseVisualStyleBackColor = true;
            btnTanaman.Click += btnTanaman_Click;
            // 
            // btnLahan
            // 
            btnLahan.Location = new Point(145, 16);
            btnLahan.Name = "btnLahan";
            btnLahan.Size = new Size(117, 38);
            btnLahan.TabIndex = 1;
            btnLahan.Text = "LAHAN";
            btnLahan.UseVisualStyleBackColor = true;
            btnLahan.Click += btnLahan_Click;
            // 
            // btnKaryawan
            // 
            btnKaryawan.Location = new Point(13, 16);
            btnKaryawan.Name = "btnKaryawan";
            btnKaryawan.Size = new Size(117, 38);
            btnKaryawan.TabIndex = 0;
            btnKaryawan.Text = "KARYAWAN";
            btnKaryawan.UseVisualStyleBackColor = true;
            btnKaryawan.Click += btnKaryawan_Click;
            // 
            // panelMiddle
            // 
            panelMiddle.Controls.Add(panelPilihanJadwalFarmer);
            panelMiddle.Controls.Add(panelPilihanJadwal);
            panelMiddle.Controls.Add(panelJadwal);
            panelMiddle.Controls.Add(panelLainnya);
            panelMiddle.Controls.Add(panelLahan);
            panelMiddle.Controls.Add(panelPelanggan);
            panelMiddle.Controls.Add(panelTanaman);
            panelMiddle.Controls.Add(panelDetailKaryawan);
            panelMiddle.Controls.Add(panelKaryawan);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 107);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1037, 380);
            panelMiddle.TabIndex = 2;
            // 
            // panelPilihanJadwalFarmer
            // 
            panelPilihanJadwalFarmer.Controls.Add(label10);
            panelPilihanJadwalFarmer.Controls.Add(btJadwalFarmerLainnya);
            panelPilihanJadwalFarmer.Controls.Add(btPanen);
            panelPilihanJadwalFarmer.Controls.Add(btTanam);
            panelPilihanJadwalFarmer.Controls.Add(button2);
            panelPilihanJadwalFarmer.Location = new Point(0, 0);
            panelPilihanJadwalFarmer.Name = "panelPilihanJadwalFarmer";
            panelPilihanJadwalFarmer.Size = new Size(1035, 382);
            panelPilihanJadwalFarmer.TabIndex = 7;
            panelPilihanJadwalFarmer.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(225, 37);
            label10.Name = "label10";
            label10.Size = new Size(618, 43);
            label10.TabIndex = 11;
            label10.Text = "Template Tugas Jadwal Farmer";
            // 
            // btJadwalFarmerLainnya
            // 
            btJadwalFarmerLainnya.Location = new Point(681, 136);
            btJadwalFarmerLainnya.Name = "btJadwalFarmerLainnya";
            btJadwalFarmerLainnya.Size = new Size(242, 125);
            btJadwalFarmerLainnya.TabIndex = 10;
            btJadwalFarmerLainnya.Text = "Lainnya";
            btJadwalFarmerLainnya.UseVisualStyleBackColor = true;
            btJadwalFarmerLainnya.Click += btJadwalFarmerLainnya_Click;
            // 
            // btPanen
            // 
            btPanen.Location = new Point(393, 136);
            btPanen.Name = "btPanen";
            btPanen.Size = new Size(226, 125);
            btPanen.TabIndex = 9;
            btPanen.Text = "Panen Tanaman";
            btPanen.UseVisualStyleBackColor = true;
            btPanen.Click += btPanen_Click;
            // 
            // btTanam
            // 
            btTanam.Location = new Point(104, 136);
            btTanam.Name = "btTanam";
            btTanam.Size = new Size(217, 125);
            btTanam.TabIndex = 8;
            btTanam.Text = "Tanam Tanaman";
            btTanam.UseVisualStyleBackColor = true;
            btTanam.Click += btTanam_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 15);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 7;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelPilihanJadwal
            // 
            panelPilihanJadwal.Controls.Add(labelPilihanJadwal);
            panelPilihanJadwal.Controls.Add(btPengantar);
            panelPilihanJadwal.Controls.Add(btFarmer);
            panelPilihanJadwal.Controls.Add(lbBack);
            panelPilihanJadwal.Location = new Point(0, 0);
            panelPilihanJadwal.Name = "panelPilihanJadwal";
            panelPilihanJadwal.Size = new Size(1031, 380);
            panelPilihanJadwal.TabIndex = 4;
            panelPilihanJadwal.Visible = false;
            // 
            // labelPilihanJadwal
            // 
            labelPilihanJadwal.AutoSize = true;
            labelPilihanJadwal.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPilihanJadwal.Location = new Point(157, 44);
            labelPilihanJadwal.Name = "labelPilihanJadwal";
            labelPilihanJadwal.Size = new Size(724, 50);
            labelPilihanJadwal.TabIndex = 5;
            labelPilihanJadwal.Text = "PILIH BUAT JADWAL UNTUK SIAPA?";
            // 
            // btPengantar
            // 
            btPengantar.Location = new Point(167, 159);
            btPengantar.Name = "btPengantar";
            btPengantar.Size = new Size(237, 102);
            btPengantar.TabIndex = 3;
            btPengantar.Text = "PENGANTAR";
            btPengantar.UseVisualStyleBackColor = true;
            btPengantar.Click += btPengantar_Click;
            // 
            // btFarmer
            // 
            btFarmer.Location = new Point(625, 159);
            btFarmer.Name = "btFarmer";
            btFarmer.Size = new Size(237, 102);
            btFarmer.TabIndex = 4;
            btFarmer.Text = "FARMER";
            btFarmer.UseVisualStyleBackColor = true;
            // 
            // lbBack
            // 
            lbBack.Location = new Point(12, 15);
            lbBack.Name = "lbBack";
            lbBack.Size = new Size(94, 38);
            lbBack.TabIndex = 6;
            lbBack.Text = "BACK";
            lbBack.UseVisualStyleBackColor = true;
            lbBack.Click += lbBack_Click;
            // 
            // panelJadwal
            // 
            panelJadwal.Controls.Add(label4);
            panelJadwal.Controls.Add(dgvJadwal);
            panelJadwal.Controls.Add(btnTambahJadwal);
            panelJadwal.Controls.Add(btnEditJadwal);
            panelJadwal.Dock = DockStyle.Fill;
            panelJadwal.Location = new Point(0, 0);
            panelJadwal.Name = "panelJadwal";
            panelJadwal.Size = new Size(1037, 380);
            panelJadwal.TabIndex = 6;
            panelJadwal.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 15);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "TABEL JADWAL";
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(3, 53);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(1031, 330);
            dgvJadwal.TabIndex = 0;
            // 
            // btnTambahJadwal
            // 
            btnTambahJadwal.Location = new Point(168, 6);
            btnTambahJadwal.Name = "btnTambahJadwal";
            btnTambahJadwal.Size = new Size(94, 38);
            btnTambahJadwal.TabIndex = 2;
            btnTambahJadwal.Text = "ADD";
            btnTambahJadwal.UseVisualStyleBackColor = true;
            btnTambahJadwal.Click += btnTambahJadwal_Click;
            // 
            // btnEditJadwal
            // 
            btnEditJadwal.Location = new Point(278, 6);
            btnEditJadwal.Name = "btnEditJadwal";
            btnEditJadwal.Size = new Size(94, 38);
            btnEditJadwal.TabIndex = 1;
            btnEditJadwal.Text = "EDIT";
            btnEditJadwal.UseVisualStyleBackColor = true;
            btnEditJadwal.Click += btnEditJadwal_Click;
            // 
            // panelLainnya
            // 
            panelLainnya.Controls.Add(btPenarikan);
            panelLainnya.Controls.Add(btLaporan);
            panelLainnya.Controls.Add(label6);
            panelLainnya.Controls.Add(dgvLainnya);
            panelLainnya.Dock = DockStyle.Fill;
            panelLainnya.Location = new Point(0, 0);
            panelLainnya.Name = "panelLainnya";
            panelLainnya.Size = new Size(1037, 380);
            panelLainnya.TabIndex = 8;
            panelLainnya.Visible = false;
            // 
            // btPenarikan
            // 
            btPenarikan.Location = new Point(327, 6);
            btPenarikan.Name = "btPenarikan";
            btPenarikan.Size = new Size(151, 38);
            btPenarikan.TabIndex = 7;
            btPenarikan.Text = "RiwayatPenarikan";
            btPenarikan.UseVisualStyleBackColor = true;
            btPenarikan.Click += btPenarikan_Click;
            // 
            // btLaporan
            // 
            btLaporan.Location = new Point(168, 6);
            btLaporan.Name = "btLaporan";
            btLaporan.Size = new Size(117, 38);
            btLaporan.TabIndex = 6;
            btLaporan.Text = "LAPORAN";
            btLaporan.UseVisualStyleBackColor = true;
            btLaporan.Click += btLaporan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 11);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 3;
            label6.Text = "TABEL ";
            // 
            // dgvLainnya
            // 
            dgvLainnya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLainnya.Location = new Point(2, 46);
            dgvLainnya.Name = "dgvLainnya";
            dgvLainnya.RowHeadersWidth = 51;
            dgvLainnya.Size = new Size(1031, 330);
            dgvLainnya.TabIndex = 0;
            dgvLainnya.CellContentClick += dgvLaporan_CellContentClick;
            // 
            // panelLahan
            // 
            panelLahan.Controls.Add(label2);
            panelLahan.Controls.Add(btnTambahLahan);
            panelLahan.Controls.Add(btnEditLahan);
            panelLahan.Controls.Add(dgvLahan);
            panelLahan.Dock = DockStyle.Fill;
            panelLahan.Location = new Point(0, 0);
            panelLahan.Name = "panelLahan";
            panelLahan.Size = new Size(1037, 380);
            panelLahan.TabIndex = 4;
            panelLahan.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 3;
            label2.Text = "TABEL LAHAN";
            // 
            // btnTambahLahan
            // 
            btnTambahLahan.Location = new Point(168, 6);
            btnTambahLahan.Name = "btnTambahLahan";
            btnTambahLahan.Size = new Size(94, 38);
            btnTambahLahan.TabIndex = 2;
            btnTambahLahan.Text = "ADD";
            btnTambahLahan.UseVisualStyleBackColor = true;
            btnTambahLahan.Click += btnTambahLahan_Click;
            // 
            // btnEditLahan
            // 
            btnEditLahan.Location = new Point(278, 6);
            btnEditLahan.Name = "btnEditLahan";
            btnEditLahan.Size = new Size(94, 38);
            btnEditLahan.TabIndex = 1;
            btnEditLahan.Text = "EDIT";
            btnEditLahan.UseVisualStyleBackColor = true;
            btnEditLahan.Click += btnEditLahan_Click;
            // 
            // dgvLahan
            // 
            dgvLahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLahan.Location = new Point(3, 50);
            dgvLahan.Name = "dgvLahan";
            dgvLahan.RowHeadersWidth = 51;
            dgvLahan.Size = new Size(1031, 330);
            dgvLahan.TabIndex = 0;
            // 
            // panelPelanggan
            // 
            panelPelanggan.Controls.Add(label5);
            panelPelanggan.Controls.Add(btnTambahPelanggan);
            panelPelanggan.Controls.Add(btnEditPelanggan);
            panelPelanggan.Controls.Add(dgvPelanggan);
            panelPelanggan.Dock = DockStyle.Fill;
            panelPelanggan.Location = new Point(0, 0);
            panelPelanggan.Name = "panelPelanggan";
            panelPelanggan.Size = new Size(1037, 380);
            panelPelanggan.TabIndex = 7;
            panelPelanggan.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 15);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 3;
            label5.Text = "TABEL PELANGGAN";
            // 
            // btnTambahPelanggan
            // 
            btnTambahPelanggan.Location = new Point(168, 6);
            btnTambahPelanggan.Name = "btnTambahPelanggan";
            btnTambahPelanggan.Size = new Size(94, 38);
            btnTambahPelanggan.TabIndex = 2;
            btnTambahPelanggan.Text = "ADD";
            btnTambahPelanggan.UseVisualStyleBackColor = true;
            btnTambahPelanggan.Click += btnTambahPelanggan_Click;
            // 
            // btnEditPelanggan
            // 
            btnEditPelanggan.Location = new Point(278, 6);
            btnEditPelanggan.Name = "btnEditPelanggan";
            btnEditPelanggan.Size = new Size(94, 38);
            btnEditPelanggan.TabIndex = 1;
            btnEditPelanggan.Text = "EDIT";
            btnEditPelanggan.UseVisualStyleBackColor = true;
            btnEditPelanggan.Click += btnEditPelanggan_Click;
            // 
            // dgvPelanggan
            // 
            dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelanggan.Location = new Point(3, 50);
            dgvPelanggan.Name = "dgvPelanggan";
            dgvPelanggan.RowHeadersWidth = 51;
            dgvPelanggan.Size = new Size(1031, 330);
            dgvPelanggan.TabIndex = 0;
            // 
            // panelTanaman
            // 
            panelTanaman.Controls.Add(btTanmanaBelumLaku);
            panelTanaman.Controls.Add(bt10TanamanPalingBanyakDitanam);
            panelTanaman.Controls.Add(label3);
            panelTanaman.Controls.Add(btnTambahTanaman);
            panelTanaman.Controls.Add(btnEditTanaman);
            panelTanaman.Controls.Add(dgvTanaman);
            panelTanaman.Dock = DockStyle.Fill;
            panelTanaman.Location = new Point(0, 0);
            panelTanaman.Name = "panelTanaman";
            panelTanaman.Size = new Size(1037, 380);
            panelTanaman.TabIndex = 5;
            panelTanaman.Visible = false;
            // 
            // btTanmanaBelumLaku
            // 
            btTanmanaBelumLaku.Location = new Point(669, 6);
            btTanmanaBelumLaku.Name = "btTanmanaBelumLaku";
            btTanmanaBelumLaku.Size = new Size(186, 38);
            btTanmanaBelumLaku.TabIndex = 5;
            btTanmanaBelumLaku.Text = "Tanaman Belum Laku";
            btTanmanaBelumLaku.UseVisualStyleBackColor = true;
            btTanmanaBelumLaku.Click += btTanmanaBelumLaku_Click;
            // 
            // bt10TanamanPalingBanyakDitanam
            // 
            bt10TanamanPalingBanyakDitanam.Location = new Point(392, 6);
            bt10TanamanPalingBanyakDitanam.Name = "bt10TanamanPalingBanyakDitanam";
            bt10TanamanPalingBanyakDitanam.Size = new Size(257, 38);
            bt10TanamanPalingBanyakDitanam.TabIndex = 4;
            bt10TanamanPalingBanyakDitanam.Text = "10 Tanaman Paling Banyak Ditanam";
            bt10TanamanPalingBanyakDitanam.UseVisualStyleBackColor = true;
            bt10TanamanPalingBanyakDitanam.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 15);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 3;
            label3.Text = "TABEL TANAMAN";
            // 
            // btnTambahTanaman
            // 
            btnTambahTanaman.Location = new Point(168, 6);
            btnTambahTanaman.Name = "btnTambahTanaman";
            btnTambahTanaman.Size = new Size(94, 38);
            btnTambahTanaman.TabIndex = 2;
            btnTambahTanaman.Text = "ADD";
            btnTambahTanaman.UseVisualStyleBackColor = true;
            btnTambahTanaman.Click += btnTambahTanaman_Click;
            // 
            // btnEditTanaman
            // 
            btnEditTanaman.Location = new Point(278, 6);
            btnEditTanaman.Name = "btnEditTanaman";
            btnEditTanaman.Size = new Size(94, 38);
            btnEditTanaman.TabIndex = 1;
            btnEditTanaman.Text = "EDIT";
            btnEditTanaman.UseVisualStyleBackColor = true;
            btnEditTanaman.Click += btnEditTanaman_Click;
            // 
            // dgvTanaman
            // 
            dgvTanaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTanaman.Location = new Point(3, 50);
            dgvTanaman.Name = "dgvTanaman";
            dgvTanaman.RowHeadersWidth = 51;
            dgvTanaman.Size = new Size(1031, 330);
            dgvTanaman.TabIndex = 0;
            // 
            // panelDetailKaryawan
            // 
            panelDetailKaryawan.Controls.Add(btEdit);
            panelDetailKaryawan.Controls.Add(btBack);
            panelDetailKaryawan.Controls.Add(lbPassword);
            panelDetailKaryawan.Controls.Add(lbUsername);
            panelDetailKaryawan.Controls.Add(lbSaldo);
            panelDetailKaryawan.Controls.Add(lbRole);
            panelDetailKaryawan.Controls.Add(label12);
            panelDetailKaryawan.Controls.Add(lbTanggalLahir);
            panelDetailKaryawan.Controls.Add(label9);
            panelDetailKaryawan.Controls.Add(label8);
            panelDetailKaryawan.Controls.Add(lbStatusKerja);
            panelDetailKaryawan.Controls.Add(label16);
            panelDetailKaryawan.Controls.Add(label15);
            panelDetailKaryawan.Controls.Add(label14);
            panelDetailKaryawan.Controls.Add(TanggalLahir);
            panelDetailKaryawan.Controls.Add(lbID);
            panelDetailKaryawan.Controls.Add(label11);
            panelDetailKaryawan.Controls.Add(lbEmail);
            panelDetailKaryawan.Controls.Add(lbNOTELP);
            panelDetailKaryawan.Controls.Add(lbNama);
            panelDetailKaryawan.Location = new Point(0, 0);
            panelDetailKaryawan.Name = "panelDetailKaryawan";
            panelDetailKaryawan.Size = new Size(1037, 377);
            panelDetailKaryawan.TabIndex = 4;
            panelDetailKaryawan.Visible = false;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(158, 15);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 19;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(22, 15);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 18;
            btBack.Text = "Kembali";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(816, 323);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 17;
            lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(816, 264);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 16;
            lbUsername.Text = "Username";
            // 
            // lbSaldo
            // 
            lbSaldo.AutoSize = true;
            lbSaldo.Location = new Point(816, 200);
            lbSaldo.Name = "lbSaldo";
            lbSaldo.Size = new Size(47, 20);
            lbSaldo.TabIndex = 15;
            lbSaldo.Text = "Saldo";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(816, 149);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(39, 20);
            lbRole.TabIndex = 14;
            lbRole.Text = "Role";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(95, 323);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 13;
            label12.Text = "Status Kerja :";
            // 
            // lbTanggalLahir
            // 
            lbTanggalLahir.AutoSize = true;
            lbTanggalLahir.Location = new Point(95, 264);
            lbTanggalLahir.Name = "lbTanggalLahir";
            lbTanggalLahir.Size = new Size(104, 20);
            lbTanggalLahir.TabIndex = 12;
            lbTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 200);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 11;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 149);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 10;
            label8.Text = "Nomer Telp :";
            // 
            // lbStatusKerja
            // 
            lbStatusKerja.AutoSize = true;
            lbStatusKerja.Location = new Point(225, 323);
            lbStatusKerja.Name = "lbStatusKerja";
            lbStatusKerja.Size = new Size(87, 20);
            lbStatusKerja.TabIndex = 9;
            lbStatusKerja.Text = "Status Kerja";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(681, 200);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
            label16.TabIndex = 8;
            label16.Text = "Saldo :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(681, 149);
            label15.Name = "label15";
            label15.Size = new Size(90, 20);
            label15.TabIndex = 7;
            label15.Text = "Nama Role :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(681, 264);
            label14.Name = "label14";
            label14.Size = new Size(82, 20);
            label14.TabIndex = 6;
            label14.Text = "Username :";
            // 
            // TanggalLahir
            // 
            TanggalLahir.AutoSize = true;
            TanggalLahir.Location = new Point(225, 264);
            TanggalLahir.Name = "TanggalLahir";
            TanggalLahir.Size = new Size(93, 20);
            TanggalLahir.TabIndex = 5;
            TanggalLahir.Text = "TanggalLahir";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(382, 94);
            lbID.Name = "lbID";
            lbID.Size = new Size(22, 20);
            lbID.TabIndex = 4;
            lbID.Text = "id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(681, 323);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 3;
            label11.Text = "Password :";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(225, 200);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbNOTELP
            // 
            lbNOTELP.AutoSize = true;
            lbNOTELP.Location = new Point(225, 149);
            lbNOTELP.Name = "lbNOTELP";
            lbNOTELP.Size = new Size(54, 20);
            lbNOTELP.TabIndex = 1;
            lbNOTELP.Text = "noTelp";
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNama.Location = new Point(429, 80);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(99, 38);
            lbNama.TabIndex = 0;
            lbNama.Text = "Nama";
            // 
            // panelKaryawan
            // 
            panelKaryawan.Controls.Add(label1);
            panelKaryawan.Controls.Add(btnTambahKaryawan);
            panelKaryawan.Controls.Add(btnEditKaryawan);
            panelKaryawan.Controls.Add(dgvKaryawan);
            panelKaryawan.Dock = DockStyle.Fill;
            panelKaryawan.Location = new Point(0, 0);
            panelKaryawan.Name = "panelKaryawan";
            panelKaryawan.Size = new Size(1037, 380);
            panelKaryawan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "TABEL KARYAWAN";
            // 
            // btnTambahKaryawan
            // 
            btnTambahKaryawan.Location = new Point(168, 6);
            btnTambahKaryawan.Name = "btnTambahKaryawan";
            btnTambahKaryawan.Size = new Size(94, 38);
            btnTambahKaryawan.TabIndex = 2;
            btnTambahKaryawan.Text = "ADD";
            btnTambahKaryawan.UseVisualStyleBackColor = true;
            btnTambahKaryawan.Click += btnTambahKaryawan_Click;
            // 
            // btnEditKaryawan
            // 
            btnEditKaryawan.Location = new Point(278, 6);
            btnEditKaryawan.Name = "btnEditKaryawan";
            btnEditKaryawan.Size = new Size(94, 38);
            btnEditKaryawan.TabIndex = 1;
            btnEditKaryawan.Text = "EDIT";
            btnEditKaryawan.UseVisualStyleBackColor = true;
            btnEditKaryawan.Click += btnEditKaryawan_Click;
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(3, 50);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowHeadersWidth = 51;
            dgvKaryawan.Size = new Size(1031, 330);
            dgvKaryawan.TabIndex = 0;
            // 
            // FormOwner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 553);
            Controls.Add(panelMiddle);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "FormOwner";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBottom.ResumeLayout(false);
            panelMiddle.ResumeLayout(false);
            panelPilihanJadwalFarmer.ResumeLayout(false);
            panelPilihanJadwalFarmer.PerformLayout();
            panelPilihanJadwal.ResumeLayout(false);
            panelPilihanJadwal.PerformLayout();
            panelJadwal.ResumeLayout(false);
            panelJadwal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            panelLainnya.ResumeLayout(false);
            panelLainnya.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLainnya).EndInit();
            panelLahan.ResumeLayout(false);
            panelLahan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).EndInit();
            panelPelanggan.ResumeLayout(false);
            panelPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).EndInit();
            panelTanaman.ResumeLayout(false);
            panelTanaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).EndInit();
            panelDetailKaryawan.ResumeLayout(false);
            panelDetailKaryawan.PerformLayout();
            panelKaryawan.ResumeLayout(false);
            panelKaryawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox pictureBox1;
        private Label lblNama;
        private Label lblSaldo;
        private Panel panelBottom;
        private Button btnLaporan;
        private Button btnPelanggan;
        private Button btnJadwal;
        private Button btnTanaman;
        private Button btnLahan;
        private Button btnKaryawan;
        private Panel panelMiddle;
        private Panel panelKaryawan;
        private DataGridView dgvKaryawan;
        private Button btnTambahKaryawan;
        private Button btnEditKaryawan;
        private Label label1;
        private Panel panelLahan;
        private Label label2;
        private Button btnTambahLahan;
        private Button btnEditLahan;
        private DataGridView dgvLahan;
        private Panel panelTanaman;
        private Label label3;
        private Button btnTambahTanaman;
        private Button btnEditTanaman;
        private DataGridView dgvTanaman;
        private Panel panelJadwal;
        private Label label4;
        private Button btnTambahJadwal;
        private Button btnEditJadwal;
        private DataGridView dgvJadwal;
        private Panel panelPelanggan;
        private Label label5;
        private Button btnTambahPelanggan;
        private Button btnEditPelanggan;
        private DataGridView dgvPelanggan;
        private Panel panelLainnya;
        private Label label6;
        private DataGridView dgvLainnya;
        private Label label7;
        private Panel panelDetailKaryawan;
        private Label lbStatusKerja;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label TanggalLahir;
        private Label lbID;
        private Label label11;
        private Label lbEmail;
        private Label lbNOTELP;
        private Label lbNama;
        private Label label8;
        private Label lbPassword;
        private Label lbUsername;
        private Label lbSaldo;
        private Label lbRole;
        private Label label12;
        private Label lbTanggalLahir;
        private Label label9;
        private Button btEdit;
        private Button btBack;
        private Button btTanmanaBelumLaku;
        private Button bt10TanamanPalingBanyakDitanam;
        private Button btPenarikan;
        private Button btLaporan;
        private Panel panelPilihanJadwal;
        private Label labelPilihanJadwal;
        private Button btFarmer;
        private Button btPengantar;
        private Panel panelPilihanJadwalFarmer;
        private Button lbBack;
        private Label label10;
        private Button btJadwalFarmerLainnya;
        private Button btPanen;
        private Button btTanam;
        private Button button2;
    }
}