namespace ProjekPBO_PSQL.Views
{
    partial class FormLaporanPengantar
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
            txtPelanggan = new TextBox();
            btnTambah = new Button();
            panel1 = new Panel();
            txtDeskripsiPengantar = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnBatal = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPelanggan
            // 
            txtPelanggan.Location = new Point(384, 108);
            txtPelanggan.Name = "txtPelanggan";
            txtPelanggan.ReadOnly = true;
            txtPelanggan.Size = new Size(310, 27);
            txtPelanggan.TabIndex = 15;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtDeskripsiPengantar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPelanggan);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 6;
            // 
            // txtDeskripsiPengantar
            // 
            txtDeskripsiPengantar.Location = new Point(384, 216);
            txtDeskripsiPengantar.Multiline = true;
            txtDeskripsiPengantar.Name = "txtDeskripsiPengantar";
            txtDeskripsiPengantar.Size = new Size(310, 158);
            txtDeskripsiPengantar.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 219);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 17;
            label3.Text = "Deskripsi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 111);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Pelanggan";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(3, 3);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += this.btnBatal_Click;
            // 
            // FormLaporanPengantar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormLaporanPengantar";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TextBox txtPelanggan;
        private Button btnTambah;
        private Panel panel1;
        public TextBox txtDeskripsiPengantar;
        private Label label3;
        private Label label1;
        private Button btnBatal;
    }
}