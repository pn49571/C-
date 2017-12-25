using System;

namespace reverse_display_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] arr = new int[10];
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Element - {0} :" , i);
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine("Reversing");
            for (int i = n-1; i >= 0 ; i--)
            {
                Console.WriteLine("{0}",arr[i]);
            }
            Console.WriteLine("\n\n");
        }
    }
}
