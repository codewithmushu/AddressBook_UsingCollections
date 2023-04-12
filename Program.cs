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
            var addressBook = new AddressBook();

            // Add people to the address book
            var person1 = new Person { Name = "John", PhoneNumber = "123-456-7890", Email = "john@example.com" };
            addressBook.AddPerson(person1);

            var person2 = new Person { Name = "Jane", PhoneNumber = "555-555-1212", Email = "jane@example.com" };
            addressBook.AddPerson(person2);

            var person3 = new Person { Name = "John", PhoneNumber = "987-654-3210", Email = "john@example.com" };
            addressBook.AddPerson(person3); // This will not be added since a person with the same name already exists

            // Search for people by name
            var searchResults = addressBook.SearchByName("John");
            Console.WriteLine($"Found {searchResults.Count} people with the name 'John':");
            foreach (var person in searchResults)
            {
                Console.WriteLine($"Name: {person.Name}, Phone: {person.PhoneNumber}, Email: {person.Email}");
            }

            Console.ReadLine();
        }
    }
}
