using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new CustomStack<int>();
            while (true)
            {
                string[] commandTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (commandTokens[0] == "END")
                {
                    break;
                }

                try
                {                    
                    switch (commandTokens[0])
                    {
                        case "Push":
                            var ints = commandTokens.Skip(1).Select(s => int.Parse(s.TrimEnd(','))).ToArray();
                            foreach (var @int in ints)
                            {
                                stack.Push(@int);
                            }

                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message == "CustomStack is empty!")
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
