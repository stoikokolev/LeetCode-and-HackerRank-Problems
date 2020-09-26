using System;
using System.Collections.Generic;
using System.Linq;

namespace UnexpectedDemant
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int filledOrders(List<int> order, int k)
        {
            int completedOrders =0;
             order.Sort();
             foreach (var item in order)
             {
                 if (item <= k)
                 {
                     k -= item;
                     completedOrders++;
                 }
                 else
                 {
                     break;
                 }
             }

             return completedOrders;

        }
    }
}
