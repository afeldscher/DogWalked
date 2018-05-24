using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogWalked.Models
{
    public class Dog
    {
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public double WalkStatus { get; set; }
        public double FoodStatus { get; set; }
        public double WaterStatus { get; set; }
        public double PeeStatus { get; set; }
        public double PoopStatus { get; set; }
    }
}