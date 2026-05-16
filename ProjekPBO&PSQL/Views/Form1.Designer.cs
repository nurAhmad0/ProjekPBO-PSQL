namespace ProjekPBO_PSQL
{
    partial class Form1
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
            label2 = new Label();
            USERNAMEBOX = new TextBox();
            PASSWORDBOX = new TextBox();
            LOGIN_BUTTON = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(USERNAMEBOX);
            panel1.Controls.Add(PASSWORDBOX);
            panel1.Controls.Add(LOGIN_BUTTON);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 653);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 322);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 6;
            label2.Text = "USERNAME";
            // 
            // USERNAMEBOX
            // 
            USERNAMEBOX.AccessibleDescription = "";
            USERNAMEBOX.Location = new Point(450, 364);
            USERNAMEBOX.Name = "USERNAMEBOX";
            USERNAMEBOX.Size = new Size(237, 27);
            USERNAMEBOX.TabIndex = 5;
            // 
            // PASSWORDBOX
            // 
            PASSWORDBOX.Location = new Point(450, 235);
            PASSWORDBOX.Name = "PASSWORDBOX";
            PASSWORDBOX.Size = new Size(237, 27);
            PASSWORDBOX.TabIndex = 4;
            // 
            // LOGIN_BUTTON
            // 
            LOGIN_BUTTON.Location = new Point(450, 524);
            LOGIN_BUTTON.Name = "LOGIN_BUTTON";
            LOGIN_BUTTON.Size = new Size(237, 62);
            LOGIN_BUTTON.TabIndex = 3;
            LOGIN_BUTTON.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 183);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "PASSWORD";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(panel1);
            Controls.Add(USERNAME);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label USERNAME;
        private Panel panel1;
        private Label label1;
        private Button LOGIN_BUTTON;
        private Label label2;
        private TextBox USERNAMEBOX;
        private TextBox PASSWORDBOX;
    }
}
