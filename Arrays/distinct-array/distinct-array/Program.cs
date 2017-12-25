using System;
using System.Linq;

namespace distinct_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 3, 4 };
            int[] q = s.Distinct().ToArray();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
