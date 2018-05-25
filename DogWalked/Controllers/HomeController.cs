using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DogWalked.Models;
using DogWalked.Services;

namespace DogWalked.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Dog Walked?";
            return View();
        }


        public ActionResult Dogs()
        {
            return View("Dogs", new DogPage()
            {
                dogs = new List<Dog> { new Dog() {
                        FoodStatus = ToDogService.percentToVal(0.5),
                        Name = "Bailey",
                        PeeStatus = ToDogService.percentToVal(1),
                        PoopStatus = ToDogService.percentToVal(0.75),
                        WalkStatus = ToDogService.percentToVal(0.25),
                        WaterStatus = ToDogService.percentToVal(0.3),
                        ImageUrl = "/DogWalked/Content/Logo.png"
                    }
                }
            });
        }

    }
}