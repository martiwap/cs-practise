using System;

namespace DataTypesInDepth
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 0;

            x = int.MaxValue; //2147483647
            Console.WriteLine(x);

            uint y = 2147483648; // int wouldn't contain it, unit would instead
            Console.WriteLine(y);

            uint min = uint.MinValue; //0
            Console.WriteLine(min);

            Console.WriteLine(typeof(int).IsPrimitive); //true
            Console.WriteLine(typeof(decimal).IsPrimitive); //false 

            Console.WriteLine("Let's see the difference between float, double and decimal.");
            float f_num = 0.0f;
            double d_num = 0.0d;
            decimal m_num = 0.0m;

            Console.WriteLine("float : " + f_num + ", double : " + d_num + ", decimal : " + m_num);

            f_num = 1 / 3f;
            d_num = 1 / 3d;
            m_num = 1 / 3m;

            Console.WriteLine("It is always the same value, to all three: ");
            Console.WriteLine("float : " + f_num + ", double : " + d_num + ", decimal : " + m_num);
        }
    }
}
