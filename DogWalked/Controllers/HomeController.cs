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
                        FoodStatus = ToDogService.percentToVal(0.8),
                        Name = "Bailey",
                        PeeStatus = ToDogService.percentToVal(.7),
                        PoopStatus = ToDogService.percentToVal(0.1),
                        WalkStatus = ToDogService.percentToVal(0.18),
                        WaterStatus = ToDogService.percentToVal(0.3),
                        ImageUrl = Url.Content("~/Content/dogimg/Bailey.jpg")
                }
                }
            });
        }

    }
}