using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    public class TrojanInvasion
    {
        public class Unit
        {
            public Unit(int value)
            {
                this.Value = value;
            }

            public int Value { get; set; }

            public override string ToString()
            {
                return this.Value.ToString();
            }
        }

        public static void Main()
        {
            int waves = int.Parse(Console.ReadLine());
            Queue<Unit> plates = new Queue<Unit>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => new Unit(int.Parse(x)))
                .ToArray());

            Stack<Unit> warriors = null;
            for (int i = 1; i <= waves; i++)
            {
                warriors = new Stack<Unit>(Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new Unit(int.Parse(x)))
                    .ToArray());

                if (i % 3 == 0)
                {
                    plates.Enqueue(new Unit(int.Parse(Console.ReadLine())));
                }

                // process the attack
                while (warriors.Count > 0 && plates.Count > 0)
                {
                    var currentWarrior = warriors.Peek();
                    var currentPlate = plates.Peek();
                    if (currentWarrior.Value > currentPlate.Value)
                    {
                        plates.Dequeue();
                        currentWarrior.Value -= currentPlate.Value;
                        if (currentWarrior.Value <= 0)
                        {
                            warriors.Pop();
                        }
                    }
                    else if (currentPlate.Value > currentWarrior.Value)
                    {
                        warriors.Pop();
                        currentPlate.Value -= currentWarrior.Value;
                    }
                    else
                    {
                        warriors.Pop();
                        plates.Dequeue();
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (plates.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}