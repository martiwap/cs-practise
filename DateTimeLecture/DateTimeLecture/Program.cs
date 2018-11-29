using System;

namespace DateTimeLecture
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime myDate = new DateTime(); //01/01/0001 00:00:00
            Console.WriteLine(myDate);        // the beginning of time 0.o

            DateTime myBirthday = new DateTime(1993, 11, 10);
            Console.WriteLine("My birthday is on the " + myBirthday);

            DateTime today = DateTime.Today;
            Console.WriteLine("Today is " + today);

            DateTime now = DateTime.Now;
            Console.WriteLine("Literally, now is " + now);
            Console.WriteLine("This will only display the current date " + now.ToShortDateString());
            Console.WriteLine("This will only display the current time " + now.ToShortTimeString());
            Console.WriteLine("This will display the actual date " + now.ToLongDateString());

            string formattedYear = string.Format("Year is {0:yyyy}", now);
            Console.WriteLine("Formatting the current year in a string: " + formattedYear);

            Console.WriteLine("Let's try this:");
            DateTime dateToDisplay = new DateTime(2017, 09, 30, 09, 09, 59);
            string firstFormat = string.Format("{0:dd-MM-yyyy H:mm:ss}", dateToDisplay);
            string secondFormat = string.Format("{0:dddd} of month {0:MMMM} year {0:yyyy}", dateToDisplay);
            Console.WriteLine("First format: " + firstFormat);
            Console.WriteLine("Second format: " + secondFormat);
            Console.WriteLine("Third format: Day {0:dddd} \n Month {0:MMMM} \n Year {0:yyyy}", dateToDisplay);

        }
    }
}
