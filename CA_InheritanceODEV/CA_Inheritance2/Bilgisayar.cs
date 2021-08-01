using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Inheritance2
{
    public class Bilgisayar:Urun
    {
        /*
         * 
         * Eğer bir property'nin birden fazla alt özelliği varsa class olarak tanımlamalıyız. Bu yüzden aşağıdaki özelliklerin birden fazla alt özelliği bulunduğu için her birini ayrı ayrı class (sınıf) oluşturarak tanımladık. 
         * Base (Temel) classımız Ürün. her bir ürünün markası, modeli ve fiyatı istisnasız olarak tanımlanacağı için base classımız içerisinde bu üç özellik bulunmaktadır. Ardından Urun isimli classımızı bütün classlara miras/kalıtım yoluyla aktardık.
         * Bilgisayar da bir ürün olduğu için (kendine ait bir marka,model ve fiyat bulunduğundan) Urun classından miras/kalıtım aldırdık.
         * 
    --Klavye
	--Monitor
	--Ram
	--İşlemci
	--Anakart
	--EkranKartı
	--Güç Kaynağı
         */

        public Klavye Klavye { get; set; }
        public Monitor Monitor { get; set; }
        public Islemci Islemci { get; set; }
        public EkranKarti EkranKarti { get; set; }
        public Anakart Anakart { get; set; }
        public GucKaynagi GucKaynagi { get; set; }






    }
}
