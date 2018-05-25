using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DogWalked.Models;

namespace DogWalked.Services
{
    public static class ToDogService
    {

        public static Dog convert()
        {
            return new Dog()
            {

            };
        }

        public static double percentToVal(double percent)
        {
            return percent * 9 - 1;
        }

    }
}