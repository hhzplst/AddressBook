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
    public Person SearchByID(int id) {
      return this.SingleOrDefault(x => x.ID == id);
    }
    public void SearchByFirstName(string firstName) {
      try {
        List<Person> foundList = this.FindAll(x => x.FirstName == firstName);
        Console.WriteLine(foundList.ToString());
      } catch (ArgumentNullException) {
        Console.WriteLine("No record found with first name {0}", firstName);
      }
    }
     public void SearchByLastName(string lastName) {
      try {
        List<Person> foundList = this.FindAll(x => x.LastName == lastName);
        Console.WriteLine(foundList.ToString());
      } catch (ArgumentNullException) {
        Console.WriteLine("No record found with last name {0}", lastName);
      }
    }
    public void RemoveById(int id) {
      Person foundPerson = SearchByID(id);
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

    public static void PrintInfo(List<Person> personList) {
      Console.WriteLine(String.Format("**********************************************************\n" +
                                      "{0, -10} {1, -15} {2, -15} {3, -20}\n" +
                                      "**********************************************************\n",  
                                      "ID", "FIRSTNAME", "LASTNAME", "FULLNAME")); 
  
      personList.ForEach(x => Console.WriteLine("{0, -10} {1, -15} {2, -15} {3, -20}\n",
                                                x.ID, x.FirstName, x.LastName, x.GetFullName()));
    }
  }
} 