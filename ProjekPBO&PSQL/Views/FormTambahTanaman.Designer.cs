namespace ProjekPBO_PSQL.Views
{
    partial class FormTambahTanaman
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
            txtNamaTanaman = new TextBox();
            txtDurasiPanen = new TextBox();
            btnTambah = new Button();
            panel1 = new Panel();
            txtHargaTanaman = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBatal = new Button();
            label3 = new Label();
            txtNamaGudang = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNamaTanaman
            // 
            txtNamaTanaman.Location = new Point(384, 108);
            txtNamaTanaman.Name = "txtNamaTanaman";
            txtNamaTanaman.Size = new Size(310, 27);
            txtNamaTanaman.TabIndex = 15;
            // 
            // txtDurasiPanen
            // 
            txtDurasiPanen.Location = new Point(384, 209);
            txtDurasiPanen.Name = "txtDurasiPanen";
            txtDurasiPanen.Size = new Size(310, 27);
            txtDurasiPanen.TabIndex = 14;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(839, 463);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtNamaGudang);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtHargaTanaman);
            panel1.Controls.Add(txtNamaTanaman);
            panel1.Controls.Add(txtDurasiPanen);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 3;
            // 
            // txtHargaTanaman
            // 
            txtHargaTanaman.Location = new Point(384, 305);
            txtHargaTanaman.Name = "txtHargaTanaman";
            txtHargaTanaman.Size = new Size(310, 27);
            txtHargaTanaman.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 305);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Harga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 212);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 2;
            label2.Text = "Estimasi Kadaluarsa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 115);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Tanaman";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 386);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 17;
            label3.Text = "Nama Gudang";
            // 
            // txtNamaGudang
            // 
            txtNamaGudang.Location = new Point(384, 386);
            txtNamaGudang.Name = "txtNamaGudang";
            txtNamaGudang.Size = new Size(310, 27);
            txtNamaGudang.TabIndex = 18;
            // 
            // FormTambahTanaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormTambahTanaman";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button btnBatal;
        public TextBox txtNamaTanaman;
        public TextBox txtDurasiPanen;
        public TextBox txtHargaTanaman;
        public TextBox txtNamaGudang;
        private Label label3;
    }
}