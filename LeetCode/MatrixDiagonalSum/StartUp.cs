using System;
using System.Reflection.Metadata.Ecma335;

namespace MatrixDiagonalSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/matrix-diagonal-sum/");
        }

        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            int iteration = mat.GetLength(0);
            for (int i = 0; i < iteration; i++)
            {
                sum += mat[i][i] + mat[iteration - 1 - i][i];
                sum += mat[iteration - 1 - i][i];
            }

            if (iteration % 2 == 1)
            {
                sum -= mat[iteration / 2][iteration / 2];
            }

            return sum;
        }
    }
}
