using System;

namespace AddressBook {
  public class Person {
    private static int LastIDAssigned = 1000;
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int ID {get; set;}
    public Person(string firstName, string lastName) {
      FirstName = firstName;
      LastName = lastName;
      ID = SetID();
    }
    public string GetFullName() {
      return FirstName + " " + LastName;
    }
    public override string ToString() {
      return String.Format("**********************************************************\n" +
                           "{0, -10} {1, -15} {2, -15} {3, -20}\n" +
                           "**********************************************************\n" + 
                           "{4, -10} {5, -15} {6, -15} {7, -20}\n", "ID", "FIRSTNAME", "LASTNAME", "FULLNAME", 
                           ID, FirstName, LastName, GetFullName());
    }
    public void PrintInfo() {
      Console.WriteLine(this);
    }
    private static int SetID() {
      return ++LastIDAssigned;
    }
  }
}