using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook {
  public class AddressBook : List<Person> {

    public void AddPerson(Person p) {
      if (this.Contains(p))
        Console.WriteLine("This Person object already exists!");
      else
        this.Add(p);
    }
    public void RemoveById(int id) {
      Person foundPerson = this.SingleOrDefault(x => x.ID == id);
      if (foundPerson == null)
        Console.WriteLine("No such ID exists!");
      else
        this.Remove(foundPerson);
    }
    public void RemoveByFirstName(string firstName) {
      try {
        this.RemoveAll(x => x.FirstName == firstName);
      } catch (ArgumentNullException) {
        Console.WriteLine("No record found with first name {0}", firstName);
      }
      
    }
    public void RemoveByLastName(string lastName) {
      try {
        this.RemoveAll(x => x.LastName == lastName);
      } catch (ArgumentNullException){
        Console.WriteLine("No record found with last name {0}", lastName);
      }
      
    }
  }
}