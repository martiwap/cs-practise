using System;

namespace Enumerations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string weekDay = WeekDays.Sunday.ToString();
            // you need to convert enum to string, because they are different type

            Console.WriteLine(weekDay);

            WeekDays myDay = WeekDays.Tuesday;
            Console.WriteLine(myDay);

            WeekDays anotherDay = WeekDays.Sunday;
            Console.WriteLine(anotherDay); // Sunday
            Console.WriteLine((int)anotherDay); // 100

        }
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday = 20,
        Sunday = 100
    }
}
