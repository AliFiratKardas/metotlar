using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_CineAdam.Abstract;
using WFA_CineAdam.Data;
using WFA_CineAdam.Interface;

namespace WFA_CineAdam
{
    public class Seat
    {
        public string CustomerName { get; set; }
        public decimal TicketPrice { get; set; }
        public int SeatNo { get; set; }
        public override string ToString()
        {
            return $"İzleyici Adı: {CustomerName} Koltuk Numarası: {SeatNo} Bilet Fiyatı: {TicketPrice} TL";
        }



    }
}
