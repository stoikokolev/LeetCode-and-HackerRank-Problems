using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedSums
{
    class StartUp
    {
        static void Main()
        {
            var a = new List<int>(){9,5,8};
            Console.WriteLine(SortedSum(a));
        }

        public static int SortedSum(List<int> a)
        {
            int sum = 0;
            var list = new List<int>();
            
            
            foreach (var num in a)
            {
                list.Add(num);
                list.Sort();
                list.Reverse();
                sum += list.Select((t, i) => list[list.Count - 1 - i] * (i + 1)).Sum();
            }

            return sum;
        }
    }
}
