using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Collection
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Person person && Name == person.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
