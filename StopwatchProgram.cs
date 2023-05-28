using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class StopwatchProgram
    {
        public DateTime startTime;
        public DateTime endTime;
        public bool isRunning;

        public void Start()
        {

            if (isRunning)
            {
                Console.WriteLine("Stopwatch is already running.");
                return;
            }

            startTime = DateTime.Now;
            isRunning = true;
            Console.WriteLine("Stopwatch started.");
        }

        public void Stop()
        {
            if (!isRunning)
            {
                Console.WriteLine("Stopwatch is not running.");
                return;
            }

            endTime = DateTime.Now;
            isRunning = false;
            Console.WriteLine("Stopwatch stopped.");
        }

        public void DisplayElapsedTime()
        {
            if (isRunning)
            {
                Console.WriteLine("Stopwatch is still running. Stop it to get the elapsed time.");
                return;
            }

            TimeSpan elapsedTime = endTime - startTime;
            Console.WriteLine("Elapsed time: " + elapsedTime);
        }
    }
}
