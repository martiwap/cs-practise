using System;

namespace CarsExercise
{
    class Car
    {
        private decimal price;
        protected int maxSpeed;
        public string color;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual void DisplayInfo()
        {
            price = 1000;
            maxSpeed = 300;
            color = "Black";

            //Console.WriteLine($"This car can get upto {maxSpeed} it comes in {color} and costs {price}");
        }
    }
}
