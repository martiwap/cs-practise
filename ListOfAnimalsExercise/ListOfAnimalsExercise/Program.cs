using System;
using System.Collections.Generic;

namespace ListOfAnimalsExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Roger";
            Animals duck = new Animals();
            duck.Name = "Patty";
            Animals pig = new Animals();
            pig.Name = "Dylan";

            List<Animals> zoo = new List<Animals>();
            zoo.Add(dog);
            zoo.Add(duck);
            zoo.Add(pig);

            foreach (Animals item in zoo)
            {
                item.SayHi();
            }
        }
    }

    class Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hi! " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is eating");
        }
    }
}
