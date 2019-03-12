using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipConnections
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public Address(string street, string city)
        {
            this.Street = street;
            this.City = city;
        }

        public bool AreAddressesEqual(Address secondAddress)
        {
            return (this.City.Equals(secondAddress.City) && this.Street.Equals(secondAddress.Street));
        }
    }
}
