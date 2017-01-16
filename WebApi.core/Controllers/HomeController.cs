using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.core.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        // GET: /
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(".NET Core V1.1.0, serveur running! check : GET: /api/values");
        }
        
    }
}
