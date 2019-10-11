using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> where T : IComparable<T>
    {
        private T value;

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {this.Value}";
        }
    }
}
