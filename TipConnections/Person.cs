using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipConnections
{
    class Person
    {
        public Name FullName { get; set; }
        public Address Address { get; set; }

        public Person(Name fullname, Address address)
        {
            this.FullName = fullname;
            this.Address = address;
        }

        public bool ArePeopleRelated(Person secondPerson)
        {
            return (this.FullName.AreNamesEqual(secondPerson.FullName) || this.Address.AreAddressesEqual(secondPerson.Address));
        }

        public bool ArePeopleEqual(Person secondPerson)
        {
            return (this.FullName.AreNamesEqual(secondPerson.FullName) && this.Address.AreAddressesEqual(secondPerson.Address));
        }
    }
}
