using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            char dirSeparator = Path.DirectorySeparatorChar;
            string inputFileName = "words.txt";
            string targetFileName = "text.txt";
            string outputFileName = "actualResults.txt";
            string sortedOutputFileName = "actualResults-sorted.txt";

            string pathToWords = $"..{dirSeparator}..{dirSeparator}..{dirSeparator}..{dirSeparator}Resources{dirSeparator}{inputFileName}";
            string pathIn = $"..{dirSeparator}..{dirSeparator}..{dirSeparator}..{dirSeparator}Resources{dirSeparator}{targetFileName}";
            string path1Out = $"..{dirSeparator}..{dirSeparator}..{dirSeparator}{outputFileName}";
            string path2Out = $"..{dirSeparator}..{dirSeparator}..{dirSeparator}{sortedOutputFileName}";

            var words = GetWords(pathToWords);
            var wordsAndCount = CountWords(pathIn, words);
            WriteDownResult(path1Out, wordsAndCount);

            var ordered = wordsAndCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            WriteDownResult(path2Out, ordered);
        }

        private static void WriteDownResult(string pathOut, Dictionary<string, int> wordsAndCount)
        {
            string[] lines = new string[wordsAndCount.Count];
            int lineCount = 0;
            foreach (var word in wordsAndCount)
            {
                lines[lineCount] = $"{word.Key} - {word.Value}";
                lineCount++;
            }

            File.WriteAllLines(pathOut, lines);
        }

        private static Dictionary<string, int> CountWords(string pathIn, string[] words)
        {
            var wordsAndCount = new Dictionary<string, int>();

            string[] lines = File.ReadAllLines(pathIn);

            foreach (var word in words)
            {
                foreach (var line in lines)
                {
                    int wordCount = Count(word, line);

                    if (wordsAndCount.ContainsKey(word))
                    {
                        wordsAndCount[word] += wordCount;
                    }
                    else
                    {
                        wordsAndCount.Add(word, wordCount);
                    }
                }
            }

            return wordsAndCount;
        }

        private static int Count(string word, string line)
        {
            int count = 0;
            var punctuation = line.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = line.Split().Select(x => x.Trim(punctuation));
            foreach (var item in words)
            {
                if (item.ToLower() == word.ToLower())
                {
                    count++;
                }
            }

            return count;
        }

        private static string[] GetWords(string pathToWords)
        {
            return File.ReadAllLines(pathToWords);
        }
    }
}