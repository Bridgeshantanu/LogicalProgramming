using System.Diagnostics;

namespace Logical_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FibonacciSeries series = new FibonacciSeries();
            series.GenerateFibonacciSeries();

            PerfectNumber perfectNumber = new PerfectNumber();
            perfectNumber.GeneratePerfectNumber();

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.GeneratePrimeNumber();

            ReverseNumber number = new ReverseNumber();
            number.GenerateReverseNumber();

            StopwatchProgram stopwatch = new StopwatchProgram();

            Console.WriteLine("Press 'S' to start the stopwatch.");
            Console.WriteLine("Press 'E' to stop the stopwatch.");
            Console.WriteLine("Press 'D' to display the elapsed time.");
            Console.WriteLine("Press 'Q' to quit the program.");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case (ConsoleKey.S):
                        stopwatch.Start();
                        break;

                    case (ConsoleKey.E):
                        stopwatch.Stop();
                        break;

                    case (ConsoleKey.D):
                        stopwatch.DisplayElapsedTime();
                        break;

                    case (ConsoleKey.Q):
                        return;


                    default:
                        Console.WriteLine("Invalid key.");
                        break;
                }

                Console.WriteLine();
            }


        }
    }
    
}