namespace ProjekPBO_PSQL.Views
{
    partial class FormOwner
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
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            lblNama = new Label();
            lblSaldo = new Label();
            panelBottom = new Panel();
            btnKaryawan = new Button();
            btnLahan = new Button();
            btnTanaman = new Button();
            btnJadwal = new Button();
            btnPelanggan = new Button();
            btnLaporan = new Button();
            panelMiddle = new Panel();
            panelKaryawan = new Panel();
            dgvKaryawan = new DataGridView();
            colIdAnggota = new DataGridViewTextBoxColumn();
            colNamaAnggota = new DataGridViewTextBoxColumn();
            colNoTelp = new DataGridViewTextBoxColumn();
            colTanggalLahir = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colStatusKerja = new DataGridViewTextBoxColumn();
            colSaldo = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            colIdRole = new DataGridViewTextBoxColumn();
            btnEditKaryawan = new Button();
            btnTambahKaryawan = new Button();
            label1 = new Label();
            button2 = new Button();
            dgvLahan = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelKaryawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.RosyBrown;
            panelTop.Controls.Add(lblSaldo);
            panelTop.Controls.Add(lblNama);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1037, 107);
            panelTop.TabIndex = 0;
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
            // btnKaryawan
            // 
            btnKaryawan.Location = new Point(13, 16);
            btnKaryawan.Name = "btnKaryawan";
            btnKaryawan.Size = new Size(117, 38);
            btnKaryawan.TabIndex = 0;
            btnKaryawan.Text = "KARYAWAN";
            btnKaryawan.UseVisualStyleBackColor = true;
            // 
            // btnLahan
            // 
            btnLahan.Location = new Point(145, 16);
            btnLahan.Name = "btnLahan";
            btnLahan.Size = new Size(117, 38);
            btnLahan.TabIndex = 1;
            btnLahan.Text = "LAHAN";
            btnLahan.UseVisualStyleBackColor = true;
            // 
            // btnTanaman
            // 
            btnTanaman.Location = new Point(278, 16);
            btnTanaman.Name = "btnTanaman";
            btnTanaman.Size = new Size(117, 38);
            btnTanaman.TabIndex = 2;
            btnTanaman.Text = "TANAMAN";
            btnTanaman.UseVisualStyleBackColor = true;
            // 
            // btnJadwal
            // 
            btnJadwal.Location = new Point(411, 16);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(117, 38);
            btnJadwal.TabIndex = 3;
            btnJadwal.Text = "JADWAL";
            btnJadwal.UseVisualStyleBackColor = true;
            // 
            // btnPelanggan
            // 
            btnPelanggan.Location = new Point(545, 16);
            btnPelanggan.Name = "btnPelanggan";
            btnPelanggan.Size = new Size(117, 38);
            btnPelanggan.TabIndex = 4;
            btnPelanggan.Text = "PELANGGAN";
            btnPelanggan.UseVisualStyleBackColor = true;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(681, 16);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(117, 38);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            // 
            // panelMiddle
            // 
            panelMiddle.Controls.Add(panelKaryawan);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 107);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1037, 380);
            panelMiddle.TabIndex = 2;
            // 
            // panelKaryawan
            // 
            panelKaryawan.Controls.Add(panel1);
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
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Columns.AddRange(new DataGridViewColumn[] { colIdAnggota, colNamaAnggota, colNoTelp, colTanggalLahir, colEmail, colStatusKerja, colSaldo, colUsername, colPassword, colIdRole });
            dgvKaryawan.Location = new Point(3, 50);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowHeadersWidth = 51;
            dgvKaryawan.Size = new Size(1031, 330);
            dgvKaryawan.TabIndex = 0;
            // 
            // colIdAnggota
            // 
            colIdAnggota.HeaderText = "ID";
            colIdAnggota.MinimumWidth = 6;
            colIdAnggota.Name = "colIdAnggota";
            colIdAnggota.Width = 125;
            // 
            // colNamaAnggota
            // 
            colNamaAnggota.HeaderText = "Nama Karyawan";
            colNamaAnggota.MinimumWidth = 6;
            colNamaAnggota.Name = "colNamaAnggota";
            colNamaAnggota.Width = 125;
            // 
            // colNoTelp
            // 
            colNoTelp.HeaderText = "No. Telp";
            colNoTelp.MinimumWidth = 6;
            colNoTelp.Name = "colNoTelp";
            colNoTelp.Width = 125;
            // 
            // colTanggalLahir
            // 
            colTanggalLahir.HeaderText = "Tanggal Lahir";
            colTanggalLahir.MinimumWidth = 6;
            colTanggalLahir.Name = "colTanggalLahir";
            colTanggalLahir.Width = 125;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.Width = 125;
            // 
            // colStatusKerja
            // 
            colStatusKerja.HeaderText = "Status Kerja";
            colStatusKerja.MinimumWidth = 6;
            colStatusKerja.Name = "colStatusKerja";
            colStatusKerja.Width = 125;
            // 
            // colSaldo
            // 
            colSaldo.HeaderText = "Saldo";
            colSaldo.MinimumWidth = 6;
            colSaldo.Name = "colSaldo";
            colSaldo.Width = 125;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.Width = 125;
            // 
            // colPassword
            // 
            colPassword.HeaderText = "Password";
            colPassword.MinimumWidth = 6;
            colPassword.Name = "colPassword";
            colPassword.Width = 125;
            // 
            // colIdRole
            // 
            colIdRole.HeaderText = "ID Role";
            colIdRole.MinimumWidth = 6;
            colIdRole.Name = "colIdRole";
            colIdRole.Width = 125;
            // 
            // btnEditKaryawan
            // 
            btnEditKaryawan.Location = new Point(278, 6);
            btnEditKaryawan.Name = "btnEditKaryawan";
            btnEditKaryawan.Size = new Size(94, 38);
            btnEditKaryawan.TabIndex = 1;
            btnEditKaryawan.Text = "EDIT";
            btnEditKaryawan.UseVisualStyleBackColor = true;
            // 
            // btnTambahKaryawan
            // 
            btnTambahKaryawan.Location = new Point(168, 6);
            btnTambahKaryawan.Name = "btnTambahKaryawan";
            btnTambahKaryawan.Size = new Size(94, 38);
            btnTambahKaryawan.TabIndex = 2;
            btnTambahKaryawan.Text = "ADD";
            btnTambahKaryawan.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(278, 6);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 1;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvLahan
            // 
            dgvLahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLahan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgvLahan.Location = new Point(3, 50);
            dgvLahan.Name = "dgvLahan";
            dgvLahan.RowHeadersWidth = 51;
            dgvLahan.Size = new Size(1031, 330);
            dgvLahan.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "ID Role";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Password";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Username";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Saldo";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Status Kerja";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Email";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Tanggal Lahir";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "No. Telp";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nama Karyawan";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(168, 6);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dgvLahan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 380);
            panel1.TabIndex = 4;
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
            panelKaryawan.ResumeLayout(false);
            panelKaryawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridViewTextBoxColumn colIdAnggota;
        private DataGridViewTextBoxColumn colNamaAnggota;
        private DataGridViewTextBoxColumn colNoTelp;
        private DataGridViewTextBoxColumn colTanggalLahir;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colStatusKerja;
        private DataGridViewTextBoxColumn colSaldo;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn colIdRole;
        private Button btnTambahKaryawan;
        private Button btnEditKaryawan;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button button2;
        private DataGridView dgvLahan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}