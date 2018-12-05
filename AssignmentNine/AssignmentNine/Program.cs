using System;

namespace AssignmentNine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome! Please choose: ");
            Select:
            Console.WriteLine("(E) - encrypt \n(D) - decrypt \n(X)exit");
            Console.WriteLine("And type your option");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string selected = Console.ReadLine().ToLower();
            if (!(selected is string))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input");
            }

            string text;
            int shift;

            switch (selected.ToLower())
            {
                case ("e"):
                    Console.WriteLine("Enter the text to encrypt, press enter, and enter the shift");
                    text = Console.ReadLine();
                    shift = Convert.ToInt32(Console.ReadLine());
                    Options.Encrypt(text, shift);
                    break;
                case ("d"):
                    Console.WriteLine("Enter the text to decrypt, press enter, and enter the shift");
                    text = Console.ReadLine();
                    shift = Convert.ToInt32(Console.ReadLine());
                    Options.Decrypt(text, shift);
                    break;
                case ("x"):
                    Options.Bye();
                    break;
                default:
                    Console.WriteLine("Please select an option");
                    goto Select;
            } 

        }


    }

    class Options
    {
        public static string Encrypt(string input, int shift)
        {
            string output = "";

            foreach (char ch in input)
            {
                output += cipher(ch, shift);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(output);
            return output;
        }

        public static string Decrypt(string input, int shift)
        {
            return Encrypt(input, 26 - shift);
        }

        public static void Bye()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Goodbye");
        }

        public static char cipher(char ch, int key) {  
            if (!char.IsLetter(ch)) {  
  
                return ch;  
            }  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + key) - d) % 26) + d);  
  
  
        } 
    }


}