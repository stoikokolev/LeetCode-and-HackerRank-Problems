using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManagement
{
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var companies = new Dictionary<string, List<int>>();
            foreach (var employee in employees)
            {
                if (!companies.ContainsKey(employee.Company))
                {
                    companies.Add(employee.Company, new List<int>() { employee.Age });
                }
                else
                {
                    companies[employee.Company].Add(employee.Age);
                }
            }

            var result = companies.ToDictionary(company => company.Key, company => (int) Math.Round(company.Value.Average(), 0));

            return result.OrderBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var companies = new Dictionary<string, int>();
            foreach (var employee in employees)
            {
                if (!companies.ContainsKey(employee.Company))
                {
                    companies.Add(employee.Company, 1);
                }
                else
                {
                    companies[employee.Company]++;
                }
            }

            return companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var companies = new Dictionary<string, Employee>();
            foreach (var employee in employees)
            {
                if (!companies.ContainsKey(employee.Company))
                {
                    companies.Add(employee.Company, employee);
                }
                else
                {
                    if (companies[employee.Company].Age < employee.Age)
                    {
                        companies[employee.Company] = employee;
                    }
                }

            }
            return companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
        }
    }
}
