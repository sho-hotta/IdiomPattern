// See https://aka.ms/new-console-template for more information

var str = Console.ReadLine();

if(int.TryParse(str, out var num))
{
    var numstr = $"{num:#,0}";
    Console.WriteLine(numstr);
}
else
{
    Console.WriteLine($"数値を入力してください");
}