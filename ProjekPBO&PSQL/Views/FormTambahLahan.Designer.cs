namespace ProjekPBO_PSQL.Views
{
    partial class FormTambahLahan
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
            btnTambah = new Button();
            panel1 = new Panel();
            cbStatusLahan = new ComboBox();
            txtNamaLahan = new TextBox();
            btnBatal = new Button();
            txtLuasLahan = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel1.Controls.Add(cbStatusLahan);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(txtNamaLahan);
            panel1.Controls.Add(btnBatal);
            panel1.Controls.Add(txtLuasLahan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 2;
            // 
            // cbStatusLahan
            // 
            cbStatusLahan.FormattingEnabled = true;
            cbStatusLahan.Items.AddRange(new object[] { "Aktif", "Tidak Aktif" });
            cbStatusLahan.Location = new Point(373, 347);
            cbStatusLahan.Name = "cbStatusLahan";
            cbStatusLahan.Size = new Size(310, 28);
            cbStatusLahan.TabIndex = 22;
            // 
            // txtNamaLahan
            // 
            txtNamaLahan.Location = new Point(373, 129);
            txtNamaLahan.Name = "txtNamaLahan";
            txtNamaLahan.Size = new Size(310, 27);
            txtNamaLahan.TabIndex = 21;
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
            // txtLuasLahan
            // 
            txtLuasLahan.Location = new Point(373, 230);
            txtLuasLahan.Name = "txtLuasLahan";
            txtLuasLahan.Size = new Size(310, 27);
            txtLuasLahan.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 132);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 17;
            label1.Text = "Nama Lahan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 350);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 19;
            label5.Text = "Status Lahan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 237);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 18;
            label2.Text = "Luas Lahan";
            // 
            // FormTambahLahan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormTambahLahan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private Panel panel1;
        private Button btnBatal;
        private Label label1;
        private Label label5;
        private Label label2;
        public ComboBox cbStatusLahan;
        public TextBox txtNamaLahan;
        public TextBox txtLuasLahan;
    }
}