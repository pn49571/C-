using System;

namespace store_retreive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("\n\n Read and print elemnets of an array: \n");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Input 0 elements in the array : \n");

            for (i = 0; i <10; i++)
            {
                Console.WriteLine("element - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\n Elements in array are :");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} ", arr[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
