using InsaatMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsaatMVC.Controllers
{
    public class CementController : Controller
    {
        InsaatMalzemeleriEntities db = new InsaatMalzemeleriEntities();
        // GET: Cement
        public ActionResult Index()
        {
            
            List<Cement> cements= db.Cements.ToList();
            return View(cements);
        }
        public ActionResult Details(int id)
        {
            var cement = db.Cements.Where(x => x.ID == id).FirstOrDefault();
            return View(cement);
        }
    }
}