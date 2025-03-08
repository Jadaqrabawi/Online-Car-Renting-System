using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoyalCarRentalSystem.Models;
using System.Data;
using System.Data.Entity;


namespace RoyalCarRentalSystem.Controllers
{
    public class HomeController : Controller
    {
        private object db;

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Car()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Features()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }

public ActionResult History()
{
    return View();
}

        [HttpPost]
        public ActionResult Registration(PassengerData passengerData)
        {
            using(RoyalCarDataEntities db=new RoyalCarDataEntities())
            {
                if(ModelState.IsValid)
                {
                    db.PassengerDatas.Add(passengerData);
                    db.SaveChanges();
                    ViewBag.message = "Registration Successfully";
                    ModelState.Clear();
                }
            }
            return View(passengerData);
        }
    }
}