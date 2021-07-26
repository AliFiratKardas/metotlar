using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public decimal KdvDahilFİyat
        {
            get
            {
                return Fiyat+(Fiyat*0.18m);
            }
        }


        public int Stok { get; set; }
    }
}
