using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        /*
           Sample Input;
           3
           11 2 4
           4 5 6
           10 8 -12

           Sample Output;
           15
        */
        static int diagonalDifference(int[][] a)
        {
            return (a[0][2] + a[1][1] + a[2][0]) - (a[0][0] + a[1][1] + a[2][2]);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int result = diagonalDifference(a);
            Console.WriteLine(result);
        }
    }
}