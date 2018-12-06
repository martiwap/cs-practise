using System;
using System.Collections;

namespace AnimalsAndTrainers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Max";

            Animals cat = new Animals();
            cat.Name = "Lucy";

            Animals elephant = new Animals();
            elephant.Name = "Dino";

            Trainers john = new Trainers();
            john.TrainerName = "Jonh Jordan";

            ArrayList list = new ArrayList();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);
            list.Add(john);

            foreach (var item in list)
            {
                if (item.GetType() != typeof(Animals) )
                {
                    ((Trainers)item).SayHi();
                }
                else {
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                }
            }

        }
    }

    struct Animals
    {
        private string name; //instance

        public string Name //property
        { 
            get { return name; } 
            set { name = value; } 
        }

        public void SayHi()
        {
            Console.WriteLine("Hello my name is " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is not eating");
        }
    }

    struct Trainers
    {
        private string trainerName;

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello I am the new trainer");
        }
    }
}
