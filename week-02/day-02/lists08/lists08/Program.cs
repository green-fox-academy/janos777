using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("Please type in the expression. The format should be: \"+ x y\"");
            string input = Console.ReadLine();
            var inputList = new List<string>();
            inputList = input.Split(' ').ToList();

            string operation = inputList[0];
            double x = double.Parse(inputList[1]);
            double y = double.Parse(inputList[2]);
            double result = 0;

            if (operation == "+")
            {
                result = x + y;
            }

            if (operation == "-")
            {
                result = x - y;
            }

            if (operation == "*")
            {
                result = x * y;
            }

            if (operation == "/")
            {
                result = x / y;
            }

            if (operation == "%")
            {
                result = x % y;
            }

            Console.WriteLine($"The result is: {result}");

            Console.ReadLine();
        }
    }
}
