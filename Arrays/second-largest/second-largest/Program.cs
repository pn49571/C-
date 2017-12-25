using System;
using System.Linq;

namespace second_largest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;
            arr = arr.OrderByDescending(x => x).ToArray();
            Console.WriteLine(arr[1]);
        }
    }
}
