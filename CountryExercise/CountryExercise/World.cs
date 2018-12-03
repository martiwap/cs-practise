using System;
using WorldNamespace;

namespace CountryExercise
{
    class ProgramTwo
    {
        static void Main(string[] args)
        {
            Country countryOne = new Country();
            Country countryTwo = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Languages.Italian.ToString();
            countryLanguages.SecondLanguage = Languages.English.ToString();

            countryOne.CountryLanguage = countryLanguages;
            countryOne.PlanetName = "Earth";
            countryOne.CountryName = "Italy";
            countryOne.Currency = Currencies.EUR;
            countryOne.Continents = Continents.Europe;

            countryOne.SayHi();
            countryOne.SayHi(countryOne.CountryName);

            Console.WriteLine($"Planet {countryOne.PlanetName} \nCountry is {countryOne.CountryName}");
            Console.WriteLine($"The languages spoken are {countryOne.CountryLanguage.FirstLanguage} and {countryOne.CountryLanguage.SecondLanguage}, \nand the currency is {countryOne.Currency}");
        }
    }
}