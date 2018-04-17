using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet ("groot")]
        public IActionResult Groot(string message)
        {
            if (message == null)
            {
                return BadRequest(new { error = "I am Groot!" });
            }
            else
            {
                return Json(new { received = $"{ message}", translated = "I am Groot!" });
            }
        }
    }
}
