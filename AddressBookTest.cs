using System;

namespace AddressBook {
    public class AddressBookTest {
        public static void Main(string[] args) {
            AddressBook testAddressBook = new AddressBook();

            Person newPerson = new Person("Ivy", "Chang");

            testAddressBook.AddPerson(newPerson);
            testAddressBook.AddPerson(new Person("Elham", "Farhodi"));
            testAddressBook.AddPerson(new Person("Austen", "Roberts"));
            testAddressBook.AddPerson(newPerson);

            AddressBook.PrintListInfo(testAddressBook);

            // testAddressBook.SearchByLastName("Chang");
        }
        
    }   
}