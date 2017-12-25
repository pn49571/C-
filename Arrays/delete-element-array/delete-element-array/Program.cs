using System;
using System.Linq;

namespace delete_element_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int removed = 2;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            arr = arr.Where(x => x != 2).ToArray();
            foreach (var item in arr) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
