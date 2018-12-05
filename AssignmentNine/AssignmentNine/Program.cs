using System;

namespace AssignmentNine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi User. \nPlease select your options: ");
            Select:
            Console.WriteLine("encrypt, decrypt, exit");
            Console.WriteLine("And type your option");

            string selected = Console.ReadLine().ToLower();
            if (!(selected is string))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input");
            }

            string text;
            int shift;

            try {
                switch (selected)
                {
                    case ("encrypt"):
                        Console.WriteLine("Enter the text to encrypt, press enter, and enter the shift");
                        text = Console.ReadLine();
                        shift = Convert.ToInt32(Console.ReadLine());
                        Options.Encrypt(text, shift);
                        break;
                    case ("decrypt"):
                        Console.WriteLine("Enter the text to decrypt, press enter, and enter the shift");
                        text = Console.ReadLine();
                        shift = Convert.ToInt32(Console.ReadLine());
                        Options.Decrypt(text, shift);
                        break;
                    case ("exit"):
                        Options.Bye();
                        break;
                    default:
                        Console.WriteLine("Please select an option");
                        goto Select;
                }  
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
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