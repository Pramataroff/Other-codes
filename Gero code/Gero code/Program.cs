using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()

        {
            Console.Write("Enter numbers: ");
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int zeros = CountOfZeros(inputNumbers);
            int nonZeros = CountOfNonZeros(inputNumbers);
            Console.WriteLine("Count of zeros: " + zeros);

            Console.WriteLine("Count of nonzeros: " + nonZeros);
        }

        static int CountOfZeros(int[] numbers)
        {
            int zeroCounts = 0;
            foreach (var VARIABLE in numbers)
            {
                if (VARIABLE == 0)
                {
                    zeroCounts++;
                }

            }
            return zeroCounts;
        }
        static int CountOfNonZeros(int[] numbers)
        {
            int nonZeroCounts = 0;

            foreach (var VARIABLE in numbers)
            {
                if (VARIABLE != 0)
                {
                    nonZeroCounts++;
                }

            }
            return nonZeroCounts;
        }
    }
}