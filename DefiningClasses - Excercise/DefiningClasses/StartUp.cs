using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            // 01. Define a Class Person & 02. Creating Constructors
            //Person firstPerson = new Person()
            //{
            //    Name = "Pesho",
            //    Age = 20
            //};

            //Person secondPerson = new Person();
            //secondPerson.Name = "Gosho";
            //secondPerson.Age = 18;

            //Person thirdPerson = new Person("Stamat", 43);

            //Person otherPerson = new Person(21);

            // 03. Oldest Family Member
            //int N = int.Parse(Console.ReadLine());

            //Family someFamily = new Family();
            //for (int i = 0; i < N; i++)
            //{
            //    string[] familyMember = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //    string memberName = familyMember[0];
            //    int memberAge = int.Parse(familyMember[1]);

            //    someFamily.AddMember(new Person(memberName, memberAge));
            //}

            //Person oldest = someFamily.GetOldestMember();
            //Console.WriteLine($"{oldest.Name} {oldest.Age}");

            // 04. Opinion Poll
            //int numbOfLines = int.Parse(Console.ReadLine());
            //List<Person> people = new List<Person>();
            //for (int i = 0; i < numbOfLines; i++)
            //{
            //    string[] personalInfo = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    string name = personalInfo[0];
            //    int age = int.Parse(personalInfo[1]);
            //    Person person = new Person(name, age);
            //    people.Add(person);
            //}

            //people
            //    .Where(p => p.Age > 30)
            //    .OrderBy(p => p.Name)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.Name + " - " + p.Age));

            // 05. Date Modifier
            //DateModifier dateModifier = new DateModifier();
            //string date1 = Console.ReadLine();
            //string date2 = Console.ReadLine();
            //Console.WriteLine(dateModifier.CalculateDifference(date1, date2));

            // 06. Speed Racing
            //int N = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < N; i++)
            //{
            //    string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    string model = carInfo[0];
            //    double fuelAmount = double.Parse(carInfo[1]);
            //    double fuelConsumptionFor1km = double.Parse(carInfo[2]);
            //    var car = new Car(model, fuelAmount, fuelConsumptionFor1km);
            //    cars.Add(car);
            //}

            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "End")
            //    {
            //        break;
            //    }

            //    string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    string carModel = tokens[1];
            //    int amountOfKm = int.Parse(tokens[2]);
            //    cars.Find(c => c.Model == carModel).Drive(amountOfKm);
            //}

            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            //}

            // 07.Raw Data - reusing the Car class from previous task extending its data
            //int N = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < N; i++)
            //{
            //    string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //    string model = carInfo[0];
            //    int engineSpeed = int.Parse(carInfo[1]);
            //    int enginePower = int.Parse(carInfo[2]);
            //    int cargoWeight = int.Parse(carInfo[3]);
            //    string cargoType = carInfo[4];
            //    double tire1Pressure = double.Parse(carInfo[5]);
            //    int tire1Age = int.Parse(carInfo[6]);
            //    double tire2Pressure = double.Parse(carInfo[7]);
            //    int tire2Age = int.Parse(carInfo[8]);
            //    double tire3Pressure = double.Parse(carInfo[9]);
            //    int tire3Age = int.Parse(carInfo[10]);
            //    double tire4Pressure = double.Parse(carInfo[11]);
            //    int tire4Age = int.Parse(carInfo[12]);

            //    Engine engine = new Engine(engineSpeed, enginePower);
            //    Cargo cargo = new Cargo(cargoType, cargoWeight);
            //    Tire[] tires = new Tire[4]
            //    {
            //        new Tire(tire1Age, tire1Pressure),
            //        new Tire(tire2Age, tire2Pressure),
            //        new Tire(tire3Age, tire3Pressure),
            //        new Tire(tire4Age, tire4Pressure)
            //    };

            //    var car = new Car(model, engine, cargo, tires);
            //    cars.Add(car);
            //}

            //string command = Console.ReadLine();
            //switch (command)
            //{
            //    case "fragile":
            //        cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
            //            .ToList()
            //            .ForEach(c => Console.WriteLine(c.Model));
            //        break;
            //    case "flamable":
            //        cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
            //            .ToList()
            //            .ForEach(c => Console.WriteLine(c.Model));
            //        break;
            //}

            // 08. Car Salesman - reusing the Car class and the engine class from previous task
            //int N = int.Parse(Console.ReadLine());
            //List<Engine> engines = new List<Engine>();
            //for (int i = 0; i < N; i++)
            //{
            //    string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    string model = engineInfo[0];
            //    int power = int.Parse(engineInfo[1]);

            //    var engine = new Engine(model, power);

            //    if (engineInfo.Length == 3)
            //    {
            //        if (int.TryParse(engineInfo[2], out int displacement))
            //        {
            //            engine.Displacement = displacement;
            //        }
            //        else
            //        {
            //            engine.Efficiency = engineInfo[2];
            //        }
            //    }
            //    else if (engineInfo.Length == 4)
            //    {
            //        int displacement = int.Parse(engineInfo[2]);
            //        engine.Displacement = displacement;
            //        string efficiency = engineInfo[3];
            //        engine.Efficiency = efficiency;
            //    }

            //    engines.Add(engine);
            //}

            //int M = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < M; i++)
            //{
            //    string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    string model = carInfo[0];
            //    Engine engine = engines.Find(e => e.Model == carInfo[1]);

            //    var car = new Car(model, engine);
            //    if (carInfo.Length == 3)
            //    {
            //        if (int.TryParse(carInfo[2], out int weight))
            //        {
            //            car.Weight = weight;
            //        }
            //        else
            //        {
            //            car.Color = carInfo[2];
            //        }
            //    }
            //    else if (carInfo.Length == 4)
            //    {
            //        car.Weight = int.Parse(carInfo[2]);
            //        car.Color = carInfo[3];
            //    }

            //    cars.Add(car);
            //}

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            // 09. Pokemon Trainer
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string trainerInfo = Console.ReadLine();
                if (trainerInfo == "Tournament")
                {
                    break;
                }

                string[] tokens = trainerInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                var trainer = new Trainer(trainerName);
                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (trainers.Any(tr => tr.Name == trainer.Name))
                {
                    trainers.First(tr => tr.Name == trainer.Name)
                        .Pokemons.Add(pokemon);
                }
                else
                {
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                    }
                }
            }

            trainers.OrderByDescending(tr => tr.Badges)
                .ToList()
                .ForEach(tr => Console.WriteLine($"{tr.Name} {tr.Badges} {tr.Pokemons.Count}"));
        }
    }
}
