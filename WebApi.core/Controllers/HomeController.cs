﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace WebApi.core.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        // GET: /
        [HttpGet]
        public JsonResult Get()
        {
            var returnObject = new
            {
                DotnetVersion= ".NET Core V1.1.0",
                ServerStatus="Green",
                Description=".Net Core Project for DevOps - Vynd",
                AvailableAPIs= "GET: /api/values"
            };

            return Json(returnObject);
        }
        
    }
}
