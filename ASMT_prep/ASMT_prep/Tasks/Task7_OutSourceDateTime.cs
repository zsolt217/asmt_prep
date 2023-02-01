using System;

/// <summary>
///  Task7 - Write unit tests for GetNextDateOf() method. (hint: you may refactor the code)
/// </summary>
/// Now it's mockable&testable

class GetDate
{
    IGetActualDate _getActualDate;

    public GetDate(IGetActualDate getActualDate)
    {
        _getActualDate = getActualDate;
    }

    public void Main123()
    {
        GetNextDateOf(DayOfWeek.Friday);
    }

    public void GetNextDateOf(DayOfWeek day)
    {
        var date = _getActualDate.DateTimeNow();
        while (date.DayOfWeek != day)
        {
            date = date.AddDays(1);
        }
        Console.WriteLine(date);
    }
}

public interface IGetActualDate
{
    DateTime DateTimeNow();
}

public class GetActualDate : IGetActualDate
{
    public DateTime DateTimeNow() => DateTime.Now;
}