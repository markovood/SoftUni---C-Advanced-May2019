using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        private static ListyIterator<string> iterator;

        public static void Main()
        {
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
                        case "Create":
                            iterator = new ListyIterator<string>(commandTokens.Skip(1).ToArray());
                            break;
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "PrintAll":
                            foreach (var item in iterator)
                            {
                                Console.Write(item + " ");
                            }

                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
