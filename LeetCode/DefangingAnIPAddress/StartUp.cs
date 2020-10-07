using System;
using System.Text;

namespace DefangingAnIPAddress
{
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(@"https://leetcode.com/problems/defanging-an-ip-address/");
        }

        public string DefangIPaddr(string address)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    sb.Append("[.]");
                }
                else
                {
                    sb.Append(address[i]);
                }
            }

            return sb.ToString();
        }
    }
}
