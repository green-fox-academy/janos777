using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_Organization
{
    class Student : Person
    {
        public string PreviousOrganization;
        public int SkippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public Student() : base()
        {
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine(@"Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", Name, Age, Gender, PreviousOrganization, SkippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            SkippedDays = SkippedDays + numberOfDays;
        }
    }
}