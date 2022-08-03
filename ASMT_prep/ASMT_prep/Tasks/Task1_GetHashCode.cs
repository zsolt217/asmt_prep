using System;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// make class Employee a proper dictionary key
/// </summary>
namespace ASMT_prep
{
    //dictionary key is that it is comparable and hashable
    //override Equals and GetHashCode
    //IEqualityComparer: This interface allows the implementation of customized equality comparison for collections.
    public class Employee : IEquatable<Employee>
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Employee empl)
            {
                this.Equals(empl);
            }
            return false;
        }

        //For distinct
        public bool Equals(Employee other)
        {
            return other.Name.Equals(Name) && other.Salary.Equals(Salary);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name.GetHashCode(), Salary.GetHashCode());
        }
    }

    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.GetHashCode();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var e1 = new Employee { Name = "X", Salary = 10 };
    //        var e2 = new Employee { Name = "Y", Salary = 20 };

    //        var emps = new Dictionary<Employee, string>();
    //        emps.Add(e1, "poor");
    //        emps.Add(e2, "rich");

    //        var serialized = JsonSerializer.Serialize(new[] { e1, e2 });
    //        var deserialized = JsonSerializer.Deserialize<Employee[]>(serialized);


    //        Console.WriteLine(emps[deserialized[0]]);
    //    }
    //}
}