using System;

public class Vehicle
{
    public string Type;
    public int NumTires;
    public int Year;
    public bool Runs;

    public Vehicle(string type, int numTires, int year, bool runs)
    {
        Type = type;
        NumTires = numTires;
        Year = year;
        Runs = runs;
    }
}