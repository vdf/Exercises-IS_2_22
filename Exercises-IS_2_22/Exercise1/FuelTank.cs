using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class FuelTank
    {
        public int Fuel;
        public int MaxVolume;

        public FuelTank()
        {
            Fuel = 0;
            MaxVolume = 100;
        }

        public void ConsumeFuel(double distance)
        {
            int fuelConsumed = (int)Math.Ceiling(distance);
            Fuel = Math.Max(Fuel - fuelConsumed, 0);
        }

        public double FuelEfficiency
        {
            get;
            set;
        }

        public void Refuel(int amount)
        {
            Fuel = Math.Min(Fuel + amount, MaxVolume);
        }

        public bool IsFuelLow()
        {
            int lowFuelThreshold = 10;
            return Fuel <= lowFuelThreshold;
        }
    }
}
