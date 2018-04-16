using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/Doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet("/Greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("/AppendA/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
             return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost("/Dountil/{what}")]
        public IActionResult Dountil(string what, [FromBody] Dountil dountil)
        {
            if (what == "sum")
            {
                if (dountil.Number == null)
                {
                    return Json(new { error = "Please provide a number!" });
                }
                else
                {
                    return Json(new { result = dountil.Sum(dountil.Number) });
                }
            }

            else if (what == "factor")
            {
                if (dountil.Number == null)
                {
                    return Json(new { error = "Please provide a number!" });
                }
                else
                {
                    return Json(new { result = dountil.Factor(dountil.Number) });
                }
            }

            return Json(new { error = "error" });
        }
    }
}
