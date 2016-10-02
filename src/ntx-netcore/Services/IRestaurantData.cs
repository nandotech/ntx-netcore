using ntx_netcore.Models;
using System.Collections.Generic;

namespace ntx_netcore.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}
