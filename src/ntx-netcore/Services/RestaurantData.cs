﻿using ntx_netcore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ntx_netcore.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        static List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant
                { Id = 1,
                    Name = "House of Kobe" },
                new Restaurant { Id = 2, Name = "House of Shit" },
                new Restaurant { Id = 3, Name = "New Restaurant" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.Where(x => x.Id == id).FirstOrDefault();

        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(newRestaurant);
            return newRestaurant;
        }
    }

   
}
