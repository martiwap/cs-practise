using System;
using System.Threading;

namespace WeekdaysAndColors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey!");
            Thread.Sleep(1000);
            Console.WriteLine("Do you know what day is today?");
            DateTime today = DateTime.Now;
            string day = today.Date.ToString("dddd");
            Thread.Sleep(2000);

            switch(day)
            {
                case "Monday":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Monday");
                    break;
                case "Tuesday":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Tuesday");
                    break;
                case "Wednesday":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wednesday");
                    break;
                case "Thursday":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Thursday");
                    break;
                case "Friday":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Friday");
                    break;
                case "Saturday":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Saturday");
                    break;
                case "Sunday":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
