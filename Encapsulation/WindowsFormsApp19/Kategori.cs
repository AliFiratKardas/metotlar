using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class Kategori
    {
        string _kategori;
        public string KategoriAd
        {
            get
            {
                return _kategori.ToLower();
            }
            set
            {
                 _kategori = value;
            }
        }// Kategori isimleri kğçğk harften oluşmalı.
        public string Aciklama { get; set; }
    }
}
