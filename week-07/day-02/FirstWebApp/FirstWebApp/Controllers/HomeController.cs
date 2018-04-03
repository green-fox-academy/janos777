﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/

        [Route("hello")]
        public IActionResult Hello()
        {
            return Content("Hello World!");
        }
    }
}
