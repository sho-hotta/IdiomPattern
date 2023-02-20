// See https://aka.ms/new-console-template for more information

var names = new List<string>
{
    "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
};

// 3.2.1
var line = Console.ReadLine();
var result1 = names.FindIndex(n => n == line);
Console.WriteLine(result1);

// 3.2.2
var result2 = names.Count(n => n.Contains('o'));
Console.WriteLine(result2);

// 3.2.3
var results3 = names.Where(n => n.Contains('o')).ToArray();
foreach(var result3 in results3)
{
    Console.WriteLine(result3);
}

// 3.2.4
var results4 = names.Where(n => n[0] == 'B').Select(n => n.Length);
foreach (var result4 in results4)
{
    Console.WriteLine(result4);
}