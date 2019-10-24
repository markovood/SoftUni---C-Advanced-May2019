namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; private set; }

        public Stat Stat { get; private set; }

        public Weapon Weapon { get; private set; }

        public int GetTotalPower()
        {
            // return the sum of the stat properties plus the sum of the weapon properties
            return this.GetWeaponPower() + this.GetStatPower();
        }

        public int GetWeaponPower()
        {
            // return the sum of the weapon properties
            return this.Weapon.Sharpness + 
                this.Weapon.Size + 
                this.Weapon.Solidity;
        }

        public int GetStatPower()
        {
            // return the sum of the stat properties
            return this.Stat.Agility + 
                this.Stat.Flexibility + 
                this.Stat.Intelligence + 
                this.Stat.Skills + 
                this.Stat.Strength;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.GetTotalPower()}]" +
                $"  Weapon Power: [{this.GetWeaponPower()}]" +
                $"  Stat Power: [{this.GetStatPower()}]";
        }
    }
}
