using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public int Speed { get; private set; }

        public int Power { get; private set; }

        public string Model { get; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
