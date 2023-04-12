using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Collection
{
    public class AddressBook
    {
        private List<Person> people;

        public AddressBook()
        {
            people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            if (people.Contains(person))
            {
                Console.WriteLine($"Person with name {person.Name} already exists in the address book.");
            }
            else
            {
                people.Add(person);
            }
        }

        public List<Person> SearchByName(string name)
        {
            return people.Where(person => person.Name == name).ToList();
        }

    }
}
