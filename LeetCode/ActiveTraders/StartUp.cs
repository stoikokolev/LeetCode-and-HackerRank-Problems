using System;
using System.Collections.Generic;
using System.Linq;

namespace ActiveTraders
{
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Result
    {
        public static List<string> mostActive(List<string> customers)
        {
            var dict = new Dictionary<string,double>();
            double trades = (double) customers.Count;
            double neededTrades = trades / 20;
            foreach (var customer in customers)
            {
                if (dict.ContainsKey(customer))
                {
                    dict[customer]++;
                }
                else
                {
                    dict.Add(customer,1);
                }
            }
            List<string> result = new List<string>();
            foreach (var company in dict.OrderBy(x=>x.Key).Where(x=>x.Value>=neededTrades))
            {
                result.Add(company.Key);
            }

            return result;
        }

    }
}
