using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_Organization
{
    class Mentor : Person
    {
        public string Level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            Level = level;
        }

        public Mentor() : base()
        {
            Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine(@"Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, Level);
        }
    }
}