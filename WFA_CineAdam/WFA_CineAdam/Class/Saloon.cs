using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_CineAdam.Abstract;
using WFA_CineAdam.Data;
using WFA_CineAdam.Interface;

namespace WFA_CineAdam.Class
{
    public class Saloon:BaseClass,ISaloon
    {
        public int SeatQuantity { get; set; }
        public decimal TicketPrice { get; set; }

        public List<Saloon> GetSaloon()
        {
           return DataBase.Saloons;//buradaki işlemde bize Liste tipinde (içinde salon olan) değerler dönmketedir
            
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
