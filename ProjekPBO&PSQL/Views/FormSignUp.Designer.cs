namespace ProjekPBO_PSQL.Views
{
    partial class FormSignUp
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
            btnBack = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            rdoPengantar = new RadioButton();
            rdoFarmer = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelp = new TextBox();
            txtEmail = new TextBox();
            txtNama = new TextBox();
            dtpLahir = new DateTimePicker();
            btnSignUp = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTelp);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(dtpLahir);
            panel1.Controls.Add(btnSignUp);
            panel1.Location = new Point(48, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 459);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoPengantar);
            groupBox1.Controls.Add(rdoFarmer);
            groupBox1.Location = new Point(38, 342);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 89);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Role";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoPengantar
            // 
            rdoPengantar.AutoSize = true;
            rdoPengantar.Location = new Point(182, 43);
            rdoPengantar.Name = "rdoPengantar";
            rdoPengantar.Size = new Size(96, 24);
            rdoPengantar.TabIndex = 1;
            rdoPengantar.Text = "Pengantar";
            rdoPengantar.UseVisualStyleBackColor = true;
            // 
            // rdoFarmer
            // 
            rdoFarmer.AutoSize = true;
            rdoFarmer.Checked = true;
            rdoFarmer.Location = new Point(71, 43);
            rdoFarmer.Name = "rdoFarmer";
            rdoFarmer.Size = new Size(75, 24);
            rdoFarmer.TabIndex = 0;
            rdoFarmer.TabStop = true;
            rdoFarmer.Text = "Farmer";
            rdoFarmer.UseVisualStyleBackColor = true;
            rdoFarmer.CheckedChanged += rdoFarmer_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(517, 172);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(517, 106);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(640, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 10;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(640, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 27);
            txtUsername.TabIndex = 9;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 288);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 8;
            label4.Text = "No. Telp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 231);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 172);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Tanggal Lahir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 106);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Nama";
            // 
            // txtTelp
            // 
            txtTelp.Location = new Point(155, 285);
            txtTelp.Name = "txtTelp";
            txtTelp.Size = new Size(250, 27);
            txtTelp.TabIndex = 4;
            txtTelp.TextChanged += txtTelp_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(155, 103);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 27);
            txtNama.TabIndex = 2;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // dtpLahir
            // 
            dtpLahir.CustomFormat = "yyyy-MM-dd";
            dtpLahir.Format = DateTimePickerFormat.Custom;
            dtpLahir.Location = new Point(155, 167);
            dtpLahir.Name = "dtpLahir";
            dtpLahir.Size = new Size(250, 27);
            dtpLahir.TabIndex = 1;
            dtpLahir.ValueChanged += dtpLahir_ValueChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(789, 427);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 538);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Name = "FormSignUp";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Panel panel1;
        private Button btnSignUp;
        private DateTimePicker dtpLahir;
        private TextBox txtNama;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtTelp;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private GroupBox groupBox1;
        private RadioButton rdoPengantar;
        private RadioButton rdoFarmer;
    }
}