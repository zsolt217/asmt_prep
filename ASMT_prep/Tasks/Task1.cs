using System;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Collections;

/// <summary>
/// make class Employee a proper dictionary key
/// </summary>
namespace dev
{
    //dictionary key is that it is comparable and hashable
    //override Equals and GetHashCode
    //IEqualityComparer: This interface allows the implementation of customized equality comparison for collections.
    class Employee1 : IEqualityComparer
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Employee1 empl)
            {
                return empl.Name.Equals(Name) && empl.Salary.Equals(Salary);
            }
            return false;
        }

        public new bool Equals(object x, object y)
        {
            if (x is Employee1 empleft && y is Employee2 empright)
            {
                return empleft.Equals(empright);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name.GetHashCode(), Salary.GetHashCode());
        }

        public int GetHashCode(object obj)
        {
            if (obj is Employee1 employee)
            {
                return employee.GetHashCode();
            }
            return 0;
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


