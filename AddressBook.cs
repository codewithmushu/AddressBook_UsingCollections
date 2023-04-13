using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Collection
{
    public class AddressBook
    {
        private HashSet<Person> people = new HashSet<Person>();
        private Dictionary<string, List<Person>> cityDictionary = new Dictionary<string, List<Person>>();
        private Dictionary<string, List<Person>> stateDictionary = new Dictionary<string, List<Person>>();

        public void AddPerson(Person person)
        {
            if (people.Contains(person))
            {
                Console.WriteLine("This person already exists in the address book.");
                return;
            }

            people.Add(person);

            if (!cityDictionary.ContainsKey(person.City))
            {
                cityDictionary[person.City] = new List<Person>();
            }
            cityDictionary[person.City].Add(person);

            if (!stateDictionary.ContainsKey(person.State))
            {
                stateDictionary[person.State] = new List<Person>();
            }
            stateDictionary[person.State].Add(person);
        }

        public List<Person> ViewPeopleByCity(string city)
        {
            if (cityDictionary.ContainsKey(city))
            {
                return cityDictionary[city];
            }
            else
            {
                Console.WriteLine($"No people found in {city}");
                return new List<Person>();
            }
        }

        public List<Person> ViewPeopleByState(string state)
        {
            if (stateDictionary.ContainsKey(state))
            {
                return stateDictionary[state];
            }
            else
            {
                Console.WriteLine($"No people found in {state}");
                return new List<Person>();
            }
        }
    }
}
