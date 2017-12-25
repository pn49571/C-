using System;
using System.Collections.Generic;
using System.Linq;

namespace count_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ids = new List<int>(new int[] { 2, 3, 7 });

            foreach (var item in ids.GroupBy(i => i))
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Count());
            }
        }
    }
}
