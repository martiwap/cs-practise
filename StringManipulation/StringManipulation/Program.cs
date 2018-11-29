using System;

namespace StringManipulation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string movieName = "   Lord of the Rings  ";

            //indexes
            Console.WriteLine(movieName[5]);

            //trim
            Console.WriteLine(movieName.Trim());

            //upper case
            Console.WriteLine(movieName.ToUpper());

            //lower case
            Console.WriteLine(movieName.Trim().ToLower());

            //length
            Console.WriteLine(movieName.Length);
            Console.WriteLine(movieName.Trim().Length);

            //replace
            Console.WriteLine(movieName.Replace('o', '0').Trim());

            string anotherTitle = "Game of Thrones";

            //index of
            Console.WriteLine(anotherTitle.IndexOf('f'));

            //last index of
            Console.WriteLine(anotherTitle.LastIndexOf('e'));

            //substring
            Console.WriteLine(anotherTitle.Substring(2, 7));

            //remove
            Console.WriteLine(anotherTitle.Remove(4));

            //insert
            Console.WriteLine(anotherTitle.Insert(8, "Mr "));

            string tvShow = "Game of Thrones";
            string seasonOne = " - Season 1";
            string newName = "";

            //Add " - season 1"
            // without concatenation or fixed index

            newName = $"{tvShow}{seasonOne}";
            Console.WriteLine(newName);

            //or
            newName = tvShow.Insert(tvShow.Length, seasonOne);
            Console.WriteLine(newName);
        }
    }
}
