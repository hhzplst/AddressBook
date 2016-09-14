using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook {
  public class AddressBook : List<Person> {

    public void AddPerson(Person p) {
      base.Add(p);
    }
    public void RemoveById(int id) {
      Person foundPerson = this.SingleOrDefault(x => x.ID == id);
      if (foundPerson == null)
        Console.WriteLine("No such ID exists!");
      else
        base.Remove(foundPerson);
    }
    public void RemoveByFirstName(string firstName) {

    }
    
  }
}