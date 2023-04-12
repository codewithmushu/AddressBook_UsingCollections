using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Collection
{
    class CityStateAddressBook
    {
        public Dictionary<string, List<Person>> _addressBook = new Dictionary<string, List<Person>>();

        public void AddPerson(Person person, string city, string state)
        {
            if (_addressBook.ContainsKey(city + state))
            {
                var peopleInCityState = _addressBook[city + state];
                if (!peopleInCityState.Contains(person))
                {
                    peopleInCityState.Add(person);
                }
            }
            else
            {
                _addressBook[city + state] = new List<Person> { person };
            }
        }

        public List<Person> SearchByCity(string city)
        {
            return _addressBook.Values.SelectMany(p => p).Where(p => p.City == city).ToList();
        }

        public List<Person> SearchByState(string state)
        {
            return _addressBook.Values.SelectMany(p => p).Where(p => p.State == state).ToList();
        }




    }
}
