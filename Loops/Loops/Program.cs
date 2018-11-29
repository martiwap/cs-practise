using System;

namespace Loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("For Loop:");

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("Count from " + i);
            }
            Console.WriteLine("Settete!!");
            Console.WriteLine("------------------------");

            Console.WriteLine("While loop:");
            int index = 0;
            while(index < 5)
            {
                Console.WriteLine("This has to be print till index is not 5");
                index++;
            }
            Console.WriteLine("It's nearly over..");
            Console.WriteLine("------------------------");


            Console.WriteLine("Do while loop:");

            Random rnd = new Random();
            int number = rnd.Next(1, 9);
            do
            {
                Console.WriteLine("it\'s just a number: " + number);
                number = rnd.Next(1, 9);
            }
            while (number != 7);

            Console.WriteLine("------------------------");

            /*
             * Blocks and Indenting

                ...the blocks within if statements, else statements, while statements, and so on should be one line long. 
                Probably that line should be a function call. Not only does this keep the enclosing function small, 
                but it also adds documentary value because the function called within the block can have a nicely descriptive name.

                This also implies that functions should not be large enough to hold nested structures.
                Therefore, the indent level of a function should not be greater than one or two. 
                This, of course, makes the functions easier to read and understand.

                So Bob Martin's recommendation is that the dept of nested structured should be two at most. 
            */

        }
    }
}
