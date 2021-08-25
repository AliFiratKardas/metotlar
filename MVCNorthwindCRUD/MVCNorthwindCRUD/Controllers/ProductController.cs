using MVCNorthwindCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNorthwindCRUD.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        //List
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        //Add
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        //Update
        //ellerinizden öper.
        public ActionResult Update(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
            {
                return View(product);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Update(Product updated)
        {
            //Product product = db.Products.Find(updated.ProductID);

            db.Entry(updated).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View();
        }



        //Delete
        public ActionResult Delete(int id)//45
        {
            Product product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        //Details
        List<Product> GetProducts()
        {
            List<Product> products = db.Products.ToList();
            return products;

        }
        public ActionResult Details(int id)
        {
            Product product = GetProducts().Where(x => x.ProductID == id).FirstOrDefault();
            return View(product);

        }

    }
}