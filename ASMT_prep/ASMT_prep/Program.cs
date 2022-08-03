using System;
using System.Linq;

namespace ASMT_prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var e1 = new Employee { Name = "X", Salary = 10 };
            //var e2 = new Employee { Name = "Y", Salary = 20 };
            //var e3 = new Employee { Name = "Z", Salary = 30 };
            //var e4 = new Employee { Name = "W", Salary = 40 };
            //var e5 = new Employee { Name = "Y", Salary = 20 };

            //var emps = new[] { e1, e2, e3, e4, e5 };

            ////with IEquatable<Employee>
            ////var distinctedEmps = emps.Distinct();
            ////with IEqualityComparer<Employee>
            //var distinctedEmps = emps.Distinct(new EmployeeComparer());

            //Console.WriteLine(distinctedEmps.Select(x => x.Name).Aggregate((x, y) => $"{x},{y}"));

            //Task6
            var numbers = new[] { new Data { Value = 3, Name = "First" }, new Data { Value = 7, Name = "Second" }, new Data { Value = 5, Name = "Third" } };
            var second = numbers.GetSecondHighest(x => x.Value);
            Console.WriteLine(second.Name);
        }
    }
}
