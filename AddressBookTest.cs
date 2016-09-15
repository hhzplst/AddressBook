using System;

namespace AddressBook {
    public class AddressBookTest {
        public static void Main(string[] args) {
            AddressBook testAddressBook = new AddressBook();

            Person p1 = new Person("Ivy", "Chang");
            Person p2 = new Person("Elham", "Chang");
            Person p3 = new Person("Ivy", "Chen");
            Person p4 = new Person("Austen", "Roberts");
            Person p5 = new Person("Will", "Roberts");
            Person p6 = new Person("Mary", "Wang");

            Console.WriteLine("Adding p1 to the list...\n");
            testAddressBook.AddPerson(p1);
            //no duplicated objects allowed in the list 
            Console.WriteLine("Tring to add p1 to the list again...");
            testAddressBook.AddPerson(p1);
            Console.WriteLine("Adding p2 - p6 to the list...");
            testAddressBook.AddPerson(p2);
            testAddressBook.AddPerson(p3);
            testAddressBook.AddPerson(p4);
            testAddressBook.AddPerson(p5);
            testAddressBook.AddPerson(p6);

            AddressBook.PrintListInfo(testAddressBook);

            Console.WriteLine("Removing ID 1002...");
            testAddressBook.RemoveById(1002);
            AddressBook.PrintListInfo(testAddressBook);

            //ignore when ID doesn't exist
            Console.WriteLine("Trying to remove ID 1010...");
            testAddressBook.RemoveById(1010);

            //ignore when first or last name doesn't exist
            Console.WriteLine("Trying to remove first name Elie...");
            testAddressBook.RemoveByFirstName("Elie");

            Console.WriteLine("Removing first name Ivy...");
            testAddressBook.RemoveByFirstName("Ivy");
            AddressBook.PrintListInfo(testAddressBook);

            //ignore when ID doesn't exist
            Console.WriteLine("Trying to search ID 1001...");
            testAddressBook.SearchByID(1001);

            //ignore when first or last name doesn't exist
            Console.WriteLine("Trying to search last name O'Malley...");
            testAddressBook.SearchByLastName("O'Malley");

            Console.WriteLine("Looking for people with last name Roberts...");
            testAddressBook.SearchByLastName("Roberts");
        }       
    }   
}

/**********************************OUTPUT************************************

➜  AddressBook git:(master) ✗ dotnet run
Project AddressBook (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling AddressBook for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.3092782
 

Adding p1 to the list...

Tring to add p1 to the list again...
This Person object already exists!

Adding p2 - p6 to the list...
**********************************************************
ID         FIRSTNAME       LASTNAME        FULLNAME            
**********************************************************

1001       Ivy             Chang           Ivy Chang           

1002       Elham           Chang           Elham Chang         

1003       Ivy             Chen            Ivy Chen            

1004       Austen          Roberts         Austen Roberts      

1005       Will            Roberts         Will Roberts        

1006       Mary            Wang            Mary Wang           

Removing ID 1002...
Successfully removed 1 records with ID 1002

**********************************************************
ID         FIRSTNAME       LASTNAME        FULLNAME            
**********************************************************

1001       Ivy             Chang           Ivy Chang           

1003       Ivy             Chen            Ivy Chen            

1004       Austen          Roberts         Austen Roberts      

1005       Will            Roberts         Will Roberts        

1006       Mary            Wang            Mary Wang           

Trying to remove ID 1010...
No such ID exists!

Trying to remove first name Elie...
No record found with first name Elie!

Removing first name Ivy...
Successfully removed 2 records with first name Ivy

**********************************************************
ID         FIRSTNAME       LASTNAME        FULLNAME            
**********************************************************

1004       Austen          Roberts         Austen Roberts      

1005       Will            Roberts         Will Roberts        

1006       Mary            Wang            Mary Wang           

Trying to search ID 1001...
No such ID exists!

Trying to search last name O'Malley...
No record found with last name O'Malley!

Looking for people with last name Roberts...
Successfully retrieved 2 records:

**********************************************************
ID         FIRSTNAME       LASTNAME        FULLNAME            
**********************************************************

1004       Austen          Roberts         Austen Roberts      

1005       Will            Roberts         Will Roberts        


*********************************END OUTPUT*********************************/