using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipConnections
{
    class Utility
    {
        public PersonNode[] nodes { get; set; }

        public Utility()
        {

        }

        public void Init(Person[] persons)
        {
            nodes = new PersonNode[persons.Length];

            for (int i = 0; i < persons.Length; i++)
            {
                nodes[i] = new PersonNode(persons[i]);
            }
        }

        public int FindMinRelationLevel(Person personA, Person personB)
        {
            return BFS(nodes, personA, personB);
        }

        public int BFS(PersonNode[] nodes, Person personA, Person personB)
        {
            Queue<PersonNode> queue = new Queue<PersonNode>();
            if (personA.ArePeopleRelated(personB))
            {
                return 1;
            }

            int personAIndex = FindIndexOfFirstMatchingPerson(nodes, personA);

            if (personAIndex == -1)
            {
                return -1;
            }

            nodes[personAIndex].SearchLevel = 0;
            queue.Enqueue(nodes[personAIndex]);
            PersonNode currentNode;

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();

                for (int i = 0; i < nodes.Length; i++)
                {
                    if (!nodes[i].IsChecked() && nodes[i].Person.ArePeopleRelated(currentNode.Person))
                    {
                        if (nodes[i].Person.ArePeopleEqual(personB))
                        {
                            return (currentNode.SearchLevel + 1);
                        }

                        nodes[i].SearchLevel = currentNode.SearchLevel + 1;
                        queue.Enqueue(nodes[i]);
                    }
                }
            }

            return -1;
        }

        public int FindIndexOfFirstMatchingPerson(PersonNode[] nodes, Person person)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Person.ArePeopleEqual(person))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
