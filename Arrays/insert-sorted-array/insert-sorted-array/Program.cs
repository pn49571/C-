using System;
using System.Linq;

namespace insert_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int inserted = 11;
            int count = 0;
            int[] arr = { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr1 = new int[arr.Length + 1];
            Array.Copy(arr, arr1, arr.Length);
            arr1[arr1.Length - 1] = inserted;
            foreach (var item in arr1.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }


        }
    }
}
