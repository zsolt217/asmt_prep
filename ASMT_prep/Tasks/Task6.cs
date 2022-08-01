using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


/// <summary>
///  Task6 - Implement GetSecondHighest() method; It should not be specific to Data class (make it generic)
/// </summary>

class Data
{
    public int Value {get; set;}
    public string Name {get; set;}
}

class Program
{
    public static void Main(string[] args)
    {
        var numbers = new [] {new Data {Value = 3, Name = "First"}, new Data {Value = 7, Name = "Second"}, new Data {Value = 5, Name = "Third"} };
        var second = numbers.GetSecondHighest(x => x.Value);
        Console.WriteLine(second.Name);
    }
}

Program.Main(new string[0]);

