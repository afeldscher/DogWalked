using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DogWalked.Models;

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
            return View("Dogs", new DogPage());
        }

    }
}