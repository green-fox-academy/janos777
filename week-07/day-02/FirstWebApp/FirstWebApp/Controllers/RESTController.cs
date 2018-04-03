﻿using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting($"Hi {name}!");

            return new JsonResult(greeting);
        }
    }
}
