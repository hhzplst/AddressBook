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
    private static int SetID() {
      return ++LastIDAssigned;
    }
  }
}