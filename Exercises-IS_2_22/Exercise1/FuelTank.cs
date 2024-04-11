using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class FuelTank
    {
        public int fuel;
        public int MaxVolume;

        public FuelTank(int Fuel, int MaxVolume)
        {
            this.fuel = Fuel;
            this.MaxVolume = MaxVolume;
        }

        public void ConsumeFuel(double distance)
        {
            int fuelConsumed = (int)Math.Ceiling(distance);
            fuel = Math.Max(fuel - fuelConsumed, 0);
        }

        public double FuelEfficiency
        {
            get;
            set;
        }

        public bool Refuel(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot be less than 0");
                return false;
            }

            if (fuel + amount > MaxVolume)
            {
                Console.WriteLine("Cannot be more than MaxVolume (100)");
                fuel = MaxVolume;
            }
            else
            {
                fuel += amount;
            }

            Console.WriteLine($"Current fuel level - {fuel}");
            return true;
        }

        public bool IsFuelLow()
        {
            int lowFuelThreshold = 10;
            return fuel <= lowFuelThreshold;
        }
    }
}
