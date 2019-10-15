using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person :IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public int CompareTo(Person other)
        {
            int equality = this.Name.CompareTo(other.Name);
            if (equality == 0)
            {
                equality = this.Age.CompareTo(other.Age);
                if (equality == 0)
                {
                    equality = this.Town.CompareTo(other.Town);
                    return equality;
                }
                else
                {
                    return equality;
                }
            }
            else
            {
                return equality;
            }
        }
    }
}
