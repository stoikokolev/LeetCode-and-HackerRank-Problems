using System;
using System.Collections.Generic;

namespace SortArrayByParity
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/sort-array-by-parity/");
        }

        public int[] SortArrayByParity(int[] A)
        {
            var evenList = new List<int>();
            var oddList = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    evenList.Add(A[i]);
                }
                else
                {
                    oddList.Add(A[i]);
                }
            }

            for (int i = 0; i < evenList.Count; i++)
            {
                A[i] = evenList[i];
            }

            for (int i = evenList.Count; i < A.Length; i++)
            {
                A[i] = oddList[i - evenList.Count];
            }

            return A;
        }
    }
}
