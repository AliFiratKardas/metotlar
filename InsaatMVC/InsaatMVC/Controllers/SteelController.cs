using InsaatMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsaatMVC.Controllers
{
    
    public class SteelController : Controller
    {
        InsaatMalzemeleriEntities db = new InsaatMalzemeleriEntities();
        // GET: Steel
        public ActionResult Index()
        {
            List<Steel> steels = db.Steels.ToList();

            return View(steels);
        }
        public ActionResult Details(int id)
        {
            var steel = db.Steels.Where(x => x.ID == id).FirstOrDefault();
            return View(steel);
        }
    }
}