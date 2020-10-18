using System;
using System.Collections.Generic;

namespace TasksOfPairing
{
    class StartUp
    {
        static void Main()
        {
            var freq = new List<long>() { 5, 6, 2, 0, 3 };
            Console.WriteLine(TaskOfPairing(freq));
        }

        private static long TaskOfPairing(List<long> freq)
        {
            long result = 0;
            var remainder = false;
            for (int i = 0; i < freq.Count; i++)
            {
                if (remainder)
                {
                    freq[i]++;
                    remainder = false;
                    if (freq[i] == 1)
                    {
                        continue;
                    }
                }
                if (freq[i] == 0)
                {
                    continue;
                }

                if (freq[i] % 2 != 0)
                {
                    if (freq[i] / 2 > 0)
                    {
                        remainder = true;
                    }
                    
                }

                result += freq[i] / 2;

            }

            return result;
        }
    }
}
