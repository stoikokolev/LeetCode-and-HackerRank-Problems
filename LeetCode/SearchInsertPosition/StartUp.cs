using System;

namespace SearchInsertPosition
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/search-insert-position/");
        }

        public int SearchInsert(int[] nums, int target)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                    return i;
                }
            }

            return nums.Length;

        }
    }
}
