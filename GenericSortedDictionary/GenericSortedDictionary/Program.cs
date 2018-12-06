using System;
using System.Collections.Generic;

namespace GenericSortedDictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create
            SortedDictionary<int, string> colors = new SortedDictionary<int, string>();

            //add
            colors.Add(3, "Red");
            colors.Add(4, "Yellow");
            colors.Add(10, "Blue");
            colors.Add(1, "Black");
            colors.Add(59, "Pink");

            //display
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            colors[5] = "Purple";
            colors[59] = "Magenta";
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");


            colors.Remove(4);
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            //colors.Clear();

            colors.ContainsKey(2);
            colors.ContainsValue("White");

        }
    }
}
