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
            panelDetailJadwalFarmer.Visible = false;
            panelDetailJadwalPengantar.Visible = false;
            panelDetailLaporan.Visible = false;
            panelPenarikan.Visible = false;
            panelPilihanJadwal.Visible = false;
            panelPilihanJadwalFarmer.Visible = false;

            panelTujuan.Visible = true;
            bagianAktif = namaBagian;
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelTop = new Panel();
            btLOGOUT = new Button();
            lblTanggal = new Label();
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
            panelPilihanJadwal = new Panel();
            labelPilihanJadwal = new Label();
            btFarmerJadwal = new Button();
            btPenagantarJadwal = new Button();
            lbBack = new Button();
            panelJadwal = new Panel();
            label4 = new Label();
            btnTambahJadwal = new Button();
            btnDetailJadwal = new Button();
            dgvJadwal = new DataGridView();
            panelKaryawan = new Panel();
            txtCariKaryawan = new TextBox();
            label1 = new Label();
            btnTambahKaryawan = new Button();
            btnEditKaryawan = new Button();
            dgvKaryawan = new DataGridView();
            panelDetailJadwalFarmer = new Panel();
            btSimpanEditFarmer = new Button();
            dataGAnggotaJadwalFarmer = new DataGridView();
            btHapusJadwalFarmer = new Button();
            btEditJadwalFarmer = new Button();
            txtTotalUpah = new TextBox();
            txtIdLahanJadwalFarmer = new TextBox();
            txtNamaLahanJadwalFarmer = new TextBox();
            txtJumlahDItanamJadwalFarmer = new TextBox();
            txtStatusJadwalFarmer = new TextBox();
            txtKeteranganJadwalFarmer = new TextBox();
            txtBanyakAnggotaJadwalFarmer = new TextBox();
            txtTanamanJadwalFarmer = new TextBox();
            label34 = new Label();
            label32 = new Label();
            label30 = new Label();
            label28 = new Label();
            label26 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label20 = new Label();
            lbTanggalJadwalFarmer = new Label();
            l = new Label();
            lbIdJadwalFarmer = new Label();
            IDJadwal = new Label();
            btKembaliJadwalFarmer = new Button();
            panelDetailJadwalPengantar = new Panel();
            btSimpanEditPengantar = new Button();
            txtDetailAlamatPengantar = new TextBox();
            txtTanggalOrderPengantar = new TextBox();
            txtNamaPelanggan = new TextBox();
            txtIdPelangganPengantar = new TextBox();
            txtKeteranganJadwalPengantar = new TextBox();
            txtNoTelpJadwalPengantar = new TextBox();
            txtTotalUpahPengantar = new TextBox();
            txtNamaAnggotaPengantar = new TextBox();
            txtStatusJadwalPengantar = new TextBox();
            txtIDJadwalPengantar = new TextBox();
            btJadwalPengantarHapus = new Button();
            btEditJadwalPengantar = new Button();
            dataGKeranjangBelanja = new DataGridView();
            label38 = new Label();
            label37 = new Label();
            label35 = new Label();
            label33 = new Label();
            label31 = new Label();
            label29 = new Label();
            label27 = new Label();
            label25 = new Label();
            label21 = new Label();
            label19 = new Label();
            label18 = new Label();
            lbTanggalJadwalPengantaran = new Label();
            label13 = new Label();
            button5 = new Button();
            panelPilihanJadwalFarmer = new Panel();
            label10 = new Label();
            btJadwalFarmerLainnya = new Button();
            btPanen = new Button();
            btTanam = new Button();
            button2 = new Button();
            panelTanaman = new Panel();
            txtCariTanaman = new TextBox();
            btTanmanaBelumLaku = new Button();
            bt10TanamanPalingBanyakDitanam = new Button();
            label3 = new Label();
            btnTambahTanaman = new Button();
            btnEditTanaman = new Button();
            dgvTanaman = new DataGridView();
            panelLahan = new Panel();
            txtCariLahan = new TextBox();
            label2 = new Label();
            btnTambahLahan = new Button();
            btnEditLahan = new Button();
            dgvLahan = new DataGridView();
            panelDetailKaryawan = new Panel();
            label48 = new Label();
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
            panelLainnya = new Panel();
            panelPenarikan = new Panel();
            btKonfirmasiPenarikan = new Button();
            txtNoRek = new TextBox();
            label47 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label46 = new Label();
            label45 = new Label();
            label39 = new Label();
            txtAtasNamaPenarikan = new TextBox();
            txtNominalPenarikan = new TextBox();
            panelDetailLaporan = new Panel();
            btKembaliLaporan = new Button();
            txtIsiJadwalLaporan = new TextBox();
            txtIdJadwalLaporan = new TextBox();
            txtNamaAnggotaLaporan = new TextBox();
            txtIdAnggotaLaporan = new TextBox();
            txtIsiLaporan = new TextBox();
            txtIdLaporan = new TextBox();
            txtWaktuLaporan = new TextBox();
            txtTanggalJadwalLaporan = new TextBox();
            label44 = new Label();
            label43 = new Label();
            label42 = new Label();
            label41 = new Label();
            label40 = new Label();
            labe = new Label();
            label36 = new Label();
            label17 = new Label();
            btTarikSaldo = new Button();
            btPenarikan = new Button();
            btLaporan = new Button();
            label6 = new Label();
            dgvLainnya = new DataGridView();
            panelPelanggan = new Panel();
            txtCariPelanggan = new TextBox();
            label5 = new Label();
            btnTambahPelanggan = new Button();
            btnEditPelanggan = new Button();
            dgvPelanggan = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelPilihanJadwal.SuspendLayout();
            panelJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            panelKaryawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            panelDetailJadwalFarmer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGAnggotaJadwalFarmer).BeginInit();
            panelDetailJadwalPengantar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGKeranjangBelanja).BeginInit();
            panelPilihanJadwalFarmer.SuspendLayout();
            panelTanaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).BeginInit();
            panelLahan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).BeginInit();
            panelDetailKaryawan.SuspendLayout();
            panelLainnya.SuspendLayout();
            panelPenarikan.SuspendLayout();
            panelDetailLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLainnya).BeginInit();
            panelPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.RosyBrown;
            panelTop.Controls.Add(btLOGOUT);
            panelTop.Controls.Add(lblTanggal);
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
            // btLOGOUT
            // 
            btLOGOUT.BackColor = Color.IndianRed;
            btLOGOUT.Location = new Point(931, 63);
            btLOGOUT.Name = "btLOGOUT";
            btLOGOUT.Size = new Size(94, 29);
            btLOGOUT.TabIndex = 41;
            btLOGOUT.Text = "LOG OUT";
            btLOGOUT.UseVisualStyleBackColor = false;
            btLOGOUT.Click += btLOGOUT_Click;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(932, 9);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(93, 20);
            lblTanggal.TabIndex = 40;
            lblTanggal.Text = "yyyy-MM-dd";
            lblTanggal.Click += lblTanggal_Click;
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
            panelMiddle.Controls.Add(panelJadwal);
            panelMiddle.Controls.Add(panelPilihanJadwal);
            panelMiddle.Controls.Add(panelKaryawan);
            panelMiddle.Controls.Add(panelDetailJadwalFarmer);
            panelMiddle.Controls.Add(panelDetailJadwalPengantar);
            panelMiddle.Controls.Add(panelPilihanJadwalFarmer);
            panelMiddle.Controls.Add(panelTanaman);
            panelMiddle.Controls.Add(panelLahan);
            panelMiddle.Controls.Add(panelDetailKaryawan);
            panelMiddle.Controls.Add(panelLainnya);
            panelMiddle.Controls.Add(panelPelanggan);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 107);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1037, 380);
            panelMiddle.TabIndex = 2;
            // 
            // panelPilihanJadwal
            // 
            panelPilihanJadwal.Controls.Add(labelPilihanJadwal);
            panelPilihanJadwal.Controls.Add(btFarmerJadwal);
            panelPilihanJadwal.Controls.Add(btPenagantarJadwal);
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
            // btFarmerJadwal
            // 
            btFarmerJadwal.Location = new Point(167, 159);
            btFarmerJadwal.Name = "btFarmerJadwal";
            btFarmerJadwal.Size = new Size(237, 102);
            btFarmerJadwal.TabIndex = 3;
            btFarmerJadwal.Text = "FARMER";
            btFarmerJadwal.UseVisualStyleBackColor = true;
            btFarmerJadwal.Click += btPengantar_Click;
            // 
            // btPenagantarJadwal
            // 
            btPenagantarJadwal.Location = new Point(625, 159);
            btPenagantarJadwal.Name = "btPenagantarJadwal";
            btPenagantarJadwal.Size = new Size(237, 102);
            btPenagantarJadwal.TabIndex = 4;
            btPenagantarJadwal.Text = "PENGANTAR";
            btPenagantarJadwal.UseVisualStyleBackColor = true;
            btPenagantarJadwal.Click += btFarmer_Click;
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
            panelJadwal.Controls.Add(btnTambahJadwal);
            panelJadwal.Controls.Add(btnDetailJadwal);
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
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "TABEL JADWAL";
            // 
            // btnTambahJadwal
            // 
            btnTambahJadwal.Location = new Point(167, 6);
            btnTambahJadwal.Name = "btnTambahJadwal";
            btnTambahJadwal.Size = new Size(94, 38);
            btnTambahJadwal.TabIndex = 2;
            btnTambahJadwal.Text = "ADD";
            btnTambahJadwal.UseVisualStyleBackColor = true;
            btnTambahJadwal.Click += btnTambahJadwal_Click;
            // 
            // btnDetailJadwal
            // 
            btnDetailJadwal.Location = new Point(277, 6);
            btnDetailJadwal.Name = "btnDetailJadwal";
            btnDetailJadwal.Size = new Size(94, 38);
            btnDetailJadwal.TabIndex = 1;
            btnDetailJadwal.Text = "Detail";
            btnDetailJadwal.UseVisualStyleBackColor = true;
            btnDetailJadwal.Click += btnEditJadwal_Click;
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(4, 48);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(1031, 330);
            dgvJadwal.TabIndex = 0;
            // 
            // panelKaryawan
            // 
            panelKaryawan.Controls.Add(txtCariKaryawan);
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
            // txtCariKaryawan
            // 
            txtCariKaryawan.Location = new Point(900, 10);
            txtCariKaryawan.Name = "txtCariKaryawan";
            txtCariKaryawan.Size = new Size(125, 27);
            txtCariKaryawan.TabIndex = 7;
            txtCariKaryawan.TextChanged += textBox1_TextChanged;
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
            btnEditKaryawan.Text = "DETAIL";
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
            // panelDetailJadwalFarmer
            // 
            panelDetailJadwalFarmer.Controls.Add(btSimpanEditFarmer);
            panelDetailJadwalFarmer.Controls.Add(dataGAnggotaJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(btHapusJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(btEditJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(txtTotalUpah);
            panelDetailJadwalFarmer.Controls.Add(txtIdLahanJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(txtNamaLahanJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(txtJumlahDItanamJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(txtStatusJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(txtKeteranganJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(txtBanyakAnggotaJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(txtTanamanJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(label34);
            panelDetailJadwalFarmer.Controls.Add(label32);
            panelDetailJadwalFarmer.Controls.Add(label30);
            panelDetailJadwalFarmer.Controls.Add(label28);
            panelDetailJadwalFarmer.Controls.Add(label26);
            panelDetailJadwalFarmer.Controls.Add(label24);
            panelDetailJadwalFarmer.Controls.Add(label23);
            panelDetailJadwalFarmer.Controls.Add(label22);
            panelDetailJadwalFarmer.Controls.Add(label20);
            panelDetailJadwalFarmer.Controls.Add(lbTanggalJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(l);
            panelDetailJadwalFarmer.Controls.Add(lbIdJadwalFarmer);
            panelDetailJadwalFarmer.Controls.Add(IDJadwal);
            panelDetailJadwalFarmer.Controls.Add(btKembaliJadwalFarmer);
            panelDetailJadwalFarmer.Location = new Point(0, 0);
            panelDetailJadwalFarmer.Name = "panelDetailJadwalFarmer";
            panelDetailJadwalFarmer.Size = new Size(1038, 380);
            panelDetailJadwalFarmer.TabIndex = 38;
            // 
            // btSimpanEditFarmer
            // 
            btSimpanEditFarmer.Enabled = false;
            btSimpanEditFarmer.Location = new Point(12, 326);
            btSimpanEditFarmer.Name = "btSimpanEditFarmer";
            btSimpanEditFarmer.Size = new Size(94, 38);
            btSimpanEditFarmer.TabIndex = 39;
            btSimpanEditFarmer.Text = "Simpan Edit";
            btSimpanEditFarmer.UseVisualStyleBackColor = true;
            btSimpanEditFarmer.Visible = false;
            btSimpanEditFarmer.Click += btSimpanEditFarmer_Click;
            // 
            // dataGAnggotaJadwalFarmer
            // 
            dataGAnggotaJadwalFarmer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGAnggotaJadwalFarmer.Location = new Point(586, 208);
            dataGAnggotaJadwalFarmer.Name = "dataGAnggotaJadwalFarmer";
            dataGAnggotaJadwalFarmer.RowHeadersWidth = 51;
            dataGAnggotaJadwalFarmer.Size = new Size(410, 156);
            dataGAnggotaJadwalFarmer.TabIndex = 38;
            dataGAnggotaJadwalFarmer.CellContentClick += dataGAnggotaJadwalFarmer_CellContentClick;
            // 
            // btHapusJadwalFarmer
            // 
            btHapusJadwalFarmer.Location = new Point(274, 5);
            btHapusJadwalFarmer.Name = "btHapusJadwalFarmer";
            btHapusJadwalFarmer.Size = new Size(94, 38);
            btHapusJadwalFarmer.TabIndex = 37;
            btHapusJadwalFarmer.Text = "HAPUS";
            btHapusJadwalFarmer.UseVisualStyleBackColor = true;
            btHapusJadwalFarmer.Click += btHapusJadwalFarmer_Click;
            // 
            // btEditJadwalFarmer
            // 
            btEditJadwalFarmer.Location = new Point(142, 5);
            btEditJadwalFarmer.Name = "btEditJadwalFarmer";
            btEditJadwalFarmer.Size = new Size(94, 38);
            btEditJadwalFarmer.TabIndex = 36;
            btEditJadwalFarmer.Text = "EDIT";
            btEditJadwalFarmer.UseVisualStyleBackColor = true;
            btEditJadwalFarmer.Click += btEditJadwalFarmer_Click;
            // 
            // txtTotalUpah
            // 
            txtTotalUpah.Location = new Point(179, 121);
            txtTotalUpah.Name = "txtTotalUpah";
            txtTotalUpah.Size = new Size(324, 27);
            txtTotalUpah.TabIndex = 35;
            // 
            // txtIdLahanJadwalFarmer
            // 
            txtIdLahanJadwalFarmer.Location = new Point(732, 169);
            txtIdLahanJadwalFarmer.Name = "txtIdLahanJadwalFarmer";
            txtIdLahanJadwalFarmer.Size = new Size(263, 27);
            txtIdLahanJadwalFarmer.TabIndex = 34;
            // 
            // txtNamaLahanJadwalFarmer
            // 
            txtNamaLahanJadwalFarmer.Location = new Point(732, 123);
            txtNamaLahanJadwalFarmer.Name = "txtNamaLahanJadwalFarmer";
            txtNamaLahanJadwalFarmer.Size = new Size(264, 27);
            txtNamaLahanJadwalFarmer.TabIndex = 33;
            // 
            // txtJumlahDItanamJadwalFarmer
            // 
            txtJumlahDItanamJadwalFarmer.Location = new Point(732, 79);
            txtJumlahDItanamJadwalFarmer.Name = "txtJumlahDItanamJadwalFarmer";
            txtJumlahDItanamJadwalFarmer.Size = new Size(264, 27);
            txtJumlahDItanamJadwalFarmer.TabIndex = 32;
            // 
            // txtStatusJadwalFarmer
            // 
            txtStatusJadwalFarmer.Location = new Point(179, 172);
            txtStatusJadwalFarmer.Name = "txtStatusJadwalFarmer";
            txtStatusJadwalFarmer.Size = new Size(324, 27);
            txtStatusJadwalFarmer.TabIndex = 31;
            // 
            // txtKeteranganJadwalFarmer
            // 
            txtKeteranganJadwalFarmer.Location = new Point(179, 237);
            txtKeteranganJadwalFarmer.Name = "txtKeteranganJadwalFarmer";
            txtKeteranganJadwalFarmer.Size = new Size(324, 27);
            txtKeteranganJadwalFarmer.TabIndex = 30;
            // 
            // txtBanyakAnggotaJadwalFarmer
            // 
            txtBanyakAnggotaJadwalFarmer.Location = new Point(179, 300);
            txtBanyakAnggotaJadwalFarmer.Name = "txtBanyakAnggotaJadwalFarmer";
            txtBanyakAnggotaJadwalFarmer.Size = new Size(324, 27);
            txtBanyakAnggotaJadwalFarmer.TabIndex = 29;
            // 
            // txtTanamanJadwalFarmer
            // 
            txtTanamanJadwalFarmer.Location = new Point(179, 76);
            txtTanamanJadwalFarmer.Name = "txtTanamanJadwalFarmer";
            txtTanamanJadwalFarmer.Size = new Size(324, 27);
            txtTanamanJadwalFarmer.TabIndex = 28;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(72, 122);
            label34.Name = "label34";
            label34.Size = new Size(88, 20);
            label34.TabIndex = 27;
            label34.Text = "Total Upah :";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(636, 162);
            label32.Name = "label32";
            label32.Size = new Size(72, 20);
            label32.TabIndex = 25;
            label32.Text = "Id Lahan :";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(585, 83);
            label30.Name = "label30";
            label30.Size = new Size(123, 20);
            label30.TabIndex = 23;
            label30.Text = "Jumlah Ditanam :";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(41, 76);
            label28.Name = "label28";
            label28.Size = new Size(119, 20);
            label28.TabIndex = 21;
            label28.Text = "Nama Tanaman :";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(609, 126);
            label26.Name = "label26";
            label26.Size = new Size(99, 20);
            label26.TabIndex = 19;
            label26.Text = "Nama Lahan :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(57, 172);
            label24.Name = "label24";
            label24.Size = new Size(103, 20);
            label24.TabIndex = 17;
            label24.Text = "status Jadwal :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(218, 237);
            label23.Name = "label23";
            label23.Size = new Size(0, 20);
            label23.TabIndex = 16;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(35, 303);
            label22.Name = "label22";
            label22.Size = new Size(125, 20);
            label22.TabIndex = 15;
            label22.Text = "Banyak Anggota :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(19, 230);
            label20.Name = "label20";
            label20.Size = new Size(141, 20);
            label20.TabIndex = 13;
            label20.Text = "Keterangan Jadwal :";
            // 
            // lbTanggalJadwalFarmer
            // 
            lbTanggalJadwalFarmer.AutoSize = true;
            lbTanggalJadwalFarmer.Location = new Point(820, 7);
            lbTanggalJadwalFarmer.Name = "lbTanggalJadwalFarmer";
            lbTanggalJadwalFarmer.Size = new Size(58, 20);
            lbTanggalJadwalFarmer.TabIndex = 12;
            lbTanggalJadwalFarmer.Text = "label19";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(666, 7);
            l.Name = "l";
            l.Size = new Size(117, 20);
            l.TabIndex = 11;
            l.Text = "Tanggal Jadwal :";
            // 
            // lbIdJadwalFarmer
            // 
            lbIdJadwalFarmer.AutoSize = true;
            lbIdJadwalFarmer.Location = new Point(179, 49);
            lbIdJadwalFarmer.Name = "lbIdJadwalFarmer";
            lbIdJadwalFarmer.Size = new Size(58, 20);
            lbIdJadwalFarmer.TabIndex = 10;
            lbIdJadwalFarmer.Text = "label17";
            // 
            // IDJadwal
            // 
            IDJadwal.AutoSize = true;
            IDJadwal.Location = new Point(84, 49);
            IDJadwal.Name = "IDJadwal";
            IDJadwal.Size = new Size(76, 20);
            IDJadwal.TabIndex = 9;
            IDJadwal.Text = "ID Jadwal:";
            // 
            // btKembaliJadwalFarmer
            // 
            btKembaliJadwalFarmer.Location = new Point(10, 2);
            btKembaliJadwalFarmer.Name = "btKembaliJadwalFarmer";
            btKembaliJadwalFarmer.Size = new Size(94, 38);
            btKembaliJadwalFarmer.TabIndex = 8;
            btKembaliJadwalFarmer.Text = "BACK";
            btKembaliJadwalFarmer.UseVisualStyleBackColor = true;
            btKembaliJadwalFarmer.Click += btKembaliJadwalFarmer_Click;
            // 
            // panelDetailJadwalPengantar
            // 
            panelDetailJadwalPengantar.Controls.Add(btSimpanEditPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtDetailAlamatPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtTanggalOrderPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtNamaPelanggan);
            panelDetailJadwalPengantar.Controls.Add(txtIdPelangganPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtKeteranganJadwalPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtNoTelpJadwalPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtTotalUpahPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtNamaAnggotaPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtStatusJadwalPengantar);
            panelDetailJadwalPengantar.Controls.Add(txtIDJadwalPengantar);
            panelDetailJadwalPengantar.Controls.Add(btJadwalPengantarHapus);
            panelDetailJadwalPengantar.Controls.Add(btEditJadwalPengantar);
            panelDetailJadwalPengantar.Controls.Add(dataGKeranjangBelanja);
            panelDetailJadwalPengantar.Controls.Add(label38);
            panelDetailJadwalPengantar.Controls.Add(label37);
            panelDetailJadwalPengantar.Controls.Add(label35);
            panelDetailJadwalPengantar.Controls.Add(label33);
            panelDetailJadwalPengantar.Controls.Add(label31);
            panelDetailJadwalPengantar.Controls.Add(label29);
            panelDetailJadwalPengantar.Controls.Add(label27);
            panelDetailJadwalPengantar.Controls.Add(label25);
            panelDetailJadwalPengantar.Controls.Add(label21);
            panelDetailJadwalPengantar.Controls.Add(label19);
            panelDetailJadwalPengantar.Controls.Add(label18);
            panelDetailJadwalPengantar.Controls.Add(lbTanggalJadwalPengantaran);
            panelDetailJadwalPengantar.Controls.Add(label13);
            panelDetailJadwalPengantar.Controls.Add(button5);
            panelDetailJadwalPengantar.Location = new Point(0, 0);
            panelDetailJadwalPengantar.Name = "panelDetailJadwalPengantar";
            panelDetailJadwalPengantar.Size = new Size(1036, 379);
            panelDetailJadwalPengantar.TabIndex = 4;
            // 
            // btSimpanEditPengantar
            // 
            btSimpanEditPengantar.Enabled = false;
            btSimpanEditPengantar.Location = new Point(10, 345);
            btSimpanEditPengantar.Name = "btSimpanEditPengantar";
            btSimpanEditPengantar.Size = new Size(151, 29);
            btSimpanEditPengantar.TabIndex = 38;
            btSimpanEditPengantar.Text = "Simpan Edit";
            btSimpanEditPengantar.UseVisualStyleBackColor = true;
            btSimpanEditPengantar.Visible = false;
            btSimpanEditPengantar.Click += btSimpanEditPengantar_Click;
            // 
            // txtDetailAlamatPengantar
            // 
            txtDetailAlamatPengantar.Location = new Point(620, 159);
            txtDetailAlamatPengantar.Name = "txtDetailAlamatPengantar";
            txtDetailAlamatPengantar.Size = new Size(351, 27);
            txtDetailAlamatPengantar.TabIndex = 37;
            // 
            // txtTanggalOrderPengantar
            // 
            txtTanggalOrderPengantar.Location = new Point(620, 119);
            txtTanggalOrderPengantar.Name = "txtTanggalOrderPengantar";
            txtTanggalOrderPengantar.Size = new Size(351, 27);
            txtTanggalOrderPengantar.TabIndex = 36;
            // 
            // txtNamaPelanggan
            // 
            txtNamaPelanggan.Location = new Point(620, 91);
            txtNamaPelanggan.Name = "txtNamaPelanggan";
            txtNamaPelanggan.Size = new Size(351, 27);
            txtNamaPelanggan.TabIndex = 35;
            // 
            // txtIdPelangganPengantar
            // 
            txtIdPelangganPengantar.Location = new Point(620, 57);
            txtIdPelangganPengantar.Name = "txtIdPelangganPengantar";
            txtIdPelangganPengantar.Size = new Size(351, 27);
            txtIdPelangganPengantar.TabIndex = 34;
            // 
            // txtKeteranganJadwalPengantar
            // 
            txtKeteranganJadwalPengantar.Location = new Point(237, 223);
            txtKeteranganJadwalPengantar.Name = "txtKeteranganJadwalPengantar";
            txtKeteranganJadwalPengantar.Size = new Size(186, 27);
            txtKeteranganJadwalPengantar.TabIndex = 33;
            // 
            // txtNoTelpJadwalPengantar
            // 
            txtNoTelpJadwalPengantar.Location = new Point(237, 185);
            txtNoTelpJadwalPengantar.Name = "txtNoTelpJadwalPengantar";
            txtNoTelpJadwalPengantar.Size = new Size(186, 27);
            txtNoTelpJadwalPengantar.TabIndex = 32;
            // 
            // txtTotalUpahPengantar
            // 
            txtTotalUpahPengantar.Location = new Point(237, 152);
            txtTotalUpahPengantar.Name = "txtTotalUpahPengantar";
            txtTotalUpahPengantar.Size = new Size(186, 27);
            txtTotalUpahPengantar.TabIndex = 31;
            // 
            // txtNamaAnggotaPengantar
            // 
            txtNamaAnggotaPengantar.Location = new Point(237, 118);
            txtNamaAnggotaPengantar.Name = "txtNamaAnggotaPengantar";
            txtNamaAnggotaPengantar.Size = new Size(186, 27);
            txtNamaAnggotaPengantar.TabIndex = 30;
            // 
            // txtStatusJadwalPengantar
            // 
            txtStatusJadwalPengantar.Location = new Point(237, 85);
            txtStatusJadwalPengantar.Name = "txtStatusJadwalPengantar";
            txtStatusJadwalPengantar.Size = new Size(186, 27);
            txtStatusJadwalPengantar.TabIndex = 29;
            // 
            // txtIDJadwalPengantar
            // 
            txtIDJadwalPengantar.Location = new Point(237, 57);
            txtIDJadwalPengantar.Name = "txtIDJadwalPengantar";
            txtIDJadwalPengantar.Size = new Size(186, 27);
            txtIDJadwalPengantar.TabIndex = 28;
            // 
            // btJadwalPengantarHapus
            // 
            btJadwalPengantarHapus.Location = new Point(268, 13);
            btJadwalPengantarHapus.Name = "btJadwalPengantarHapus";
            btJadwalPengantarHapus.Size = new Size(94, 38);
            btJadwalPengantarHapus.TabIndex = 27;
            btJadwalPengantarHapus.Text = "HAPUS";
            btJadwalPengantarHapus.UseVisualStyleBackColor = true;
            btJadwalPengantarHapus.Click += btJadwalPengantarHapus_Click;
            // 
            // btEditJadwalPengantar
            // 
            btEditJadwalPengantar.Location = new Point(142, 10);
            btEditJadwalPengantar.Name = "btEditJadwalPengantar";
            btEditJadwalPengantar.Size = new Size(94, 38);
            btEditJadwalPengantar.TabIndex = 26;
            btEditJadwalPengantar.Text = "EDIT";
            btEditJadwalPengantar.UseVisualStyleBackColor = true;
            btEditJadwalPengantar.Click += btEditJadwalPengantar_Click;
            // 
            // dataGKeranjangBelanja
            // 
            dataGKeranjangBelanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGKeranjangBelanja.Location = new Point(599, 223);
            dataGKeranjangBelanja.Name = "dataGKeranjangBelanja";
            dataGKeranjangBelanja.RowHeadersWidth = 51;
            dataGKeranjangBelanja.Size = new Size(426, 141);
            dataGKeranjangBelanja.TabIndex = 25;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(457, 223);
            label38.Name = "label38";
            label38.Size = new Size(136, 20);
            label38.TabIndex = 23;
            label38.Text = "Keranjang Belanja :";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(483, 118);
            label37.Name = "label37";
            label37.Size = new Size(110, 20);
            label37.TabIndex = 22;
            label37.Text = "Tanggal Order :";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(84, 223);
            label35.Name = "label35";
            label35.Size = new Size(141, 20);
            label35.TabIndex = 20;
            label35.Text = "Ketarangan Jadwal :";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(464, 86);
            label33.Name = "label33";
            label33.Size = new Size(129, 20);
            label33.TabIndex = 19;
            label33.Text = "Nama Pelanggan :";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(491, 60);
            label31.Name = "label31";
            label31.Size = new Size(102, 20);
            label31.TabIndex = 18;
            label31.Text = "Id Pelanggan :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(84, 86);
            label29.Name = "label29";
            label29.Size = new Size(105, 20);
            label29.TabIndex = 17;
            label29.Text = "Status Jadwal :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(85, 152);
            label27.Name = "label27";
            label27.Size = new Size(88, 20);
            label27.TabIndex = 16;
            label27.Text = "Total Upah :";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(84, 118);
            label25.Name = "label25";
            label25.Size = new Size(118, 20);
            label25.TabIndex = 15;
            label25.Text = "Nama Anggota :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(84, 188);
            label21.Name = "label21";
            label21.Size = new Size(95, 20);
            label21.TabIndex = 14;
            label21.Text = "Nomor Telp :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(485, 159);
            label19.Name = "label19";
            label19.Size = new Size(108, 20);
            label19.TabIndex = 13;
            label19.Text = "Detail Alamat :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(83, 57);
            label18.Name = "label18";
            label18.Size = new Size(78, 20);
            label18.TabIndex = 12;
            label18.Text = "Id Jadwal :";
            // 
            // lbTanggalJadwalPengantaran
            // 
            lbTanggalJadwalPengantaran.AutoSize = true;
            lbTanggalJadwalPengantaran.Location = new Point(849, 17);
            lbTanggalJadwalPengantaran.Name = "lbTanggalJadwalPengantaran";
            lbTanggalJadwalPengantaran.Size = new Size(58, 20);
            lbTanggalJadwalPengantaran.TabIndex = 11;
            lbTanggalJadwalPengantaran.Text = "label17";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(696, 16);
            label13.Name = "label13";
            label13.Size = new Size(133, 20);
            label13.TabIndex = 10;
            label13.Text = "Tanggal Sekarang :";
            // 
            // button5
            // 
            button5.Location = new Point(13, 8);
            button5.Name = "button5";
            button5.Size = new Size(94, 38);
            button5.TabIndex = 9;
            button5.Text = "BACK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            // panelTanaman
            // 
            panelTanaman.Controls.Add(txtCariTanaman);
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
            // txtCariTanaman
            // 
            txtCariTanaman.Location = new Point(900, 15);
            txtCariTanaman.Name = "txtCariTanaman";
            txtCariTanaman.Size = new Size(125, 27);
            txtCariTanaman.TabIndex = 6;
            txtCariTanaman.TextChanged += txtCariTanaman_TextChanged;
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
            // panelLahan
            // 
            panelLahan.Controls.Add(txtCariLahan);
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
            // txtCariLahan
            // 
            txtCariLahan.Location = new Point(900, 11);
            txtCariLahan.Name = "txtCariLahan";
            txtCariLahan.Size = new Size(125, 27);
            txtCariLahan.TabIndex = 4;
            txtCariLahan.TextChanged += txtCariLahan_TextChanged;
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
            // panelDetailKaryawan
            // 
            panelDetailKaryawan.Controls.Add(label48);
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
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(99, 103);
            label48.Name = "label48";
            label48.Size = new Size(90, 20);
            label48.TabIndex = 20;
            label48.Text = "Id Karyawan";
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
            lbID.Location = new Point(225, 103);
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
            // panelLainnya
            // 
            panelLainnya.Controls.Add(panelPenarikan);
            panelLainnya.Controls.Add(panelDetailLaporan);
            panelLainnya.Controls.Add(btTarikSaldo);
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
            // panelPenarikan
            // 
            panelPenarikan.Controls.Add(btKonfirmasiPenarikan);
            panelPenarikan.Controls.Add(txtNoRek);
            panelPenarikan.Controls.Add(label47);
            panelPenarikan.Controls.Add(radioButton2);
            panelPenarikan.Controls.Add(radioButton1);
            panelPenarikan.Controls.Add(label46);
            panelPenarikan.Controls.Add(label45);
            panelPenarikan.Controls.Add(label39);
            panelPenarikan.Controls.Add(txtAtasNamaPenarikan);
            panelPenarikan.Controls.Add(txtNominalPenarikan);
            panelPenarikan.Location = new Point(0, 46);
            panelPenarikan.Name = "panelPenarikan";
            panelPenarikan.Size = new Size(1034, 342);
            panelPenarikan.TabIndex = 8;
            // 
            // btKonfirmasiPenarikan
            // 
            btKonfirmasiPenarikan.Location = new Point(849, 280);
            btKonfirmasiPenarikan.Name = "btKonfirmasiPenarikan";
            btKonfirmasiPenarikan.Size = new Size(146, 38);
            btKonfirmasiPenarikan.TabIndex = 17;
            btKonfirmasiPenarikan.Text = "Konfirmasi";
            btKonfirmasiPenarikan.UseVisualStyleBackColor = true;
            btKonfirmasiPenarikan.Click += btKonfirmasiPenarikan_Click;
            // 
            // txtNoRek
            // 
            txtNoRek.Location = new Point(685, 162);
            txtNoRek.Name = "txtNoRek";
            txtNoRek.Size = new Size(243, 27);
            txtNoRek.TabIndex = 9;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(528, 165);
            label47.Name = "label47";
            label47.Size = new Size(121, 20);
            label47.TabIndex = 8;
            label47.Text = "Nomor Rekening";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(104, 214);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Transfer";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(104, 178);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(40, 162);
            label46.Name = "label46";
            label46.Size = new Size(61, 20);
            label46.TabIndex = 5;
            label46.Text = "Metode";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(35, 80);
            label45.Name = "label45";
            label45.Size = new Size(66, 20);
            label45.TabIndex = 4;
            label45.Text = "Nominal";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(573, 73);
            label39.Name = "label39";
            label39.Size = new Size(79, 20);
            label39.TabIndex = 3;
            label39.Text = "Atas nama";
            // 
            // txtAtasNamaPenarikan
            // 
            txtAtasNamaPenarikan.Location = new Point(685, 69);
            txtAtasNamaPenarikan.Name = "txtAtasNamaPenarikan";
            txtAtasNamaPenarikan.Size = new Size(243, 27);
            txtAtasNamaPenarikan.TabIndex = 2;
            // 
            // txtNominalPenarikan
            // 
            txtNominalPenarikan.Location = new Point(127, 80);
            txtNominalPenarikan.Name = "txtNominalPenarikan";
            txtNominalPenarikan.Size = new Size(125, 27);
            txtNominalPenarikan.TabIndex = 1;
            // 
            // panelDetailLaporan
            // 
            panelDetailLaporan.Controls.Add(btKembaliLaporan);
            panelDetailLaporan.Controls.Add(txtIsiJadwalLaporan);
            panelDetailLaporan.Controls.Add(txtIdJadwalLaporan);
            panelDetailLaporan.Controls.Add(txtNamaAnggotaLaporan);
            panelDetailLaporan.Controls.Add(txtIdAnggotaLaporan);
            panelDetailLaporan.Controls.Add(txtIsiLaporan);
            panelDetailLaporan.Controls.Add(txtIdLaporan);
            panelDetailLaporan.Controls.Add(txtWaktuLaporan);
            panelDetailLaporan.Controls.Add(txtTanggalJadwalLaporan);
            panelDetailLaporan.Controls.Add(label44);
            panelDetailLaporan.Controls.Add(label43);
            panelDetailLaporan.Controls.Add(label42);
            panelDetailLaporan.Controls.Add(label41);
            panelDetailLaporan.Controls.Add(label40);
            panelDetailLaporan.Controls.Add(labe);
            panelDetailLaporan.Controls.Add(label36);
            panelDetailLaporan.Controls.Add(label17);
            panelDetailLaporan.Location = new Point(0, 49);
            panelDetailLaporan.Name = "panelDetailLaporan";
            panelDetailLaporan.Size = new Size(1039, 333);
            panelDetailLaporan.TabIndex = 16;
            // 
            // btKembaliLaporan
            // 
            btKembaliLaporan.Location = new Point(22, 268);
            btKembaliLaporan.Name = "btKembaliLaporan";
            btKembaliLaporan.Size = new Size(117, 38);
            btKembaliLaporan.TabIndex = 9;
            btKembaliLaporan.Text = "Back";
            btKembaliLaporan.UseVisualStyleBackColor = true;
            btKembaliLaporan.Click += btKembaliLaporan_Click;
            // 
            // txtIsiJadwalLaporan
            // 
            txtIsiJadwalLaporan.Location = new Point(668, 148);
            txtIsiJadwalLaporan.Name = "txtIsiJadwalLaporan";
            txtIsiJadwalLaporan.Size = new Size(250, 27);
            txtIsiJadwalLaporan.TabIndex = 15;
            // 
            // txtIdJadwalLaporan
            // 
            txtIdJadwalLaporan.Location = new Point(668, 104);
            txtIdJadwalLaporan.Name = "txtIdJadwalLaporan";
            txtIdJadwalLaporan.Size = new Size(250, 27);
            txtIdJadwalLaporan.TabIndex = 14;
            // 
            // txtNamaAnggotaLaporan
            // 
            txtNamaAnggotaLaporan.Location = new Point(668, 63);
            txtNamaAnggotaLaporan.Name = "txtNamaAnggotaLaporan";
            txtNamaAnggotaLaporan.Size = new Size(250, 27);
            txtNamaAnggotaLaporan.TabIndex = 13;
            // 
            // txtIdAnggotaLaporan
            // 
            txtIdAnggotaLaporan.Location = new Point(668, 30);
            txtIdAnggotaLaporan.Name = "txtIdAnggotaLaporan";
            txtIdAnggotaLaporan.Size = new Size(250, 27);
            txtIdAnggotaLaporan.TabIndex = 12;
            // 
            // txtIsiLaporan
            // 
            txtIsiLaporan.Location = new Point(161, 150);
            txtIsiLaporan.Name = "txtIsiLaporan";
            txtIsiLaporan.Size = new Size(229, 27);
            txtIsiLaporan.TabIndex = 11;
            // 
            // txtIdLaporan
            // 
            txtIdLaporan.Location = new Point(163, 110);
            txtIdLaporan.Name = "txtIdLaporan";
            txtIdLaporan.Size = new Size(227, 27);
            txtIdLaporan.TabIndex = 10;
            // 
            // txtWaktuLaporan
            // 
            txtWaktuLaporan.Location = new Point(162, 60);
            txtWaktuLaporan.Name = "txtWaktuLaporan";
            txtWaktuLaporan.Size = new Size(228, 27);
            txtWaktuLaporan.TabIndex = 9;
            // 
            // txtTanggalJadwalLaporan
            // 
            txtTanggalJadwalLaporan.Location = new Point(161, 25);
            txtTanggalJadwalLaporan.Name = "txtTanggalJadwalLaporan";
            txtTanggalJadwalLaporan.Size = new Size(229, 27);
            txtTanggalJadwalLaporan.TabIndex = 8;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(22, 24);
            label44.Name = "label44";
            label44.Size = new Size(117, 20);
            label44.TabIndex = 7;
            label44.Text = "Tanggal Jadwal :";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(40, 66);
            label43.Name = "label43";
            label43.Size = new Size(99, 20);
            label43.TabIndex = 6;
            label43.Text = "Waktu Lapor :";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(540, 27);
            label42.Name = "label42";
            label42.Size = new Size(91, 20);
            label42.TabIndex = 5;
            label42.Text = "Id Anggota :";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(553, 104);
            label41.Name = "label41";
            label41.Size = new Size(78, 20);
            label41.TabIndex = 4;
            label41.Text = "Id Jadwal :";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(552, 148);
            label40.Name = "label40";
            label40.Size = new Size(79, 20);
            label40.TabIndex = 3;
            label40.Text = "Isi Jadwal :";
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.Location = new Point(521, 63);
            labe.Name = "labe";
            labe.Size = new Size(110, 20);
            labe.TabIndex = 2;
            labe.Text = "Nama Pelapor :";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(46, 153);
            label36.Name = "label36";
            label36.Size = new Size(88, 20);
            label36.TabIndex = 1;
            label36.Text = "Isi Laporan :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(52, 113);
            label17.Name = "label17";
            label17.Size = new Size(87, 20);
            label17.TabIndex = 0;
            label17.Text = "Id Laporan :";
            // 
            // btTarikSaldo
            // 
            btTarikSaldo.Location = new Point(509, 8);
            btTarikSaldo.Name = "btTarikSaldo";
            btTarikSaldo.Size = new Size(151, 38);
            btTarikSaldo.TabIndex = 9;
            btTarikSaldo.Text = "Penarikan Saldo";
            btTarikSaldo.UseVisualStyleBackColor = true;
            btTarikSaldo.Click += btTarikSaldo_Click;
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
            dgvLainnya.Location = new Point(3, 49);
            dgvLainnya.Name = "dgvLainnya";
            dgvLainnya.RowHeadersWidth = 51;
            dgvLainnya.Size = new Size(1031, 330);
            dgvLainnya.TabIndex = 0;
            dgvLainnya.CellContentClick += dgvLaporan_CellContentClick;
            dgvLainnya.CellDoubleClick += dgvLainnya_CellDoubleClick;
            // 
            // panelPelanggan
            // 
            panelPelanggan.Controls.Add(txtCariPelanggan);
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
            // txtCariPelanggan
            // 
            txtCariPelanggan.Location = new Point(900, 11);
            txtCariPelanggan.Name = "txtCariPelanggan";
            txtCariPelanggan.Size = new Size(125, 27);
            txtCariPelanggan.TabIndex = 8;
            txtCariPelanggan.TextChanged += textBox1_TextChanged_1;
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
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
            panelPilihanJadwal.ResumeLayout(false);
            panelPilihanJadwal.PerformLayout();
            panelJadwal.ResumeLayout(false);
            panelJadwal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            panelKaryawan.ResumeLayout(false);
            panelKaryawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            panelDetailJadwalFarmer.ResumeLayout(false);
            panelDetailJadwalFarmer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGAnggotaJadwalFarmer).EndInit();
            panelDetailJadwalPengantar.ResumeLayout(false);
            panelDetailJadwalPengantar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGKeranjangBelanja).EndInit();
            panelPilihanJadwalFarmer.ResumeLayout(false);
            panelPilihanJadwalFarmer.PerformLayout();
            panelTanaman.ResumeLayout(false);
            panelTanaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).EndInit();
            panelLahan.ResumeLayout(false);
            panelLahan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).EndInit();
            panelDetailKaryawan.ResumeLayout(false);
            panelDetailKaryawan.PerformLayout();
            panelLainnya.ResumeLayout(false);
            panelLainnya.PerformLayout();
            panelPenarikan.ResumeLayout(false);
            panelPenarikan.PerformLayout();
            panelDetailLaporan.ResumeLayout(false);
            panelDetailLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLainnya).EndInit();
            panelPelanggan.ResumeLayout(false);
            panelPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).EndInit();
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
        private Button btnDetailJadwal;
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
        private Button btPenagantarJadwal;
        private Button btFarmerJadwal;
        private Panel panelPilihanJadwalFarmer;
        private Button lbBack;
        private Label label10;
        private Button btJadwalFarmerLainnya;
        private Button btPanen;
        private Button btTanam;
        private Button button2;
        private Panel panelDetailJadwalPengantar;
        private Label lbIdJadwalFarmer;
        private Label IDJadwal;
        private Button btKembaliJadwalFarmer;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label20;
        private Label lbTanggalJadwalFarmer;
        private Label l;
        private Label label34;
        private Label label32;
        private Label label30;
        private Label label28;
        private Label label26;
        private TextBox txtStatusJadwalFarmer;
        private TextBox txtKeteranganJadwalFarmer;
        private TextBox txtBanyakAnggotaJadwalFarmer;
        private TextBox txtTanamanJadwalFarmer;
        private TextBox txtTotalUpah;
        private TextBox txtIdLahanJadwalFarmer;
        private TextBox txtNamaLahanJadwalFarmer;
        private TextBox txtJumlahDItanamJadwalFarmer;
        private Button btHapusJadwalFarmer;
        private Button btEditJadwalFarmer;
        private Panel panelDetailJadwalFarmer;
        private Button button5;
        private Label lbTanggalJadwalPengantaran;
        private Label label13;
        private Label label18;
        private Label label19;
        private Label label35;
        private Label label33;
        private Label label31;
        private Label label29;
        private Label label27;
        private Label label25;
        private Label label21;
        private Label label38;
        private Label label37;
        private DataGridView dataGKeranjangBelanja;
        private Button btJadwalPengantarHapus;
        private Button btEditJadwalPengantar;
        private TextBox txtDetailAlamatPengantar;
        private TextBox txtTanggalOrderPengantar;
        private TextBox txtNamaPelanggan;
        private TextBox txtIdPelangganPengantar;
        private TextBox txtKeteranganJadwalPengantar;
        private TextBox txtNoTelpJadwalPengantar;
        private TextBox txtTotalUpahPengantar;
        private TextBox txtNamaAnggotaPengantar;
        private TextBox txtStatusJadwalPengantar;
        private TextBox txtIDJadwalPengantar;
        private DataGridView dataGAnggotaJadwalFarmer;
        private Button btSimpanEditPengantar;
        private Button btSimpanEditFarmer;
        private Panel panelPenarikan;
        private Label labe;
        private Label label36;
        private Label label17;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label40;
        private TextBox txtIsiJadwalLaporan;
        private TextBox txtIdJadwalLaporan;
        private TextBox txtNamaAnggotaLaporan;
        private TextBox txtIdAnggotaLaporan;
        private TextBox txtIsiLaporan;
        private TextBox txtIdLaporan;
        private TextBox txtWaktuLaporan;
        private TextBox txtTanggalJadwalLaporan;
        private Button btKembaliLaporan;
        private Button btTarikSaldo;
        private Panel panelDetailLaporan;
        private Label label46;
        private Label label45;
        private Label label39;
        private TextBox txtAtasNamaPenarikan;
        private TextBox txtNominalPenarikan;
        private TextBox txtNoRek;
        private Label label47;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btKonfirmasiPenarikan;
        private TextBox txtCariTanaman;
        private TextBox txtCariKaryawan;
        private TextBox txtCariPelanggan;
        private TextBox txtCariLahan;
        private Label label48;
        private Label lblTanggal;
        private Button btLOGOUT;
        private System.Windows.Forms.Timer timer1;
    }
}