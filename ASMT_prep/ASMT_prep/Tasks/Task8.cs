using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
///  Task8 - Create your own collection
/// </summary>

public class MyCollection<T> : IEnumerable<T>
{
    private readonly IEnumerable<T> _sourceData;

    public MyCollection(IEnumerable<T> sourceData)
    {
        _sourceData = sourceData;
    }

    //with yield, there is IEnumerator under the hood
    //public IEnumerator<T> GetEnumerator()
    //{
    //    foreach (var item in _sourceData)
    //        yield return item;
    //}

    public IEnumerator<T> GetEnumerator()
    {
        return new MyEnumeratorT<T>(_sourceData);
    }

    //Legacy, dont need to implement
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MyEnumeratorT<T> : IEnumerator<T>
{   
    private readonly IEnumerator<T> _sourceEnumerator;

    public MyEnumeratorT(IEnumerable<T> sourceData)
    {
        _sourceEnumerator = sourceData.GetEnumerator();        
    }

    public T Current { get; private set; }

    object IEnumerator.Current => _sourceEnumerator;

    public void Dispose()
    {
        _sourceEnumerator.Dispose();
    }

    public bool MoveNext()
    {
        while (_sourceEnumerator.MoveNext())
        {
            Current = _sourceEnumerator.Current;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {
//       var myCollection = new MyCollection<int>();
//       foreach (var item in myCollection)
//       {
//            Console.Write(item);           
//       }
//    }
//}

//Program.Main(new string[0]);