using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


/// <summary>
///  Task6 - Implement GetSecondHighest() method; It should not be specific to Data class (make it generic)
/// </summary>

public class Data
{
    public int Value { get; set; }
    public string Name { get; set; }
}


public static class Extension4IEnumerable
{
    public static Y GetSecondHighest<T, Y>(this IEnumerable<Y> collection, Func<Y, T> selector) where T : IComparable
    {
        var enumerator = collection.GetEnumerator();
        //List not empty
        if (!enumerator.MoveNext())
            throw new Exception("Empty collection");

        T highest = selector(enumerator.Current);
        Y highestObj = enumerator.Current;
        T secondHighest = selector(enumerator.Current);
        Y secondHighestObj = enumerator.Current;

        foreach (var currentObj in collection)
        {
            T value = selector(currentObj);

            //value higher than highest
            if (value.CompareTo(highest) > 0)
            {
                secondHighest = highest;
                secondHighestObj = highestObj;
                highest = value;
                highestObj = currentObj;
            }
            else if (value.CompareTo(secondHighest) > 0)
            {
                secondHighest = selector(currentObj);
                secondHighestObj = currentObj;
            }
        }

        return secondHighestObj;
    }
}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        var numbers = new [] {new Data {Value = 3, Name = "First"}, new Data {Value = 7, Name = "Second"}, new Data {Value = 5, Name = "Third"} };
//        var second = numbers.GetSecondHighest(x => x.Value);
//        Console.WriteLine(second.Name);
//    }
//}

//Program.Main(new string[0]);

