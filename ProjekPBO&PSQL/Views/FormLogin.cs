using ProjekPBO_PSQL.Controllers;
using ProjekPBO_PSQL.Helpers;
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
                        this.Hide();
                        formOwner.ShowDialog(); 
                        txtUsername.Clear();
                        txtPassword.Clear();
                        this.Show();
                        break;

                    case 2:
                        MessageBox.Show("Login Berhasil! Selamat Datang Farmer.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormKaryawan formFarmer = new FormKaryawan(idAnggota, idrole);
                        this.Hide();
                        formFarmer.ShowDialog();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        this.Show();
                        break;

                    case 3:
                        MessageBox.Show("Login Berhasil! Selamat Datang Karyawan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormKaryawan formPengantar = new FormKaryawan(idAnggota, idrole);
                        this.Hide();
                        formPengantar.ShowDialog();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        this.Show();
                        break;

                    default:
                        MessageBox.Show("Role akun Anda tidak dikenali oleh sistem!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }

                
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
        }
    }
}
