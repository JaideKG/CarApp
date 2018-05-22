using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarApp.Models;

namespace CarApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Car> carList = new List<Car>();
            carList.Add(new Car("Pontiac", "Aztek", 2007));
            carList.Add(new Car("Tesla", "S3", 2018));
            carList.Add(new Car("Fiat", "500", 2016));

            ViewBag.CarList = carList;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CarForm()
        {
            Car car = new Car();
            ViewBag.Car = car;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create(Car c)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Car = c;
                return View();
            }
            else
            {
                return View("CarForm");
            }
            
        }
    }
}