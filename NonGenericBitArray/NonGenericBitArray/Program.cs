using System;
using System.Collections;

namespace NonGenericBitArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //creating
            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;


            BitArray bit = new BitArray(4); //need to specify the size
            BitArray anotherBit = new BitArray(boolArray);

            //setting value
            bit.Set(0, true);
            bit.Set(1, false);
            bit.Set(2, true);
            bit.Set(3, true);
            foreach (var item in bit)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");

            // and or not
            Console.WriteLine("Comparing both array on And, they must be the same length");
            BitArray result = new BitArray(4);

            result = bit.And(anotherBit);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Or this time");
            BitArray resultOr = new BitArray(4);
            resultOr = bit.Or(anotherBit);
            foreach (var item in resultOr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Now only Not on the first array");
            bit.Not();
            foreach (var item in bit)
            {
                Console.WriteLine(item);
            }
        }
    }
}
