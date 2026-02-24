using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Market_tes.Helpers;

namespace Market_tes.Services
{
    public class UserService
    {
        private string connectionString = Database.ConnectionString;

        public bool Authenticate(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            using MySqlConnection conn = new MySqlConnection(connectionString);
            {
                conn.Open();
                string query =  "SELECT COUNT(*) FROM users WHERE username=@user AND password=@pass";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder bd = new StringBuilder();

                foreach (byte b in bytes)
                
                    bd.Append(b.ToString("x2"));
                return bd.ToString();
            }
        }
    }
}
