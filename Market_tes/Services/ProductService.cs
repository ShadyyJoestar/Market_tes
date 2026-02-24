using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Market_tes.Models;
using System.Collections.Generic;

namespace Market_tes.Services
{
    internal class ProductService
    {
        private string ConnStr = "server=localhost;database=winform_db;pwd=;user=root;";

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection Conn = new MySqlConnection(ConnStr))
            {
                Conn.Open();
                string query = "SELECT ID, name, category, price, stock FROM products";
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product
                    {
                        id = reader.GetInt32("ID"),
                        name = reader.GetString("name"),
                        Category = reader.GetString("Category"),
                        Price = reader.GetDecimal("price"),
                        stock = reader.GetInt32("stock")
                    };
                    products.Add(p);
                }
            }
            return products;
        }

        public void AddProduct(Product p)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                string query = "INSERT INTO products (name, category, price, stock) VALUES (@name, @Category, @price, @stock)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.Category);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@stock", p.stock);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product p)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                String query = "UPDATE products SET name=@name, category=@category, price=@price, stock=@stock WHERE ID=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.Category);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@Stock", p.Price);
                cmd.Parameters.AddWithValue("@id", p.id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                string query = "DELETE FROM products WHERE ID=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
