using System;
using System.Linq;

namespace Recursion
{
    public class StartUp
    {
        public static void Main()
        {
            // 01. Recursive Array Sum
            //int[] arr = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //Console.WriteLine(RecursiveArraySum.Sum(arr));

            // 02. Recursive Factorial
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursiveFactorial.Factorial(number));
        }
    }
}
