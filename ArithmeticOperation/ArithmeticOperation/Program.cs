using System;

namespace ArithmeticOperation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operators!!!");
            Console.WriteLine("The different operators are listed below.");

            int num1 = 7;
            int num2 = 2;

            Console.WriteLine("Add: " + (num1 + num2));
            Console.WriteLine("Sub: " + (num1 - num2));
            Console.WriteLine("Divide (/): " + (float)(num1 / num2));
            Console.WriteLine("Multiply: " + (num1 * num2));
            Console.WriteLine("Get reminder (%): " + (num1 % num2));
        }
    }
}
