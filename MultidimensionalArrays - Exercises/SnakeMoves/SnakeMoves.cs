using System;
using System.Linq;

namespace SnakeMoves
{
    public class SnakeMoves
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            char[,] stairs = new char[dimensions[0], dimensions[1]];
            int snakeIndex = 0;
            for (int i = 0; i < stairs.GetLength(0); i++)
            {
                for (int j = 0; j < stairs.GetLength(1); j++)
                {
                    stairs[i, j] = snake[snakeIndex];
                    snakeIndex++;
                    if (snakeIndex >= snake.Length)
                    {
                        snakeIndex = 0;
                    }
                }
            }

            Print(stairs);
        }

        private static void Print(char[,] stairs)
        {
            for (int i = 0; i < stairs.GetLength(0); i++)
            {
                for (int j = 0; j < stairs.GetLength(1); j++)
                {
                    Console.Write(stairs[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
