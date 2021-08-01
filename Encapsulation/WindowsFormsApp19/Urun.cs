using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class Urun
    {
        string _adi;
        public string Ad 
        {
            get
            {
                return _adi.ToLower();
            }
            set
            {
                _adi = value;
            }

        
        }
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
