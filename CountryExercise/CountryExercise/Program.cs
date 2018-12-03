using System;

namespace WorldNamespace
{
    abstract class World
    {
        private string planetName;
        private Continents continents;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        public Continents Continents
        {
            get { return continents; }
            set { continents = value; }
        }
    }

    class Country : World
    {
        private string countryName;
        private string capital;
        private CountryLanguages countryLanguages;
        private Currencies currencies;

        public Country()
        {
            countryName = "Unknown";
            capital = "Unknown";
        }

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public CountryLanguages CountryLanguage
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }

        public Currencies Currency
        {
            get { return currencies; }
            set { currencies = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Welcome there..");      
        }

        public void SayHi(string country)
        {
            Console.WriteLine($"Welcome to {country}!");
        }
    }

    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }

    enum Continents
    {
        Asia,
        Africa,
        Antarctica,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica
    }

    enum Currencies
    {
        USD,
        EUR,
        JPY,
        GBP,
        AUD,
        CAD,
        CHF,

        CNY,
        SEK,
        NZD,
        MXN,
        SGD,
        HKD,
        NOK,
        KRW,
        TRY,
        RUB,
        INR,
        EGP,
        BRL,
        ZAR,
        AED,
        TND,
        SAR,
        RON,
        PLN
    }

    enum Languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
}