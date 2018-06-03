using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Concurrent;
using DogWalked.Models;

namespace DogWalked.DAL
{
    public class DogRepository
    {

        private static Dictionary<String, Dog> dict = new Dictionary<String, Dog>();

        public Dog getDog(String name)
        {
            Dog dog = null;
            if (dict.TryGetValue(name, out dog))
            {
                return dog;
            }
            else
            {
                return null;
            }
        }

        public void putDog(Dog dog)
        {
            if (dict.ContainsKey(dog.Name))
            {
                //TODO COnflict exception
                throw new Exception("Conflicting dog name");
            }
            dict.Add(dog.Name, dog);
        }

        public void updateDog(Dog dog)
        {
            dict.Add(dog.Name, dog);
        }

    }
}