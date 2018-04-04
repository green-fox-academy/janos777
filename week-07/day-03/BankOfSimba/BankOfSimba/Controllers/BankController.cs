using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("web")]
    public class BankController : Controller
    {
        // GET: /<controller>/

        [Route("simba")]
        public IActionResult Simba()
        {
            var bankAccountSimba = new BankAccount("Simba", 2000, "Animal.Lion");

            return View(bankAccountSimba);
        }
    }
}
