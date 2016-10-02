using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ntx_netcore.Services
{

    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration config)
        {
            _greeting = config["Greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
     }
}
