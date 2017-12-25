using System;

namespace _2d_array_3x3matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int col = 3;

            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.Write("\nThe matrix is : \n");
            for (int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < col; j++)
                    Console.Write("{0}\t", arr[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
