using System;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 3;
            double div = 0;

            try
            {
                div = y / x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is: " + e.Message);
            }
            finally
            {
                Console.WriteLine("result is : " + div);
            }


            // exeption exercise
            int numOne = 0;
            int numTwo = 0;
            double result;

            start:

            Console.Write("Enter the first number: ");
            numOne = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            numTwo = int.Parse(Console.ReadLine());

            try 
            {
                result = (double)numOne / (double)numTwo;
                Console.WriteLine("Result = " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Exited.");
                goto start;
            }

            // or to be specific
            /*
            catch (DivideByZeroException)
            {
                Console.WriteLine("You have tried to divide by zero")    
            }
            catch (FormatException e)
            {
                Console.WriteLne("What you have entered is not valid");
            }

            */

        }
    }

}
