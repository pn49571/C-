using System;
using System.Collections.Generic;

namespace count_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };

            var dict = new Dictionary<int, int>();

            foreach (var item in arr1)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine("Value {0} occurred {1} times.", item.Key, item.Value);
                Console.ReadKey();
            }      

        }
    }
}
