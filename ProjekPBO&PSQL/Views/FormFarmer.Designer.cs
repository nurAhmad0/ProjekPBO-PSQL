namespace ProjekPBO_PSQL.Views
{
    partial class FormFarmer
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
            panelMiddle = new Panel();
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
            panelLaporan = new Panel();
            dgvLaporan = new DataGridView();
            label6 = new Label();
            btnTambahLaporan = new Button();
            btnHapusLaporan = new Button();
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
            panelHistoriPenarikan = new Panel();
            label5 = new Label();
            dgvHistori = new DataGridView();
            panelBottom = new Panel();
            btJadwal = new Button();
            btnHistoriPenarikan = new Button();
            btnLaporan = new Button();
            btnTarikSaldo = new Button();
            btnJadwal = new Button();
            lblSaldo = new Label();
            lblNama = new Label();
            pictureBox1 = new PictureBox();
            panelTop = new Panel();
            lbSaldo = new Label();
            lblTanggal = new Label();
            panelMiddle.SuspendLayout();
            panelPenarikan.SuspendLayout();
            panelLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            panelJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            panelBuatLaporan.SuspendLayout();
            panelJadwlDiterima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridJadwalDiterima).BeginInit();
            panelHistoriPenarikan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistori).BeginInit();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMiddle
            // 
            panelMiddle.Controls.Add(panelPenarikan);
            panelMiddle.Controls.Add(panelLaporan);
            panelMiddle.Controls.Add(panelJadwal);
            panelMiddle.Controls.Add(panelBuatLaporan);
            panelMiddle.Controls.Add(panelJadwlDiterima);
            panelMiddle.Controls.Add(panelHistoriPenarikan);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 107);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1037, 380);
            panelMiddle.TabIndex = 5;
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
            panelLaporan.Controls.Add(dgvLaporan);
            panelLaporan.Controls.Add(label6);
            panelLaporan.Controls.Add(btnTambahLaporan);
            panelLaporan.Controls.Add(btnHapusLaporan);
            panelLaporan.Dock = DockStyle.Fill;
            panelLaporan.Location = new Point(0, 0);
            panelLaporan.Name = "panelLaporan";
            panelLaporan.Size = new Size(1037, 380);
            panelLaporan.TabIndex = 7;
            panelLaporan.Visible = false;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 14);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 3;
            label6.Text = "TABEL LAPORAN";
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
            label3.Location = new Point(692, 132);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Isi text Laporan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 132);
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
            // panelHistoriPenarikan
            // 
            panelHistoriPenarikan.Controls.Add(label5);
            panelHistoriPenarikan.Controls.Add(dgvHistori);
            panelHistoriPenarikan.Dock = DockStyle.Fill;
            panelHistoriPenarikan.Location = new Point(0, 0);
            panelHistoriPenarikan.Name = "panelHistoriPenarikan";
            panelHistoriPenarikan.Size = new Size(1037, 380);
            panelHistoriPenarikan.TabIndex = 6;
            panelHistoriPenarikan.Visible = false;
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
            // panelBottom
            // 
            panelBottom.BackColor = Color.RosyBrown;
            panelBottom.Controls.Add(btJadwal);
            panelBottom.Controls.Add(btnHistoriPenarikan);
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
            // btnHistoriPenarikan
            // 
            btnHistoriPenarikan.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistoriPenarikan.Location = new Point(382, 14);
            btnHistoriPenarikan.Name = "btnHistoriPenarikan";
            btnHistoriPenarikan.Size = new Size(127, 38);
            btnHistoriPenarikan.TabIndex = 3;
            btnHistoriPenarikan.Text = "HISTORI PENARIKAN";
            btnHistoriPenarikan.UseVisualStyleBackColor = true;
            btnHistoriPenarikan.Click += btnNavHistori_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(544, 14);
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
            btnJadwal.Location = new Point(685, 16);
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
            panelHistoriPenarikan.ResumeLayout(false);
            panelHistoriPenarikan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistori).EndInit();
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
    }
}