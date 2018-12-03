using System;

namespace CarsExercise
{
    class Mercedes : Car
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            base.Price = 12000;
            base.color = "Blue";
            base.maxSpeed = 200;

        }
    }
}
