// See https://aka.ms/new-console-template for more information

var numbers = new int[]
{
    5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35,
};

// 6.1.1
var maxValue = numbers.Max();
Console.WriteLine(maxValue);


// 6.1.2
var lastNumbers = numbers.TakeLast(2);
foreach (var item in lastNumbers)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


// 6.1.3
var strNumbers = numbers.Select(x => x.ToString());
foreach (var item in strNumbers)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


// 6.1.4
var result4 = numbers.OrderBy(x => x).Take(3);
foreach (var item in result4)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


// 6.1.5
var result5 = numbers.Distinct().Count(x => x > 10);
Console.WriteLine(result5);
