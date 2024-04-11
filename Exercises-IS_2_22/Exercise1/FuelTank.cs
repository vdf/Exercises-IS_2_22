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

        public FuelTank(int Fuel, int MaxVolume)
        {
            this.Fuel = Fuel;
            this.MaxVolume = MaxVolume;
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

        public bool Refuel(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot be less than 0");
                return false;
            }

            if (Fuel + amount > MaxVolume)
            {
                Console.WriteLine("Cannot be more than MaxVolume (100)");
                Fuel = MaxVolume;
            }
            else
            {
                Fuel += amount;
            }

            Console.WriteLine($"Current fuel level - {Fuel}");
            return true;
        }

        public bool IsFuelLow()
        {
            int lowFuelThreshold = 10;
            return Fuel <= lowFuelThreshold;
        }
    }
}
