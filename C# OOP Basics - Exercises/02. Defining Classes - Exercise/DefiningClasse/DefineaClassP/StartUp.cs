using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Employee> company = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                if (info.Length == 6)
                {
                    AddEmployeeWithSixProperties(company, info);
                }
                else if (info.Length == 5)
                {
                    AddEmployeeWithFiveProperties(company, info);
                }
                else if (info.Length == 4)
                {
                    AddEmployeeWithFourProperties(company, info);
                }
            }

            Dictionary<string, double> dict = new Dictionary<string, double>();
            foreach (var item in company)
            {
                if (!dict.ContainsKey(item.department))
                {
                    dict.Add(item.department, item.salary);
                }
                else
                {
                    dict[item.department] += item.salary;
                }
            }

            string highestPaidDepartment = "";
            double highestAverageSalary = double.MinValue;

            foreach (var dep in dict)
            {
                double averageSalary = dict[dep.Key] / company.Where(x => x.department == dep.Key).Count();
                if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    highestPaidDepartment = dep.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment}");
            foreach (var employee in company.Where(x => x.department == highestPaidDepartment).OrderByDescending(x => x.salary))
            {
                Console.WriteLine($"{employee.name} {employee.salary:f2} {employee.email} {employee.age}");
            }
        }

        private static void AddEmployeeWithFourProperties(List<Employee> company, string[] info)
        {
            company.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3]));
        }

        private static void AddEmployeeWithFiveProperties(List<Employee> company, string[] info)
        {
            if (IsAge(info[4]))
            {
                company.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3], int.Parse(info[4])));
            }
            else
            {
                company.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3], info[4]));
            }
        }

        private static bool IsAge(string str)
        {
            try
            {
                int.Parse(str);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private static void AddEmployeeWithSixProperties(List<Employee> company, string[] info)
        {
            company.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3], info[4], int.Parse(info[5])));
        }
    }
}
