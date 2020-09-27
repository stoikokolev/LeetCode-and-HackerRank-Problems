using System;

namespace NumberOfGoodPairs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/number-of-good-pairs/");
        }

        public int NumIdenticalPairs(int[] nums)
        {
            short count = 0;
            for (var i = 0; i < nums.Length-1; i++)
            {
                for (var j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
