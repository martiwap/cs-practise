using System;

namespace Assignment8
{
    class GermanShepard : Animal, DogInterface
    {
        private Gender gender;
        private double weight;
        private bool securityGuard;
        private TrainingAbility training;
        private Sizes size;

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public bool SecurityGuard
        {
            get { return securityGuard; }
            set { securityGuard = value; }
        }

        public TrainingAbility Training
        {
            get { return training; }
            set { training = value; }
        }

        public Sizes Size
        {
            get { return size; }
            set { size = value; }
        }

        public void Eat()
        {
            Console.WriteLine("The dog is eating");   
        }

        public void Eat(string dogName)
        {
            Console.WriteLine($"{dogName} is eating");
        }

        public void Drink()
        {
            Console.WriteLine("The dog is drinking");
        }

        public void Drink(string dogName)
        {
            Console.WriteLine($"{dogName} is drinking");
        }

        public void Sit()
        {
            Console.WriteLine("The dog is sitting");
        }

        public void Sit(string dogName)
        {
            Console.WriteLine($"{dogName} is sitting");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
        public void Sleep(string dogName)
        {
            Console.WriteLine($"{dogName} is sleeping");
        }

        public void SayHi()
        {
            Console.WriteLine("Hiii \"in dogs language :D\"");
        }

        public void DisplayDogInformation()
        {
            Console.WriteLine($"The dog name is {Name} from {Origin}, " +
                $"was born on {BirthDate.ToShortDateString()} " +
                $"{Name} is a {gender} and weights {weight} kilos and its size is {Size} ");
        }
    }
}
