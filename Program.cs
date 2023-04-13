using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            // Adding sample data
            addressBook.AddPerson(new Person { FirstName = "John", LastName = "Doe", Address = "123 Main St", City = "Chicago", State = "IL", PhoneNumber = "555-1234", Email = "johndoe@example.com" });
            addressBook.AddPerson(new Person { FirstName = "Jane", LastName = "Smith", Address = "456 State St", City = "Chicago", State = "IL", PhoneNumber = "555-5678", Email = "janesmith@example.com" });
            addressBook.AddPerson(new Person { FirstName = "Bob", LastName = "Johnson", Address = "789 Elm St", City = "New York", State = "NY", PhoneNumber = "555-6789", Email = "bobjohnson@example.com" });
            addressBook.AddPerson(new Person { FirstName = "Alice", LastName = "Lee", Address = "321 Oak St", City = "New York", State = "NY", PhoneNumber = "555-7890", Email = "alicelee@example.com" });
            }
    }
}
