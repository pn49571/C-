using System;
using System.Linq;

namespace odd_even_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in arr.Where(n => n % 2 == 0))
            {
                Console.WriteLine("Even is {0}",item );
            }
            foreach (var item in arr.Where(n => n % 2 != 0))
            {
                Console.WriteLine("Odd is {0}", item);
            }

        }
    }
}
