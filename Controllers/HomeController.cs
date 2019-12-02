using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication23.Models;
using WebApplication23.Models.Manager;
using WebApplication23.Models.ViewModels;

namespace WebApplication23.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult HomePage()
        {
            DatabaseContext db = new DatabaseContext();
            PersonViewModel pvm = new PersonViewModel();
            pvm.Fullname = db.Persons.ToList();
            pvm.Id = db.Persons.ToList();
            pvm.Hour = db.Clocks.ToList();
            return View(pvm);
        }
        [HttpPost]
        public ActionResult HomePage(List<int> Id, List<DateTime> Hour)
        {

            DatabaseContext db = new DatabaseContext();
            for (int i = 0; i < Hour.Count; i++)
            {
                if (Hour[i] == )
                {
                    db.Clocks.Add(new Clock
                    {
                        Hour = Hour[i],
                        PersonId = Id[i]
                    });
                }else
                {

                }
            }
            db.SaveChanges();
            return HomePage();
        }
        [HttpGet]
        public ActionResult History()
        {
            DatabaseContext db = new DatabaseContext();
            PersonViewModel pvm = new PersonViewModel();
            pvm.Fullname = db.Persons.ToList();
            pvm.Id = db.Persons.ToList();
            pvm.Hour = db.Clocks.ToList();
            return View(pvm);
        }
    }
}