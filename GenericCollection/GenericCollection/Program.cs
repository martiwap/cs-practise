using System;
using System.Collections.Generic;

namespace GenericCollection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //creating
            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>();

            //adding
            firstList.Add("melone");
            firstList.Add("pere");
            firstList.Add("prugne");
            firstList.Add("fichi");

            //display
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");

            //index
            Console.WriteLine(firstList[2]);
            Console.WriteLine("--------------------");

            //capacity
            Console.WriteLine("Count : " + firstList.Count);
            Console.WriteLine("--------------------");

            //sorting
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");

            //reversing
            firstList.Reverse();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");

            //removing
            firstList.Remove("pere"); //removeAt and removeRange
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");

            //remove all
            //firstList.Clear();

            //contains
            Console.WriteLine(firstList.Contains("uva"));
            Console.WriteLine("--------------------");

            //getRange
            secondList = firstList.GetRange(0, 2);
            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
