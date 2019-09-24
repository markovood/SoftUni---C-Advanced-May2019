using System;
using System.IO;
using System.Linq;

namespace EvenLines
{
    public class EvenLines
    {
        public static void Main()
        {
            string pathIn = @"..\..\..\..\Resources\text.txt";
            using (var reader = new StreamReader(pathIn))
            {
                int lineNumb = 0;

                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    if (lineNumb % 2 == 0)
                    {
                        Replace(ref line);
                        Reverse(ref line);
                        Console.WriteLine(line);
                    }

                    lineNumb++;
                }
            }
        }

        private static void Reverse(ref string line)
        {
            string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            line = string.Join(' ', words.Reverse());
        }

        private static void Replace(ref string line)
        {
            string[] symbols = new string[] { "-", ",", ".", "!", "?" };
            foreach (var symbol in symbols)
            {
                if (line.Contains(symbol))
                {
                    line = line.Replace(symbol, "@");
                }
            }
        }
    }
}
