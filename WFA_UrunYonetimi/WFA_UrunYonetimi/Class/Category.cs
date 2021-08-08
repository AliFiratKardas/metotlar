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
    public class Category:BaseClass,ICategory
    {
        public Category()
        {
            CreatedDate = DateTime.Now;
        }



        public string CategoryName { get; set; }

        public List<Category> GetCategories()//
        {
            return Database.categories;
        }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
