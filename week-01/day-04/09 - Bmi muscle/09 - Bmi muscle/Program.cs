using System;

namespace _09___Bmi_muscle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;
            double bMI;

            bMI = massInKg / Math.Pow(heightInM, 2);

            Console.WriteLine(bMI);
            Console.ReadLine();
        }
    }
}
