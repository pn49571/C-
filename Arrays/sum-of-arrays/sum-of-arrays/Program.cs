using System;

namespace sum_of_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            int[] arr = new int[10];

            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum is: ", sum);
        }
    }
}
