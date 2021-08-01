using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BilgisayarToplama
{
    public class Bilgisayar:Urun
    {
        public Klavye Klavye { get; set; }
        public Monitor Monitor { get; set; }
        public Islemci Islemci { get; set; }
        public EkranKarti EkranKarti { get; set; }
        public Anakart Anakart { get; set; }
        public GucKaynagi GucKaynagi { get; set; }
    }
}
