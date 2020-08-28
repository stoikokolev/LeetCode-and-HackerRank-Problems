using System;

namespace SuffleTheArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/shuffle-the-array/");
        }

        public class Solution
        {
            public int[] Shuffle(int[] nums, int n)
            {
                var count = -1;
                var newArr = new int[n * 2];
                for (var i = 0; i < n * 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                        newArr[i] = nums[count];
                    }
                    else
                    {
                        newArr[i] = nums[count + n];

                    }

                }

                return newArr;
            }

        }
    }
}
