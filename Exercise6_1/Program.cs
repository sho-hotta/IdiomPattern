// See https://aka.ms/new-console-template for more information

var numbers = new int[]
{
    5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35,
};

/// 6.1.1
var result1 = numbers.Max();
Console.WriteLine(result1);

/// 6.1.2
var result2 = numbers.TakeLast(2);
foreach (var result in result2)
{
    Console.Write($"{result} ");
}
Console.WriteLine();

/// 6.1.3
var result3 = numbers.Select(x => x.ToString());
foreach (var result in result3)
{
    Console.Write($"{result} ");
}
Console.WriteLine();

/// 6.1.4
var result4 = numbers.OrderBy(x => x).Take(3);
foreach (var result in result4)
{
    Console.Write($"{result} ");
}
Console.WriteLine();

/// 6.1.5
var result5 = numbers.Distinct().Count(x => x > 10);
Console.WriteLine(result5);