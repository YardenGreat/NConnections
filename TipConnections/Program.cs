using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipConnections
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            Person[] persons = {new Person(new Name("Arthur", "Collins"), new Address("Man", "NYC")),
                               new Person(new Name("Shilla", "Collins"), new Address("Man1", "NYC")),
                               new Person(new Name("Arthur", "Collins"), new Address("Man2", "NYC")),
                               new Person(new Name("Shilla", "Collins"), new Address("Man2", "NYC")),
                               new Person(new Name("Mark", "Collins"), new Address("Man3", "NYC"))};
            utility.Init(persons);
            
            int relation = utility.FindMinRelationLevel(persons[1], persons[4]);
            Console.WriteLine($"The two supplied people are {(relation == -1 ? "not" : relation.ToString())} related.");    
        }      
    }
}
