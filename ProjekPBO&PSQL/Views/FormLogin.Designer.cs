namespace ProjekPBO_PSQL
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            USERNAME = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            linkSignUp = new LinkLabel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // USERNAME
            // 
            USERNAME.AutoSize = true;
            USERNAME.Location = new Point(593, 286);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(0, 20);
            USERNAME.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 410);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(linkSignUp);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(52, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 286);
            panel2.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(218, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 27);
            txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 225);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 6;
            label3.Text = "Belum Punya akun?";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(218, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 27);
            txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 124);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(263, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.Location = new Point(343, 225);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(61, 20);
            linkSignUp.TabIndex = 4;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign Up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 60);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username\r\n";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 410);
            Controls.Add(panel1);
            Controls.Add(USERNAME);
            Name = "FormLogin";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label USERNAME;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label1;
        private Label label3;
        private Label label2;
        private LinkLabel linkSignUp;
        private Panel panel2;
    }
}
