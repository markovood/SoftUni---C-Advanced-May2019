using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    public class Bombs
    {
        private static int[][] matrix;

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            string[] bombsCells = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < bombsCells.Length; i++)
            {
                int[] currentBomb = bombsCells[i]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // first check if current bomb hasn't exploded yet or been damaged by another bomb's blast
                if (matrix[currentBomb[0]][currentBomb[1]] > 0)
                {
                    // damage up
                    int row = currentBomb[0] - 1;
                    int col = currentBomb[1];
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    // damage up right
                    row = currentBomb[0] - 1;
                    col = currentBomb[1] + 1;
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    // damage right
                    row = currentBomb[0];
                    col = currentBomb[1] + 1;
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    // damage down right
                    row = currentBomb[0] + 1;
                    col = currentBomb[1] + 1;
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    // damage down
                    row = currentBomb[0] + 1;
                    col = currentBomb[1];
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    // damage down left
                    row = currentBomb[0] + 1;
                    col = currentBomb[1] - 1;
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    // damage left
                    row = currentBomb[0];
                    col = currentBomb[1] - 1;
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    // damage up left
                    row = currentBomb[0] - 1;
                    col = currentBomb[1] - 1;
                    if (IsInside(row, col) && matrix[row][col] > 0)
                    {
                        matrix[row][col] -= matrix[currentBomb[0]][currentBomb[1]];
                    }

                    matrix[currentBomb[0]][currentBomb[1]] = 0;
                }
            }

            // Print
            List<int> aliveCells = CountCells();
            long sumOfCells = GetSumOfCells(aliveCells);
            Console.WriteLine($"Alive cells: {aliveCells.Count}");
            Console.WriteLine($"Sum: {sumOfCells}");
            Print(matrix);
        }

        private static long GetSumOfCells(List<int> aliveCells)
        {
            long sum = 0;
            aliveCells.ForEach(x => sum += x);
            return sum;
        }

        private static List<int> CountCells()
        {
            List<int> cells = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] > 0)
                    {
                        cells.Add(matrix[i][j]);
                    }
                }
            }

            return cells;
        }

        private static void Print(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }

        private static bool IsInside(int row, int col)
        {
            if ((row >= 0 && row < matrix.Length) &&
                (col >= 0 && col < matrix[row].Length))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
