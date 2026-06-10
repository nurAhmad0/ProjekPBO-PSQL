using ProjekPBO_PSQL.Controllers;
using ProjekPBO_PSQL.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjekPBO_PSQL
{
    public partial class FormLogin : Form
    {
        OrangController Controller = new OrangController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp formSignIn = new FormSignUp();

            formSignIn.Show();

            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.ApakahKosong(txtUsername.Text) || Validator.ApakahKosong(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            Tuple<int, int> hasilLogin = Controller.LoginOtentikasi(Username, Password);

            int idAnggota = hasilLogin.Item1;    
            int idrole = hasilLogin.Item2;

            if (idAnggota > 0)
            {
                MessageBox.Show($"Login Berhasil! Selamat Datang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (idrole)
                {
                    case 1:
                        FormOwner formOwner = new FormOwner(idAnggota);
                        formOwner.Show();
                        break;

                    
                }

                this.Hide();
            }
        }
    }
}
