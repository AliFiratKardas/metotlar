using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    class Tedarikci
    {
        public string Ad { get; set; }
        string _telefonNo;
        public string  TelefonNo 
        {
            get
            {
                return _telefonNo;
            }
            set
            {
                if (!value.StartsWith("+90"))
                {
                    MessageBox.Show("Hatalı giriş yaptınız, lütfen telefon numaranızın başına +90 yazınız");
                    
                    
                }
                else
                {
                    _telefonNo = value;
                }

            }
        }
        public string Adres { get; set; }
        
    }
}
