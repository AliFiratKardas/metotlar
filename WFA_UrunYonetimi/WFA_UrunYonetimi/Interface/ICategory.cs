using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_UrunYonetimi.Class;

namespace WFA_UrunYonetimi.Interface
{
    public interface ICategory
    {
        List<Category> GetCategories();
    }
}
