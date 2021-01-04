using BlazorLearnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLearnApp.Services
{
    public class MyService : IMyService
    {
        readonly List<Restaurant> restrants;

        public MyService()
        {
            restrants = new List<Restaurant> {
                new Restaurant
                {
                    Name = "Captain Kid",
                    City = "Redondo Beach",
                    State = "CA"
                },
                new Restaurant
                {
                    Name = "La Bu La",
                    City = "Bellevue",
                    State = "WA"
                },
                new Restaurant
                {
                    Name = "Szechuan Chef",
                    City = "Bellevue",
                    State = "WA"
                },
            };
        }

        public int Count()
        {
            return this.restrants.Count;
        }

        public Restaurant[] GetRestaurants()
        {
            return restrants.ToArray();
        }
    }
}
