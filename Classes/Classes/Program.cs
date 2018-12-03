using System;

namespace Classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person cloneOne = new Person();
            cloneOne.FirstName = "Adrian";
            cloneOne.LastName = "Ipster";
            cloneOne.Country = "NoWhere";

            Person cloneTwo = new Person();
            cloneTwo.FirstName = "Patricia";
            cloneTwo.LastName = "Lorry";
            cloneTwo.Country = "Brazil";

            Person cloneThree = new Person();
            cloneThree.FirstName = "Dany";

            Console.WriteLine(cloneOne.FirstName);
            Console.WriteLine(cloneTwo.FirstName);
            Console.WriteLine(cloneThree.FirstName);

            DisplayMessage();
            cloneTwo.DisplayMessage();
        }

        static void DisplayMessage()
        {
            Console.WriteLine("hi from a static method!");
        }
    }

    class Person
    {
        string firstName; // better not to put public
        string lastName;  // cause we don't want these properties to be available
        DateTime birthDate; //from the outer world
        string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Country { get; set; } //same

        //construct
        public Person()
        {
            firstName = "Unknown";
        }

        public void DisplayMessage()
        {
            Console.WriteLine("hi from a non static method in person class!");
        }
    }
}
