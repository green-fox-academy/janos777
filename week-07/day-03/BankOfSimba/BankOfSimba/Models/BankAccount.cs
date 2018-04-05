using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }
        public bool King { get; set; }
        public bool GoodGuy { get; set; }

        public BankAccount(string name, int balance, string animalType, bool king, bool goodguy)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            King = king;
            GoodGuy = goodguy;
            Currency = "Zebra";
        }

        public double AddMoney()
        {
            return Balance += King ? 100 : 10;
        }

        public static List<BankAccount> allBankAccounts = new List<BankAccount>
        {
            new BankAccount("Simba", 2000, "Animal.Lion", true, true),
            new BankAccount("Nala", 1000, "Animal.Lion", false, true),
            new BankAccount("Mufasa", 400, "Animal.Lion", false, true),
            new BankAccount("Scar", 1400, "Animal.Lion", false, false),
            new BankAccount("Rafiki", 2200, "Animal.Mandrill", false, true),
            new BankAccount("Timon", 1200, "Animal.Meerkat", false, true),
            new BankAccount("Pumbaa", 900, "Animal.Warthog", false, true)
        };
    }
}
