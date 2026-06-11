namespace ProjekPBO_PSQL.Views
{
    partial class FormEditLahan
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
            panel1 = new Panel();
            cbStatusLahan = new ComboBox();
            btnHapus = new Button();
            txtNamaLahan = new TextBox();
            btnUpdate = new Button();
            txtLuasLahan = new TextBox();
            txtIdLahan = new TextBox();
            label1 = new Label();
            label10 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnBatal = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(cbStatusLahan);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(txtNamaLahan);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtLuasLahan);
            panel1.Controls.Add(txtIdLahan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 3;
            // 
            // cbStatusLahan
            // 
            cbStatusLahan.FormattingEnabled = true;
            cbStatusLahan.Items.AddRange(new object[] { "Aktif", "Tidak Aktif" });
            cbStatusLahan.Location = new Point(377, 338);
            cbStatusLahan.Name = "cbStatusLahan";
            cbStatusLahan.Size = new Size(310, 28);
            cbStatusLahan.TabIndex = 28;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 128, 128);
            btnHapus.Location = new Point(805, 463);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(126, 29);
            btnHapus.TabIndex = 26;
            btnHapus.Text = "HAPUS BARIS";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // txtNamaLahan
            // 
            txtNamaLahan.Location = new Point(377, 120);
            txtNamaLahan.Name = "txtNamaLahan";
            txtNamaLahan.Size = new Size(310, 27);
            txtNamaLahan.TabIndex = 27;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdate.Location = new Point(683, 463);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtLuasLahan
            // 
            txtLuasLahan.Location = new Point(377, 221);
            txtLuasLahan.Name = "txtLuasLahan";
            txtLuasLahan.Size = new Size(310, 27);
            txtLuasLahan.TabIndex = 26;
            // 
            // txtIdLahan
            // 
            txtIdLahan.Location = new Point(189, 461);
            txtIdLahan.Name = "txtIdLahan";
            txtIdLahan.ReadOnly = true;
            txtIdLahan.Size = new Size(310, 27);
            txtIdLahan.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 123);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 23;
            label1.Text = "Nama Lahan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(85, 467);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 23;
            label10.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 341);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 25;
            label5.Text = "Status Lahan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 228);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 24;
            label2.Text = "Luas Lahan";
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
            // FormEditLahan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormEditLahan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnBatal;
        private Label label10;
        private Button btnHapus;
        private Button btnUpdate;
        public ComboBox cbStatusLahan;
        public TextBox txtNamaLahan;
        public TextBox txtLuasLahan;
        private Label label1;
        private Label label5;
        private Label label2;
        public TextBox txtIdLahan;
    }
}