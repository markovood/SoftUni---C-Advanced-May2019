using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionFor1km;
            this.TravelledDistance = 0;
        }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public int Weight { get; set; }

        public string Color { get; set; }

        public Tire[] Tires { get; }

        public Cargo Cargo { get; }

        public Engine Engine { get; }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        private bool CanMove(int distance)
        {
            if (this.FuelAmount >= distance * this.FuelConsumptionPerKilometer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Drive(int distance)
        {
            if (CanMove(distance))
            {
                this.FuelAmount -= distance * this.FuelConsumptionPerKilometer;
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            sb.AppendLine($"    Displacement: {(this.Engine.Displacement == 0 ? "n/a" : $"{this.Engine.Displacement}")}");
            sb.AppendLine($"    Efficiency: {(string.IsNullOrEmpty(this.Engine.Efficiency) ? "n/a" : $"{this.Engine.Efficiency}")}");
            sb.AppendLine($"  Weight: {(this.Weight == 0 ? "n/a" : $"{this.Weight}")}");
            sb.Append($"  Color: {(string.IsNullOrEmpty(this.Color) ? "n/a" : $"{this.Color}")}");
            return sb.ToString();
        }
    }
}
