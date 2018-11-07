using System;

public class MainClass
{
    public static void Main()
    {
        //Create vehicles here from Vehicle class
        Vehicle car = new Vehicle("car", 4, 2000, true);
        Vehicle oldCar = new Vehicle("car", 4, 1980, false);
        Vehicle bike = new Vehicle("bike", 2, 2017, true);
        
        // Test code
        Console.WriteLine(car.Type);
        Console.WriteLine(oldCar.Runs);
        Console.WriteLine(bike.NumTires);
    }
}

