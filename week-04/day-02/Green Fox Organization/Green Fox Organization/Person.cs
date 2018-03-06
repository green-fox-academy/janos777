﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_Organization
{
    class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        public virtual void Introduce()
        {
            Console.WriteLine(@"Hi, I'm {0} a {1} year old {2}.", Name, Age, Gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}