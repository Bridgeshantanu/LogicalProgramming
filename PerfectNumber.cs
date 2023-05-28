using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class PerfectNumber
    {
        public void GeneratePerfectNumber()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;


            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }


            if (sum == number)
            {
                Console.WriteLine(number + " is a perfect number.");
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number.");
            }
        }
    }
}
