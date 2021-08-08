using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_UrunYonetimi.Abstract;
using WFA_UrunYonetimi.Data;
using WFA_UrunYonetimi.Interface;

namespace WFA_UrunYonetimi.Class
{
    public class Product:BaseClass,IProduct
    {
        public Product()
        {
            CreatedDate = DateTime.Now;
            Id = Database.products.Count + 1;
        }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Category Category { get; set; }

        public string AddProduct(Product product)
        {
            string result;
            try
            {
                Database.products.Add(product);
                result = $"{product.ProductName} eklendi!";
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }
            return result;
        }

        public List<Product> GetProducts()
        {
            return Database.products;
        }

        public override string ToString()
        {
            return $"Ürün Adı: {ProductName} Fiyat: {UnitPrice} Kategori: {Category.CategoryName}";
        }

    }
}
