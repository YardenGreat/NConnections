using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipConnections
{
    class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public bool AreNamesEqual(Name secondName)
        {
            return (this.FirstName.Equals(secondName.FirstName) && this.LastName.Equals(secondName.LastName));
        }
    }
}
