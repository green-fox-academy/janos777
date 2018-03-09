using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_Organization
{
    class Cohort
    {
        public string Name;
        public List<Student> Students;
        public List<Mentor> Mentors;

        public Cohort(string name)
        {
            Name = name;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine(@"The {0} cohort has {1} students and {2} mentors.", Name, Students.Count, Mentors.Count);
        }
    }
}