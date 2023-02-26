// See https://aka.ms/new-console-template for more information


using Exercise4;

// 4.2.1
var yearMonthArray = new YearMonth[]
{
    new YearMonth(1995, 11),
    new YearMonth(1998, 2),
    new YearMonth(2023, 2),
    new YearMonth(1999, 12),
    new YearMonth(2000, 1)
};

// 4.2.2
foreach (var yearMonth in yearMonthArray)
{
    Console.Write($"{yearMonth.ToString()} ");
}
Console.WriteLine();

// 4.2.4
YearMonth first21CenturyYear = Search21Century(yearMonthArray);
if (first21CenturyYear == null)
{
    Console.WriteLine($"21世紀のデータはありません");
}
else
{
    Console.WriteLine($"{first21CenturyYear.ToString()}");
}

// 4.2.3
YearMonth Search21Century(YearMonth[] yearMonthsArray)
{
    foreach (var yearMonth in yearMonthArray)
    {
        if (yearMonth.Is21Century)
        {
            return yearMonth;
        }
    }
    return null;
}

// 4.2.5
YearMonth[] oneMonthLaterArray = yearMonthArray.Select(n => n.AddOneMonth()).ToArray();
foreach (var yearMonth in oneMonthLaterArray)
{
    Console.Write($"{yearMonth.ToString()} ");
}