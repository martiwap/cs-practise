using System;

namespace Abstraction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Lines line = new Lines();
            line.SayHi();
            line.Draw();
        }
    }

    abstract class Shapes
    {
        abstract public void Draw();

        public void SayHi()
        {
            Console.WriteLine("Hi from the abstract class");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Hi I am a Line");
        }
    }
}
