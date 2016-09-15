using System;
using System.Collections.Generic;

namespace AddressBook {
  public class AddressBook : List<Person> {

    public void AddPerson(Person p) {
      if (this.Contains(p))
        Console.WriteLine("This Person object already exists!\n");
      else
        this.Add(p);
    }
    public void SearchByID (int id) {
      List<Person> recordList = this.FindAll(x => x.ID == id);
      if(recordList.Count == 0)
        Console.WriteLine("No such ID exists!\n");
      else {
        Console.WriteLine("Successfully retrieved {0} record:\n", recordList);
        PrintListInfo(recordList);
      }
    }
    public void SearchByFirstName(string firstName) {
      List<Person> recordList = this.FindAll(x => x.FirstName == firstName);
      if (recordList.Count == 0)
        Console.WriteLine("No record found with first name {0}!\n", firstName);
      else {
        Console.WriteLine("Successfully retrieved {0} records:\n", recordList.Count);
        PrintListInfo(recordList);
      }
    }
     public void SearchByLastName(string lastName) {
      List<Person> recordList = this.FindAll(x => x.LastName == lastName);
      if (recordList.Count == 0)
        Console.WriteLine("No record found with last name {0}!\n", lastName);
      else {
        Console.WriteLine("Successfully retrieved {0} records:\n", recordList.Count);
        PrintListInfo(recordList);
      }
    }
    public void RemoveById(int id) {
      int records = this.RemoveAll(x => x.ID == id);
      if (records == 0)
        Console.WriteLine("No such ID exists!\n");
      else
        Console.WriteLine("Successfully removed {0} records with ID {1}\n", records, id);
    }

    public void RemoveByFirstName(string firstName) {
      int records = this.RemoveAll(x => x.FirstName == firstName); 
      if(records == 0)
        Console.WriteLine("No record found with first name {0}!\n", firstName);
      else
        Console.WriteLine("Successfully removed {0} records with first name {1}\n", records, firstName);
    }
    public void RemoveByLastName(string lastName) {
      int records = this.RemoveAll(x => x.FirstName == lastName); 
      if(records == 0)
        Console.WriteLine("No record found with last name {0}!\n", lastName);
      else
        Console.WriteLine("Successfully removed {0} records with last name {1}\n", records, lastName);
    }

    public static void PrintListInfo(List<Person> personList) {
      Console.WriteLine(String.Format("**********************************************************\n" +
                                      "{0, -10} {1, -15} {2, -15} {3, -20}\n" +
                                      "**********************************************************\n",  
                                      "ID", "FIRSTNAME", "LASTNAME", "FULLNAME")); 
  
      personList.ForEach(x => Console.WriteLine("{0, -10} {1, -15} {2, -15} {3, -20}\n",
                                                x.ID, x.FirstName, x.LastName, x.GetFullName()));
    }
  }
} 