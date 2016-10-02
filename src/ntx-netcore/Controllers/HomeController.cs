using Microsoft.AspNetCore.Mvc;
using ntx_netcore.Data;
using ntx_netcore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ntx_netcore.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData,
                                IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {

            return new ObjectResult(_restaurantData.GetAll());
        }
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return new ObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create(Restaurant model)
        {
            var newRestaraunt = new Restaurant();
            newRestaraunt.Name = model.Name;
            newRestaraunt.Id = model.Id;

            newRestaraunt = _restaurantData.Add(newRestaraunt);

            return new ObjectResult(_restaurantData.GetAll());
        }
    }
}
