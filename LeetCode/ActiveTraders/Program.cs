using System;
using System.Collections.Generic;
using System.Linq;

namespace ActiveTraders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Result
    {

        /*
         * Complete the 'mostActive' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts STRING_ARRAY customers as parameter.
         */

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
