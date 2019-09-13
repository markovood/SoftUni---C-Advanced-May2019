using System;
using System.Collections.Generic;

namespace AutoRepairAndService
{
    public class AutoRepairAndService
    {
        public static void Main()
        {
            Queue<string> awaitingCars = new Queue<string>(
                                            Console.ReadLine()
                                                .Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Stack<string> servedCars = new Stack<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                if (command == "Service")
                {
                    string car = awaitingCars.Dequeue();
                    Console.WriteLine($"Vehicle {car} got served.");
                    servedCars.Push(car);
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }
                else
                {
                    // CarInfo-{modelName}
                    string modelName = command.Split('-')[1];
                    if (servedCars.Contains(modelName))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
            }

            if (awaitingCars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", awaitingCars)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
        }
    }
}
