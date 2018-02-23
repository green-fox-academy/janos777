using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            // make it bigger by 10

            Console.WriteLine(a + 10);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b - 7);

            int c = 44;
            // please double c's value

            Console.WriteLine(c * 2);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d / 5);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(e^3);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)

            Console.WriteLine(f1 > f2);


            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            Console.WriteLine(g1 < (g2 * 2));


            double h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)

            Console.WriteLine((h % 11) == 0);


            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            Console.WriteLine((Math.Pow(i2, 2)) < i1 && i1 < (Math.Pow(i2, 3)));


            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)

            Console.WriteLine((j % 3) == 0 || (j % 5) == 0);


            string k = "Apple";
            //fill the k variable with its content 4 times

            Console.WriteLine(k = k + k + k + k);

            Console.ReadLine();
        }
    }
}
