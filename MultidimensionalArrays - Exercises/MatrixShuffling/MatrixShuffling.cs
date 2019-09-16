using System;
using System.Linq;

namespace MatrixShuffling
{
    public class MatrixShuffling
    {
        public static string[,] matrix;

        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            matrix = new string[dimensions[0], dimensions[1]];
            // fill up the matrix
            for (int i = 0; i < dimensions[0]; i++)
            {
                string[] lineTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < lineTokens.Length; j++)
                {
                    matrix[i, j] = lineTokens[j];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                if (IsValid(command))
                {
                    string[] commandTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int row1 = int.Parse(commandTokens[1]);
                    int col1 = int.Parse(commandTokens[2]);
                    int row2 = int.Parse(commandTokens[3]);
                    int col2 = int.Parse(commandTokens[4]);

                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    Print(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void Print(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool IsValid(string command)
        {
            string[] commandTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (commandTokens.Length > 5 || commandTokens.Length < 5)
            {
                return false;
            }
            else if (commandTokens[0] != "swap")
            {
                return false;
            }
            else if (!AreValidCoordinates(commandTokens[1], commandTokens[2], commandTokens[3], commandTokens[4]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool AreValidCoordinates(string coordRow1, string coordCol1, string coordRow2, string coordCol2)
        {
            int row1;
            int col1;
            int row2;
            int col2;
            if ((int.TryParse(coordRow1, out row1) && row1 >= 0 && row1 < matrix.GetLength(0)) &&
                (int.TryParse(coordCol1, out col1) && col1 >= 0 && col1 < matrix.GetLength(1)) &&
                (int.TryParse(coordRow2, out row2) && row2 >= 0 && row2 < matrix.GetLength(0)) &&
                (int.TryParse(coordCol2, out col2) && col2 >= 0 && col2 < matrix.GetLength(1)))
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
