using System;

namespace ArrangingCoins
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/arranging-coins/");
        }
        public int ArrangeCoins(int n)
        {
            var count = 0;
            while (n >= 0)
            {

                if (count <= n)
                {
                    n -= count;
                    count++;
                }
                else
                { break; }
            }
            return count - 1;
        }

    }
}
