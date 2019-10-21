using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private int id;

        private Dictionary<int, Person> data;

        public Repository()
        {
            id = 0;
            data = new Dictionary<int, Person>();
        }

        public int Count
        {
            get { return this.data.Count; }
        }

        public void Add(Person person)
        {
            // adds an entity to the Data
            if (person == null)
            {
                throw new ArgumentNullException("person", "Cannot add person with null value!");
            }

            this.data.Add(this.id, person);
            this.id++;
        }

        public Person Get(int id)
        {
            // returns the entity with given ID
            if (id < 0)
            {
                throw new InvalidOperationException("Cannot get an entity with a negative index!");
            }

            if (this.data.ContainsKey(id))
            {
                return this.data[id];
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", "Entity doesn't exist!");
            }
        }

        public bool Update(int id, Person newPerson)
        {
            if (newPerson != null)
            {
                if (id < 0 || !this.data.ContainsKey(id))
                {
                    return false;
                }
                
                this.data[id] = newPerson;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            // deletes an entity by given id. Return false if the id doesn't exist, otherwise return true.
            if (id < 0 || !this.data.ContainsKey(id))
            {
                return false;
            }

            this.data.Remove(id);
            return true;
        }
    }
}
