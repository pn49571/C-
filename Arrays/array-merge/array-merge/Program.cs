using System;

namespace array_merge
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };

            int[] c = MergeArrays(a, b);
        }
        public static T[] MergeArrays<T>(T[] first, T[] second)
        {
            T[] result = new T[first.Length + second.Length];
            Array.Copy(first, result, first.Length);
            Array.Copy(second, 0, result, first.Length, second.Length);
            return result;
        }
    }
}
