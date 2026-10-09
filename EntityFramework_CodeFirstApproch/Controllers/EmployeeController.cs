using EntityFramework_CodeFirstApproch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_CodeFirstApproch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
      readonly EmployeeDbContext db = new EmployeeDbContext();

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            db.employees.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Read");
        } 
        public ActionResult Read()
        {
            var users = db.employees.ToList();
            db.SaveChanges();
            return View(users);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var user = db.employees.Where(u => u.Eno == id).SingleOrDefault();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Employee emp)
        {
            var user = db.employees.FirstOrDefault(x => x.Eno == id);
            if (user != null)
            {
                user.Ename = emp.Ename;
                user.Sal = emp.Sal;
                user.Job = emp.Job;
                user.Sal = emp.Sal;
                user.Deptno = emp.Deptno;
                db.SaveChanges();
                return RedirectToAction("Read");
            }
            return View(); 
        }

        public ActionResult Delete(int id)
        {
            var user = db.employees.Where(u => u.Eno == id).SingleOrDefault();
            if (user != null)
            {
                db.employees.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("Read");
        }



    }
}