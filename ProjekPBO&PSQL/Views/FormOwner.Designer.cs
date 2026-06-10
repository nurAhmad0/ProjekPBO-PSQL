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
            panelLaporan.Visible = false;

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
            panelLaporan = new Panel();
            label6 = new Label();
            dgvLaporan = new DataGridView();
            colIdLaporan = new DataGridViewTextBoxColumn();
            colWaktuLapor = new DataGridViewTextBoxColumn();
            colIsiLaporan = new DataGridViewTextBoxColumn();
            colTanggalJadwalLaporan = new DataGridViewTextBoxColumn();
            colKeteranganJadwalLaporan = new DataGridViewTextBoxColumn();
            colDivisiLaporan = new DataGridViewTextBoxColumn();
            colNamaPelapor = new DataGridViewTextBoxColumn();
            colNoTelpPelapor = new DataGridViewTextBoxColumn();
            panelPelanggan = new Panel();
            label5 = new Label();
            btnTambahPelanggan = new Button();
            btnEditPelanggan = new Button();
            dgvPelanggan = new DataGridView();
            colIdPelanggan = new DataGridViewTextBoxColumn();
            colNamaPelanggan = new DataGridViewTextBoxColumn();
            colNoTelpPelanggan = new DataGridViewTextBoxColumn();
            colEmailPelanggan = new DataGridViewTextBoxColumn();
            colAlamatPelanggan = new DataGridViewTextBoxColumn();
            panelJadwal = new Panel();
            label4 = new Label();
            btnTambahJadwal = new Button();
            btnEditJadwal = new Button();
            dgvJadwal = new DataGridView();
            colIdJadwal = new DataGridViewTextBoxColumn();
            colTanggalJadwal = new DataGridViewTextBoxColumn();
            colKeteranganKegiatan = new DataGridViewTextBoxColumn();
            colTipeJadwal = new DataGridViewTextBoxColumn();
            colJumlahAnggota = new DataGridViewTextBoxColumn();
            colTotalUpah = new DataGridViewTextBoxColumn();
            colStatusGlobal = new DataGridViewTextBoxColumn();
            colLahanPelangganJadwal = new DataGridViewTextBoxColumn();
            panelTanaman = new Panel();
            label3 = new Label();
            btnTambahTanaman = new Button();
            btnEditTanaman = new Button();
            dgvTanaman = new DataGridView();
            colIdTanaman = new DataGridViewTextBoxColumn();
            colNamaTanaman = new DataGridViewTextBoxColumn();
            colDurasiPanen = new DataGridViewTextBoxColumn();
            colHargaTanaman = new DataGridViewTextBoxColumn();
            panelLahan = new Panel();
            label2 = new Label();
            btnTambahLahan = new Button();
            btnEditLahan = new Button();
            dgvLahan = new DataGridView();
            colIdLahan = new DataGridViewTextBoxColumn();
            colNamaLahan = new DataGridViewTextBoxColumn();
            colLuasLahan = new DataGridViewTextBoxColumn();
            colStatusLahan = new DataGridViewTextBoxColumn();
            panelKaryawan = new Panel();
            label1 = new Label();
            btnTambahKaryawan = new Button();
            btnEditKaryawan = new Button();
            dgvKaryawan = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            panelPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).BeginInit();
            panelJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            panelTanaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).BeginInit();
            panelLahan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).BeginInit();
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
            btnLaporan.Text = "LAPORAN";
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
            panelMiddle.Controls.Add(panelLaporan);
            panelMiddle.Controls.Add(panelPelanggan);
            panelMiddle.Controls.Add(panelJadwal);
            panelMiddle.Controls.Add(panelTanaman);
            panelMiddle.Controls.Add(panelLahan);
            panelMiddle.Controls.Add(panelKaryawan);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 107);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1037, 380);
            panelMiddle.TabIndex = 2;
            // 
            // panelLaporan
            // 
            panelLaporan.Controls.Add(label6);
            panelLaporan.Controls.Add(dgvLaporan);
            panelLaporan.Dock = DockStyle.Fill;
            panelLaporan.Location = new Point(0, 0);
            panelLaporan.Name = "panelLaporan";
            panelLaporan.Size = new Size(1037, 380);
            panelLaporan.TabIndex = 8;
            panelLaporan.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 15);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 3;
            label6.Text = "TABEL LAPORAN";
            // 
            // dgvLaporan
            // 
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Columns.AddRange(new DataGridViewColumn[] { colIdLaporan, colWaktuLapor, colIsiLaporan, colTanggalJadwalLaporan, colKeteranganJadwalLaporan, colDivisiLaporan, colNamaPelapor, colNoTelpPelapor });
            dgvLaporan.Location = new Point(3, 50);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 51;
            dgvLaporan.Size = new Size(1031, 330);
            dgvLaporan.TabIndex = 0;
            dgvLaporan.CellContentClick += dgvLaporan_CellContentClick;
            // 
            // colIdLaporan
            // 
            colIdLaporan.HeaderText = "ID";
            colIdLaporan.MinimumWidth = 6;
            colIdLaporan.Name = "colIdLaporan";
            colIdLaporan.Width = 125;
            // 
            // colWaktuLapor
            // 
            colWaktuLapor.HeaderText = "Waktu Lapor";
            colWaktuLapor.MinimumWidth = 6;
            colWaktuLapor.Name = "colWaktuLapor";
            colWaktuLapor.Width = 125;
            // 
            // colIsiLaporan
            // 
            colIsiLaporan.HeaderText = "Isi Laporan";
            colIsiLaporan.MinimumWidth = 6;
            colIsiLaporan.Name = "colIsiLaporan";
            colIsiLaporan.Width = 125;
            // 
            // colTanggalJadwalLaporan
            // 
            colTanggalJadwalLaporan.HeaderText = "Tanggal Jadwal";
            colTanggalJadwalLaporan.MinimumWidth = 6;
            colTanggalJadwalLaporan.Name = "colTanggalJadwalLaporan";
            colTanggalJadwalLaporan.Width = 125;
            // 
            // colKeteranganJadwalLaporan
            // 
            colKeteranganJadwalLaporan.HeaderText = "Keterangan Jadwal";
            colKeteranganJadwalLaporan.MinimumWidth = 6;
            colKeteranganJadwalLaporan.Name = "colKeteranganJadwalLaporan";
            colKeteranganJadwalLaporan.Width = 125;
            // 
            // colDivisiLaporan
            // 
            colDivisiLaporan.HeaderText = "Divisi";
            colDivisiLaporan.MinimumWidth = 6;
            colDivisiLaporan.Name = "colDivisiLaporan";
            colDivisiLaporan.Width = 125;
            // 
            // colNamaPelapor
            // 
            colNamaPelapor.HeaderText = "Nama";
            colNamaPelapor.MinimumWidth = 6;
            colNamaPelapor.Name = "colNamaPelapor";
            colNamaPelapor.Width = 125;
            // 
            // colNoTelpPelapor
            // 
            colNoTelpPelapor.HeaderText = "No. Telp";
            colNoTelpPelapor.MinimumWidth = 6;
            colNoTelpPelapor.Name = "colNoTelpPelapor";
            colNoTelpPelapor.Width = 125;
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
            dgvPelanggan.Columns.AddRange(new DataGridViewColumn[] { colIdPelanggan, colNamaPelanggan, colNoTelpPelanggan, colEmailPelanggan, colAlamatPelanggan });
            dgvPelanggan.Location = new Point(3, 50);
            dgvPelanggan.Name = "dgvPelanggan";
            dgvPelanggan.RowHeadersWidth = 51;
            dgvPelanggan.Size = new Size(1031, 330);
            dgvPelanggan.TabIndex = 0;
            // 
            // colIdPelanggan
            // 
            colIdPelanggan.HeaderText = "ID";
            colIdPelanggan.MinimumWidth = 6;
            colIdPelanggan.Name = "colIdPelanggan";
            colIdPelanggan.Width = 125;
            // 
            // colNamaPelanggan
            // 
            colNamaPelanggan.HeaderText = "Nama Pelanggan";
            colNamaPelanggan.MinimumWidth = 6;
            colNamaPelanggan.Name = "colNamaPelanggan";
            colNamaPelanggan.Width = 125;
            // 
            // colNoTelpPelanggan
            // 
            colNoTelpPelanggan.HeaderText = "No. Telp Pelanggan";
            colNoTelpPelanggan.MinimumWidth = 6;
            colNoTelpPelanggan.Name = "colNoTelpPelanggan";
            colNoTelpPelanggan.Width = 125;
            // 
            // colEmailPelanggan
            // 
            colEmailPelanggan.HeaderText = "Email Pelanggan";
            colEmailPelanggan.MinimumWidth = 6;
            colEmailPelanggan.Name = "colEmailPelanggan";
            colEmailPelanggan.Width = 125;
            // 
            // colAlamatPelanggan
            // 
            colAlamatPelanggan.HeaderText = "Alamat Pelanggan";
            colAlamatPelanggan.MinimumWidth = 6;
            colAlamatPelanggan.Name = "colAlamatPelanggan";
            colAlamatPelanggan.Width = 125;
            // 
            // panelJadwal
            // 
            panelJadwal.Controls.Add(label4);
            panelJadwal.Controls.Add(btnTambahJadwal);
            panelJadwal.Controls.Add(btnEditJadwal);
            panelJadwal.Controls.Add(dgvJadwal);
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
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Columns.AddRange(new DataGridViewColumn[] { colIdJadwal, colTanggalJadwal, colKeteranganKegiatan, colTipeJadwal, colJumlahAnggota, colTotalUpah, colStatusGlobal, colLahanPelangganJadwal });
            dgvJadwal.Location = new Point(3, 50);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(1031, 330);
            dgvJadwal.TabIndex = 0;
            // 
            // colIdJadwal
            // 
            colIdJadwal.HeaderText = "ID";
            colIdJadwal.MinimumWidth = 6;
            colIdJadwal.Name = "colIdJadwal";
            colIdJadwal.Width = 125;
            // 
            // colTanggalJadwal
            // 
            colTanggalJadwal.HeaderText = "Tanggal";
            colTanggalJadwal.MinimumWidth = 6;
            colTanggalJadwal.Name = "colTanggalJadwal";
            colTanggalJadwal.Width = 125;
            // 
            // colKeteranganKegiatan
            // 
            colKeteranganKegiatan.HeaderText = "Kegiatan";
            colKeteranganKegiatan.MinimumWidth = 6;
            colKeteranganKegiatan.Name = "colKeteranganKegiatan";
            colKeteranganKegiatan.Width = 125;
            // 
            // colTipeJadwal
            // 
            colTipeJadwal.HeaderText = "Tipe Jadwal";
            colTipeJadwal.MinimumWidth = 6;
            colTipeJadwal.Name = "colTipeJadwal";
            colTipeJadwal.Width = 125;
            // 
            // colJumlahAnggota
            // 
            colJumlahAnggota.HeaderText = "Jumlah Anggota";
            colJumlahAnggota.MinimumWidth = 6;
            colJumlahAnggota.Name = "colJumlahAnggota";
            colJumlahAnggota.Width = 125;
            // 
            // colTotalUpah
            // 
            colTotalUpah.HeaderText = "Total Upah";
            colTotalUpah.MinimumWidth = 6;
            colTotalUpah.Name = "colTotalUpah";
            colTotalUpah.Width = 125;
            // 
            // colStatusGlobal
            // 
            colStatusGlobal.HeaderText = "Status";
            colStatusGlobal.MinimumWidth = 6;
            colStatusGlobal.Name = "colStatusGlobal";
            colStatusGlobal.Width = 125;
            // 
            // colLahanPelangganJadwal
            // 
            colLahanPelangganJadwal.HeaderText = "Lahan / Pelanggan";
            colLahanPelangganJadwal.MinimumWidth = 6;
            colLahanPelangganJadwal.Name = "colLahanPelangganJadwal";
            colLahanPelangganJadwal.Width = 125;
            // 
            // panelTanaman
            // 
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
            dgvTanaman.Columns.AddRange(new DataGridViewColumn[] { colIdTanaman, colNamaTanaman, colDurasiPanen, colHargaTanaman });
            dgvTanaman.Location = new Point(3, 50);
            dgvTanaman.Name = "dgvTanaman";
            dgvTanaman.RowHeadersWidth = 51;
            dgvTanaman.Size = new Size(1031, 330);
            dgvTanaman.TabIndex = 0;
            // 
            // colIdTanaman
            // 
            colIdTanaman.HeaderText = "ID";
            colIdTanaman.MinimumWidth = 6;
            colIdTanaman.Name = "colIdTanaman";
            colIdTanaman.Width = 125;
            // 
            // colNamaTanaman
            // 
            colNamaTanaman.HeaderText = "Nama Tanaman";
            colNamaTanaman.MinimumWidth = 6;
            colNamaTanaman.Name = "colNamaTanaman";
            colNamaTanaman.Width = 125;
            // 
            // colDurasiPanen
            // 
            colDurasiPanen.HeaderText = "Durasi Panen";
            colDurasiPanen.MinimumWidth = 6;
            colDurasiPanen.Name = "colDurasiPanen";
            colDurasiPanen.Width = 125;
            // 
            // colHargaTanaman
            // 
            colHargaTanaman.HeaderText = "Harga Tanaman";
            colHargaTanaman.MinimumWidth = 6;
            colHargaTanaman.Name = "colHargaTanaman";
            colHargaTanaman.Width = 125;
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
            dgvLahan.Columns.AddRange(new DataGridViewColumn[] { colIdLahan, colNamaLahan, colLuasLahan, colStatusLahan });
            dgvLahan.Location = new Point(3, 50);
            dgvLahan.Name = "dgvLahan";
            dgvLahan.RowHeadersWidth = 51;
            dgvLahan.Size = new Size(1031, 330);
            dgvLahan.TabIndex = 0;
            // 
            // colIdLahan
            // 
            colIdLahan.HeaderText = "ID";
            colIdLahan.MinimumWidth = 6;
            colIdLahan.Name = "colIdLahan";
            colIdLahan.Width = 125;
            // 
            // colNamaLahan
            // 
            colNamaLahan.HeaderText = "Nama Lahan";
            colNamaLahan.MinimumWidth = 6;
            colNamaLahan.Name = "colNamaLahan";
            colNamaLahan.Width = 125;
            // 
            // colLuasLahan
            // 
            colLuasLahan.HeaderText = "Luas Lahan";
            colLuasLahan.MinimumWidth = 6;
            colLuasLahan.Name = "colLuasLahan";
            colLuasLahan.Width = 125;
            // 
            // colStatusLahan
            // 
            colStatusLahan.HeaderText = "Status Lahan";
            colStatusLahan.MinimumWidth = 6;
            colStatusLahan.Name = "colStatusLahan";
            colStatusLahan.Width = 125;
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
            panelKaryawan.Visible = false;
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
            panelLaporan.ResumeLayout(false);
            panelLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            panelPelanggan.ResumeLayout(false);
            panelPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).EndInit();
            panelJadwal.ResumeLayout(false);
            panelJadwal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            panelTanaman.ResumeLayout(false);
            panelTanaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).EndInit();
            panelLahan.ResumeLayout(false);
            panelLahan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).EndInit();
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
        private DataGridViewTextBoxColumn colIdLahan;
        private DataGridViewTextBoxColumn colNamaLahan;
        private DataGridViewTextBoxColumn colLuasLahan;
        private DataGridViewTextBoxColumn colStatusLahan;
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
        private DataGridViewTextBoxColumn colIdPelanggan;
        private DataGridViewTextBoxColumn colNamaPelanggan;
        private DataGridViewTextBoxColumn colNoTelpPelanggan;
        private DataGridViewTextBoxColumn colEmailPelanggan;
        private DataGridViewTextBoxColumn colAlamatPelanggan;
        private Panel panelLaporan;
        private Label label6;
        private DataGridView dgvLaporan;
        private DataGridViewTextBoxColumn colIdTanaman;
        private DataGridViewTextBoxColumn colNamaTanaman;
        private DataGridViewTextBoxColumn colDurasiPanen;
        private DataGridViewTextBoxColumn colHargaTanaman;
        private DataGridViewTextBoxColumn colIdLaporan;
        private DataGridViewTextBoxColumn colWaktuLapor;
        private DataGridViewTextBoxColumn colIsiLaporan;
        private DataGridViewTextBoxColumn colTanggalJadwalLaporan;
        private DataGridViewTextBoxColumn colKeteranganJadwalLaporan;
        private DataGridViewTextBoxColumn colDivisiLaporan;
        private DataGridViewTextBoxColumn colNamaPelapor;
        private DataGridViewTextBoxColumn colNoTelpPelapor;
        private DataGridViewTextBoxColumn colIdJadwal;
        private DataGridViewTextBoxColumn colTanggalJadwal;
        private DataGridViewTextBoxColumn colKeteranganKegiatan;
        private DataGridViewTextBoxColumn colTipeJadwal;
        private DataGridViewTextBoxColumn colJumlahAnggota;
        private DataGridViewTextBoxColumn colTotalUpah;
        private DataGridViewTextBoxColumn colStatusGlobal;
        private DataGridViewTextBoxColumn colLahanPelangganJadwal;
        private Label label7;
    }
}