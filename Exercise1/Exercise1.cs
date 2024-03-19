using System;

namespace Exercise1
{
    class Engine
    {
        private const int state_stopped = 1;
        private const int state_started = 2;
        public int engine_state;

        public void start()
        {
            Console.Out.WriteLine( "Start" );
            engine_state = state_stopped;
        }

        public void stop()
        {
            Console.Out.WriteLine( "Stop" );
            engine_state = state_started;
        }

        public String getState()
        {
            String state = null;

            if( engine_state == state_stopped )
            {
                state = "STOPPED";
            }
            else if( engine_state == state_started )
            {
                state = "STARTED";
            }

            return state;
        }
    }
}
