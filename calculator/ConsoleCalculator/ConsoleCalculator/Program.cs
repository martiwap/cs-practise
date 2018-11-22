using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        private static void Main()
        {
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!

            Console.WriteLine("HI!");
            Console.WriteLine("THIS IS A SIMPLE CALCULATOR THAT TAKES TWO POSITIVE NUMBERS AND ONE OF THE BASIC FOUR MATEMATICAL OPERATOR!");
            Console.WriteLine("  (*^_^*)  ");
            Console.ReadKey();

            float number1;
            float number2;
            string operation;
            float result;

            Console.Write("Please enter your first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the name of the operation you would like to execute (+, -, *, /): ");
            operation = Console.ReadLine();

            Console.Write("Please enter your second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine("The operation executed is: ");
            Console.WriteLine(number1.ToString() + " " + operation + " " + number2.ToString() + " = " + result.ToString());
          
            Console.ReadLine();

       
        }
    }
}
