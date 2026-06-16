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

                switch (idrole)
                {
                    case 1:
                        MessageBox.Show("Login Berhasil! Selamat Datang Owner.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormOwner formOwner = new FormOwner(idAnggota);
                        formOwner.FormClosed += (s, args) => this.Close(); 
                        formOwner.Show();
                        this.Hide(); 
                        break;

                    case 2:
                        MessageBox.Show("Login Berhasil! Selamat Datang Farmer.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormFarmer formFarmer = new FormFarmer(idAnggota, idrole);
                        this.Hide();
                        formFarmer.ShowDialog();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        this.Show();
                        break;

                    case 3:
                        MessageBox.Show("Login Berhasil! Selamat Datang Farmer.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormFarmer formPengantar = new FormFarmer(idAnggota, idrole);
                        formPengantar.FormClosed += (s, args) => this.Close();
                        formPengantar.Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show("Role akun Anda tidak dikenali oleh sistem!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }

                
            }
        }
    }
}
