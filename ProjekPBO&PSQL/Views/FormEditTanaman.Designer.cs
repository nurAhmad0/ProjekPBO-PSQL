namespace ProjekPBO_PSQL.Views
{
    partial class FormEditTanaman
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
            btnBatal = new Button();
            panel1 = new Panel();
            btnHapus = new Button();
            btnUpdate = new Button();
            txtIdTanaman = new TextBox();
            label10 = new Label();
            txtHargaTanaman = new ComboBox();
            txtNamaTanaman = new TextBox();
            txtDurasiPanen = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtHargaTanaman);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(txtNamaTanaman);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtDurasiPanen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtIdTanaman);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 4;
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
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdate.Location = new Point(683, 463);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtIdTanaman
            // 
            txtIdTanaman.Location = new Point(189, 461);
            txtIdTanaman.Name = "txtIdTanaman";
            txtIdTanaman.ReadOnly = true;
            txtIdTanaman.Size = new Size(310, 27);
            txtIdTanaman.TabIndex = 24;
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
            // txtHargaTanaman
            // 
            txtHargaTanaman.FormattingEnabled = true;
            txtHargaTanaman.Items.AddRange(new object[] { "Aktif", "Tidak Aktif" });
            txtHargaTanaman.Location = new Point(391, 344);
            txtHargaTanaman.Name = "txtHargaTanaman";
            txtHargaTanaman.Size = new Size(310, 28);
            txtHargaTanaman.TabIndex = 22;
            // 
            // txtNamaTanaman
            // 
            txtNamaTanaman.Location = new Point(391, 126);
            txtNamaTanaman.Name = "txtNamaTanaman";
            txtNamaTanaman.Size = new Size(310, 27);
            txtNamaTanaman.TabIndex = 21;
            // 
            // txtDurasiPanen
            // 
            txtDurasiPanen.Location = new Point(391, 227);
            txtDurasiPanen.Name = "txtDurasiPanen";
            txtDurasiPanen.Size = new Size(310, 27);
            txtDurasiPanen.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 347);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "Harga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 234);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 18;
            label2.Text = "Durasi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 129);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 17;
            label1.Text = "Nama Tanaman";
            // 
            // FormEditTanaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Name = "FormEditTanaman";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox5;
        private TextBox textBox4;
        private Button btnBatal;
        private Panel panel1;
        private Button btnHapus;
        private Button btnUpdate;
        private TextBox textBox7;
        private Label label10;
        public ComboBox txtHargaTanaman;
        public TextBox txtNamaTanaman;
        public TextBox txtDurasiPanen;
        private Label label5;
        private Label label2;
        private Label label1;
        public TextBox txtIdTanaman;
        private TextBox textBox1;
    }
}