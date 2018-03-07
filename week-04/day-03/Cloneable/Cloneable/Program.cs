using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("John", 20, "male", "BME");

            student.Introduce();

            var twinOfJohn = (Student)student.Clone();

            twinOfJohn.Introduce();

            Console.ReadLine();
        }
    }
}
