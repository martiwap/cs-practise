using System;

namespace TypeConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            int serialNo = 100;
            string accountNo = "";
            float anyNo = 3.5f;

            accountNo = serialNo.ToString();

            Console.WriteLine(accountNo);

            //serialNo = Convert.ToInt32(anyNo); //serialNo = 4
            serialNo = (int)anyNo; //serialNo = 3

            Console.WriteLine(serialNo);

        }
    }
}
