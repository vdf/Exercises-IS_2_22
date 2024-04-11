using System;
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

            FuelTank tank = new FuelTank();
            Console.WriteLine("What is value of fuel now ? (int)");
            tank.Fuel = int.Parse(Console.ReadLine());
            if (tank.Fuel <= 0) {
                Console.WriteLine("Fuel cannot be 0 or lower");
            }
            else
            {
                Console.WriteLine($"Max volume is - {tank.MaxVolume}, Fuel now - {tank.Fuel}");
            }

            Console.ReadKey();
        }
    }
}
