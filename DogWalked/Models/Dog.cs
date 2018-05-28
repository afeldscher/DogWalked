using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogWalked.Models
{
    public class Dog
    {
        public int Page { get; set; }
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public double WalkStatus { get; set; }
        public double FoodStatus { get; set; }
        public double WaterStatus { get; set; }
        public double PeeStatus { get; set; }
        public double PoopStatus { get; set; }

        //TODO: Move these calcs elsewhere
        //Not percents, height em
        public bool WalkDot
        {
            get { return WalkStatus < 0.8; }
        }
        public bool FoodDot
        {
            get { return FoodStatus < 0.8; }
        }
        public bool WaterDot
        {
            get { return WaterStatus < 0.8; }
        }
        public bool PeeDot
        {
            get { return PeeStatus < 0.8; }
        }
        public bool PoopDot
        {
            get { return PoopStatus < 0.8; }
        }

    }
}