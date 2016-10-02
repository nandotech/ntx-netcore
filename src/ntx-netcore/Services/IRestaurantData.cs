using ntx_netcore.Data;
using System.Collections.Generic;

namespace ntx_netcore.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
    }
}
