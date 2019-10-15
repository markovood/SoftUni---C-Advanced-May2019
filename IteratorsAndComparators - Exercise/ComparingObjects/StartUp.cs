using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            // "{name} {age} {town}"
            var persons = new List<Person>();
            while (true)
            {
                string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (personInfo[0] == "END")
                {
                    break;
                }

                var person = new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
                persons.Add(person);
            }

            int n = int.Parse(Console.ReadLine());
            var personToCompare = persons[n - 1];
            persons.RemoveAt(n - 1);

            int same = 1;
            int different = 0;
            foreach (var person in persons)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    same++;
                }
                else
                {
                    different++;
                }
            }

            if (same == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{same} {different} {persons.Count + 1}");
            }
        }
    }
}
