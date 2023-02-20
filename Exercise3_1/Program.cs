// See https://aka.ms/new-console-template for more information

var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

// 3.1.1
int result1 = numbers.Count(n => (n % 8 == 0) || (n % 9 == 0));
Console.WriteLine(result1);

// 3.1.2
numbers.ForEach(n => Console.WriteLine(n / 2.0));

// 3.1.3
List<int> result3 = numbers.Where(n => n >= 50).ToList();
result3.ForEach(n => Console.WriteLine(n));

// 3.1.4
List<int> result4 = numbers.Select(n => n * 2).ToList();
result4.ForEach(n => Console.WriteLine(n));