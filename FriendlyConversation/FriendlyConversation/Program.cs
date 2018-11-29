using System;

namespace FriendlyConversation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name + ". My name is C#, How old are you?");
            int age = int.Parse(Console.ReadLine());
            int csAge = 2002;
            DateTime thisYear = DateTime.Now;
            int currentYear = thisYear.Year;
            Console.WriteLine(age + " is good for me! I was bord on " + csAge + " ,which makes me " + (currentYear - csAge) + " years old.");

            Console.WriteLine();
            Console.WriteLine("Now let's guess the day!");
            Console.Write("Enter the day (in ints): ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter the month (in ints): "); // we could have a method that get the nameOfTheMonth from the number
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime fullDate = new DateTime(year,month,day);
            string dayOfTheWeek = fullDate.Date.ToString("dddd");

            Console.WriteLine("This day should be " + dayOfTheWeek);
        }
    }
}
