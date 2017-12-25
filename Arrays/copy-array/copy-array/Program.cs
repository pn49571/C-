using System;

namespace copy_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            arr.CopyTo(arr2,0);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr2[i]);
            };
        }
    }
}
