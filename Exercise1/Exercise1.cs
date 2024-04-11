using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStoped = 1;
        private const int StateStarted = 2;
        public int EngineState;

        public void start()
        {
            Console.Out.WriteLine( "Start" );
            EngineState = StateStarted;
        }

        public void stop()
        {
            Console.Out.WriteLine( "Stop" );
            EngineState = StateStoped;
        }

        public String getState()
        {
            String state = "start or stop";

            if( EngineState == StateStoped )
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
