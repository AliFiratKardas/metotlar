using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    class Musteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
        string _email;
        public string Email 
        {
            get
            {
                return _email;
            }


            set
            {
                if (value.Contains("@gmail.com"))
                {
                    _email = value;
                }
                if (value.Contains("@hotmail.com"))
                {
                    _email = value;
                }
                else
                {
                    MessageBox.Show("Doğru formatta mail giriniz");
                }
            } 
        }
        public string Adres { get; set; }
    }
}
