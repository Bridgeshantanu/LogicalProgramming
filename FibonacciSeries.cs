using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class FibonacciSeries
    {
        public void GenerateFibonacciSeries()
        {
            int n = 10;

            int term1 = 0;
            int term2 = 1;

            Console.WriteLine("Fibonacci Series:");


            for (int i = 0; i < n; i++)
            {
                Console.Write(term1 + " ");

                int nextTerm = term1 + term2;
                term1 = term2;
                term2 = nextTerm;

            }


        }
    }

}

     



