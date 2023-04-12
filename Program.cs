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
            var cityStateAddressBook = new CityStateAddressBook();

            // Add people to the address book for New York City, New York
            var person1 = new Person { Name = "John", PhoneNumber = "123-456-7890", Email = "john@example.com", City = "New York City", State = "New York" };
            var person2 = new Person { Name = "Jane", PhoneNumber = "234-567-8901", Email = "jane@example.com", City = "New York City", State = "New York" };
            var person3 = new Person { Name = "Bob", PhoneNumber = "345-678-9012", Email = "bob@example.com", City = "New York City", State = "New York" };
            cityStateAddressBook.AddPerson(person1, person1.City, person1.State);
            cityStateAddressBook.AddPerson(person2, person2.City, person2.State);
            cityStateAddressBook.AddPerson(person3, person3.City, person3.State);



            // Add people to the address book for San Francisco, California
            var person4 = new Person { Name = "Samantha", PhoneNumber = "456-789-0123", Email = "samantha@example.com", City = "San Francisco", State = "California" };
            var person5 = new Person { Name = "Peter", PhoneNumber = "567-890-1234", Email = "peter@example.com", City = "San Francisco", State = "California" };
            cityStateAddressBook.AddPerson(person4, person4.City, person4.State);
            cityStateAddressBook.AddPerson(person5, person5.City, person5.State);


            // Search for people in New York City
            Console.WriteLine("People in New York City:");
            var peopleInNYC = cityStateAddressBook.SearchByCity("New York City");
            foreach (var person in peopleInNYC)
            {
                Console.WriteLine($"{person.Name} - {person.PhoneNumber} - {person.Email}");
            }
            Console.WriteLine();

            // Search for people in California
            Console.WriteLine("People in California:");
            var peopleInCalifornia = cityStateAddressBook.SearchByState("California");
            foreach (var person in peopleInCalifornia)
            {
                Console.WriteLine($"{person.Name} - {person.PhoneNumber} - {person.Email}");
            }
            Console.WriteLine();

            // Search for a person by name
            Console.WriteLine("Search for person with name Bob:");
            var bob = cityStateAddressBook.SearchByCity("New York City").Find(p => p.Name == "Bob");
            if (bob != null)
            {
                Console.WriteLine($"{bob.Name} - {bob.PhoneNumber} - {bob.Email}");
            }
            else
            {
                Console.WriteLine("Bob not found.");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    
}
