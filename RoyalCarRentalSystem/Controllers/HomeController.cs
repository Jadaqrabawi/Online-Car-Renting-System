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
            using (RoyalCarDataEntities db = new RoyalCarDataEntities())
            {
                if (ModelState.IsValid)
                {
                    db.PassengerDatas.Add(passengerData);
                    db.SaveChanges();
                    ViewBag.message = "Registration Successfully";
                    ModelState.Clear();
                }
            }
            return View(passengerData);
        }

        [Authorize]
        public ActionResult SearchResults(string pickupLocation, string dropLocation, string pickupDate, string pickupTime, string car)
        {
            var searchResults = GetSearchResults(pickupLocation, dropLocation, pickupDate, pickupTime, car);
            return View(searchResults);
        }

        private IEnumerable<Car> GetSearchResults(string pickupLocation, string dropLocation, string pickupDate, string pickupTime, string car)
        {
            // Replace with actual search logic
            return new List<Car>
            {
                new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, PricePerDay = 50, ImageUrl = "/Content/img/car1.jpg", Seats = 5, Luggage = 3, Transmission = "Automatic", FuelType = "Petrol" },
                new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2021, PricePerDay = 60, ImageUrl = "/Content/img/car2.jpg", Seats = 5, Luggage = 4, Transmission = "Manual", FuelType = "Diesel" },
                new Car { Id = 3, Make = "Ford", Model = "Focus", Year = 2019, PricePerDay = 45, ImageUrl = "/Content/img/car3.jpg", Seats = 5, Luggage = 2, Transmission = "Automatic", FuelType = "Petrol" }
            };
        }

        [Authorize]
        public ActionResult BookCar(int id)
        {
            var car = GetCarById(id);
            return View(car);
        }

        private Car GetCarById(int id)
        {
            // Replace with actual logic to get car by ID
            return new Car { Id = id, Make = "Toyota", Model = "Camry", Year = 2020, PricePerDay = 50, ImageUrl = "/Content/img/car1.jpg", Seats = 5, Luggage = 3, Transmission = "Automatic", FuelType = "Petrol" };
        }

        [Authorize]
        [HttpPost]
        public ActionResult ProcessBooking(BookingData bookingData)
        {
            // Process booking and payment
            return RedirectToAction("BookingConfirmation");
        }

        [Authorize]
        public ActionResult BookingConfirmation()
        {
            return View();
        }
    }
}