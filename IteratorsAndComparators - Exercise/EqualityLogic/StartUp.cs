using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> personsSorted = new SortedSet<Person>();
            HashSet<Person> personsUnique = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);
                Person person = new Person(personName, personAge);
                personsSorted.Add(person);
                personsUnique.Add(person);
            }

            Console.WriteLine(personsSorted.Count);
            Console.WriteLine(personsUnique.Count);
        }
    }
}
