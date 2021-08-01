using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Eticaret
{
    public class Kitap:Urun
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string YayinEvi { get; set; }
        public int Sayfa { get; set; }
    }
}
