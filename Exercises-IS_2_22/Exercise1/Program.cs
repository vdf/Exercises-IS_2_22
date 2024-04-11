using System;
using System.Globalization;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine eng = new Engine();
            Console.WriteLine("State: " + eng.GetState());
            Console.WriteLine();

            eng.Start();
            Console.WriteLine("State: " + eng.GetState());
            Console.WriteLine("\nSleeping for 2 sec");
            Thread.Sleep( 2000 );
            Console.WriteLine();

            eng.Start();
            Console.WriteLine("State: " + eng.GetState());
            Console.WriteLine();

            FuelTank tank = new FuelTank();
            Console.WriteLine("Max tank volume is - " + tank.MaxVolume);
            Console.WriteLine();

            Console.WriteLine("How much fuel you want to add ? (int)");
            int fuelToAdd = int.Parse(Console.ReadLine());
            tank.Refuel(fuelToAdd);

            Console.WriteLine("Fuel added. Current level is - " + tank.Fuel);
            Console.WriteLine();

            Console.WriteLine("Enter the distance you driven (double)");
            string distanceDriven = Console.ReadLine().Replace(',', '.');
            double X = double.Parse(distanceDriven, CultureInfo.InvariantCulture);
            tank.ConsumeFuel(X);
            Console.WriteLine();

            Console.WriteLine("After driving fuel level is - " + tank.Fuel);
            Console.WriteLine();

            if (tank.IsFuelLow())
            {
                Console.WriteLine("Fuel is low!");
            }

            Console.ReadKey();
        }
    }
}
