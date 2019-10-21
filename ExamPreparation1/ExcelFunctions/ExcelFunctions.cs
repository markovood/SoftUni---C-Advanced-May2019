using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelFunctions
{
    public class ExcelFunctions
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<List<string>> matrix = new List<List<string>>();

            for (int i = 0; i < n; i++)
            {
                matrix.Add(
                    Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList());
            }

            string[] commandTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string header = commandTokens[1];
            int headerIndex = matrix[0].IndexOf(header);
            switch (commandTokens[0])
            {
                case "hide":
                    // delete the column with the corresponding header
                    if (headerIndex >= 0)
                    {
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            matrix[i].RemoveAt(headerIndex);
                        }
                    }

                    break;
                case "sort":
                    // sort the rows in the table by the header given in ascending order. Note that the header
                    // row should not be sorted
                    var headerRowPairs = new List<KeyValuePair<string, List<string>>>();
                    if (headerIndex >= 0)
                    {
                        for (int i = 1; i < matrix.Count; i++)
                        {
                            headerRowPairs.Add(new KeyValuePair<string, List<string>>(matrix[i][headerIndex], matrix[i]));
                        }
                    }

                    headerRowPairs = headerRowPairs.OrderBy(x => x.Key).ToList();
                    for (int i = 1; i < matrix.Count; i++)
                    {
                        matrix[i] = headerRowPairs[i - 1].Value;
                    }

                    break;
                case "filter":
                    // return the rows with the value given in the corresponding header
                    string headerValue = commandTokens[2];
                    var headerRow = matrix[0];

                    matrix = matrix
                        .Where(x => x[headerIndex] == headerValue)
                        .ToList();

                    matrix.Insert(0, headerRow);

                    break;
            }

            Print(matrix);
        }

        private static void Print(List<List<string>> matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" | ", row));
            }
        }
    }
}
