using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            Engine eng = new Engine();
            Console.Out.WriteLine( "State: " + eng.GetState() );
            Console.Out.WriteLine();

            eng.Start();
            Console.Out.WriteLine( "State: " + eng.GetState() );
            Console.WriteLine("\nSleeping for 2 sec");
            Thread.Sleep( 2000 );
            Console.Out.WriteLine();

            eng.Start();
            Console.Out.WriteLine( "State: " + eng.GetState() );

            Console.ReadKey();
        }
    }
}
