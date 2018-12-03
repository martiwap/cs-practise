using System;

namespace Arrays
{
    class MainClass
    {
        private static Random _random = new Random();

        public static void Main(string[] args)
        {
            int[] numbers = new int[] {}; //initialize empty array

            int[] otherNumbers = new int[5]; //set length
            otherNumbers[0] = 1;
            otherNumbers[1] = 2;
            otherNumbers[2] = 3;
            otherNumbers[3] = 4;
            otherNumbers[4] = 5;

            int[] lastOne = new int[] {10, 15, 20, 25}; // done 

            for (int i = 0; i < otherNumbers.Length; i++)
            {
                Console.WriteLine(otherNumbers[i]);
            }

            string[] weekdays = new string[] {"Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun"};
            foreach(string day in weekdays)
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.WriteLine("The day is: " + day);
            }

            PrintUpSidedownTriangle();

            MonthAndDays();

            DiceRoller();
        }

        public static void PrintUpSidedownTriangle()
        {
            for (int i = 15; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }

        }

        public static void MonthAndDays()
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 13);
            int days = DateTime.DaysInMonth(2018, month);

            Console.WriteLine(month + "-" + days + " days");
        }

        public static void DiceRoller()
        {
            Console.WriteLine("Roll dice? (yes, no)");
            string answer = Console.ReadLine();
            Random rnd = new Random();

            if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(rnd.Next(1, 7));                
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
    }
}

