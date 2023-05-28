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



        }
    }
    
}