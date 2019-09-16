using System;
using System.Collections.Generic;
using System.Linq;

namespace BombTheBasement
{
    public class BombTheBasement
    {
        public static void Main()
        {
            // More easy is to represent the basement as an array of columns, and every column will be List<int>
            // as we are going to use the functionality provided from the List class later to drop all 0 to the
            // bottom, pay extra attention to the way you print the basement as it is an array of COLUMNs

            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            // fill up every column with 0 initially
            List<List<int>> basement = new List<List<int>>();
            for (int i = 0; i < dimensions[1]; i++)
            {
                basement.Add(new List<int>(new int[dimensions[0]]));
            }

            int[] bombDetails = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = bombDetails[0];
            int targetCol = bombDetails[1];
            int radius = bombDetails[2];

            // mark cells after the blast
            for (int col = 0; col < dimensions[1]; col++)
            {
                for (int row = 0; row < dimensions[0]; row++)
                {
                    if (IsInsideBlast(row, col, targetRow, targetCol, radius))
                    {
                        basement[col][row] = 1;
                    }
                }
            }
            
            // drop all 0 to the bottom
            for (int col = 0; col < basement.Count; col++)
            {
                if (basement[col].Contains(0) && basement[col].Contains(1))
                {
                    while (basement[col][0] != 1)
                    {
                        basement[col].RemoveAt(0);
                        basement[col].Add(0);
                    }
                }
            }

            // print matrix
            Print(basement, dimensions[0]);
        }

        private static void Print(List<List<int>> matrix, int rowsCount)
        {
            // we need to print the first element of every column, before going to the next row
            int row = 0;
            while (row < rowsCount)
            {
                for (int col = 0; col < matrix.Count; col++)
                {
                    Console.Write(matrix[col][row]);
                }

                Console.WriteLine();
                row++;
            }
        }

        private static bool IsInsideBlast(int x, int y, int center_x, int center_y, int radius)
        {
            // using Pythagorean theorem a^2 + b^2 = c^2, define if point(x,y) is inside the specified radius
            // (x - center_x)^2 + (y - center_y)^2 <= radius^2

            double result = Math.Sqrt(Math.Pow(x - center_x, 2) + Math.Pow(y - center_y, 2));

            if (result <= radius)
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
