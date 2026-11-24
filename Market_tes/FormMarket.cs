using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market_tes.Services;
using Market_tes.Models;
using Market_tes.Helpers;

namespace Market_tes
{
    public partial class FormMarket : Form
    {
        private ProductService productService = new ProductService();
        private int selectedProductId = -1; 
        public FormMarket()
        {
            InitializeComponent();
        }
       


        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                btndel.Enabled = true;
                btnupdt.Enabled = true;

            }
        }



        private void FormMarket_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show("Akses ditolak");
                this.Close();
                return;
            }

            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = productService.GetAllProducts();
        }

        private bool ValidateInput()
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name Wajib di isi!");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Price harus angka!");
                return false;
            }

            if (!int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("Stock harus angka!");
                return false;
            }
            return true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            Product p = new Product
            {
                name = txtName.Text,
                Category = txtCategory.Text,
                Price = decimal.Parse(txtPrice.Text),
                stock = int.Parse(txtStock.Text)
            };

            productService.AddProduct(p);

            LoadProducts();
            ClearForm();
        }

        private void ClearForm()
        {
            txtCategory.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            selectedProductId = -1;
            btnupdt.Enabled = false;
            btndel.Enabled = false;
        }

        private void btnupdt_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Pilih produk dulu");
                return;
            }

            if (!ValidateInput())
                return;
            Product p = new Product
            {
                id = selectedProductId,
                name = txtName.Text,
                Category = txtCategory.Text,
                Price = decimal.Parse(txtPrice.Text),
                stock = int.Parse(txtStock.Text)
            };

            productService.UpdateProduct(p);

            LoadProducts();
            ClearForm();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("pilih produk dulu!");
                return;
            }
            DialogResult result = MessageBox.Show("Yakin mau dihapus?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productService.DeleteProduct(selectedProductId);

                LoadProducts();
                ClearForm();
            }
        }
       

        private void btnclr_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("yakin mau logout?", "konfirmasi ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.IsLoggedIn = false;
                Form1 Login = new Form1();
                Login.Show();
                this.Close();
            }
        }

        
    }
}
