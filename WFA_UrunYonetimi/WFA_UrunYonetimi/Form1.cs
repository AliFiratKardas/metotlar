using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_UrunYonetimi.Class;
using WFA_UrunYonetimi.Data;

namespace WFA_UrunYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Category category = new Category();
        Product product = new Product();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Category category in category.GetCategories())
            {
                cmbCategory.Items.Add(category);
            }
            if (product.GetProducts().Count > 0)
            {
                FillListBox();
            }
            else
            {
                listBox1.Items.Add("herhangi bir ürün eklenmemiş!");
            }
            foreach (Category c in Database.categories)
            {
                CheckBox chk = new CheckBox();
                chk.Text = c.CategoryName;
                chk.Tag = c;
                flowLayoutPanel1.Controls.Add(chk);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.UnitPrice = nudUnitPrice.Value;
            product.Category = (Category)cmbCategory.SelectedItem;
            string result = product.AddProduct(product);
            MessageBox.Show(result);
            FillListBox();
        }
        public void FillListBox()
        {
            listBox1.Items.Clear();
            foreach (Product product in product.GetProducts())
            {
                listBox1.Items.Add(product);
            }
        }
        private void rbLast_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = Database.products.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(Database.products[i]);
            }
        }
        private void rbHighPrice_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Product product = new Product();
            product = Database.products[0];
            for (int i = 0; i <= Database.products.Count - 1; i++)
            {
                if (Database.products[i].UnitPrice >= product.UnitPrice)
                {
                    product = Database.products[i];
                }
            }
            listBox1.Items.Add(product);
        }
        private void rbLowPrice_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Product product = new Product();
            product = Database.products[0];
            for (int i = 0; i <= Database.products.Count - 1; i++)
            {
                if (Database.products[i].UnitPrice <= product.UnitPrice)
                {
                    product = Database.products[i];
                }
            }
            listBox1.Items.Add(product);
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Product> products = Database.products;
            List<Category> categories = Database.categories;
            listBox1.Items.Clear();

            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {


                    for (int i = 0; i <= products.Count - 1; i++)
                    {
                        if (products[i].Category.CategoryName == chk.Text)
                        {
                            listBox1.Items.Add(products[i]);
                        }
                    }
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        string text;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Product> products = Database.products;
            text = txtSearch.Text;
            for (int i = 0; i < Database.products.Count - 1; i++)
            {
                if (products[i].ProductName.Contains(text))
                {
                    listBox1.Items.Add(product);
                }
                else
                {
                    MessageBox.Show("Lütfen ürün giriniz!");
                }
            }
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            product = Database.products[0];
            text = txtSearch.Text;
            for (int i = 0; i < Database.products.Count - 1; i++)
            {
                if (Database.products[i].Category.CategoryName.Contains(text))
                {
                    listBox1.Items.Add(product);
                }
                else
                {
                    MessageBox.Show("lüften kategori giriniz");
                }
            }
        }
    }
}
