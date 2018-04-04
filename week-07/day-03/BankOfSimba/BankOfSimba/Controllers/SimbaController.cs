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
        public IActionResult Simba()
        {
            var bankAccountSimba = new BankAccount("Simba", 2000, "Animal.Lion", true);

            return View(bankAccountSimba);
        }

        [Route("all")]
        public IActionResult All()
        {
            List<BankAccount> allBankAccounts = new List<BankAccount>();

            allBankAccounts.Add(new BankAccount("Simba", 2000, "Animal.Lion", true));
            allBankAccounts.Add(new BankAccount("Nala", 1000, "Animal.Lion", false));
            allBankAccounts.Add(new BankAccount("Mufasa", 400, "Animal.Lion", false));
            allBankAccounts.Add(new BankAccount("Rafiki", 2200, "Animal.Mandrill", false));
            allBankAccounts.Add(new BankAccount("Timon", 1200, "Animal.Meerkat", false));
            allBankAccounts.Add(new BankAccount("Pumbaa", 900, "Animal.Warthog", false));

            return View(allBankAccounts);



            /*
            var bankAccountSimba = new BankAccount("Simba", 2000, "Animal.Lion");
            var bankAccountNala = new BankAccount("Nala", 1000, "Animal.Lion");
            var bankAccountMufasa = new BankAccount("Mufasa", 400, "Animal.Lion");
            var bankAccountRafiki = new BankAccount("Rafiki", 2200, "Animal.Mandrill");
            var bankAccountTimon = new BankAccount("Timon", 1200, "Animal.Meerkat");
            var bankAccountPumbaa = new BankAccount("Pumbaa", 900, "Animal.Warthog");

            List<BankAccount> allBankAccounts = new List<BankAccount>();

            allBankAccounts.Add(bankAccountSimba);
            allBankAccounts.Add(bankAccountNala);
            allBankAccounts.Add(bankAccountMufasa);
            allBankAccounts.Add(bankAccountRafiki);
            allBankAccounts.Add(bankAccountTimon);
            allBankAccounts.Add(bankAccountPumbaa);

            return View(allBankAccounts);
            */

            /*
            if (allBankAccounts.Count > 1)
            {
                for (int i = 0; i < allBankAccounts.Count; i++)
                {
                    return View(allBankAccounts[i]);
                }
            }

            else
            {
                return View(bankAccountSimba);
            }
            */

            /*
            @model BankOfSimba.Models.BankAccount
            <!DOCTYPE HTML>
            <html xmlns:th="http://www.thymeleaf.org">
            <head>
            <title>Getting Started: Serving Web Content</title>
            <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
            </head>
            <body>
            <p><strong>Name:</strong> @Model.Name</p>
            <p><strong>Balance:</strong> @Model.Balance.ToString("0.00") @Model.Currency</p>
            <p><strong>Animal type:</strong> @Model.AnimalType</p>
            </body>
            </html>
            */

            /*
             *     th, td {
            border: 2px solid black;
            padding: 10px;
            ${King} == 'true' ? <span style="background-color:red" >;

            {% if King == 'true' % <span style="background-color: red">


            if King == 'true'
            return style="background-color: red"

            return style="background-color: red" {% if King == 'true' %};

            if King ==

                if sourcedata.orderamount < 2000 and sourcedata.orderamount >= 1000
            return 'style="color:green"'
            endif
            }
            */

            /*
             @if (d.King == true)
             @{
                <td>style="background-color: red" </td>;
            }
            */
        }
    }
}
