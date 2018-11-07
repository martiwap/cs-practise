using System;

//Write Vehicle class here

public class MainClass
{
    public static void Main()
    {
        //Create vehicles here
        Vehicle car = new Vehicle("car", 4, 2000, true);
        Vehicle oldCar = new Vehicle("car", 4, 1980, false);
        Vehicle bike = new Vehicle("bike", 2, 2017, true);
        
        // Test code
        Console.WriteLine(car.Type);
        Console.WriteLine(oldCar.Runs);
        Console.WriteLine(bike.NumTires);
    }
}

public class Vehicle
{
    public string Type;
    public int NumTires;
    public int Year;
    public bool Runs;

    //construct
    public Vehicle(string type, int numTires, int year, bool runs)
    {
        Type = type;
        NumTires = numTires;
        Year = year;
        Runs = runs;
    }
}