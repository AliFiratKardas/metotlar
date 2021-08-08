using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_UrunYonetimi.Class;

namespace WFA_UrunYonetimi.Interface
{
    public interface IProduct
    {
        //Listeleme
        List<Product> GetProducts();

        //Ekleme
        string AddProduct(Product product);

        //Silme

        //Güncelleme

    }
}
