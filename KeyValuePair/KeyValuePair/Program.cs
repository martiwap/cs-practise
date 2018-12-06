using System;
using System.Collections.Generic;

namespace KeyValuePair
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var capitals = new List<KeyValuePair<string, string>>();

            capitals.Add(new KeyValuePair<string, string>("Italy", "Rome"));
            capitals.Add(new KeyValuePair<string, string>("Germany", "Berlin"));
            capitals.Add(new KeyValuePair<string, string>("Latvia", "Riga"));
            capitals.Add(new KeyValuePair<string, string>("France", "Paris"));
            capitals.Add(new KeyValuePair<string, string>("Finland", "Helsink"));

            foreach (var item in capitals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");

            capitals.RemoveAt(3);

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("-----");

            Console.WriteLine(capitals.Count);

            Console.WriteLine(GetFirstAndLastName());

        }

        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstName = "Martina";
            string lastName = "Natale";

            return new KeyValuePair<string, string>(firstName, lastName);
        }
    }
}
