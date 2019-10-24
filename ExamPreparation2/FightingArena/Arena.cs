using System;
using System.Collections.Generic;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.gladiators = new List<Gladiator>();
            this.Name = name;
        }

        public string Name { get; private set; }

        public int Count => this.gladiators.Count;

        public void Add(Gladiator gladiator)
        {
            if (gladiator == null)
            {
                throw new ArgumentNullException("gladiator");
            }

            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            this.gladiators.RemoveAll(g => g.Name == name);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            var orderedByStat = this.gladiators.OrderByDescending(g => g.GetStatPower());
            return orderedByStat.First();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            var orderedByWeapon = this.gladiators.OrderByDescending(g => g.GetWeaponPower());
            return orderedByWeapon.First();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            var orderedByTotalPower = this.gladiators.OrderByDescending(g => g.GetTotalPower());
            return orderedByTotalPower.First();
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}
