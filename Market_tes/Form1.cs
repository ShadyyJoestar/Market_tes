using MySql.Data.MySqlClient;
using Market_tes.Helpers;
using Market_tes.Services;

namespace Market_tes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string ConnStr = Database.ConnectionString;
        private UserService userservice = new UserService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtPassword.Text;

            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username dan Password wajib di isi");
                }
                if(userservice.Authenticate(username, password))
                {
                    MessageBox.Show("Login Berhasil!");

                    Session.IsLoggedIn = true;
                    Session.username = username;

                    FormMarket Formmarket = new FormMarket();
                    Formmarket.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login gagal");
                    txtPassword.Clear();
                    txtusername.Clear();
                    txtusername.Focus();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin mau keluar dri aplikasi?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
