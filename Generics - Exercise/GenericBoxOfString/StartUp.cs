using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main()
        {
            // 1. Generic Box of String
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string str = Console.ReadLine();
            //    Box<string> box = new Box<string>() { Value = str };
            //    Console.WriteLine(box);
            //}

            // 2. Generic Box of Integer
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    Box<int> box = new Box<int>() { Value = num };
            //    Console.WriteLine(box);
            //}

            // 3. Generic Swap Method Strings
            //int n = int.Parse(Console.ReadLine());
            //List<Box<string>> list = new List<Box<string>>();
            //for (int i = 0; i < n; i++)
            //{
            //    string str = Console.ReadLine();
            //    Box<string> box = new Box<string>() { Value = str };
            //    list.Add(box);
            //}

            //int[] indexesToSwap = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //Swap(list, indexesToSwap[0], indexesToSwap[1]);
            //list.ForEach(Console.WriteLine);

            // 4. Generic Swap Method Integers
            //int n = int.Parse(Console.ReadLine());
            //List<Box<int>> list = new List<Box<int>>();
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    Box<int> box = new Box<int>() { Value = num };
            //    list.Add(box);
            //}

            //int[] indexesToSwap = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //Swap(list, indexesToSwap[0], indexesToSwap[1]);
            //list.ForEach(Console.WriteLine);

            // 5. Generic Count Method Strings
            //int n = int.Parse(Console.ReadLine());
            //List<string> list = new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    string element = Console.ReadLine();
            //    list.Add(element);
            //}

            //string elementToCompare = Console.ReadLine();
            //int count = Count(list, elementToCompare);
            //Console.WriteLine(count);

            // 6. Generic Count Method Doubles
            //int n = int.Parse(Console.ReadLine());
            //List<double> list = new List<double>();
            //for (int i = 0; i < n; i++)
            //{
            //    double num = double.Parse(Console.ReadLine());
            //    list.Add(num);
            //}

            //double elementToCompare = double.Parse(Console.ReadLine());
            //int count = Count(list, elementToCompare);
            //Console.WriteLine(count);

            // 7. Tuple
            //// {first name} {last name} {address}
            //string[] line1 = Console.ReadLine().Split();

            //// {name} {liters of beer}
            //string[] line2 = Console.ReadLine().Split();

            //// {integer} {double}
            //string[] line3 = Console.ReadLine().Split();

            //MyTuple<string, string> tuple1 = new MyTuple<string, string>(line1[0] + " " + line1[1], line1[2]);
            //Console.WriteLine($"{tuple1.Item1} -> {tuple1.Item2}");

            //MyTuple<string, int> tuple2 = new MyTuple<string, int>(line2[0], int.Parse(line2[1]));
            //Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2}");

            //MyTuple<int, double> tuple3 = new MyTuple<int, double>(int.Parse(line3[0]), double.Parse(line3[1]));
            //Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2}");

            // 8. Threeuple
            // {first name} {last name} {address} {town}
            string[] line1 = Console.ReadLine().Split();

            // {name} {liters of beer} {drunk or not}
            string[] line2 = Console.ReadLine().Split();

            // {name} {account balance} {bank name}
            string[] line3 = Console.ReadLine().Split();

            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>
                (line1[0] + " " + line1[1], line1[2], line1[3]);
            Console.WriteLine($"{threeuple1.Item1} -> {threeuple1.Item2} -> {threeuple1.Item3}");

            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>
                (line2[0], int.Parse(line2[1]), line2[2] == "drunk");
            Console.WriteLine($"{threeuple2.Item1} -> {threeuple2.Item2} -> {threeuple2.Item3}");

            Threeuple<string, decimal, string> threeuple3 = new Threeuple<string, decimal, string>
                (line3[0], decimal.Parse(line3[1]), line3[2]);
            Console.WriteLine($"{threeuple3.Item1} -> {threeuple3.Item2:F1} -> {threeuple3.Item3}");
        }

        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            // TODO: Validate indexes!
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        public static int Count<T>(List<T> list, T element) where T : IComparable<T>
        {
            int count = 0;
            foreach (T item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
