namespace ProjekPBO_PSQL.Views
{
    partial class FormKaryawan
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
            components = new System.ComponentModel.Container();
            panelMiddle = new Panel();
            panelHistoriPenarikan = new Panel();
            btKembaliPenarikan = new Button();
            label5 = new Label();
            dgvHistori = new DataGridView();
            panelPenarikan = new Panel();
            btKonfirmasiPenarikan = new Button();
            btnHistoriPenarikan = new Button();
            txtNoRek = new TextBox();
            label47 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label46 = new Label();
            label45 = new Label();
            label39 = new Label();
            txtAtasNamaPenarikan = new TextBox();
            txtNominalPenarikan = new TextBox();
            panelLaporan = new Panel();
            btnHapusLaporan = new Button();
            btnTambahLaporan = new Button();
            label6 = new Label();
            dgvLaporan = new DataGridView();
            panelJadwal = new Panel();
            btnPilihJadwal = new Button();
            label2 = new Label();
            dgvJadwal = new DataGridView();
            panelBuatLaporan = new Panel();
            btBuatLaporan = new Button();
            txtTextLaporan = new TextBox();
            cbPilihJadwal = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btKembali = new Button();
            panelJadwlDiterima = new Panel();
            dataGridJadwalDiterima = new DataGridView();
            button1 = new Button();
            panelPenarikanSaldo = new Panel();
            btnTarik = new Button();
            txtNominalTarik = new TextBox();
            btnMinus50k = new Button();
            btnPlus100k = new Button();
            btnMinus100k = new Button();
            btnPlus50k = new Button();
            panelBottom = new Panel();
            btJadwal = new Button();
            btnLaporan = new Button();
            btnTarikSaldo = new Button();
            btnJadwal = new Button();
            lblSaldo = new Label();
            lblNama = new Label();
            pictureBox1 = new PictureBox();
            panelTop = new Panel();
            btLOGOUT = new Button();
            lbSaldo = new Label();
            lblTanggal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMiddle.SuspendLayout();
            panelHistoriPenarikan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistori).BeginInit();
            panelPenarikan.SuspendLayout();
            panelLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            panelJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            panelBuatLaporan.SuspendLayout();
            panelJadwlDiterima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridJadwalDiterima).BeginInit();
            panelPenarikanSaldo.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMiddle
            // 
            panelMiddle.Controls.Add(panelHistoriPenarikan);
            panelMiddle.Controls.Add(panelPenarikan);
            panelMiddle.Controls.Add(panelLaporan);
            panelMiddle.Controls.Add(panelJadwal);
            panelMiddle.Controls.Add(panelBuatLaporan);
            panelMiddle.Controls.Add(panelJadwlDiterima);
            panelMiddle.Controls.Add(panelPenarikanSaldo);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 107);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1037, 380);
            panelMiddle.TabIndex = 5;
            // 
            // panelHistoriPenarikan
            // 
            panelHistoriPenarikan.Controls.Add(btKembaliPenarikan);
            panelHistoriPenarikan.Controls.Add(label5);
            panelHistoriPenarikan.Controls.Add(dgvHistori);
            panelHistoriPenarikan.Dock = DockStyle.Fill;
            panelHistoriPenarikan.Location = new Point(0, 0);
            panelHistoriPenarikan.Name = "panelHistoriPenarikan";
            panelHistoriPenarikan.Size = new Size(1037, 380);
            panelHistoriPenarikan.TabIndex = 6;
            panelHistoriPenarikan.Visible = false;
            // 
            // btKembaliPenarikan
            // 
            btKembaliPenarikan.Location = new Point(219, 6);
            btKembaliPenarikan.Name = "btKembaliPenarikan";
            btKembaliPenarikan.Size = new Size(117, 38);
            btKembaliPenarikan.TabIndex = 5;
            btKembaliPenarikan.Text = "Kembali";
            btKembaliPenarikan.UseVisualStyleBackColor = true;
            btKembaliPenarikan.Click += btKembaliPenarikan_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 15);
            label5.Name = "label5";
            label5.Size = new Size(192, 20);
            label5.TabIndex = 3;
            label5.Text = "TABEL HISTORI PENARIKAN";
            // 
            // dgvHistori
            // 
            dgvHistori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistori.Location = new Point(3, 50);
            dgvHistori.Name = "dgvHistori";
            dgvHistori.RowHeadersWidth = 51;
            dgvHistori.Size = new Size(1031, 330);
            dgvHistori.TabIndex = 0;
            // 
            // panelPenarikan
            // 
            panelPenarikan.Controls.Add(btKonfirmasiPenarikan);
            panelPenarikan.Controls.Add(btnHistoriPenarikan);
            panelPenarikan.Controls.Add(txtNoRek);
            panelPenarikan.Controls.Add(label47);
            panelPenarikan.Controls.Add(radioButton2);
            panelPenarikan.Controls.Add(radioButton1);
            panelPenarikan.Controls.Add(label46);
            panelPenarikan.Controls.Add(label45);
            panelPenarikan.Controls.Add(label39);
            panelPenarikan.Controls.Add(txtAtasNamaPenarikan);
            panelPenarikan.Controls.Add(txtNominalPenarikan);
            panelPenarikan.Location = new Point(0, 0);
            panelPenarikan.Name = "panelPenarikan";
            panelPenarikan.Size = new Size(1034, 380);
            panelPenarikan.TabIndex = 11;
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
            // btnHistoriPenarikan
            // 
            btnHistoriPenarikan.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistoriPenarikan.Location = new Point(46, 311);
            btnHistoriPenarikan.Name = "btnHistoriPenarikan";
            btnHistoriPenarikan.Size = new Size(127, 38);
            btnHistoriPenarikan.TabIndex = 3;
            btnHistoriPenarikan.Text = "HISTORI";
            btnHistoriPenarikan.UseVisualStyleBackColor = true;
            btnHistoriPenarikan.Click += btnNavHistori_Click;
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
            // panelLaporan
            // 
            panelLaporan.Controls.Add(btnHapusLaporan);
            panelLaporan.Controls.Add(btnTambahLaporan);
            panelLaporan.Controls.Add(label6);
            panelLaporan.Controls.Add(dgvLaporan);
            panelLaporan.Dock = DockStyle.Fill;
            panelLaporan.Location = new Point(0, 0);
            panelLaporan.Name = "panelLaporan";
            panelLaporan.Size = new Size(1037, 380);
            panelLaporan.TabIndex = 7;
            panelLaporan.Visible = false;
            // 
            // btnHapusLaporan
            // 
            btnHapusLaporan.BackColor = Color.FromArgb(255, 192, 192);
            btnHapusLaporan.Location = new Point(287, 5);
            btnHapusLaporan.Name = "btnHapusLaporan";
            btnHapusLaporan.Size = new Size(94, 38);
            btnHapusLaporan.TabIndex = 4;
            btnHapusLaporan.Text = "DELETE";
            btnHapusLaporan.UseVisualStyleBackColor = false;
            btnHapusLaporan.Click += btnHapusLaporan_Click;
            // 
            // btnTambahLaporan
            // 
            btnTambahLaporan.BackColor = Color.White;
            btnTambahLaporan.Location = new Point(176, 5);
            btnTambahLaporan.Name = "btnTambahLaporan";
            btnTambahLaporan.Size = new Size(94, 38);
            btnTambahLaporan.TabIndex = 2;
            btnTambahLaporan.Text = "ADD";
            btnTambahLaporan.UseVisualStyleBackColor = false;
            btnTambahLaporan.Click += btnTambahLaporan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 14);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 3;
            label6.Text = "TABEL LAPORAN";
            // 
            // dgvLaporan
            // 
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(1, 49);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 51;
            dgvLaporan.Size = new Size(1031, 330);
            dgvLaporan.TabIndex = 0;
            // 
            // panelJadwal
            // 
            panelJadwal.Controls.Add(btnPilihJadwal);
            panelJadwal.Controls.Add(label2);
            panelJadwal.Controls.Add(dgvJadwal);
            panelJadwal.Dock = DockStyle.Fill;
            panelJadwal.Location = new Point(0, 0);
            panelJadwal.Name = "panelJadwal";
            panelJadwal.Size = new Size(1037, 380);
            panelJadwal.TabIndex = 4;
            panelJadwal.Visible = false;
            // 
            // btnPilihJadwal
            // 
            btnPilihJadwal.BackColor = SystemColors.ActiveCaption;
            btnPilihJadwal.Location = new Point(177, 4);
            btnPilihJadwal.Name = "btnPilihJadwal";
            btnPilihJadwal.Size = new Size(94, 38);
            btnPilihJadwal.TabIndex = 2;
            btnPilihJadwal.Text = "PILIH";
            btnPilihJadwal.UseVisualStyleBackColor = false;
            btnPilihJadwal.Click += btnPilihJadwal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 3;
            label2.Text = "TABEL JADWAL";
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(3, 50);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(1031, 330);
            dgvJadwal.TabIndex = 0;
            dgvJadwal.CellContentClick += dgvJadwal_CellContentClick;
            // 
            // panelBuatLaporan
            // 
            panelBuatLaporan.Controls.Add(btBuatLaporan);
            panelBuatLaporan.Controls.Add(txtTextLaporan);
            panelBuatLaporan.Controls.Add(cbPilihJadwal);
            panelBuatLaporan.Controls.Add(label3);
            panelBuatLaporan.Controls.Add(label1);
            panelBuatLaporan.Controls.Add(btKembali);
            panelBuatLaporan.Location = new Point(0, 0);
            panelBuatLaporan.Name = "panelBuatLaporan";
            panelBuatLaporan.Size = new Size(1038, 381);
            panelBuatLaporan.TabIndex = 5;
            // 
            // btBuatLaporan
            // 
            btBuatLaporan.Location = new Point(808, 324);
            btBuatLaporan.Name = "btBuatLaporan";
            btBuatLaporan.Size = new Size(94, 29);
            btBuatLaporan.TabIndex = 5;
            btBuatLaporan.Text = "Buat Laporan";
            btBuatLaporan.UseVisualStyleBackColor = true;
            btBuatLaporan.Click += btBuatLaporan_Click;
            // 
            // txtTextLaporan
            // 
            txtTextLaporan.Location = new Point(605, 195);
            txtTextLaporan.Name = "txtTextLaporan";
            txtTextLaporan.Size = new Size(323, 27);
            txtTextLaporan.TabIndex = 4;
            // 
            // cbPilihJadwal
            // 
            cbPilihJadwal.FormattingEnabled = true;
            cbPilihJadwal.Location = new Point(119, 194);
            cbPilihJadwal.Name = "cbPilihJadwal";
            cbPilihJadwal.Size = new Size(262, 28);
            cbPilihJadwal.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 152);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Isi text Laporan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Pilih Jadwal";
            // 
            // btKembali
            // 
            btKembali.Location = new Point(46, 44);
            btKembali.Name = "btKembali";
            btKembali.Size = new Size(94, 29);
            btKembali.TabIndex = 0;
            btKembali.Text = "Back";
            btKembali.UseVisualStyleBackColor = true;
            btKembali.Click += btKembali_Click;
            // 
            // panelJadwlDiterima
            // 
            panelJadwlDiterima.Controls.Add(dataGridJadwalDiterima);
            panelJadwlDiterima.Controls.Add(button1);
            panelJadwlDiterima.Location = new Point(0, 0);
            panelJadwlDiterima.Name = "panelJadwlDiterima";
            panelJadwlDiterima.Size = new Size(1038, 375);
            panelJadwlDiterima.TabIndex = 4;
            // 
            // dataGridJadwalDiterima
            // 
            dataGridJadwalDiterima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJadwalDiterima.Location = new Point(13, 79);
            dataGridJadwalDiterima.Name = "dataGridJadwalDiterima";
            dataGridJadwalDiterima.RowHeadersWidth = 51;
            dataGridJadwalDiterima.Size = new Size(1012, 293);
            dataGridJadwalDiterima.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 3;
            button1.Text = "PILIH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelPenarikanSaldo
            // 
            panelPenarikanSaldo.Controls.Add(btnTarik);
            panelPenarikanSaldo.Controls.Add(txtNominalTarik);
            panelPenarikanSaldo.Controls.Add(btnMinus50k);
            panelPenarikanSaldo.Controls.Add(btnPlus100k);
            panelPenarikanSaldo.Controls.Add(btnMinus100k);
            panelPenarikanSaldo.Controls.Add(btnPlus50k);
            panelPenarikanSaldo.Dock = DockStyle.Fill;
            panelPenarikanSaldo.Location = new Point(0, 0);
            panelPenarikanSaldo.Name = "panelPenarikanSaldo";
            panelPenarikanSaldo.Size = new Size(1037, 380);
            panelPenarikanSaldo.TabIndex = 5;
            panelPenarikanSaldo.Visible = false;
            // 
            // btnTarik
            // 
            btnTarik.BackColor = Color.FromArgb(192, 255, 192);
            btnTarik.Location = new Point(477, 311);
            btnTarik.Name = "btnTarik";
            btnTarik.Size = new Size(94, 29);
            btnTarik.TabIndex = 10;
            btnTarik.Text = "TARIK";
            btnTarik.UseVisualStyleBackColor = false;
            // 
            // txtNominalTarik
            // 
            txtNominalTarik.BackColor = Color.FromArgb(255, 255, 128);
            txtNominalTarik.Location = new Point(412, 145);
            txtNominalTarik.Name = "txtNominalTarik";
            txtNominalTarik.ReadOnly = true;
            txtNominalTarik.Size = new Size(233, 27);
            txtNominalTarik.TabIndex = 8;
            // 
            // btnMinus50k
            // 
            btnMinus50k.Location = new Point(242, 227);
            btnMinus50k.Name = "btnMinus50k";
            btnMinus50k.Size = new Size(94, 29);
            btnMinus50k.TabIndex = 7;
            btnMinus50k.Text = "- 50.000";
            btnMinus50k.UseVisualStyleBackColor = true;
            // 
            // btnPlus100k
            // 
            btnPlus100k.Location = new Point(719, 227);
            btnPlus100k.Name = "btnPlus100k";
            btnPlus100k.Size = new Size(94, 29);
            btnPlus100k.TabIndex = 6;
            btnPlus100k.Text = "+ 100.000";
            btnPlus100k.UseVisualStyleBackColor = true;
            // 
            // btnMinus100k
            // 
            btnMinus100k.Location = new Point(342, 227);
            btnMinus100k.Name = "btnMinus100k";
            btnMinus100k.Size = new Size(94, 29);
            btnMinus100k.TabIndex = 5;
            btnMinus100k.Text = "- 100.000";
            btnMinus100k.UseVisualStyleBackColor = true;
            btnMinus100k.Click += btnMinus100k_Click;
            // 
            // btnPlus50k
            // 
            btnPlus50k.Location = new Point(619, 227);
            btnPlus50k.Name = "btnPlus50k";
            btnPlus50k.Size = new Size(94, 29);
            btnPlus50k.TabIndex = 4;
            btnPlus50k.Text = "+ 50.000";
            btnPlus50k.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.RosyBrown;
            panelBottom.Controls.Add(btJadwal);
            panelBottom.Controls.Add(btnLaporan);
            panelBottom.Controls.Add(btnTarikSaldo);
            panelBottom.Controls.Add(btnJadwal);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 487);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1037, 66);
            panelBottom.TabIndex = 4;
            // 
            // btJadwal
            // 
            btJadwal.Location = new Point(12, 16);
            btJadwal.Name = "btJadwal";
            btJadwal.Size = new Size(182, 38);
            btJadwal.TabIndex = 4;
            btJadwal.Text = "JADWAL DITERIMA";
            btJadwal.UseVisualStyleBackColor = true;
            btJadwal.Click += btJadwal_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(381, 16);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(117, 38);
            btnLaporan.TabIndex = 2;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnNavLaporan_Click;
            // 
            // btnTarikSaldo
            // 
            btnTarikSaldo.Location = new Point(229, 16);
            btnTarikSaldo.Name = "btnTarikSaldo";
            btnTarikSaldo.Size = new Size(117, 38);
            btnTarikSaldo.TabIndex = 1;
            btnTarikSaldo.Text = "TARIK SALDO";
            btnTarikSaldo.UseVisualStyleBackColor = true;
            btnTarikSaldo.Click += btnNavPenarikan_Click;
            // 
            // btnJadwal
            // 
            btnJadwal.Location = new Point(528, 16);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(117, 38);
            btnJadwal.TabIndex = 0;
            btnJadwal.Text = "JADWAL";
            btnJadwal.UseVisualStyleBackColor = true;
            btnJadwal.Click += btnNavJadwal_Click;
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
            lblNama.Click += lblNama_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Jer;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.RosyBrown;
            panelTop.Controls.Add(btLOGOUT);
            panelTop.Controls.Add(lbSaldo);
            panelTop.Controls.Add(lblTanggal);
            panelTop.Controls.Add(lblSaldo);
            panelTop.Controls.Add(lblNama);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1037, 107);
            panelTop.TabIndex = 3;
            // 
            // btLOGOUT
            // 
            btLOGOUT.BackColor = Color.IndianRed;
            btLOGOUT.Location = new Point(922, 65);
            btLOGOUT.Name = "btLOGOUT";
            btLOGOUT.Size = new Size(94, 29);
            btLOGOUT.TabIndex = 5;
            btLOGOUT.Text = "LOG OUT";
            btLOGOUT.UseVisualStyleBackColor = false;
            btLOGOUT.Click += btLOGOUT_Click;
            // 
            // lbSaldo
            // 
            lbSaldo.AutoSize = true;
            lbSaldo.BackColor = Color.Transparent;
            lbSaldo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSaldo.Location = new Point(229, 63);
            lbSaldo.Name = "lbSaldo";
            lbSaldo.Size = new Size(69, 31);
            lbSaldo.TabIndex = 4;
            lbSaldo.Text = "saldo";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(932, 12);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(93, 20);
            lblTanggal.TabIndex = 3;
            lblTanggal.Text = "yyyy-MM-dd";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // FormFarmer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 553);
            Controls.Add(panelMiddle);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "FormFarmer";
            Text = "Form1";
            Load += FormFarmer_Load;
            panelMiddle.ResumeLayout(false);
            panelHistoriPenarikan.ResumeLayout(false);
            panelHistoriPenarikan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistori).EndInit();
            panelPenarikan.ResumeLayout(false);
            panelPenarikan.PerformLayout();
            panelLaporan.ResumeLayout(false);
            panelLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            panelJadwal.ResumeLayout(false);
            panelJadwal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            panelBuatLaporan.ResumeLayout(false);
            panelBuatLaporan.PerformLayout();
            panelJadwlDiterima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridJadwalDiterima).EndInit();
            panelPenarikanSaldo.ResumeLayout(false);
            panelPenarikanSaldo.PerformLayout();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMiddle;
        private Panel panelBottom;
        private Button btnJadwal;
        private Label lblSaldo;
        private Label lblNama;
        private PictureBox pictureBox1;
        private Panel panelTop;
        private Label label2;
        private Button btnPilihJadwal;
        private DataGridView dgvJadwal;
        private Button btnTarikSaldo;
        private Button btnHistoriPenarikan;
        private Button btnLaporan;
        private Panel panelPenarikanSaldo;
        private TextBox txtNominalTarik;
        private Button btnTarik;
        private Panel panelJadwal;
        private Panel panelHistoriPenarikan;
        private Label label5;
        private DataGridView dgvHistori;
        private Panel panelLaporan;
        private Label label6;
        private Button btnTambahLaporan;
        private DataGridView dgvLaporan;
        private Button btnHapusLaporan;
        private Label lblTanggal;
        private Panel panelJadwlDiterima;
        private Button btJadwal;
        private Label lbSaldo;
        private DataGridView dataGridJadwalDiterima;
        private Button button1;
        private Panel panelPenarikan;
        private Button btKonfirmasiPenarikan;
        private TextBox txtNoRek;
        private Label label47;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label46;
        private Label label45;
        private Label label39;
        private TextBox txtAtasNamaPenarikan;
        private TextBox txtNominalPenarikan;
        private Panel panelBuatLaporan;
        private Button btKembali;
        private Button btBuatLaporan;
        private TextBox txtTextLaporan;
        private ComboBox cbPilihJadwal;
        private Label label3;
        private Label label1;
        private Button btnPlus50k;
        private Button btnMinus50k;
        private Button btnPlus100k;
        private Button btnMinus100k;
        private Button btKembaliPenarikan;
        private Button btLOGOUT;
        private System.Windows.Forms.Timer timer1;
    }
}