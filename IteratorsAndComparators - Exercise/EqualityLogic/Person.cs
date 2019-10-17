using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>, IEquatable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int CompareTo(Person other)
        {
            int equality = this.Name.CompareTo(other.Name);
            if (equality == 0)
            {
                equality = this.Age.CompareTo(other.Age);
                return equality;
            }
            else
            {
                return equality;
            }
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   Name == other.Name &&
                   Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
}
