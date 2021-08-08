using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_CineAdam.Class;

namespace WFA_CineAdam.Data
{
    public class DataBase
    {
        public static List<Film> Filmler = new List<Film>();


        public static List<Saloon> Saloons = new List<Saloon>()
        {
            new Saloon{Name="1",SeatQuantity=25},
            new Saloon{Name="2",SeatQuantity=25},
            new Saloon {Name="3",SeatQuantity=25},
            new Saloon {Name="4",SeatQuantity=25},
            new Saloon {Name="5",SeatQuantity=25}
        };
        public static List<Seat> seats = new List<Seat>();


    }
}
