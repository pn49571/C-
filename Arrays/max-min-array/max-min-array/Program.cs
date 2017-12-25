using System;
using System.Linq;

namespace max_min_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, -1, -2, 0 };
            Console.WriteLine(array1.Max());
            Console.WriteLine(array1.Min(x => Math.Abs(x)));
            Console.WriteLine(array1.Min());
        }
    }
}
