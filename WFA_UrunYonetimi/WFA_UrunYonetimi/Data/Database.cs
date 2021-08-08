using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_UrunYonetimi.Class;

namespace WFA_UrunYonetimi.Data
{
    public class Database
    {

        //Kategori Listesi
        public static List<Category> categories = new List<Category>()
        {
            new Category{Id=1,CategoryName="Beverages"},
            new Category{Id=2,CategoryName="Condiments"},
            new Category{Id=3,CategoryName="Diary Products"}

        };



        //Ürün Listesi
        public static List<Product> products = new List<Product>();

    }
}
