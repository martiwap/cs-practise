using System;

public class Person
{
	public Person(string firstName, string lastName, DateTime dateOfBirth)
	{
		FirstName = firstName;
		LastName = lastName;
		DateOfBirth = dateOfBirth;
	}
	
	public string FirstName 
  { 
    get; 
    set; 
  }
	
	public string LastName 
  { 
    get; 
    set; 
  }
	
	public DateTime DateOfBirth 
  { 
    get;  
    set; 
  }
	
	public string GetFullName()
	{
		return FirstName + " " + LastName;
	}
	
	public int GetAge()
	{
		return DateTime.Now.Year - DateOfBirth.Year;
	}
}
