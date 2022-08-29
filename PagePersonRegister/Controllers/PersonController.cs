using PagePersonRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PagePersonRegister.Controllers
{
    public class PersonController : Controller
    {
        private PersonDBEntities1 db = new PersonDBEntities1();

        // GET: Person
        public ActionResult Index()
        {
            return View(db.Person.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Person.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }
        public ActionResult Edit(int id)
        {
            Person person = db.Person.Find(id);
            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }
    }
}