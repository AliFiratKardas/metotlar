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
   public class Film:BaseClass,IMovie
    {
        public Film()
        {
            CreateDate = DateTime.Now;
        }
        public Saloon Saloon { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime CreateDate { get; set; }

        public string AddMovie(Film film)
        {
            string result;
            try
            {
                DataBase.Filmler.Add(film);
                result = $"{film.Name} eklendi";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }



        public override string ToString()
        {
            return Name + " " + Description + " " + Saloon + " " + Duration + " " + CreateDate;
        }
    }
}
