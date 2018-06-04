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
                },
                new Dog() {
                        FoodStatus = ToDogService.percentToVal(0.1),
                        Name = "Hamilton",
                        PeeStatus = ToDogService.percentToVal(1.0),
                        PoopStatus = ToDogService.percentToVal(1.0),
                        WalkStatus = ToDogService.percentToVal(1.0),
                        WaterStatus = ToDogService.percentToVal(0.1),
                        ImageUrl = Url.Content("~/Content/dogimg/Hamilton.jpg")
                },
                new Dog() {
                        FoodStatus = ToDogService.percentToVal(0.1),
                        Name = "Sophie",
                        PeeStatus = ToDogService.percentToVal(0.1),
                        PoopStatus = ToDogService.percentToVal(0.1),
                        WalkStatus = ToDogService.percentToVal(0.1),
                        WaterStatus = ToDogService.percentToVal(0.1),
                        ImageUrl = Url.Content("~/Content/dogimg/Sophie.jpg")
                }
                }
            });
        }

    }
}