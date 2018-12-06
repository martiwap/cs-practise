using System;
using System.Collections.Specialized;
using System.Linq;

namespace NameValueCollections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create
            NameValueCollection cities = new NameValueCollection();

            //add
            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Munich");
            cities.Add("Portugal", "Lisbon");
            cities.Add("Portugal", "Faro");
            cities.Add("Portugal", "Porto");
            cities.Add("Bulgaria", "Sofia");
            cities.Add("Albania", "Tirana");

            //display
            foreach (string item in cities)
            {
                Console.WriteLine("Item :" + item);
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("   ----   ");

            //set
            cities.Set("Bulgaria", "Boh"); // it replace it totally
            foreach (string item in cities)
            {
                Console.WriteLine("Item :" + item);
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("   ----   ");

            //contains
            Console.WriteLine(cities.HasKeys());
            Console.WriteLine("   ----   ");

            //remove
            cities.Remove("Germany");
            foreach (string item in cities)
            {
                Console.WriteLine("Item :" + item);
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("   ----   ");

            //removeall
            cities.Clear();
        }
    }
}
