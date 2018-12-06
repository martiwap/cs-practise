using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericSortedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //creating
            SortedList list = new SortedList(); //non generic
            SortedList<string, string> phoneBook = new SortedList<string, string>(); //generic

            //adding
            phoneBook.Add("Jack", "0192833");
            phoneBook.Add("Paul", "1223243");
            phoneBook.Add("Raul", "1226243");
            phoneBook.Add("Matt", "5555243");
            phoneBook.Add("Cath", "0988765");


            //displaying
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("-------------------------");

            //index
            phoneBook["Paul"] = "0000000";
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("-------------------------");

            //trygetvalue
            phoneBook.TryGetValue("Miss", out string result);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("-------------------------");

            //remove
            phoneBook.Remove("Paul");
            phoneBook.RemoveAt(3);
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("-------------------------");

            //removeall
            //phoneBook.Clear();

            //contains
            Console.WriteLine(phoneBook.ContainsValue("92738390"));
        }
    }
}
