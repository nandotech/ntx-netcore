using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ntx_netcore.Data;

namespace ntx_netcore.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private DataContext _context;

        public SqlRestaurantData(DataContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            _context.Add(newRestaurant);
            _context.SaveChanges();
            return newRestaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants;
        }
    }
}
