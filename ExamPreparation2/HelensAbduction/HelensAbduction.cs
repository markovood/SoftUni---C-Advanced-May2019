using System;

namespace HelensAbduction
{
    public class HelensAbduction
    {
        private static char[][] field;

        public static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                field[i] = Console.ReadLine()
                    .ToCharArray();
            }

            int[] parisLocation = GetLocation('P');

            while (true)
            {
                if (energy <= 0)
                {
                    break;
                }

                string[] commandTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // First, Spartan spawns on the given indexes.
                int spartanRowPos = int.Parse(commandTokens[1]);
                int spartanColPos = int.Parse(commandTokens[2]);
                field[spartanRowPos][spartanColPos] = 'S';
                
                // Paris moves in a direction, which decreases his energy by 1.
                field[parisLocation[0]][parisLocation[1]] = '-';
                switch (commandTokens[0])
                {
                    case "up": parisLocation[0]--;
                        break;
                    case "down": parisLocation[0]++;
                        break;
                    case "left": parisLocation[1]--;
                        break;
                    case "right": parisLocation[1]++;
                        break;
                }

                energy--;
                // If is outside of the field, he doesn’t move but still has his energy decreased.
                Validate(parisLocation);
                
                if (field[parisLocation[0]][parisLocation[1]] == 'S')
                {
                    energy -= 2;
                    if (energy <= 0)
                    {
                        //field[parisLocation[0]][parisLocation[1]] = 'X';
                        break;
                    }
                    else
                    {
                        field[parisLocation[0]][parisLocation[1]] = 'P';
                    }
                }
                else if (field[parisLocation[0]][parisLocation[1]] == 'H')
                {
                    field[parisLocation[0]][parisLocation[1]] = '-';
                    break;
                }
                else
                {
                    field[parisLocation[0]][parisLocation[1]] = 'P';
                }

            }

            if (energy <= 0)
            {
                field[parisLocation[0]][parisLocation[1]] = 'X';
                Console.WriteLine($"Paris died at {parisLocation[0]};{parisLocation[1]}.");
            }
            else
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }

            Print(field);
        }

        private static void Validate(int[] parisLocation)
        {
            if (parisLocation[0] < 0)
            {
                parisLocation[0] = 0;
            }
            else if (parisLocation[0] >= field.Length)
            {
                parisLocation[0] = field.Length - 1;
            }

            if (parisLocation[1] < 0)
            {
                parisLocation[1] = 0;
            }
            else if (parisLocation[1] >= field[0].Length)
            {
                parisLocation[1] = field[0].Length - 1;
            }
        }

        private static int[] GetLocation(char charToLocate)
        {
            for (int i = 0; i < field.Length; i++)
            {
                int colIndex = Array.IndexOf(field[i], charToLocate);
                if (colIndex >= 0)
                {
                    return new int[] { i, colIndex };
                }
            }

            throw new ApplicationException("charToLocate does not exist");
        }

        private static void Print(char[][] field)
        {
            foreach (var row in field)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}