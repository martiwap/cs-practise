using System;
using System.Linq;
using System.Collections.Generic;

namespace DictionaryCollection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            //create with initialization
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1, "uno"},
                {2, "due"},
                {3, "tre"},
                {4, "quattro"},
                {5, "cinque"},
            };
            foreach (var item in names)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("---------------------");

            //add
            capitals.Add("Russia", "Moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "Berlin");

            //displaying
            foreach (var item in capitals)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("------------------------------");
            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals.Keys.ElementAt(i));
            }
            Console.WriteLine("------------------------------");

            //index
            Console.WriteLine(capitals["Italy"]);
            capitals["USA"] = "Washington"; //adding it
            foreach (var item in capitals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            //capacity
            Console.WriteLine(capitals.Count);
            Console.WriteLine("------------------------------");

            //try get value
            Console.WriteLine(capitals["Spain"]);
            capitals.TryGetValue("Germany", out string result);
            if(result != null)
            {
                Console.WriteLine("result is : " + result);
            }
            Console.WriteLine("------------------------------");

            //remove
            capitals.Remove("Italy");
            foreach (var item in capitals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            //remove all
            //capitals.Clear();

            //contains
            Console.WriteLine(capitals.ContainsKey("England"));
            Console.WriteLine(capitals.ContainsValue("Paris"));

        }
    }
}
