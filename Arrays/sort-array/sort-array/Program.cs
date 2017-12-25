using System;
using System.Linq;

namespace sort_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 10, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in arr.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }

        }
    }
}
