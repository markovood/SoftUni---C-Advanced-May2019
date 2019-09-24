using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            string pathIn = @"..\..\..\..\Resources\text.txt";
            string pathOut = @"..\..\..\output.txt";

            string[] lines = File.ReadAllLines(pathIn);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"Line {i + 1}: {lines[i]} ({CountLetters(lines[i])})({CountPunctuationMarks(lines[i])})";
            }

            File.WriteAllLines(pathOut, lines);
        }

        private static int CountPunctuationMarks(string line)
        {
            char[] symbols = line.ToCharArray();
            int count = 0;
            foreach (var symbol in symbols)
            {
                if (char.IsPunctuation(symbol))
                {
                    count++;
                }
            }

            return count;
        }

        private static int CountLetters(string line)
        {
            char[] symbols = line.ToCharArray();
            int count = 0;
            foreach (var symbol in symbols)
            {
                if (char.IsLetter(symbol))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
