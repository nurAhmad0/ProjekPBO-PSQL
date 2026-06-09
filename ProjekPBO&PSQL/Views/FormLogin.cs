using ProjekPBO_PSQL.Views;

namespace ProjekPBO_PSQL
{
    public partial class FormLogin : Form
    {
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
    }
}
