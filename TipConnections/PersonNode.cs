using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipConnections
{
    class PersonNode
    {
        public Person Person { get; set; }
        public int SearchLevel { get; set; }

        public PersonNode(Person person)
        {
            this.Person = person;
            this.SearchLevel = -1;
        }

        public bool IsChecked()
        {
            return (this.SearchLevel >= 0);
        }

    }
}
