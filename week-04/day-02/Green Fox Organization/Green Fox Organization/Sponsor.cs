using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_Organization
{
    class Sponsor : Person
    {
        public string Company;
        public int HiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            Company = company;
            HiredStudents = 0;
        }

        public Sponsor() : base()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine(@"Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", Name, Age, Gender, Company, HiredStudents);
        }

        public int Hire()
        {
            return HiredStudents += 1;
        }
    }
}