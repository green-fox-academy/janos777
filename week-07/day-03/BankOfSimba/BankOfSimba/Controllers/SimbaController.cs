using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("bank")]
    public class SimbaController : Controller
    {
        // GET: /<controller>/

        [Route("simba")]
        [HttpGet]
        public IActionResult Simba()
        {
            var bankAccountSimba = new BankAccount("Simba", 2000, "Animal.Lion", true, true);

            return View(bankAccountSimba);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            return View(BankAccount.allBankAccounts);
        }
        
        [HttpPost]
        [Route("/addmoney/{name}")]
        public IActionResult AddMoney(string name)
        {
            foreach (var bankAccount in BankAccount.allBankAccounts)
            {
                if (bankAccount.Name.Equals(name))
                {
                    bankAccount.AddMoney();
                }
            }

            return RedirectToAction("All");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(string name, int balance, string animalType, string kingFromUser, string goodguyFromUser)
        {
            bool king = Convert.ToBoolean(kingFromUser);
            bool goodguy = Convert.ToBoolean(goodguyFromUser);

            BankAccount.allBankAccounts.Add(new BankAccount(name, balance, animalType, king, goodguy));

            return RedirectToAction("All");
        }
    }
}
