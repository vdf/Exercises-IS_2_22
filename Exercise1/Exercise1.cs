using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int EngineState;

        public void start()
        {
            Console.WriteLine( "Start" );
            EngineState = StateStarted;
        }

        public void stop()
        {
            Console.WriteLine( "Stop" );
            EngineState = StateStopped;
        }

        public string GetState()
        {
            string state = null;

            if( EngineState == StateStopped )
            {
                state = "STOPPED";
            }
            else if( EngineState == StateStarted )
            {
                state = "STARTED";
            }

            return state;
        }
    }
}
