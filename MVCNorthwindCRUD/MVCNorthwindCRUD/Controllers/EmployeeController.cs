using MVCNorthwindCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNorthwindCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
           List<Employee>employees= db.Employees.ToList();
            return View(employees);
        }



        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();

            }
        }
        public ActionResult Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee!=null)
            {


                db.Employees.Remove(employee);
                db.SaveChanges();
                return RedirectToAction("Index");


            }
            else
            {
                return RedirectToAction("Index");
            }

        }











    }
}