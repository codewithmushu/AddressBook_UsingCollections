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

            addressBook.AddPerson(new Person { FirstName = "John", LastName = "Doe", Address = "123 Main St", City = "Anytown", State = "CA", Zip = "12345" });
            addressBook.AddPerson(new Person { FirstName = "Jane", LastName = "Doe", Address = "456 Elm St", City = "Othertown", State = "NY", Zip = "67890" });
            addressBook.AddPerson(new Person { FirstName = "Bob", LastName = "Smith", Address = "789 Oak St", City = "Anytown", State = "CA", Zip = "12345" });
            addressBook.AddPerson(new Person { FirstName = "Mary", LastName = "Smith", Address = "321 Pine St", City = "Another town", State = "NY", Zip = "67890" });

            Console.WriteLine("People in Anytown:");
            foreach (Person person in addressBook.ViewPeopleByCity("Anytown"))
            {
                Console.WriteLine($"{person.Name}, Address: {person.Address}, City: {person.City}, State: {person.State}, Zip: {person.Zip}");  
            }
        }
    }
}
