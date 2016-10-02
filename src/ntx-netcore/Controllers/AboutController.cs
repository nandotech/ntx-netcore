using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ntx_netcore.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {
        public string Address()
        {
            return "123 ABC Lane";
        }
        public string Phone()
        {
            return "1+555-555-555";
        }
    }
}
