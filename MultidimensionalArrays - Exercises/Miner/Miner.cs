using System;
using System.Linq;

namespace Miner
{
    public class Miner
    {
        private static char[][] mine;

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] moveCommands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            mine = new char[size][];
            for (int i = 0; i < mine.Length; i++)
            {
                mine[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }

            int[] position = GetInitialPosition();
            int coalsCount = CountCoals();
            int collectedCoals = 0;
            for (int move = 0; move < moveCommands.Length; move++)
            {
                switch (moveCommands[move])
                {
                    case "up":
                        if (IsValid(position[0] - 1, position[1]))
                        {
                            position[0]--;
                            if (mine[position[0]][position[1]] == 'c')
                            {
                                collectedCoals++;
                                mine[position[0]][position[1]] = '*';
                                if (collectedCoals == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({position[0]}, {position[1]})");
                                    return;
                                }
                            }
                            else if (mine[position[0]][position[1]] == 'e')
                            {
                                Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                                return;
                            }
                        }

                        break;
                    case "down":
                        if (IsValid(position[0] + 1, position[1]))
                        {
                            position[0]++;
                            if (mine[position[0]][position[1]] == 'c')
                            {
                                collectedCoals++;
                                mine[position[0]][position[1]] = '*';
                                if (collectedCoals == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({position[0]}, {position[1]})");
                                    return;
                                }
                            }
                            else if (mine[position[0]][position[1]] == 'e')
                            {
                                Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                                return;
                            }
                        }

                        break;
                    case "left":
                        if (IsValid(position[0], position[1] - 1))
                        {
                            position[1]--;
                            if (mine[position[0]][position[1]] == 'c')
                            {
                                collectedCoals++;
                                mine[position[0]][position[1]] = '*';
                                if (collectedCoals == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({position[0]}, {position[1]})");
                                    return;
                                }
                            }
                            else if (mine[position[0]][position[1]] == 'e')
                            {
                                Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                                return;
                            }
                        }

                        break;
                    case "right":
                        if (IsValid(position[0], position[1] + 1))
                        {
                            position[1]++;
                            if (mine[position[0]][position[1]] == 'c')
                            {
                                collectedCoals++;
                                mine[position[0]][position[1]] = '*';
                                if (collectedCoals == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({position[0]}, {position[1]})");
                                    return;
                                }
                            }
                            else if (mine[position[0]][position[1]] == 'e')
                            {
                                Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                                return;
                            }
                        }

                        break;
                }
            }

            int remainingCoals = coalsCount - collectedCoals;
            Console.WriteLine($"{remainingCoals} coals left. ({position[0]}, {position[1]})");
        }

        private static bool IsValid(int row, int col)
        {
            if ((row >= 0 && row < mine.Length) &&
                (col >= 0 && col < mine[row].Length))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int[] GetInitialPosition()
        {
            for (int row = 0; row < mine.Length; row++)
            {
                for (int col = 0; col < mine[row].Length; col++)
                {
                    if (mine[row][col] == 's')
                    {
                        return new int[] { row, col };
                    }
                }
            }

            throw new ApplicationException("No start position found!");
        }

        private static int CountCoals()
        {
            int count = 0;
            foreach (var row in mine)
            {
                count += row.Count(c => c == 'c');
            }

            return count;
        }
    }
}
