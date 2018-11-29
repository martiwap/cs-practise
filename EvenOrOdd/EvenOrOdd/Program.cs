using System;

namespace EvenOrOdd
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will say if the number entered is even or not");

            Console.WriteLine("Enter your nuber: ");
            float number = float.Parse(Console.ReadLine());

            Console.WriteLine(IsEven(number));
        }

        public static bool IsEven(float num)
        {
            if (num % 2 == 0) return true;
            
            return false;
        }
    }
}
