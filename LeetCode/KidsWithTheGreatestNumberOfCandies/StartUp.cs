using System;
using System.Collections.Generic;
using System.Linq;

namespace KidsWithTheGreatestNumberOfCandies
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/");
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            var list = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                list.Add(candies[i] + extraCandies >= max);
            }

            return list;
        }
}
}
